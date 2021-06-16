
namespace ScaleFocus2.View
{
    partial class UserMenu
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
            this.components = new System.ComponentModel.Container();
            this.createBtn = new System.Windows.Forms.Button();
            this.titleTbx = new System.Windows.Forms.TextBox();
            this.ToDoListsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.topMenu = new System.Windows.Forms.Panel();
            this.topLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.createBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Location = new System.Drawing.Point(152, 33);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(58, 20);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "CREATE";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // titleTbx
            // 
            this.titleTbx.Location = new System.Drawing.Point(62, 33);
            this.titleTbx.MaxLength = 12;
            this.titleTbx.Name = "titleTbx";
            this.titleTbx.Size = new System.Drawing.Size(84, 20);
            this.titleTbx.TabIndex = 2;
            // 
            // ToDoListsPanel
            // 
            this.ToDoListsPanel.AutoScroll = true;
            this.ToDoListsPanel.Location = new System.Drawing.Point(12, 59);
            this.ToDoListsPanel.Name = "ToDoListsPanel";
            this.ToDoListsPanel.Size = new System.Drawing.Size(196, 308);
            this.ToDoListsPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "List title:";
            // 
            // CheckTimer
            // 
            this.CheckTimer.Enabled = true;
            this.CheckTimer.Interval = 1000;
            this.CheckTimer.Tick += new System.EventHandler(this.CheckTimer_Tick);
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.topMenu.Location = new System.Drawing.Point(-4, -4);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(231, 31);
            this.topMenu.TabIndex = 13;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
            this.topMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseMove);
            this.topMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseUp);
            // 
            // topLbl
            // 
            this.topLbl.AutoSize = true;
            this.topLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.topLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.topLbl.Location = new System.Drawing.Point(12, 7);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(102, 17);
            this.topLbl.TabIndex = 11;
            this.topLbl.Text = "My ToDo Lists:";
            this.topLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topLbl_MouseDown);
            this.topLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLbl_MouseMove);
            this.topLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topLbl_MouseUp);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Location = new System.Drawing.Point(10, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 14;
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(220, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.ToDoListsPanel);
            this.Controls.Add(this.titleTbx);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.topMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(220, 370);
            this.MinimumSize = new System.Drawing.Size(220, 370);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox titleTbx;
        private System.Windows.Forms.Panel ToDoListsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer CheckTimer;
        private System.Windows.Forms.Panel topMenu;
        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
    }
}