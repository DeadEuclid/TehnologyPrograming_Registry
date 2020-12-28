namespace TehnologyProgramingForms
{
    partial class DocAutorize
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
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AutorizeButton = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ID специалиста:";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CancelButton.Location = new System.Drawing.Point(9, 782);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(182, 48);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AutorizeButton
            // 
            this.AutorizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AutorizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AutorizeButton.Location = new System.Drawing.Point(1284, 782);
            this.AutorizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.AutorizeButton.Name = "AutorizeButton";
            this.AutorizeButton.Size = new System.Drawing.Size(178, 48);
            this.AutorizeButton.TabIndex = 2;
            this.AutorizeButton.Text = "Вход";
            this.AutorizeButton.UseVisualStyleBackColor = true;
            this.AutorizeButton.Click += new System.EventHandler(this.AutorizeButton_Click);
            // 
            // IdBox
            // 
            this.IdBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.IdBox.Location = new System.Drawing.Point(854, 10);
            this.IdBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(565, 44);
            this.IdBox.TabIndex = 3;
            // 
            // DocAutorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 843);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.AutorizeButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DocAutorize";
            this.Text = "Авторизация специалиста";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AutorizeButton;
        private System.Windows.Forms.TextBox IdBox;
    }
}