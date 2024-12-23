﻿namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputHealth = new System.Windows.Forms.TextBox();
            this.InputArmor = new System.Windows.Forms.TextBox();
            this.LabelHealth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelArmor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxOutput = new System.Windows.Forms.TextBox();
            this.OutputToughness = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputPoints = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputHealth
            // 
            this.InputHealth.Location = new System.Drawing.Point(14, 50);
            this.InputHealth.Name = "InputHealth";
            this.InputHealth.Size = new System.Drawing.Size(126, 20);
            this.InputHealth.TabIndex = 0;
            // 
            // InputArmor
            // 
            this.InputArmor.Location = new System.Drawing.Point(12, 96);
            this.InputArmor.Name = "InputArmor";
            this.InputArmor.Size = new System.Drawing.Size(126, 20);
            this.InputArmor.TabIndex = 1;
            this.InputArmor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LabelHealth
            // 
            this.LabelHealth.AutoSize = true;
            this.LabelHealth.Location = new System.Drawing.Point(12, 33);
            this.LabelHealth.Name = "LabelHealth";
            this.LabelHealth.Size = new System.Drawing.Size(38, 13);
            this.LabelHealth.TabIndex = 2;
            this.LabelHealth.Text = "Health";
            this.LabelHealth.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabelArmor
            // 
            this.LabelArmor.AutoSize = true;
            this.LabelArmor.Location = new System.Drawing.Point(12, 80);
            this.LabelArmor.Name = "LabelArmor";
            this.LabelArmor.Size = new System.Drawing.Size(34, 13);
            this.LabelArmor.TabIndex = 4;
            this.LabelArmor.Text = "Armor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "^ 3";
            // 
            // BoxOutput
            // 
            this.BoxOutput.Location = new System.Drawing.Point(12, 228);
            this.BoxOutput.Name = "BoxOutput";
            this.BoxOutput.ReadOnly = true;
            this.BoxOutput.Size = new System.Drawing.Size(126, 20);
            this.BoxOutput.TabIndex = 6;
            // 
            // OutputToughness
            // 
            this.OutputToughness.AutoSize = true;
            this.OutputToughness.Location = new System.Drawing.Point(9, 212);
            this.OutputToughness.Name = "OutputToughness";
            this.OutputToughness.Size = new System.Drawing.Size(60, 13);
            this.OutputToughness.TabIndex = 7;
            this.OutputToughness.Text = "Toughness";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 133);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(222, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(223, 365);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "\'Points\'";
            // 
            // OutputPoints
            // 
            this.OutputPoints.Location = new System.Drawing.Point(12, 184);
            this.OutputPoints.Name = "OutputPoints";
            this.OutputPoints.ReadOnly = true;
            this.OutputPoints.Size = new System.Drawing.Size(126, 20);
            this.OutputPoints.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Assistance Table";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputPoints);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.OutputToughness);
            this.Controls.Add(this.BoxOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelArmor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelHealth);
            this.Controls.Add(this.InputArmor);
            this.Controls.Add(this.InputHealth);
            this.Name = "Form1";
            this.Text = "Toughness Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputHealth;
        private System.Windows.Forms.TextBox InputArmor;
        private System.Windows.Forms.Label LabelHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelArmor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxOutput;
        private System.Windows.Forms.Label OutputToughness;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutputPoints;
        private System.Windows.Forms.Label label4;
    }
}

