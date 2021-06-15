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
        public ToDoListMenu(string user_id, string[] id)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.list_info = id;
            titlelbl.Text = id[1];
            tbx.Enabled = false;
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
                controller.shareList(list_info[7], tbx.Text);
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
                titlelbl.Text = tbx.Text;
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
            tbx.Text = titlelbl.Text;
        }
    }
}
