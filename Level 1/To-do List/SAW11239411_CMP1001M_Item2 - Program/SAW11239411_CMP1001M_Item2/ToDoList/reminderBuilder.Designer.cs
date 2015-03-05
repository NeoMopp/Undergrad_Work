namespace ToDoList
{
    partial class reminderBuilder
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
            this.reminderDone = new System.Windows.Forms.Button();
            this.reminderCancel = new System.Windows.Forms.Button();
            this.reminderName = new System.Windows.Forms.Label();
            this.reminderDescription = new System.Windows.Forms.Label();
            this.reminderDate = new System.Windows.Forms.Label();
            this.reminderNameText = new System.Windows.Forms.TextBox();
            this.reminderDescriptionText = new System.Windows.Forms.TextBox();
            this.reminderDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // reminderDone
            // 
            this.reminderDone.Location = new System.Drawing.Point(121, 128);
            this.reminderDone.Name = "reminderDone";
            this.reminderDone.Size = new System.Drawing.Size(72, 25);
            this.reminderDone.TabIndex = 8;
            this.reminderDone.Text = "Done";
            this.reminderDone.UseVisualStyleBackColor = true;
            this.reminderDone.Click += new System.EventHandler(this.reminderDone_Click);
            // 
            // reminderCancel
            // 
            this.reminderCancel.Location = new System.Drawing.Point(199, 128);
            this.reminderCancel.Name = "reminderCancel";
            this.reminderCancel.Size = new System.Drawing.Size(72, 25);
            this.reminderCancel.TabIndex = 9;
            this.reminderCancel.Text = "Cancel";
            this.reminderCancel.UseVisualStyleBackColor = true;
            this.reminderCancel.Click += new System.EventHandler(this.reminderCancel_Click);
            // 
            // reminderName
            // 
            this.reminderName.AutoSize = true;
            this.reminderName.Location = new System.Drawing.Point(20, 20);
            this.reminderName.Name = "reminderName";
            this.reminderName.Size = new System.Drawing.Size(83, 13);
            this.reminderName.TabIndex = 10;
            this.reminderName.Text = "Reminder Name";
            // 
            // reminderDescription
            // 
            this.reminderDescription.AutoSize = true;
            this.reminderDescription.Location = new System.Drawing.Point(19, 52);
            this.reminderDescription.Name = "reminderDescription";
            this.reminderDescription.Size = new System.Drawing.Size(108, 13);
            this.reminderDescription.TabIndex = 11;
            this.reminderDescription.Text = "Reminder Description";
            // 
            // reminderDate
            // 
            this.reminderDate.AutoSize = true;
            this.reminderDate.Location = new System.Drawing.Point(20, 86);
            this.reminderDate.Name = "reminderDate";
            this.reminderDate.Size = new System.Drawing.Size(30, 13);
            this.reminderDate.TabIndex = 12;
            this.reminderDate.Text = "Date";
            // 
            // reminderNameText
            // 
            this.reminderNameText.Location = new System.Drawing.Point(146, 19);
            this.reminderNameText.MaxLength = 16;
            this.reminderNameText.Name = "reminderNameText";
            this.reminderNameText.Size = new System.Drawing.Size(125, 20);
            this.reminderNameText.TabIndex = 13;
            // 
            // reminderDescriptionText
            // 
            this.reminderDescriptionText.Location = new System.Drawing.Point(146, 49);
            this.reminderDescriptionText.MaxLength = 256;
            this.reminderDescriptionText.Name = "reminderDescriptionText";
            this.reminderDescriptionText.Size = new System.Drawing.Size(125, 20);
            this.reminderDescriptionText.TabIndex = 14;
            // 
            // reminderDateTime
            // 
            this.reminderDateTime.Location = new System.Drawing.Point(146, 80);
            this.reminderDateTime.Name = "reminderDateTime";
            this.reminderDateTime.Size = new System.Drawing.Size(125, 20);
            this.reminderDateTime.TabIndex = 15;
            this.reminderDateTime.Value = new System.DateTime(2012, 3, 27, 0, 0, 0, 0);
            // 
            // reminderBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.reminderDateTime);
            this.Controls.Add(this.reminderDescriptionText);
            this.Controls.Add(this.reminderNameText);
            this.Controls.Add(this.reminderDate);
            this.Controls.Add(this.reminderDescription);
            this.Controls.Add(this.reminderName);
            this.Controls.Add(this.reminderCancel);
            this.Controls.Add(this.reminderDone);
            this.Name = "reminderBuilder";
            this.Text = "To Do List Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.reminderBuilder_FormClosing);
            this.Load += new System.EventHandler(this.reminderBuilder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reminderDone;
        private System.Windows.Forms.Button reminderCancel;
        private System.Windows.Forms.Label reminderName;
        private System.Windows.Forms.Label reminderDescription;
        private System.Windows.Forms.Label reminderDate;
        private System.Windows.Forms.TextBox reminderNameText;
        private System.Windows.Forms.TextBox reminderDescriptionText;
        private System.Windows.Forms.DateTimePicker reminderDateTime;

    }
}