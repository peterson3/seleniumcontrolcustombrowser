using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Linq;

namespace SeleniumControlCustomBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.profileNameBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.profileUsernameBox = new System.Windows.Forms.TextBox();
            this.profilePasswordBox = new System.Windows.Forms.TextBox();
            this.profileGenderBox = new System.Windows.Forms.TextBox();
            this.profileNumberBox = new System.Windows.Forms.TextBox();
            this.profileProxyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smsPvaBalanceLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Criar Conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 342);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // profileNameBox
            // 
            this.profileNameBox.Location = new System.Drawing.Point(462, 12);
            this.profileNameBox.Name = "profileNameBox";
            this.profileNameBox.Size = new System.Drawing.Size(171, 20);
            this.profileNameBox.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Gerar Perfil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // profileUsernameBox
            // 
            this.profileUsernameBox.Location = new System.Drawing.Point(462, 38);
            this.profileUsernameBox.Name = "profileUsernameBox";
            this.profileUsernameBox.Size = new System.Drawing.Size(100, 20);
            this.profileUsernameBox.TabIndex = 6;
            // 
            // profilePasswordBox
            // 
            this.profilePasswordBox.Location = new System.Drawing.Point(462, 65);
            this.profilePasswordBox.Name = "profilePasswordBox";
            this.profilePasswordBox.Size = new System.Drawing.Size(100, 20);
            this.profilePasswordBox.TabIndex = 7;
            // 
            // profileGenderBox
            // 
            this.profileGenderBox.Location = new System.Drawing.Point(462, 91);
            this.profileGenderBox.Name = "profileGenderBox";
            this.profileGenderBox.Size = new System.Drawing.Size(100, 20);
            this.profileGenderBox.TabIndex = 8;
            // 
            // profileNumberBox
            // 
            this.profileNumberBox.Location = new System.Drawing.Point(462, 118);
            this.profileNumberBox.Name = "profileNumberBox";
            this.profileNumberBox.Size = new System.Drawing.Size(100, 20);
            this.profileNumberBox.TabIndex = 9;
            // 
            // profileProxyBox
            // 
            this.profileProxyBox.Location = new System.Drawing.Point(462, 145);
            this.profileProxyBox.Name = "profileProxyBox";
            this.profileProxyBox.Size = new System.Drawing.Size(100, 20);
            this.profileProxyBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "SMSPVA Balance";
            // 
            // smsPvaBalanceLabel
            // 
            this.smsPvaBalanceLabel.AutoSize = true;
            this.smsPvaBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smsPvaBalanceLabel.Location = new System.Drawing.Point(17, 145);
            this.smsPvaBalanceLabel.Name = "smsPvaBalanceLabel";
            this.smsPvaBalanceLabel.Size = new System.Drawing.Size(41, 25);
            this.smsPvaBalanceLabel.TabIndex = 12;
            this.smsPvaBalanceLabel.Text = "NA";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(205, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Run Python Script";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.smsPvaBalanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileProxyBox);
            this.Controls.Add(this.profileNumberBox);
            this.Controls.Add(this.profileGenderBox);
            this.Controls.Add(this.profilePasswordBox);
            this.Controls.Add(this.profileUsernameBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.profileNameBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox profileNameBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox profileUsernameBox;
        private System.Windows.Forms.TextBox profilePasswordBox;
        private System.Windows.Forms.TextBox profileGenderBox;
        private System.Windows.Forms.TextBox profileNumberBox;
        private System.Windows.Forms.TextBox profileProxyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label smsPvaBalanceLabel;
        private System.Windows.Forms.Button button4;
    }
}

