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
    public partial class ToDoListMenu : Form
    {
        string user_id;
        string[] list_info;
        IController controller;
        string listId;
        List<string[]> tasks;
        public ToDoListMenu(string user_id, string[] id)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.list_info = id;
            topLbl.Text = id[1];
            listId = id[7];
            tbx.Enabled = false;
            enterBtn.Enabled = false;
            PrintApplications();
        }
        int choice = 0;
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.controller = new ControllerClass();

            if (user_id == list_info[3])
            {
                controller.RemoveAllLists(list_info[7]);
            }
            else
            {
                controller.RemoveOneList(list_info[7], user_id);
            }
            
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            this.controller = new ControllerClass();

            if(choice == 1)
            {
                List<string[]> users = controller.AllUsers();
                foreach (var item in users)
                {
                    if(item[1] == (tbx.Text).ToLower())
                    {
                        controller.shareList(list_info[7], item[0]);
                    }
                }
                
            }
            else if(choice == 2)
            {
                if (user_id == list_info[3])
                {
                    controller.ChangeAllLists(list_info[7], tbx.Text);
                }
                else
                {
                    controller.ChangeOneList(list_info[7], tbx.Text, user_id);
                }
                topLbl.Text = tbx.Text;
            }
            else if(choice == 3)
            {
                controller.AddTask(list_info[7], tbx.Text, user_id);
            }
            choice = 0;

            enterBtn.Enabled = false;
            tbx.Enabled = false;
            tbx.Text = "";
            lbl.Text = "";
        }

        private void shareBtn_Click(object sender, EventArgs e)
        {
            choice = 1;
            enterBtn.Enabled = true;
            tbx.Enabled = true;
            lbl.Text = "Share with id:";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            choice = 2;
            enterBtn.Enabled = true;
            tbx.Enabled = true;
            lbl.Text = "Edit with title:";
            tbx.Text = topLbl.Text;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void PrintApplications()
        {
            this.controller = new ControllerClass();
            this.tasks = controller.AllTasks(listId);
            ToDoTasksPanel.Controls.Clear();
            for (int i = 0; i < tasks.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Name = "checkbox" + i;
                int z = ((i) * 35) + 10;
                checkBox.Width = 25;
                checkBox.Location = new Point(0, z);
                checkBox.Text = tasks[i][2];
                checkBox.Width = 100;
                
                checkBox.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                if (tasks[i][4] == "True")
                {
                    checkBox.Checked = true;
                }
                else
                {
                    checkBox.Checked = false; 
                }

                ToDoTasksPanel.Controls.Add(checkBox);


                

                Button button = new Button();
                button.Name = (i).ToString();
                int y = ((i) * 35) + 10;
                button.Location = new Point(117, y);
                button.Text = ">";
                button.BackColor = Color.FromArgb(207, 207, 207);
                button.FlatAppearance.BorderSize = 0;
                button.Width = 30;
                button.FlatAppearance.MouseDownBackColor = Color.FromKnownColor(KnownColor.PaleGreen);
                button.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.PaleGreen);
                button.FlatStyle = FlatStyle.Flat;
                ToDoTasksPanel.Controls.Add(button);
                checkBox.CheckedChanged += (s, em) => UpdateCheck(checkBox.Checked, tasks[int.Parse(button.Name)]);
                button.Click += (s, em) => ShowMethod(tasks[int.Parse(button.Name)]);
            }
        }
        private void UpdateCheck(bool check, string[] task_info)
        {
            this.controller = new ControllerClass();
            if(check == true)
            {
                controller.UpdateCheck("1", task_info[0]);
            }
            else if(check == false)
            {
                controller.UpdateCheck("0", task_info[0]);
            }
        }
        private void ShowMethod(string[] task_info)
        {
            TaskForm taskForm = new TaskForm(task_info[2], task_info[3], task_info[0], user_id, listId);
            taskForm.ShowDialog();
            PrintApplications();
        }

        private void taskBtn_Click(object sender, EventArgs e)
        {
            choice = 3;
            enterBtn.Enabled = true;
            tbx.Enabled = true;
            lbl.Text = "Enter title:";
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            this.controller = new ControllerClass();
            if (controller.AllTasks(listId).Count != tasks.Count)
            {
                PrintApplications();
            }
        }
    }
}
