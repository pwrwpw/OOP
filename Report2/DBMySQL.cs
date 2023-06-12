using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace Bank
{
    public class DBMySQL
    {
        
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=shopdb;Uid=root;Pwd=1q2q3q;");
        MySqlDataAdapter adpt;
        MySqlCommand cmd;

        public void Connection()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectOne(string condition,string table,string column)
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = $"SELECT {condition} FROM {table} {column}";
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, table);
                if(ds.Tables[0].Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    return ds;
                }
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public DataSet SelectAll(string table)
        {
            try
            {
                DataSet ds = new DataSet();

                string sql = $"SELECT * FROM {table}";
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, table);
                if (ds.Tables.Count > 0)
                {
                    return ds;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        public void Insert(string table, string value)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO {table} VALUES({value})";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }   
        }
        public void Update(string table, string value, string condition)
        {
            try
            {
                conn.Open();
                string sql = $"UPDATE {table} SET {value} WHERE {condition}";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        public void DeleteOne(string table, string whereCol, string whereValue)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM {table} WHERE {whereCol} = '{whereValue}'";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        public void DeleteAll(string table)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM {table}";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
    }
    }
