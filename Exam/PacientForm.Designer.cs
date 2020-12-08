namespace Exam
{
    partial class PacientForm
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
            this.logout_button = new System.Windows.Forms.Button();
            this.hello_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.give_zakaz_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout_button.Location = new System.Drawing.Point(732, -2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(127, 41);
            this.logout_button.TabIndex = 5;
            this.logout_button.Text = "Выйти";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hello_label.Location = new System.Drawing.Point(326, 109);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(155, 25);
            this.hello_label.TabIndex = 6;
            this.hello_label.Text = "Приветствую!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.give_zakaz_Button);
            this.groupBox1.Location = new System.Drawing.Point(123, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 293);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // give_zakaz_Button
            // 
            this.give_zakaz_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.give_zakaz_Button.Location = new System.Drawing.Point(208, 117);
            this.give_zakaz_Button.Name = "give_zakaz_Button";
            this.give_zakaz_Button.Size = new System.Drawing.Size(185, 48);
            this.give_zakaz_Button.TabIndex = 0;
            this.give_zakaz_Button.Text = "Сделать заказ";
            this.give_zakaz_Button.UseVisualStyleBackColor = true;
            this.give_zakaz_Button.Click += new System.EventHandler(this.give_zakaz_Button_Click);
            // 
            // PacientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(859, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hello_label);
            this.Controls.Add(this.logout_button);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PacientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacientForm";
            this.Load += new System.EventHandler(this.PacientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label hello_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button give_zakaz_Button;
    }
}