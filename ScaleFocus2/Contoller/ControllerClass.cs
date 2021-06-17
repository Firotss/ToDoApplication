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
        Connector connector = new Connector();
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
            connector.addUser(firstname, lastname, password, username);
        }
        public void updateUser(string id, string firstname, string lastname, string password, string username)
        {
            connector.updateUser(id, firstname, lastname, password, username);
        }
        public void deleteUser(string id)
        {
            connector.deleteUser(id);
        }
        public List<string[]> AllUsers()
        {
            return connector.AllUsers();
        }
        public List<string[]> AllLists(string id)
        {
            return connector.AllLists(id.ToString());
        }
        public string[] OneUser(string username)
        {
            return connector.OneUser(username);
        }
        public void addList(string title, string id)
        {
            connector.addList(title, id);
        }
        public void shareList(string listId, string userId)
        {
            connector.shareList(listId, userId);
        }
        public void RemoveOneList(string listId, string userId)
        {
            this.connector.RemoveOneList(listId, userId);
        }
        public void RemoveAllLists(string listId)
        {
            this.connector.RemoveAllLists(listId);
        }
        public void ChangeAllLists(string listId, string title)
        {
            this.connector.ChangeAllLists(listId, title);
        }
        public void ChangeOneList(string listId, string title, string userId)
        {
            this.connector.ChangeOneList(listId, title, userId);
        }
        public List<string[]> AllTasks(string id_of_the_list)
        {
            return connector.AllTasks(id_of_the_list);
        }
        public void AddTask(string listId, string title, string userId)
        {
            this.connector.AddTask(listId, title, userId);
        }
        public void UpdateTask(string taskId, string title, string description, string userId, string listId)
        {
            this.connector.UpdateTask(taskId, title, description, userId, listId);
        }
        public void DeleteTask(string id)
        {
            this.connector.DeleteTask(id);
        }
        public void UpdateCheck(string check, string id)
        {
            this.connector.UpdateCheck(check, id);
        }
        public string[] loadUsers(string userId)
        {
            return this.connector.loadUsers(userId);
        }
        public List<string[]> allUsersLists(string listId)
        {
            return this.connector.allUsersLists(listId);
        }
        public List<string[]> allUsersNeedToDo(string taskId)
        {
            return connector.allUsersNeedToDo(taskId);
        }
        public void AddUsersNeedToDo(string taskId, string userId)
        {
            connector.AddUsersNeedToDo(taskId, userId);
        }
        public void DeleteUsersNeedToDo(string taskId, string userId)
        {
            connector.DeleteUsersNeedToDo(taskId, userId);
        }
        public string GetListId(string id)
        {
            return connector.GetListId(id);
        }
    }
}
