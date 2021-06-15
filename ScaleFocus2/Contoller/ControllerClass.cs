using ScaleFocus2.Model;
using ScaleFocus2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFocus2.Contoller
{
    class ControllerClass : IController
    {
        public string userType(string username, string password)
        {
            Connector connector = new Connector();
            bool check = connector.user(username, password);

            if (check == false)
            {
                return "error";
            }
            else
            {
                if (username.ToLower() == "admin")
                {
                    return "admin";
                }
                else
                {
                    return "user";
                }
            }
        }
        public void addUser(string firstname, string lastname, string password, string username)
        {
            Connector connector = new Connector();
            connector.addUser(firstname, lastname, password, username);
        }
        public void updateUser(string id, string firstname, string lastname, string password, string username)
        {
            Connector connector = new Connector();
            connector.updateUser(id, firstname, lastname, password, username);
        }
        public void deleteUser(string id)
        {
            Connector connector = new Connector();
            connector.deleteUser(id);
        }
        public List<string[]> AllUsers()
        {
            Connector connector = new Connector();
            return connector.AllUsers();
        }
        public List<string[]> AllLists(string id)
        {
            Connector connector = new Connector();
            return connector.AllLists(id.ToString());
        }
        public string[] OneUser(string username)
        {
            Connector connector = new Connector();
            return connector.OneUser(username); 
        }
        public void addList(string title, string id)
        {
            Connector connector = new Connector();
            connector.addList(title, id);
        }
    }
}
