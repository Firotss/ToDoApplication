
namespace ScaleFocus2.View
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstnameLbl = new System.Windows.Forms.Label();
            this.lasynameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTxb = new System.Windows.Forms.TextBox();
            this.PasswordTxb = new System.Windows.Forms.TextBox();
            this.lastnameTxb = new System.Windows.Forms.TextBox();
            this.IDlbl = new System.Windows.Forms.Label();
            this.firstnameTxb = new System.Windows.Forms.TextBox();
            this.idTxb = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.dataGridOfUsers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_creation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_of_creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_last_change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // firstnameLbl
            // 
            this.firstnameLbl.AutoSize = true;
            this.firstnameLbl.Location = new System.Drawing.Point(338, 64);
            this.firstnameLbl.Name = "firstnameLbl";
            this.firstnameLbl.Size = new System.Drawing.Size(60, 13);
            this.firstnameLbl.TabIndex = 29;
            this.firstnameLbl.Text = "First Name:";
            // 
            // lasynameLbl
            // 
            this.lasynameLbl.AutoSize = true;
            this.lasynameLbl.Location = new System.Drawing.Point(337, 90);
            this.lasynameLbl.Name = "lasynameLbl";
            this.lasynameLbl.Size = new System.Drawing.Size(61, 13);
            this.lasynameLbl.TabIndex = 28;
            this.lasynameLbl.Text = "Last Name:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(147, 90);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(56, 13);
            this.passwordLbl.TabIndex = 27;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(147, 64);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(58, 13);
            this.usernameLbl.TabIndex = 26;
            this.usernameLbl.Text = "Username:";
            // 
            // usernameTxb
            // 
            this.usernameTxb.Location = new System.Drawing.Point(208, 61);
            this.usernameTxb.MaxLength = 14;
            this.usernameTxb.Name = "usernameTxb";
            this.usernameTxb.Size = new System.Drawing.Size(100, 20);
            this.usernameTxb.TabIndex = 25;
            // 
            // PasswordTxb
            // 
            this.PasswordTxb.Location = new System.Drawing.Point(208, 87);
            this.PasswordTxb.MaxLength = 50;
            this.PasswordTxb.Name = "PasswordTxb";
            this.PasswordTxb.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxb.TabIndex = 24;
            // 
            // lastnameTxb
            // 
            this.lastnameTxb.Location = new System.Drawing.Point(401, 87);
            this.lastnameTxb.MaxLength = 50;
            this.lastnameTxb.Name = "lastnameTxb";
            this.lastnameTxb.Size = new System.Drawing.Size(100, 20);
            this.lastnameTxb.TabIndex = 23;
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(183, 14);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(19, 13);
            this.IDlbl.TabIndex = 22;
            this.IDlbl.Text = "Id:";
            // 
            // firstnameTxb
            // 
            this.firstnameTxb.Location = new System.Drawing.Point(401, 61);
            this.firstnameTxb.MaxLength = 50;
            this.firstnameTxb.Name = "firstnameTxb";
            this.firstnameTxb.Size = new System.Drawing.Size(100, 20);
            this.firstnameTxb.TabIndex = 21;
            // 
            // idTxb
            // 
            this.idTxb.Location = new System.Drawing.Point(208, 11);
            this.idTxb.Name = "idTxb";
            this.idTxb.Size = new System.Drawing.Size(100, 20);
            this.idTxb.TabIndex = 20;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(415, 16);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterBtn.TabIndex = 19;
            this.EnterBtn.Text = "ENTER";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // dataGridOfUsers
            // 
            this.dataGridOfUsers.AllowUserToAddRows = false;
            this.dataGridOfUsers.AllowUserToDeleteRows = false;
            this.dataGridOfUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOfUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.password,
            this.first_name,
            this.last_name,
            this.date_of_creation,
            this.id_of_creator,
            this.date_of_last_change,
            this.last_id});
            this.dataGridOfUsers.Location = new System.Drawing.Point(12, 125);
            this.dataGridOfUsers.Name = "dataGridOfUsers";
            this.dataGridOfUsers.ReadOnly = true;
            this.dataGridOfUsers.Size = new System.Drawing.Size(570, 246);
            this.dataGridOfUsers.TabIndex = 18;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "first_name";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "last_name";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // date_of_creation
            // 
            this.date_of_creation.HeaderText = "date_of_creation";
            this.date_of_creation.Name = "date_of_creation";
            this.date_of_creation.ReadOnly = true;
            // 
            // id_of_creator
            // 
            this.id_of_creator.HeaderText = "id_of_creator";
            this.id_of_creator.Name = "id_of_creator";
            this.id_of_creator.ReadOnly = true;
            // 
            // date_of_last_change
            // 
            this.date_of_last_change.HeaderText = "date_of_last_change";
            this.date_of_last_change.Name = "date_of_last_change";
            this.date_of_last_change.ReadOnly = true;
            // 
            // last_id
            // 
            this.last_id.HeaderText = "last_id";
            this.last_id.Name = "last_id";
            this.last_id.ReadOnly = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(12, 87);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(120, 32);
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "DELETE USER";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(12, 49);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(120, 32);
            this.editBtn.TabIndex = 16;
            this.editBtn.Text = "EDIT USER";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 11);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(120, 32);
            this.createBtn.TabIndex = 15;
            this.createBtn.Text = "CREATE USER";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 382);
            this.Controls.Add(this.firstnameLbl);
            this.Controls.Add(this.lasynameLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.usernameTxb);
            this.Controls.Add(this.PasswordTxb);
            this.Controls.Add(this.lastnameTxb);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.firstnameTxb);
            this.Controls.Add(this.idTxb);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.dataGridOfUsers);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.createBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(610, 421);
            this.MinimumSize = new System.Drawing.Size(610, 421);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnameLbl;
        private System.Windows.Forms.Label lasynameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernameTxb;
        private System.Windows.Forms.TextBox PasswordTxb;
        private System.Windows.Forms.TextBox lastnameTxb;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.TextBox firstnameTxb;
        private System.Windows.Forms.TextBox idTxb;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.DataGridView dataGridOfUsers;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_creation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_of_creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_last_change;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_id;
    }
}