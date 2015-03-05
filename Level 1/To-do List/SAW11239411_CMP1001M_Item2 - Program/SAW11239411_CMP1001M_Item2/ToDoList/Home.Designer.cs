namespace ToDoList
{
    partial class Home
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
            this.homeMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskNameBox = new System.Windows.Forms.ListBox();
            this.taskDescription = new System.Windows.Forms.RichTextBox();
            this.itemDelete = new System.Windows.Forms.Button();
            this.itemEdit = new System.Windows.Forms.Button();
            this.taskComplete = new System.Windows.Forms.Button();
            this.cal1 = new System.Windows.Forms.MonthCalendar();
            this.homeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeMenu
            // 
            this.homeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.homeMenu.Location = new System.Drawing.Point(0, 0);
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(643, 24);
            this.homeMenu.TabIndex = 0;
            this.homeMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // taskNameBox
            // 
            this.taskNameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.taskNameBox.FormattingEnabled = true;
            this.taskNameBox.Location = new System.Drawing.Point(16, 33);
            this.taskNameBox.Name = "taskNameBox";
            this.taskNameBox.Size = new System.Drawing.Size(147, 82);
            this.taskNameBox.TabIndex = 2;
            this.taskNameBox.SelectedIndexChanged += new System.EventHandler(this.taskNameBox_SelectedIndexChanged);
            // 
            // taskDescription
            // 
            this.taskDescription.Location = new System.Drawing.Point(189, 33);
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.ReadOnly = true;
            this.taskDescription.ShowSelectionMargin = true;
            this.taskDescription.Size = new System.Drawing.Size(164, 162);
            this.taskDescription.TabIndex = 3;
            this.taskDescription.Text = "";
            // 
            // itemDelete
            // 
            this.itemDelete.Location = new System.Drawing.Point(12, 121);
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(61, 23);
            this.itemDelete.TabIndex = 4;
            this.itemDelete.Text = "Delete";
            this.itemDelete.UseVisualStyleBackColor = true;
            this.itemDelete.Click += new System.EventHandler(this.itemDelete_Click);
            // 
            // itemEdit
            // 
            this.itemEdit.Location = new System.Drawing.Point(102, 121);
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(61, 23);
            this.itemEdit.TabIndex = 5;
            this.itemEdit.Text = "Edit";
            this.itemEdit.UseVisualStyleBackColor = true;
            this.itemEdit.Click += new System.EventHandler(this.itemEdit_Click);
            // 
            // taskComplete
            // 
            this.taskComplete.Location = new System.Drawing.Point(12, 158);
            this.taskComplete.Name = "taskComplete";
            this.taskComplete.Size = new System.Drawing.Size(150, 21);
            this.taskComplete.TabIndex = 6;
            this.taskComplete.Text = "Complete";
            this.taskComplete.UseVisualStyleBackColor = true;
            this.taskComplete.Click += new System.EventHandler(this.taskComplete_Click);
            // 
            // cal1
            // 
            this.cal1.Location = new System.Drawing.Point(382, 33);
            this.cal1.Name = "cal1";
            this.cal1.TabIndex = 7;
            this.cal1.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 222);
            this.Controls.Add(this.cal1);
            this.Controls.Add(this.taskComplete);
            this.Controls.Add(this.itemEdit);
            this.Controls.Add(this.itemDelete);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.taskNameBox);
            this.Controls.Add(this.homeMenu);
            this.MainMenuStrip = this.homeMenu;
            this.Name = "Home";
            this.Text = "Home";
            this.homeMenu.ResumeLayout(false);
            this.homeMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip homeMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox taskNameBox;
        private System.Windows.Forms.RichTextBox taskDescription;
        private System.Windows.Forms.Button itemDelete;
        private System.Windows.Forms.Button itemEdit;
        private System.Windows.Forms.Button taskComplete;
        public System.Windows.Forms.MonthCalendar cal1;
    }
}