using MySql.Data.MySqlClient;
using ScaleFocus2.Contoller;
using ScaleFocus2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleFocus2
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }
        private IController controller;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.controller = new ControllerClass();
            try
            {
                string[] console = (usernameTbx.Text).Split();
                if (console[1] == "console")
                {
                    string checkConsole = controller.userType((console[0]).ToLower(), passwordTbx.Text);
                    string[] userInfo = controller.OneUser(console[0]);
                    passwordTbx.Text = "";
                    usernameTbx.Text = "";
                    if(NativeMethods.AllocConsole())
                    {
                        IntPtr stdHandle = NativeMethods.GetStdHandle(NativeMethods.STD_OUTPUT_HANDLE);
                        string[] command = Console.ReadLine().Split();
                        while (command != null)
                        {
                            string id;
                            switch (command[0])
                            {
                                case "allTasks":
                                    List<string[]> tasks = controller.AllTasks(command[1]);
                                    foreach (var item in tasks)
                                    {
                                        Console.WriteLine($"{item[0]} - {item[1]} - {item[2]} - {item[3]} - {item[4]} - {item[5]} - {item[6]} - {item[7]} - {item[8]}");
                                    }
                                    break;
                                case "createTasks":
                                    controller.AddTask(command[1], command[2], userInfo[0]);
                                    Console.WriteLine("Tasks succesfully added!");
                                    break;
                                case "deleteTasks":
                                    controller.DeleteTask(command[1]);
                                    Console.WriteLine("Tasks succesfully deleted!");
                                    break;
                                case "updateTasks":
                                    string listId = controller.GetListId(command[0]);
                                    controller.UpdateTask(command[1], command[2], command[3], userInfo[0], listId);
                                    Console.WriteLine("Tasks succesfully updated!");
                                    break;
                                case "todo":
                                    id = command[1];
                                    command[1] = "todo";
                                    foreach (var item in command)
                                    {
                                        if(item == "todo")
                                        {
                                            continue;
                                        }
                                        controller.AddUsersNeedToDo(id, item);
                                    }
                                    Console.WriteLine("ToDo task added to another user! :D");
                                    break;
                                case "todoRemove":
                                    id = command[1];
                                    command[1] = "todo";
                                    foreach (var item in command)
                                    {
                                        if (item == "todo")
                                        {
                                            continue;
                                        }
                                        controller.DeleteUsersNeedToDo(id, item);
                                    }
                                    Console.WriteLine("ToDo task removed from another user!");
                                    break;
                                case "taskComplete":
                                    controller.UpdateCheck("1", command[1]);
                                    Console.WriteLine("Task completed!1!!");
                                    break;
                            }
                            command = Console.ReadLine().Split();
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                string check = controller.userType((usernameTbx.Text).ToLower(), passwordTbx.Text);
                if (check == "admin")
                {
                    errorLbl.Text = "";
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                }
                else if (check == "user")
                {
                    errorLbl.Text = "";
                    UserMenu user_Menu = new UserMenu((usernameTbx.Text).ToLower());
                    user_Menu.Show();
                }
                else
                {
                    errorLbl.Text = "Incorrect login or password!";
                }
            }
        }
        public partial class NativeMethods
        {
            public static Int32 STD_OUTPUT_HANDLE = -11;
            [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "GetStdHandle")]
            public static extern System.IntPtr GetStdHandle(Int32 nStdHandle);
            [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "AllocConsole")]
            [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
            public static extern bool AllocConsole();
        }
        bool mouseDown = false;//нужно е за преместване
        Point startMousePos;
        private void topMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            startMousePos = e.Location;
        }

        private void topMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - startMousePos.X) + e.X, (this.Location.Y - startMousePos.Y) + e.Y);
            }
        }

        private void topMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topLbl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            startMousePos = e.Location;
        }

        private void topLbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - startMousePos.X) + e.X, (this.Location.Y - startMousePos.Y) + e.Y);
            }
        }

        private void topLbl_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
