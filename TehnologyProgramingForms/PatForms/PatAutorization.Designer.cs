namespace TehnologyProgramingForms
{
    partial class PatAutorization
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
            this.SNILSBox = new System.Windows.Forms.TextBox();
            this.autorizeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SNILSBox
            // 
            this.SNILSBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SNILSBox.Location = new System.Drawing.Point(15, 47);
            this.SNILSBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SNILSBox.Name = "SNILSBox";
            this.SNILSBox.Size = new System.Drawing.Size(359, 44);
            this.SNILSBox.TabIndex = 7;
            // 
            // autorizeButton
            // 
            this.autorizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.autorizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.autorizeButton.Location = new System.Drawing.Point(1252, 720);
            this.autorizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.autorizeButton.Name = "autorizeButton";
            this.autorizeButton.Size = new System.Drawing.Size(182, 66);
            this.autorizeButton.TabIndex = 6;
            this.autorizeButton.Text = "Вход";
            this.autorizeButton.UseVisualStyleBackColor = true;
            this.autorizeButton.Click += new System.EventHandler(this.autorizeButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.Location = new System.Drawing.Point(16, 720);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.MinimumSize = new System.Drawing.Size(153, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите СНИЛС пациента:";
            // 
            // PatAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 845);
            this.Controls.Add(this.SNILSBox);
            this.Controls.Add(this.autorizeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(153, 65);
            this.Name = "PatAutorization";
            this.Text = "Регистрация пациента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SNILSBox;
        private System.Windows.Forms.Button autorizeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}