using ScaleFocus2.Contoller;
using ScaleFocus2.Model;
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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            off();
            this.controller = new ControllerClass();
            List<string[]> listOfUsers= new List<string[]>();
            listOfUsers = controller.AllUsers();
            foreach (string[] item in listOfUsers)
            {
                dataGridOfUsers.Rows.Add(item);
            }
           
        }
        private int choice = 0;
        private IController controller;
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            this.controller = new ControllerClass();

            if(choice == 1)
            {
                controller.addUser(firstnameTxb.Text, lastnameTxb.Text, PasswordTxb.Text, usernameTxb.Text);
            }
            else if(choice == 2)
            {
                controller.updateUser(idTxb.Text, firstnameTxb.Text, lastnameTxb.Text, PasswordTxb.Text, usernameTxb.Text);
            }
            else if(choice == 3)
            {
                controller.deleteUser(idTxb.Text);
            }
            List<string[]> listOfUsers = new List<string[]>();
            listOfUsers = controller.AllUsers();
            dataGridOfUsers.Rows.Clear();
            foreach (string[] item in listOfUsers)
            {
                dataGridOfUsers.Rows.Add(item);
            }
            choice = 0;
            off();

            createBtn.Enabled = true;
            editBtn.Enabled = true;
            DeleteBtn.Enabled = true;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            choice = 1;

            EnterBtn.Visible = true;

            createBtn.Enabled = false;
            DeleteBtn.Enabled = true;
            editBtn.Enabled = true;

            idTxb.Visible = false;
            IDlbl.Visible = false;
            usernameLbl.Visible = true;
            usernameTxb.Visible = true;
            passwordLbl.Visible = true;
            PasswordTxb.Visible = true;
            firstnameLbl.Visible = true;
            firstnameTxb.Visible = true;
            lastnameTxb.Visible = true;
            lasynameLbl.Visible = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            choice = 2;

            EnterBtn.Visible = true;

            editBtn.Enabled = false;
            createBtn.Enabled = true;
            DeleteBtn.Enabled = true;

            idTxb.Visible = true;
            IDlbl.Visible = true;
            usernameLbl.Visible = true;
            usernameTxb.Visible = true;
            passwordLbl.Visible = true;
            PasswordTxb.Visible = true;
            firstnameLbl.Visible = true;
            firstnameTxb.Visible = true;
            lastnameTxb.Visible = true;
            lasynameLbl.Visible = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            off();
            choice = 3;

            EnterBtn.Visible = true;

            DeleteBtn.Enabled = false;
            createBtn.Enabled = true;
            editBtn.Enabled = true;

            IDlbl.Visible = true;
            idTxb.Visible = true;

        }

        private void off()
        {
            EnterBtn.Visible = false;
            idTxb.Visible = false;
            IDlbl.Visible = false;
            usernameLbl.Visible = false;
            usernameTxb.Visible = false;
            passwordLbl.Visible = false;
            PasswordTxb.Visible = false;
            firstnameLbl.Visible = false;
            firstnameTxb.Visible = false;
            lastnameTxb.Visible = false;
            lasynameLbl.Visible = false;
        }
    }
}
