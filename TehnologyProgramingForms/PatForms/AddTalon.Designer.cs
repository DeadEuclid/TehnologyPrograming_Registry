namespace TehnologyProgramingForms.PatForms
{
    partial class AddTalon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HousUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.specialistBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GetTalonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.HousUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Специалист";
            // 
            // HousUpDown
            // 
            this.HousUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.HousUpDown.Location = new System.Drawing.Point(239, 104);
            this.HousUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HousUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.HousUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.HousUpDown.Name = "HousUpDown";
            this.HousUpDown.Size = new System.Drawing.Size(51, 44);
            this.HousUpDown.TabIndex = 3;
            this.HousUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.HousUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // minuteUpDown
            // 
            this.minuteUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.minuteUpDown.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.minuteUpDown.Location = new System.Drawing.Point(325, 104);
            this.minuteUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minuteUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.minuteUpDown.Name = "minuteUpDown";
            this.minuteUpDown.Size = new System.Drawing.Size(45, 44);
            this.minuteUpDown.TabIndex = 4;
            // 
            // specialistBox
            // 
            this.specialistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.specialistBox.FormattingEnabled = true;
            this.specialistBox.Location = new System.Drawing.Point(238, 23);
            this.specialistBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.specialistBox.Name = "specialistBox";
            this.specialistBox.Size = new System.Drawing.Size(464, 45);
            this.specialistBox.TabIndex = 5;
            this.specialistBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.Location = new System.Drawing.Point(11, 730);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 104);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetTalonButton
            // 
            this.GetTalonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetTalonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.GetTalonButton.Location = new System.Drawing.Point(1196, 730);
            this.GetTalonButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetTalonButton.Name = "GetTalonButton";
            this.GetTalonButton.Size = new System.Drawing.Size(250, 104);
            this.GetTalonButton.TabIndex = 7;
            this.GetTalonButton.Text = "Записаться";
            this.GetTalonButton.UseVisualStyleBackColor = true;
            this.GetTalonButton.Click += new System.EventHandler(this.GetTalonButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(295, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.dateTime.Location = new System.Drawing.Point(387, 103);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(297, 44);
            this.dateTime.TabIndex = 9;
            // 
            // AddTalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 845);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetTalonButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.specialistBox);
            this.Controls.Add(this.minuteUpDown);
            this.Controls.Add(this.HousUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTalon";
            this.Text = "Запись на приём";
            this.Load += new System.EventHandler(this.AddTalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HousUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown HousUpDown;
        private System.Windows.Forms.NumericUpDown minuteUpDown;
        private System.Windows.Forms.ComboBox specialistBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GetTalonButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}