namespace DesktopApp1
{
    partial class NewHighscore
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
            this.nickname_label = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nickname_label
            // 
            this.nickname_label.AutoSize = true;
            this.nickname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickname_label.Location = new System.Drawing.Point(32, 30);
            this.nickname_label.Name = "nickname_label";
            this.nickname_label.Size = new System.Drawing.Size(109, 24);
            this.nickname_label.TabIndex = 0;
            this.nickname_label.Text = "Nickname:";
            this.nickname_label.UseMnemonic = false;
            this.nickname_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // nickname
            // 
            this.nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickname.Location = new System.Drawing.Point(36, 87);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(105, 29);
            this.nickname.TabIndex = 1;
            this.nickname.Text = "Worm";
            this.nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(36, 122);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(105, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // NewHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.nickname_label);
            this.Name = "NewHighscore";
            this.Text = "New higscore!";
            this.Load += new System.EventHandler(this.NewHighscore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nickname_label;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Button Submit;
    }
}