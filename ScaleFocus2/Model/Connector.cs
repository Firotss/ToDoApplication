using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFocus2.Model
{
    class Connector
    {
        string connStr = "server=localhost;user=root;database=todoapplications;port=3306;password=''; pooling = false; convert zero datetime=True";
        public bool user(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = $"SELECT username FROM users WHERE username = '{username}' AND password = '{password}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if ((string)rdr["username"] != null)
                {
                    rdr.Close();
                    conn.Close();
                    return true;
                }

                rdr.Close();
                conn.Close();
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void addUser(string firstname, string lastname, string password, string username)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                DateTime currDate = DateTime.Now;
                string sql = $"INSERT INTO users " +
                    $"(`username`, `password`, `first_name`, `last_name`, `date_of_creation`, `id_of_creator`, `date_of_last_change`, `last_id`) " +
                    $"VALUES ('{username}', '{password}', '{firstname}', '{lastname}', NOW(), '1', NOW(), '1')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void updateUser(string id, string firstname, string lastname, string password, string username)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                DateTime currDate = DateTime.Now;
                string sql = $"UPDATE `users` SET `username`='{username}',`password`='{password}',`first_name`='{firstname}',`last_name`='{lastname}',`date_of_last_change`=NOW(),`last_id`='0' WHERE id={id}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void deleteUser(string id)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = $"DELETE FROM users WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public List<string[]> AllUsers()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = $"SELECT * FROM users";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<string[]> users = new List<string[]>();

            while (rdr.Read())
            {
                string[] all = { rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(), rdr[8].ToString() };
                users.Add(all);

            }
            rdr.Close();
            conn.Close();
            return users;
        }
        public List<string[]> AllLists(string user_id)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = $"SELECT * FROM todolists WHERE user_id = {user_id}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<string[]> lists = new List<string[]>();

            while (rdr.Read())
            {
                string[] all = { rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString() };
                lists.Add(all);

            }
            rdr.Close();
            conn.Close();
            return lists;
        }
        public string[] OneUser(string username)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = $"SELECT * FROM users WHERE username = '{username}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();
                string[] all = { rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(), rdr[8].ToString() };


                rdr.Close();
                conn.Close();
                return all;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void addList(string title, string id)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = $"INSERT INTO todolists " +
                    $"(`title`, `date_of_creation`, `id_of_the_creator`, `date_of_last_change`, `last_id`, `user_id`) " +
                    $"VALUES ('{title}', NOW(), '{id}', NOW(), '{id}', '{id}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                addListId();
                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void addListId()
        {//тут должна будет быть заявка которая проверяет строчки и если id_of_the_creator = user_id, то id = list_id
            string sql = $"UPDATE `todolists` SET `list_id`=id WHERE id_of_the_creator=user_id";
        }
    }
}
