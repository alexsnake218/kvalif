namespace Exam
{
    partial class ChooseAuthor
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
            this.admin_button = new System.Windows.Forms.Button();
            this.laborant_button = new System.Windows.Forms.Button();
            this.booker_button = new System.Windows.Forms.Button();
            this.pacient_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Войти под каким пользователем?";
            // 
            // admin_button
            // 
            this.admin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admin_button.Location = new System.Drawing.Point(20, 148);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(234, 39);
            this.admin_button.TabIndex = 4;
            this.admin_button.Text = "Администратор";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // laborant_button
            // 
            this.laborant_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laborant_button.Location = new System.Drawing.Point(260, 148);
            this.laborant_button.Name = "laborant_button";
            this.laborant_button.Size = new System.Drawing.Size(234, 39);
            this.laborant_button.TabIndex = 5;
            this.laborant_button.Text = "Лаборант";
            this.laborant_button.UseVisualStyleBackColor = true;
            this.laborant_button.Click += new System.EventHandler(this.laborant_button_Click);
            // 
            // booker_button
            // 
            this.booker_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booker_button.Location = new System.Drawing.Point(260, 193);
            this.booker_button.Name = "booker_button";
            this.booker_button.Size = new System.Drawing.Size(234, 39);
            this.booker_button.TabIndex = 6;
            this.booker_button.Text = "Бухгалтер";
            this.booker_button.UseVisualStyleBackColor = true;
            this.booker_button.Click += new System.EventHandler(this.booker_button_Click);
            // 
            // pacient_button
            // 
            this.pacient_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pacient_button.Location = new System.Drawing.Point(20, 193);
            this.pacient_button.Name = "pacient_button";
            this.pacient_button.Size = new System.Drawing.Size(234, 39);
            this.pacient_button.TabIndex = 7;
            this.pacient_button.Text = "Пациент";
            this.pacient_button.UseVisualStyleBackColor = true;
            this.pacient_button.Click += new System.EventHandler(this.pacient_button_Click);
            // 
            // LoginChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(496, 407);
            this.Controls.Add(this.pacient_button);
            this.Controls.Add(this.booker_button);
            this.Controls.Add(this.laborant_button);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.label2);
            this.Name = "LoginChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход за пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button laborant_button;
        private System.Windows.Forms.Button booker_button;
        private System.Windows.Forms.Button pacient_button;
    }
}