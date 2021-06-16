using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFocus2.View
{
    interface IController
    {
        string userType(string username, string password);
        void addUser(string firstname, string lastname, string password, string username);
        void updateUser(string id, string firstname, string lastname, string password, string username);
        void deleteUser(string id);
        List<string[]> AllUsers();
        List<string[]> AllLists(string id);
        void addList(string title, string id);
        string[] OneUser(string username);
        void shareList(string listId, string userId);
        void RemoveAllLists(string listId);
        void RemoveOneList(string listId, string userId);
        void ChangeOneList(string listId, string title, string userId);
        void ChangeAllLists(string listId, string title);
        List<string[]> AllTasks(string id_of_the_list);
        void AddTask(string listId, string title, string userId);
        void UpdateTask(string taskId, string title, string description, string userId, string listId);
        void DeleteTask(string id);
        void UpdateCheck(string check, string id);
    }
}
