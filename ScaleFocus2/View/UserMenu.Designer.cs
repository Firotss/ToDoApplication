
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
            this.createBtn = new System.Windows.Forms.Button();
            this.titleTbx = new System.Windows.Forms.TextBox();
            this.ToDoListsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(150, 7);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(58, 20);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "CREATE";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // titleTbx
            // 
            this.titleTbx.Location = new System.Drawing.Point(60, 7);
            this.titleTbx.Name = "titleTbx";
            this.titleTbx.Size = new System.Drawing.Size(84, 20);
            this.titleTbx.TabIndex = 2;
            // 
            // ToDoListsPanel
            // 
            this.ToDoListsPanel.AutoScroll = true;
            this.ToDoListsPanel.Location = new System.Drawing.Point(12, 33);
            this.ToDoListsPanel.Name = "ToDoListsPanel";
            this.ToDoListsPanel.Size = new System.Drawing.Size(196, 284);
            this.ToDoListsPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "List title:";
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDoListsPanel);
            this.Controls.Add(this.titleTbx);
            this.Controls.Add(this.createBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(236, 370);
            this.MinimumSize = new System.Drawing.Size(236, 370);
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
    }
}