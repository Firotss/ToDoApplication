
namespace ScaleFocus2.View
{
    partial class ToDoListMenu
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.shareBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.tbx = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.ToDoTasksPanel = new System.Windows.Forms.Panel();
            this.topMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.topLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.taskBtn = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(10, 33);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 20);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // shareBtn
            // 
            this.shareBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.shareBtn.FlatAppearance.BorderSize = 0;
            this.shareBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.shareBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.shareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shareBtn.Location = new System.Drawing.Point(10, 59);
            this.shareBtn.Name = "shareBtn";
            this.shareBtn.Size = new System.Drawing.Size(75, 20);
            this.shareBtn.TabIndex = 1;
            this.shareBtn.Text = "SHARE";
            this.shareBtn.UseVisualStyleBackColor = false;
            this.shareBtn.Click += new System.EventHandler(this.shareBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(91, 85);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(48, 20);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Location = new System.Drawing.Point(91, 44);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 3;
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(91, 60);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(81, 20);
            this.tbx.TabIndex = 4;
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.enterBtn.FlatAppearance.BorderSize = 0;
            this.enterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.enterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBtn.Location = new System.Drawing.Point(145, 85);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(27, 20);
            this.enterBtn.TabIndex = 6;
            this.enterBtn.Text = "->";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // ToDoTasksPanel
            // 
            this.ToDoTasksPanel.AutoScroll = true;
            this.ToDoTasksPanel.Location = new System.Drawing.Point(3, 111);
            this.ToDoTasksPanel.Name = "ToDoTasksPanel";
            this.ToDoTasksPanel.Size = new System.Drawing.Size(169, 184);
            this.ToDoTasksPanel.TabIndex = 7;
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.topMenu.Location = new System.Drawing.Point(-3, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(179, 27);
            this.topMenu.TabIndex = 14;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
            this.topMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseMove);
            this.topMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Location = new System.Drawing.Point(10, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 2);
            this.panel2.TabIndex = 17;
            // 
            // topLbl
            // 
            this.topLbl.AutoSize = true;
            this.topLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.topLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.topLbl.Location = new System.Drawing.Point(12, 7);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(111, 17);
            this.topLbl.TabIndex = 15;
            this.topLbl.Text = "My ToDo Tasks:";
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
            this.closeBtn.Location = new System.Drawing.Point(163, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(13, 13);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // taskBtn
            // 
            this.taskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.taskBtn.FlatAppearance.BorderSize = 0;
            this.taskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.taskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.taskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskBtn.Location = new System.Drawing.Point(10, 85);
            this.taskBtn.Name = "taskBtn";
            this.taskBtn.Size = new System.Drawing.Size(75, 20);
            this.taskBtn.TabIndex = 18;
            this.taskBtn.Text = "new Task";
            this.taskBtn.UseVisualStyleBackColor = false;
            this.taskBtn.Click += new System.EventHandler(this.taskBtn_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // ToDoListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(177, 297);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.taskBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ToDoTasksPanel);
            this.Controls.Add(this.topLbl);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.shareBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.topMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToDoListMenu";
            this.Text = "ToDoListMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button shareBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Panel ToDoTasksPanel;
        private System.Windows.Forms.Panel topMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button taskBtn;
        private System.Windows.Forms.Timer updateTimer;
    }
}