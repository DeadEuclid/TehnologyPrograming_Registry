namespace TehnologyProgramingForms
{
    partial class RoleChoise
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DocButton = new System.Windows.Forms.Button();
            this.PatButton = new System.Windows.Forms.Button();
            this.ManagerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите роль:";
            // 
            // DocButton
            // 
            this.DocButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocButton.Location = new System.Drawing.Point(68, 45);
            this.DocButton.Margin = new System.Windows.Forms.Padding(2);
            this.DocButton.MinimumSize = new System.Drawing.Size(153, 65);
            this.DocButton.Name = "DocButton";
            this.DocButton.Size = new System.Drawing.Size(1415, 65);
            this.DocButton.TabIndex = 1;
            this.DocButton.Text = "Врач";
            this.DocButton.UseVisualStyleBackColor = true;
            this.DocButton.Click += new System.EventHandler(this.DocButton_Click);
            // 
            // PatButton
            // 
            this.PatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatButton.Location = new System.Drawing.Point(68, 112);
            this.PatButton.Margin = new System.Windows.Forms.Padding(2);
            this.PatButton.MinimumSize = new System.Drawing.Size(153, 65);
            this.PatButton.Name = "PatButton";
            this.PatButton.Size = new System.Drawing.Size(1415, 65);
            this.PatButton.TabIndex = 2;
            this.PatButton.Text = "Пациент";
            this.PatButton.UseVisualStyleBackColor = true;
            this.PatButton.Click += new System.EventHandler(this.PatButton_Click);
            // 
            // ManagerButton
            // 
            this.ManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagerButton.Location = new System.Drawing.Point(68, 180);
            this.ManagerButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManagerButton.MinimumSize = new System.Drawing.Size(153, 65);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(1415, 65);
            this.ManagerButton.TabIndex = 3;
            this.ManagerButton.Text = "Заведующий отделением";
            this.ManagerButton.UseVisualStyleBackColor = true;
            this.ManagerButton.Click += new System.EventHandler(this.ManagerButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(706, 769);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.MinimumSize = new System.Drawing.Size(153, 65);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(166, 65);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // RoleChoise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ManagerButton);
            this.Controls.Add(this.PatButton);
            this.Controls.Add(this.DocButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoleChoise";
            this.Text = "Выбор роли";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DocButton;
        private System.Windows.Forms.Button PatButton;
        private System.Windows.Forms.Button ManagerButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

