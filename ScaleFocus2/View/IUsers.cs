using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFocus2.View
{
    interface IUsers
    {
        int Id { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string First_name { get; set; }
        string Last_name { get; set; }
        DateTime DateOfCreation { get; set; }
        int IdOfCreator { get; set; }
        DateTime DateOfLastChange { get; set; }
        int LastId { get; set; }

    }
}
