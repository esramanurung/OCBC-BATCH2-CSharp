using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Models
{
    public class MovieContext
    {
        public string ConnectionString { get; set; }

        public MovieContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<MovieItem> GetAllMovie()
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Movie", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            Id = reader.GetInt32("id"),
                            Names = reader.GetString("names"),
                            Genre = reader.GetString("genre"),
                            Duration = reader.GetString("duration"),
                            ReleaseDate = reader.GetDateTime("ReleaseDate")

                        });
                    }
                }
            }
            return list;
        }



        public List<MovieItem> GetMovie(string id)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Movie WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);


                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.Write("masuk");
                        Console.WriteLine(reader.GetDateTime("ReleaseDate"));
                        list.Add(new MovieItem()
                        {
                            Id = reader.GetInt32("id"),
                            Names = reader.GetString("names"),
                            Genre = reader.GetString("genre"),
                            Duration = reader.GetString("duration"),
                            ReleaseDate = reader.GetDateTime("ReleaseDate")

                        });
                    }
                }
            }

            return list;
        }


        public String InsertDataMovie(MovieItem data)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO Movie(names,genre,duration,ReleaseDate) VALUES(@name,@genre,@duration,@release_date)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {

                        cmd.Parameters.AddWithValue("@name", data.Names);
                        cmd.Parameters.AddWithValue("@genre", data.Genre);
                        cmd.Parameters.AddWithValue("@duration", data.Duration);
                        cmd.Parameters.AddWithValue("@release_date", data.ReleaseDate);
                        Console.WriteLine(data);
                        Console.WriteLine(sql);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return "Insert Data Berhasil";
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.ToString());
                        return "Insert Data Gagal";
                    }

                }
            }
        }
        public String UpdateDataMovie(MovieItem data)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "UPDATE Movie SET names = @name, genre = @genre,duration= @duration , ReleaseDate = @release_date WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", data.Id);
                        cmd.Parameters.AddWithValue("@name", data.Names);
                        cmd.Parameters.AddWithValue("@genre", data.Genre);
                        cmd.Parameters.AddWithValue("@duration", data.Duration);
                        cmd.Parameters.AddWithValue("@release_date", data.ReleaseDate);
                        Console.WriteLine(data);
                        Console.WriteLine(sql);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return "Update Data Berhasil";
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.ToString());
                        return "Update Data Gagal";
                    }

                }
            }
        }

        public String DeleteDataMovie(string id)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Movie WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        Console.WriteLine(id);
                        Console.WriteLine(sql);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return "Delete Data Berhasil";
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.ToString());
                        return "Delete Data Gagal";
                    }

                }
            }
        }
    }
}
