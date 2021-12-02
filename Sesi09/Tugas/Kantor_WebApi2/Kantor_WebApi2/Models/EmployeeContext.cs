﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kantor_WebApi2.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }

        public EmployeeContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")

                        });
                    }
                }
            }
            return list;
        }
        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM EMPLOYEE WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }

            return list;
        }

        public String InsertDataEmployee(EmployeeItem data)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO EMPLOYEE(nama,jenis_kelamin,alamat) VALUES(@nama,@jenisKelamin,@alamat)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@nama", data.nama);
                        cmd.Parameters.AddWithValue("@jenisKelamin", data.jenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", data.alamat);
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

         public String UpdateDataEmployee(EmployeeItem data)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "UPDATE EMPLOYEE SET nama = @nama, jenis_kelamin = @jenisKelamin,alamat = @alamat WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", data.id);
                        cmd.Parameters.AddWithValue("@nama", data.nama);
                        cmd.Parameters.AddWithValue("@jenisKelamin", data.jenisKelamin);
                        cmd.Parameters.AddWithValue("@alamat", data.alamat);
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

         public String DeleteEmployeeData(string id)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM EMPLOYEE WHERE id = @id";
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
