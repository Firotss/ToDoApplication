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
            catch (Exception)
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

                string sql = $"INSERT INTO users " +
                    $"(`username`, `password`, `first_name`, `last_name`, `date_of_creation`, `id_of_creator`, `date_of_last_change`, `last_id`) " +
                    $"VALUES ('{username}', '{password}', '{firstname}', '{lastname}', NOW(), '1', NOW(), '1')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void updateUser(string id, string firstname, string lastname, string password, string username)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = $"UPDATE `users` SET `username`='{username}',`password`='{password}',`first_name`='{firstname}',`last_name`='{lastname}',`date_of_last_change`=NOW(),`last_id`='0' WHERE id={id}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
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
            catch (Exception)
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
                DateTime dateCreate = DateTime.Parse(rdr[5].ToString());
                DateTime dateUpdate = DateTime.Parse(rdr[7].ToString());
                string sqldateUpdate = dateUpdate.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string[] all = { rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), dateCreate.ToString(), rdr[6].ToString(), dateUpdate.ToString(), rdr[8].ToString() };
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
                string[] all = { rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString() };
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
                DateTime dateCreate = DateTime.Parse(rdr[5].ToString());
                DateTime dateUpdate = DateTime.Parse(rdr[7].ToString());
                string[] all = { rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), dateCreate.ToString(), rdr[6].ToString(), dateUpdate.ToString(), rdr[8].ToString() };


                rdr.Close();
                conn.Close();
                return all;
            }
            catch (Exception)
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
            catch (Exception)
            {

            }
        }
        public void addListId()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                string sql = $"UPDATE `todolists` SET `list_id`=`id` WHERE id_of_the_creator = user_id";
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }

        }
        public void shareList(string listId, string userId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                string sql = $"SELECT * FROM todolists " +
                    $"WHERE id = {listId} AND user_id = id_of_the_creator";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();

                string[] all = { rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString() };

                shareListInsert(all, userId);

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }

        }
        public void shareListInsert(string[] list, string userId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();

                DateTime dateCreate = DateTime.Parse(list[2]);
                string sqldateCreate = dateCreate.ToString("yyyy-MM-dd HH:mm:ss.fff");
                DateTime dateUpdate = DateTime.Parse(list[4]);
                string sqldateUpdate = dateUpdate.ToString("yyyy-MM-dd HH:mm:ss.fff");

                string sql = $"INSERT INTO todolists " +
                    $"(`title`, `date_of_creation`, `id_of_the_creator`, `date_of_last_change`, `last_id`, `user_id`, `list_id`) " +
                    $"VALUES ('{list[1]}', '{sqldateCreate}', '{list[3]}', '{sqldateUpdate}', '{list[5]}', '{userId}', '{list[7]}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void RemoveAllLists(string listId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                string sql = $"DELETE FROM todolists " +
                    $"WHERE list_id = '{listId}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void RemoveOneList(string listId, string userId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                string sql = $"DELETE FROM todolists " +
                    $"WHERE list_id = '{listId}' AND user_id = '{userId}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void ChangeOneList(string listId, string title, string userId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                string sql = $"UPDATE todolists SET title='{title}', last_id = user_id, date_of_last_change = NOW()" +
                    $"WHERE list_id = '{listId}' AND user_id = '{userId}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void ChangeAllLists(string listId, string title)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                string sql = $"UPDATE todolists SET title='{title}', last_id = user_id, date_of_last_change = NOW()" +
                    $"WHERE list_id = '{listId}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public List<string[]> AllTasks(string id_of_the_list)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                string sql = $"SELECT * FROM todotasks WHERE id_of_the_list = '{id_of_the_list}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string[]> tasks = new List<string[]>();

                while (rdr.Read())
                {
                    string[] all = { rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(), rdr[8].ToString() };
                    tasks.Add(all);
                }
                rdr.Close();
                conn.Close();
                return tasks;
            }
            catch(Exception)
            {

            }
            return null;
        }
        public void AddTask(string listId, string title, string userId)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = $"INSERT INTO todotasks " +
                    $"(`id_of_the_list` ,`title`, `isComplete`, `date_of_creation`, `id_of_creator`, `date_of_last_change`, `last_id`) " +
                    $"VALUES ('{listId}', '{title}', '0', NOW(), '{userId}', NOW(), '{userId}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                UpdateList(listId, userId);
                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void UpdateList(string listId, string userId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                string sql = $"UPDATE `todolists` SET `last_id`='{userId}', `date_of_last_change`= NOW() WHERE list_id = '{listId}'";
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void UpdateTask(string taskId, string title, string description, string userId, string listId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);

                string sql = $"UPDATE `todotasks` SET `last_id`='{userId}', `date_of_last_change`= NOW(), `title` = '{title}', `description`='{description}' WHERE id = '{taskId}'";
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                UpdateList(listId, userId);
                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void DeleteTask(string id)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = $"DELETE FROM todotasks WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }

        public void UpdateCheck(string check, string id)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = $"UPDATE todotasks SET isComplete={check} WHERE id={id}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
