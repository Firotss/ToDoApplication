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
            string check = controller.userType((usernameTbx.Text).ToLower(), passwordTbx.Text);
            if (check == "admin")
            {
                errorLbl.Text = "";
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else if(check == "user")
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
