﻿
namespace Parking_plac
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
            this.components = new System.ComponentModel.Container();
            this.Open = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.brVozila = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.Lime;
            this.Open.Location = new System.Drawing.Point(214, 47);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(84, 41);
            this.Open.TabIndex = 0;
            this.Open.Text = "OPEN";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(214, 138);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(84, 44);
            this.close.TabIndex = 1;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // brVozila
            // 
            this.brVozila.Enabled = false;
            this.brVozila.Location = new System.Drawing.Point(32, 86);
            this.brVozila.Name = "brVozila";
            this.brVozila.Size = new System.Drawing.Size(100, 22);
            this.brVozila.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Slobodni mesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(399, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brVozila);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Open);
            this.Name = "Form1";
            this.Text = "PARKING PLAC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox brVozila;
        private System.Windows.Forms.Label label1;
    }
}

