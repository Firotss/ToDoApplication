using ScaleFocus2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFocus2.Model
{
    class Users : IUsers
    {
        int id;
        string username;
        string password;
        string first_name;
        string last_name;
        DateTime dateOfCreation;
        int idOfCreator;
        DateTime dateOfLastChange;
        int lastId;

        public Users(int id, string username, string password, string first_name, string last_name, DateTime dateOfCreation, int idOfCreator, DateTime dateOfLastChange, int lastId)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.first_name = first_name;
            this.last_name = last_name;
            this.dateOfCreation = dateOfCreation;
            this.idOfCreator = idOfCreator;
            this.dateOfLastChange = dateOfLastChange;
            this.lastId = lastId;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int IdOfCreator { get; set; }
        public DateTime DateOfLastChange { get; set; }
        public int LastId { get; set; }
    }
}
