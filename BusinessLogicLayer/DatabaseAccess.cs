﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataLayer
{
    public class SqlConnectionData
    {
        public static SqlConnection connectToQuanLyTaiKhoan()
        {
            string str = @"Data Source=DESKTOP-E5D90BN;Initial Catalog=QuanLyTaiKhoan;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(str);
            return conn;
        }

        public static SqlConnection connectToQuanLyKhachSan()
        {
            string str = @"Data Source=DESKTOP-E5D90BN;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            return conn;
        }
    }
    internal class DatabaseAccess
    {
        public DataTable getDataGridViewWithQuery(string query)
        {
            using (SqlConnection connection = SqlConnectionData.connectToQuanLyKhachSan())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                return table;
            }
        }

        public void executeQuery(string query)
        {
            using (SqlConnection connection = SqlConnectionData.connectToQuanLyKhachSan())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
        }
    }
}
