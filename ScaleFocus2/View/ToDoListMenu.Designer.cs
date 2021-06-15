
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.shareBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.tbx = new System.Windows.Forms.TextBox();
            this.titlelbl = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(3, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = "delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // shareBtn
            // 
            this.shareBtn.Location = new System.Drawing.Point(3, 28);
            this.shareBtn.Name = "shareBtn";
            this.shareBtn.Size = new System.Drawing.Size(75, 23);
            this.shareBtn.TabIndex = 1;
            this.shareBtn.Text = "share";
            this.shareBtn.UseVisualStyleBackColor = true;
            this.shareBtn.Click += new System.EventHandler(this.shareBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(3, 53);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(81, 8);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 3;
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(84, 31);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(88, 20);
            this.tbx.TabIndex = 4;
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Location = new System.Drawing.Point(70, 79);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(30, 13);
            this.titlelbl.TabIndex = 5;
            this.titlelbl.Text = "Title:";
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(84, 53);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(88, 23);
            this.enterBtn.TabIndex = 6;
            this.enterBtn.Text = "enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // ToDoListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 207);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.shareBtn);
            this.Controls.Add(this.deleteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Button enterBtn;
    }
}