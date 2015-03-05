namespace ToDoList
{
    partial class appointmentBuilder
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
            this.appointmentName = new System.Windows.Forms.Label();
            this.appointmentDescription = new System.Windows.Forms.Label();
            this.appointmentDate = new System.Windows.Forms.Label();
            this.appointmentTime = new System.Windows.Forms.Label();
            this.appointmentLocation = new System.Windows.Forms.Label();
            this.appointmentNameText = new System.Windows.Forms.TextBox();
            this.appointmentLocationText = new System.Windows.Forms.TextBox();
            this.appointmentDescriptionText = new System.Windows.Forms.TextBox();
            this.appointmentDateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.appointmentDateTimeTime = new System.Windows.Forms.DateTimePicker();
            this.appointmentCancel = new System.Windows.Forms.Button();
            this.appointmentDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appointmentName
            // 
            this.appointmentName.AutoSize = true;
            this.appointmentName.Location = new System.Drawing.Point(15, 19);
            this.appointmentName.Name = "appointmentName";
            this.appointmentName.Size = new System.Drawing.Size(97, 13);
            this.appointmentName.TabIndex = 0;
            this.appointmentName.Text = "Appointment Name";
            // 
            // appointmentDescription
            // 
            this.appointmentDescription.AutoSize = true;
            this.appointmentDescription.Location = new System.Drawing.Point(15, 63);
            this.appointmentDescription.Name = "appointmentDescription";
            this.appointmentDescription.Size = new System.Drawing.Size(122, 13);
            this.appointmentDescription.TabIndex = 1;
            this.appointmentDescription.Text = "Appointment Description";
            // 
            // appointmentDate
            // 
            this.appointmentDate.AutoSize = true;
            this.appointmentDate.Location = new System.Drawing.Point(15, 150);
            this.appointmentDate.Name = "appointmentDate";
            this.appointmentDate.Size = new System.Drawing.Size(92, 13);
            this.appointmentDate.TabIndex = 2;
            this.appointmentDate.Text = "Appointment Date";
            // 
            // appointmentTime
            // 
            this.appointmentTime.AutoSize = true;
            this.appointmentTime.Location = new System.Drawing.Point(15, 197);
            this.appointmentTime.Name = "appointmentTime";
            this.appointmentTime.Size = new System.Drawing.Size(92, 13);
            this.appointmentTime.TabIndex = 3;
            this.appointmentTime.Text = "Appointment Time";
            // 
            // appointmentLocation
            // 
            this.appointmentLocation.AutoSize = true;
            this.appointmentLocation.Location = new System.Drawing.Point(15, 105);
            this.appointmentLocation.Name = "appointmentLocation";
            this.appointmentLocation.Size = new System.Drawing.Size(110, 13);
            this.appointmentLocation.TabIndex = 4;
            this.appointmentLocation.Text = "Appointment Location";
            // 
            // appointmentNameText
            // 
            this.appointmentNameText.Location = new System.Drawing.Point(160, 19);
            this.appointmentNameText.MaxLength = 16;
            this.appointmentNameText.Name = "appointmentNameText";
            this.appointmentNameText.Size = new System.Drawing.Size(118, 20);
            this.appointmentNameText.TabIndex = 5;
            // 
            // appointmentLocationText
            // 
            this.appointmentLocationText.Location = new System.Drawing.Point(160, 102);
            this.appointmentLocationText.MaxLength = 256;
            this.appointmentLocationText.Name = "appointmentLocationText";
            this.appointmentLocationText.Size = new System.Drawing.Size(118, 20);
            this.appointmentLocationText.TabIndex = 6;
            // 
            // appointmentDescriptionText
            // 
            this.appointmentDescriptionText.Location = new System.Drawing.Point(160, 60);
            this.appointmentDescriptionText.MaxLength = 256;
            this.appointmentDescriptionText.Name = "appointmentDescriptionText";
            this.appointmentDescriptionText.Size = new System.Drawing.Size(118, 20);
            this.appointmentDescriptionText.TabIndex = 7;
            // 
            // appointmentDateTimeDate
            // 
            this.appointmentDateTimeDate.Location = new System.Drawing.Point(159, 143);
            this.appointmentDateTimeDate.Name = "appointmentDateTimeDate";
            this.appointmentDateTimeDate.Size = new System.Drawing.Size(119, 20);
            this.appointmentDateTimeDate.TabIndex = 8;
            this.appointmentDateTimeDate.Value = new System.DateTime(2012, 4, 2, 0, 0, 0, 0);
            // 
            // appointmentDateTimeTime
            // 
            this.appointmentDateTimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.appointmentDateTimeTime.Location = new System.Drawing.Point(160, 190);
            this.appointmentDateTimeTime.Name = "appointmentDateTimeTime";
            this.appointmentDateTimeTime.ShowUpDown = true;
            this.appointmentDateTimeTime.Size = new System.Drawing.Size(118, 20);
            this.appointmentDateTimeTime.TabIndex = 9;
            this.appointmentDateTimeTime.Value = new System.DateTime(2012, 4, 26, 11, 32, 48, 0);
            // 
            // appointmentCancel
            // 
            this.appointmentCancel.Location = new System.Drawing.Point(206, 225);
            this.appointmentCancel.Name = "appointmentCancel";
            this.appointmentCancel.Size = new System.Drawing.Size(72, 25);
            this.appointmentCancel.TabIndex = 11;
            this.appointmentCancel.Text = "Cancel";
            this.appointmentCancel.UseVisualStyleBackColor = true;
            this.appointmentCancel.Click += new System.EventHandler(this.appointmentCancel_Click);
            // 
            // appointmentDone
            // 
            this.appointmentDone.Location = new System.Drawing.Point(123, 225);
            this.appointmentDone.Name = "appointmentDone";
            this.appointmentDone.Size = new System.Drawing.Size(72, 25);
            this.appointmentDone.TabIndex = 10;
            this.appointmentDone.Text = "Done";
            this.appointmentDone.UseVisualStyleBackColor = true;
            this.appointmentDone.Click += new System.EventHandler(this.appointmentDone_Click);
            // 
            // appointmentBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.appointmentCancel);
            this.Controls.Add(this.appointmentDone);
            this.Controls.Add(this.appointmentDateTimeTime);
            this.Controls.Add(this.appointmentDateTimeDate);
            this.Controls.Add(this.appointmentDescriptionText);
            this.Controls.Add(this.appointmentLocationText);
            this.Controls.Add(this.appointmentNameText);
            this.Controls.Add(this.appointmentLocation);
            this.Controls.Add(this.appointmentTime);
            this.Controls.Add(this.appointmentDate);
            this.Controls.Add(this.appointmentDescription);
            this.Controls.Add(this.appointmentName);
            this.Name = "appointmentBuilder";
            this.Text = "To Do List Appointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.appointmentBuilder_FormClosing);
            this.Load += new System.EventHandler(this.appointmentBuilder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appointmentName;
        private System.Windows.Forms.Label appointmentDescription;
        private System.Windows.Forms.Label appointmentDate;
        private System.Windows.Forms.Label appointmentTime;
        private System.Windows.Forms.Label appointmentLocation;
        private System.Windows.Forms.TextBox appointmentNameText;
        private System.Windows.Forms.TextBox appointmentLocationText;
        private System.Windows.Forms.TextBox appointmentDescriptionText;
        private System.Windows.Forms.DateTimePicker appointmentDateTimeDate;
        private System.Windows.Forms.DateTimePicker appointmentDateTimeTime;
        private System.Windows.Forms.Button appointmentCancel;
        private System.Windows.Forms.Button appointmentDone;
    }
}