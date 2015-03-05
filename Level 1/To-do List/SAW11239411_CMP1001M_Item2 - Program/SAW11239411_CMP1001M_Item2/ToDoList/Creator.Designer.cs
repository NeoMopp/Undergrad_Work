namespace ToDoList
{
    partial class Creator
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
            this.extenedTaskButton = new System.Windows.Forms.Button();
            this.reminderButton = new System.Windows.Forms.Button();
            this.appointmentButton = new System.Windows.Forms.Button();
            this.noteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extenedTaskButton
            // 
            this.extenedTaskButton.Location = new System.Drawing.Point(95, 102);
            this.extenedTaskButton.Name = "extenedTaskButton";
            this.extenedTaskButton.Size = new System.Drawing.Size(109, 26);
            this.extenedTaskButton.TabIndex = 0;
            this.extenedTaskButton.Text = "Task";
            this.extenedTaskButton.UseVisualStyleBackColor = true;
            this.extenedTaskButton.Click += new System.EventHandler(this.extenedTaskButton_Click);
            // 
            // reminderButton
            // 
            this.reminderButton.Location = new System.Drawing.Point(95, 163);
            this.reminderButton.Name = "reminderButton";
            this.reminderButton.Size = new System.Drawing.Size(109, 26);
            this.reminderButton.TabIndex = 1;
            this.reminderButton.Text = "Reminder";
            this.reminderButton.UseVisualStyleBackColor = true;
            this.reminderButton.Click += new System.EventHandler(this.reminderButton_Click);
            // 
            // appointmentButton
            // 
            this.appointmentButton.Location = new System.Drawing.Point(95, 220);
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.Size = new System.Drawing.Size(109, 26);
            this.appointmentButton.TabIndex = 2;
            this.appointmentButton.Text = "Appointment";
            this.appointmentButton.UseVisualStyleBackColor = true;
            this.appointmentButton.Click += new System.EventHandler(this.appointmentButton_Click);
            // 
            // noteButton
            // 
            this.noteButton.Location = new System.Drawing.Point(95, 46);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(109, 26);
            this.noteButton.TabIndex = 3;
            this.noteButton.Text = "Note";
            this.noteButton.UseVisualStyleBackColor = true;
            this.noteButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 293);
            this.Controls.Add(this.noteButton);
            this.Controls.Add(this.appointmentButton);
            this.Controls.Add(this.reminderButton);
            this.Controls.Add(this.extenedTaskButton);
            this.Name = "Creator";
            this.Text = "To Do List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Creator_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button extenedTaskButton;
        private System.Windows.Forms.Button reminderButton;
        private System.Windows.Forms.Button appointmentButton;
        private System.Windows.Forms.Button noteButton;

    }
}