using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBPRAKTIKA
{
    public static class sqlcoms
    {
        static string provider = ConfigurationManager.AppSettings["provider"];
        static string connectionstring = ConfigurationManager.AppSettings["connectionString"];

        internal static List<PlantClass> plants(string tablename)
        {
            var plantlist = new List<PlantClass>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    SqlCommand com = new SqlCommand("SELECT * FROM "+tablename, con);
                    using (SqlDataReader rea = com.ExecuteReader())
                    {
                        while (rea.Read())
                        {
                            plantlist.Add(new PlantClass() { id = Convert.ToInt32(rea[0]), name = rea[1].ToString() });
                        }
                    }
                }
            }
            return plantlist;
        }

        internal static void changeGroup(int idpl, int idgrp)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    using (SqlCommand com = new SqlCommand("UPDATE PlantDetails SET PlantGroup = @grp WHERE ID = @ID", con))
                    {
                        List<SqlParameter> p = new List<SqlParameter>();
                        com.Parameters.AddWithValue("@grp", idgrp);
                        com.Parameters.AddWithValue("@ID", idpl);

                        com.ExecuteNonQuery();
                    }
                }
            }
        }

        internal static int Login(string User, string Pass)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    SqlCommand com = new SqlCommand("SELECT * FROM UserLogins WHERE Name=@Name", con);
                    {
                        List<SqlParameter> p = new List<SqlParameter>();
                        com.Parameters.AddWithValue("@Name", User);
                        using (SqlDataReader rea = com.ExecuteReader())
                        {
                            try
                            {
                                rea.Read();
                                if (rea[2].ToString() == Pass)
                                {
                                    MessageBox.Show("match found");
                                    return Convert.ToInt32(rea[0]);
                                }
                                else
                                {
                                    MessageBox.Show("Password was incorrect");
                                    return 0;
                                }
                            }
                            catch
                            {
                                MessageBox.Show("User not found");
                            }
                        }
                    }
                }
            }
            return 0;
        }

        internal static void removePlantUser(int idusr, int idplt)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    using (SqlCommand com = new SqlCommand("DELETE FROM UserPlantRel WHERE UserId = @usr AND PlantId = @plid", con))
                    {
                        List<SqlParameter> p = new List<SqlParameter>();
                        com.Parameters.AddWithValue("@usr", idusr);
                        com.Parameters.AddWithValue("@plid", idplt);

                        com.ExecuteNonQuery();
                    }
                }
            }
        }

        internal static void CreateNewUser()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    using (SqlCommand com = new SqlCommand("DELETE FROM UserPlantRel WHERE UserId = @usr AND PlantId = @plid", con))
                    {
                        List<SqlParameter> p = new List<SqlParameter>();
                      //  com.Parameters.AddWithValue("@usr", idusr);
                      //  com.Parameters.AddWithValue("@plid", idplt);

                        com.ExecuteNonQuery();
                    }
                }
            }
        }

        internal static bool checkifexists(string Name)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    using (SqlCommand com = new SqlCommand("SELECT COUNT (Name) FROM UserLogins WHERE UserLogins.Name=@Name", con))
                    {
                        List<SqlParameter> p = new List<SqlParameter>();
                        com.Parameters.AddWithValue("@Name", Name);

                        int asd =Convert.ToInt32(com.ExecuteScalar());
                        if (asd>0)
                        { return true; }
                    }
                }
            } return false;
        }

        internal static bool Adduser(string username, string password, string firstname, string lastname, string email, string city, int gender)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    using (SqlCommand com = new SqlCommand("INSERT INTO UserLogins (Name , Pass) VALUES (@Name , @Pass)", con))
                    {
                        List<SqlParameter> p = new List<SqlParameter>();
                        com.Parameters.AddWithValue("@Name", username);
                        com.Parameters.AddWithValue("@Pass", password);
                        com.ExecuteNonQuery();
                    }
                    int id = getid(username);
                    using (SqlCommand com = new SqlCommand("INSERT INTO UserDetails (Id , Firstname , Lastname , Email , Gender , City) VALUES (@Id , @Firstname , @Lastname , @Email , @Gender , @City)", con))
                    {
                        List<SqlParameter> p = new List<SqlParameter>();
                        com.Parameters.AddWithValue("@Id", id);
                        com.Parameters.AddWithValue("@Firstname", firstname);
                        com.Parameters.AddWithValue("@Lastname", lastname);
                        com.Parameters.AddWithValue("@Email", email);
                        com.Parameters.AddWithValue("@Gender", gender);
                        com.Parameters.AddWithValue("@City", city);
                        com.ExecuteNonQuery();

                        MessageBox.Show("User registered succesfully");
                        return true;
                    }
                }
            }
        }

        internal static int getid(string name)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    using (SqlCommand com = new SqlCommand("SELECT Id FROM UserLogins WHERE Name=@Name", con))
                    {
                        List<SqlParameter> p = new List<SqlParameter>();
                        com.Parameters.AddWithValue("@Name", name);
                        using (SqlDataReader rea = com.ExecuteReader())
                        {
                            while (rea.Read())
                            {
                                return Convert.ToInt32(rea[0]);
                            }
                        }
                    }
                }
            }
            return 0;
        }

        internal static void addlantUser(int idusr, int idplt)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    using (SqlCommand com = new SqlCommand("INSERT INTO UserPlantRel (UserId , PlantId) VALUES (@usr , @plid)", con))
                    {
                        List<SqlParameter> p = new List<SqlParameter>();
                        com.Parameters.AddWithValue("@usr", idusr);
                        com.Parameters.AddWithValue("@plid", idplt);

                        com.ExecuteNonQuery();
                    }
                }
            }
        }

        internal static List<PlantClass> getuserplants(int usr)
        {
            var plantlist = new List<PlantClass>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    using (SqlCommand com = new SqlCommand(
                        "SELECT * FROM Plant " +
                        "INNER JOIN UserPlantRel " +
                        "ON Plant.ID = UserPlantRel.PlantID " +
                        "WHERE UserPlantRel.UserID = " + usr, con))
                    {
                        using (SqlDataReader rea = com.ExecuteReader())
                        {
                            while (rea.Read())
                            {
                                plantlist.Add(new PlantClass() { id = Convert.ToInt32(rea[0]), name = rea[1].ToString() });
                                //MessageBox.Show(rea[0].ToString() + rea[1].ToString());
                            }
                        }
                    }
                }
            }
            return plantlist;
        }
        //SELECT Name, ID1, Notes FROM Plant INNER JOIN Synergy ON Synergy.ID0 = Plant.ID

        internal static List<PlantClass> getplantrel(int plid)
        {
            var plantlist = new List<PlantClass>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    using (SqlCommand com = new SqlCommand("SELECT Name, ID1, Notes, Releationship, Synergy.Id " +
                        "FROM Plant " +
                        "INNER JOIN Synergy " +
                        "ON Synergy.ID0 = Plant.ID WHERE Plant.ID = " + plid, con))
                    {
                        using (SqlDataReader rea = com.ExecuteReader())
                        {
                            while (rea.Read())
                            {
                                plantlist.Add(new PlantClass() { name = rea[0].ToString(), id = Convert.ToInt32(rea[1]), note = rea[2].ToString(), rel = Convert.ToBoolean(rea[3]), xtraid=Convert.ToInt32(rea[4])});
                            }
                        }
                    }
                    
                }
            }
            return plantlist;
        }

        internal static List<PlantClass> getnotuserplants(int usr)
        {
            var plantlist = new List<PlantClass>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    using (SqlCommand com = new SqlCommand(
                        "SELECT * FROM Plant " +
                        "LEFT JOIN UserPlantRel " +
                        "ON UserPlantRel.PlantId = " +
                        "Plant.ID AND UserPlantRel.UserId = "+usr+
                        " WHERE UserPlantRel.Id IS NULL", con))
                    {
                        using (SqlDataReader rea = com.ExecuteReader())
                        {
                            while (rea.Read())
                            {
                                plantlist.Add(new PlantClass() { id = Convert.ToInt32(rea[0]), name = rea[1].ToString() });
                                //MessageBox.Show(rea[0].ToString() + rea[1].ToString());
                            }
                        }
                    }
                }
            }
            return plantlist;
        }

        internal static string getgroup(int _id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    SqlCommand com = new SqlCommand("SELECT * FROM PlantGroup WHERE id=" + _id, con);
                    using (SqlDataReader rea = com.ExecuteReader())
                    {
                        while (rea.Read())
                        {
                            return rea[1].ToString();
                        }
                    }
                }
            }
            return null;
        }

        internal static string getplname(int id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    SqlCommand com = new SqlCommand("SELECT Name FROM Plant WHERE id=" + id, con);
                    using (SqlDataReader rea = com.ExecuteReader())
                    {
                        while (rea.Read())
                        {
                            return rea[0].ToString();
                        }
                    }
                }
            }
            return null;
        }

        internal static string getgroupnote(int _id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    SqlCommand com = new SqlCommand("SELECT notes FROM PlantGroup WHERE id=" + _id, con);
                    using (SqlDataReader rea = com.ExecuteReader())
                    {
                        while (rea.Read())
                        {
                            return rea[0].ToString();
                        }
                    }
                }
            }
            return null;
        }

        internal static List<string> PlantSpecs(int _id)
        {
            var list = new List<string>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    SqlCommand com = new SqlCommand("SELECT * FROM PlantDetails WHERE ID=" + _id, con);
                    using (SqlDataReader rea = com.ExecuteReader())
                    {
                        while (rea.Read())
                        {
                            list.Add(rea[0].ToString());
                            list.Add(rea[1].ToString());
                            list.Add(rea[2].ToString());
                            list.Add(rea[3].ToString());
                            list.Add(rea[4].ToString());
                            list.Add(rea[5].ToString());
                            list.Add(rea[6].ToString());
                        }
                    }
                }
            }
            return list;
        }

        internal static List<string> growinfo(int _id)
        {
            var list = new List<string>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionstring;
                con.Open();
                {
                    SqlCommand com = new SqlCommand("SELECT * FROM GrowingInfo WHERE ID=" + _id, con);
                    using (SqlDataReader rea = com.ExecuteReader())
                    {
                        while (rea.Read())
                        {
                            list.Add(rea[1].ToString());
                            list.Add(rea[2].ToString());
                            list.Add(rea[3].ToString());
                            list.Add(rea[4].ToString());
                        }
                    }
                }
            }
            return list;
        }

    }
}
