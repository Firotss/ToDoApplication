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
            string check = controller.userType(usernameTbx.Text, passwordTbx.Text);
            if (check == "admin")
            {

                MessageBox.Show("ADMIN LOADED");
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else if(check == "user")
            {
                UserMenu user_Menu = new UserMenu(usernameTbx.Text);
                user_Menu.Show();
            }
            else
            {
                MessageBox.Show("Incorrect login or password");
            }
        }
    }
}
