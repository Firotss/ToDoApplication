
namespace ScaleFocus2.View
{
    partial class TaskForm
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
            this.descriptionTxb = new System.Windows.Forms.RichTextBox();
            this.titleTxb = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.topMenu = new System.Windows.Forms.Panel();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionTxb
            // 
            this.descriptionTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTxb.Location = new System.Drawing.Point(12, 54);
            this.descriptionTxb.MaxLength = 300;
            this.descriptionTxb.Name = "descriptionTxb";
            this.descriptionTxb.Size = new System.Drawing.Size(140, 124);
            this.descriptionTxb.TabIndex = 0;
            this.descriptionTxb.Text = "";
            // 
            // titleTxb
            // 
            this.titleTxb.Location = new System.Drawing.Point(12, 28);
            this.titleTxb.Name = "titleTxb";
            this.titleTxb.Size = new System.Drawing.Size(140, 20);
            this.titleTxb.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.Location = new System.Drawing.Point(150, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(13, 13);
            this.closeBtn.TabIndex = 14;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.topMenu.Location = new System.Drawing.Point(-1, -2);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(164, 24);
            this.topMenu.TabIndex = 16;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
            this.topMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseMove);
            this.topMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseUp);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(51, 190);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(63, 20);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(164, 222);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.titleTxb);
            this.Controls.Add(this.descriptionTxb);
            this.Controls.Add(this.topMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionTxb;
        private System.Windows.Forms.TextBox titleTxb;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel topMenu;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Button deleteBtn;
    }
}