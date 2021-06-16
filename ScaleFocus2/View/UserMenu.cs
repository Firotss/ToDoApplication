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
    public partial class UserMenu : Form
    {
        private IController controller;
        public string user_id;
        List<string[]> lists;
        string username;
        public UserMenu(string username)
        {
            InitializeComponent();
            this.controller = new ControllerClass();
            string[] oneuser = controller.OneUser(username);
            user_id = oneuser[0];
            this.username = username;
            PrintApplications();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            this.controller = new ControllerClass();
            controller.addList(titleTbx.Text+$"({username})", user_id);
            titleTbx.Text = "";
        }
        private void PrintApplications()
        {
            this.lists = controller.AllLists(user_id);
            ToDoListsPanel.Controls.Clear();
            for (int i = 0; i < lists.Count; i++)
            {
                Label label = new Label();
                label.Name = "title" + i;
                int x = ((i) * 35) + 5 + 10;
                label.Location = new Point(5, x);
                label.Text = lists[i][1];
                label.Width = 140;
                label.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                ToDoListsPanel.Controls.Add(label);

                Button button = new Button();
                button.Name = (i).ToString();
                int y = ((i) * 35) + 10;
                button.Location = new Point(145, y);
                button.Text = "->";
                button.BackColor = Color.FromArgb(207, 207, 207);
                button.FlatAppearance.BorderSize = 0;
                button.Width = 30;
                button.FlatAppearance.MouseDownBackColor = Color.FromKnownColor(KnownColor.PaleGreen);
                button.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.PaleGreen);
                button.FlatStyle = FlatStyle.Flat;
                ToDoListsPanel.Controls.Add(button);

                button.Click += (s, em) => ShowMethod(lists[int.Parse(button.Name)]);
            }
        }
        private void ShowMethod(string[] id)
        {
            ToDoListMenu toDoListMenu = new ToDoListMenu(user_id, id);
            toDoListMenu.ShowDialog();
            PrintApplications();
        }

        private void CheckTimer_Tick(object sender, EventArgs e)
        {
            if (controller.AllLists(user_id).Count != lists.Count)
            {
                PrintApplications();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
