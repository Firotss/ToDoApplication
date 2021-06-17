using ScaleFocus2.Contoller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleFocus2.View
{
    public partial class TaskForm : Form
    {
        IController controller;
        string taskId;
        string userId;
        string listId;
        public TaskForm(string title, string description, string taskId, string userId, string listId)
        {
            InitializeComponent();
            descriptionTxb.Text = description;
            titleTxb.Text = title;
            this.taskId = taskId;
            this.userId = userId;
            this.listId = listId;
            loadUsers();
        }
        private void loadUsers()
        {
            this.controller = new ControllerClass();
            List<string[]> lists = controller.allUsersLists(listId);

            for (int i = 0; i < lists.Count; i++)
            {
                string[] users = controller.loadUsers(lists[i][6]);
                Label label = new Label();
                int z = ((i) * 25) + 5;
                label.Text = users[1];
                label.Location = new Point(0, z);
                label.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                List<string[]> usersToDo = controller.allUsersNeedToDo(taskId);
                if (usersToDo != null)
                {
                    for (int x = 0; x < usersToDo.Count; x++)
                    {
                        if (usersToDo[x][2] == users[0])
                        {
                            label.BackColor = Color.Green;
                        }
                    }
                }
                usersPanel.Controls.Add(label);
                label.Click += (s, em) =>
                {
                    if (label.BackColor == Color.Green)
                    {
                        label.BackColor = Color.Transparent;
                        controller.DeleteUsersNeedToDo(taskId, users[0]);
                    }
                    else
                    {
                        label.BackColor = Color.Green;
                        controller.AddUsersNeedToDo(taskId, users[0]);
                    }

                };
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            this.controller = new ControllerClass();
            controller.UpdateTask(taskId, titleTxb.Text, descriptionTxb.Text, userId, listId);
        }
        bool mouseDown = false;
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.controller = new ControllerClass();
            controller.DeleteTask(taskId);
            this.Close();
        }
    }
}
