using System;

namespace DesktopApp1
{
    partial class Form1
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
            this.playagainButton = new System.Windows.Forms.Button();
            this.you_scored_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scorepanel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.select_level_label = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.scorepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playagainButton
            // 
            this.playagainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagainButton.ForeColor = System.Drawing.Color.Crimson;
            this.playagainButton.Location = new System.Drawing.Point(178, 290);
            this.playagainButton.Name = "playagainButton";
            this.playagainButton.Size = new System.Drawing.Size(131, 59);
            this.playagainButton.TabIndex = 0;
            this.playagainButton.Text = "Play again!";
            this.playagainButton.UseVisualStyleBackColor = true;
            this.playagainButton.Visible = false;
            this.playagainButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // you_scored_label
            // 
            this.you_scored_label.AutoSize = true;
            this.you_scored_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.you_scored_label.Location = new System.Drawing.Point(12, 9);
            this.you_scored_label.Name = "you_scored_label";
            this.you_scored_label.Size = new System.Drawing.Size(139, 25);
            this.you_scored_label.TabIndex = 2;
            this.you_scored_label.Text = "You scored:";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.Location = new System.Drawing.Point(157, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(70, 25);
            this.score_label.TabIndex = 3;
            this.score_label.Text = "label2";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "!!!";
            // 
            // scorepanel
            // 
            this.scorepanel.Controls.Add(this.you_scored_label);
            this.scorepanel.Controls.Add(this.label3);
            this.scorepanel.Controls.Add(this.score_label);
            this.scorepanel.Location = new System.Drawing.Point(93, 138);
            this.scorepanel.Name = "scorepanel";
            this.scorepanel.Size = new System.Drawing.Size(290, 49);
            this.scorepanel.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(236, 213);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(273, 213);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(310, 213);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(36, 24);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(347, 213);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(36, 24);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // select_level_label
            // 
            this.select_level_label.AutoSize = true;
            this.select_level_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_level_label.Location = new System.Drawing.Point(89, 212);
            this.select_level_label.Name = "select_level_label";
            this.select_level_label.Size = new System.Drawing.Size(117, 24);
            this.select_level_label.TabIndex = 5;
            this.select_level_label.Text = "Select Level:";
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.SystemColors.Menu;
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.Color.Crimson;
            this.startbutton.Location = new System.Drawing.Point(141, 9);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(205, 123);
            this.startbutton.TabIndex = 10;
            this.startbutton.Text = "Play Game!";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Visible = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.select_level_label);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.scorepanel);
            this.Controls.Add(this.playagainButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.scorepanel.ResumeLayout(false);
            this.scorepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            level = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button playagainButton;
        private System.Windows.Forms.Label you_scored_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel scorepanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label select_level_label;
        private System.Windows.Forms.Button startbutton;
    }
}

