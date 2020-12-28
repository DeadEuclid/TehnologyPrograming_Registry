namespace TehnologyProgramingForms.PatForms
{
    partial class MainPatForm
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
            this.talonGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SNILSlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FIOlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTalonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.talonGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // talonGrid
            // 
            this.talonGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.talonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.talonGrid.Location = new System.Drawing.Point(482, 46);
            this.talonGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.talonGrid.Name = "talonGrid";
            this.talonGrid.RowHeadersWidth = 51;
            this.talonGrid.RowTemplate.Height = 24;
            this.talonGrid.Size = new System.Drawing.Size(662, 612);
            this.talonGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(494, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "СПИСОК ПРИЁМОВ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.Location = new System.Drawing.Point(1231, 734);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 96);
            this.button1.TabIndex = 3;
            this.button1.Text = "Записаться";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button2.Location = new System.Drawing.Point(482, 681);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 96);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отменить запись";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button3.Location = new System.Drawing.Point(18, 681);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 96);
            this.button3.TabIndex = 5;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SNILSlabel
            // 
            this.SNILSlabel.AutoSize = true;
            this.SNILSlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SNILSlabel.Location = new System.Drawing.Point(11, 120);
            this.SNILSlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SNILSlabel.Name = "SNILSlabel";
            this.SNILSlabel.Size = new System.Drawing.Size(96, 37);
            this.SNILSlabel.TabIndex = 9;
            this.SNILSlabel.Text = "снилс";
            this.SNILSlabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ваш СНИЛС :";
            // 
            // FIOlabel
            // 
            this.FIOlabel.AutoSize = true;
            this.FIOlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.FIOlabel.Location = new System.Drawing.Point(11, 46);
            this.FIOlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FIOlabel.Name = "FIOlabel";
            this.FIOlabel.Size = new System.Drawing.Size(90, 37);
            this.FIOlabel.TabIndex = 7;
            this.FIOlabel.Text = "ИОФ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Здравствуйте";
            // 
            // AddTalonButton
            // 
            this.AddTalonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTalonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AddTalonButton.Location = new System.Drawing.Point(946, 681);
            this.AddTalonButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddTalonButton.Name = "AddTalonButton";
            this.AddTalonButton.Size = new System.Drawing.Size(198, 96);
            this.AddTalonButton.TabIndex = 10;
            this.AddTalonButton.Text = "Записаться на приём";
            this.AddTalonButton.UseVisualStyleBackColor = true;
            this.AddTalonButton.Click += new System.EventHandler(this.AddTalonButton_Click);
            // 
            // MainPatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 736);
            this.Controls.Add(this.AddTalonButton);
            this.Controls.Add(this.SNILSlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FIOlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.talonGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPatForm";
            this.Text = "Основоное окно пациента";
            this.Load += new System.EventHandler(this.MainPatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.talonGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView talonGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label SNILSlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FIOlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddTalonButton;
    }
}