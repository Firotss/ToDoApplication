
namespace ScaleFocus2
{
    partial class StartPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.usernameTbx = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topLbl = new System.Windows.Forms.Label();
            this.topMenu = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // passwordTbx
            // 
            this.passwordTbx.Location = new System.Drawing.Point(74, 81);
            this.passwordTbx.MaxLength = 50;
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.PasswordChar = '*';
            this.passwordTbx.Size = new System.Drawing.Size(100, 20);
            this.passwordTbx.TabIndex = 7;
            // 
            // usernameTbx
            // 
            this.usernameTbx.Location = new System.Drawing.Point(74, 55);
            this.usernameTbx.MaxLength = 14;
            this.usernameTbx.Name = "usernameTbx";
            this.usernameTbx.Size = new System.Drawing.Size(100, 20);
            this.usernameTbx.TabIndex = 6;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(180, 55);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(26, 46);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "->";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Location = new System.Drawing.Point(10, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 10;
            // 
            // topLbl
            // 
            this.topLbl.AutoSize = true;
            this.topLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.topLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.topLbl.Location = new System.Drawing.Point(12, 7);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(43, 17);
            this.topLbl.TabIndex = 11;
            this.topLbl.Text = "Login";
            this.topLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topLbl_MouseDown);
            this.topLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLbl_MouseMove);
            this.topLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topLbl_MouseUp);
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.Transparent;
            this.topMenu.Controls.Add(this.topLbl);
            this.topMenu.Controls.Add(this.closeBtn);
            this.topMenu.Location = new System.Drawing.Point(0, -2);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(230, 32);
            this.topMenu.TabIndex = 12;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
            this.topMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseMove);
            this.topMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseUp);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.Location = new System.Drawing.Point(206, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(13, 13);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.errorLbl.Location = new System.Drawing.Point(52, 37);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 15);
            this.errorLbl.TabIndex = 14;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(220, 131);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTbx);
            this.Controls.Add(this.usernameTbx);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.topMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartPage";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.TextBox usernameTbx;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.Panel topMenu;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label errorLbl;
    }
}

