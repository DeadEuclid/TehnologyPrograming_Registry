namespace TehnologyProgramingForms
{
    partial class DocRegistration
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
            this.button1 = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specialisationBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.Location = new System.Drawing.Point(16, 753);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.MinimumSize = new System.Drawing.Size(153, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.RegistrationButton.Location = new System.Drawing.Point(1111, 751);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegistrationButton.MinimumSize = new System.Drawing.Size(153, 65);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(307, 67);
            this.RegistrationButton.TabIndex = 1;
            this.RegistrationButton.Text = "Зрегестрировать";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MinimumSize = new System.Drawing.Size(153, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите данные для регистрации:";
            // 
            // FIOBox
            // 
            this.FIOBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FIOBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.FIOBox.Location = new System.Drawing.Point(797, 45);
            this.FIOBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FIOBox.MinimumSize = new System.Drawing.Size(153, 65);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(621, 44);
            this.FIOBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MinimumSize = new System.Drawing.Size(153, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 65);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя Фамилия Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MinimumSize = new System.Drawing.Size(153, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 65);
            this.label3.TabIndex = 6;
            this.label3.Text = "Специализация";
            // 
            // specialisationBox
            // 
            this.specialisationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.specialisationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.specialisationBox.Location = new System.Drawing.Point(797, 93);
            this.specialisationBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.specialisationBox.MinimumSize = new System.Drawing.Size(153, 65);
            this.specialisationBox.Name = "specialisationBox";
            this.specialisationBox.Size = new System.Drawing.Size(621, 44);
            this.specialisationBox.TabIndex = 7;
            // 
            // DocRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 840);
            this.Controls.Add(this.specialisationBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DocRegistration";
            this.Text = "Регистрация специалиста";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DocRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox specialisationBox;
    }
}