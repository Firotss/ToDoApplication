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
            if(user_id == list_info[3])
            {
                //добавить что то вроде 'удалить все записи где айди создателя равняется чичашнему айди,
                //а чичашнее айди поста равняется первому айди'
            }
            else
            {
                //удалить один пост где айди юзера равняется с этим юзером, а первое айди равняется чичашнему
            }
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if(choice == 1)
            {
                //добавляет запись с такими же данными за исключением одного - юзер айди должен быть тот который мы написали
            }
            else if(choice == 2)
            {
                //меняет залавие у всех таблиц с лист айди как у этого и с таким же заглавием, или если айди создателя и айди юзера разные, то меняет только название с этим юзер айди
            }

            choice = 0;

            enterBtn.Enabled = false;
            tbx.Enabled = false;
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
        }
    }
}
