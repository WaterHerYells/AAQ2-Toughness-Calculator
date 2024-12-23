namespace Calculator
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableOfToughnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
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
            this.BoxOutput.Location = new System.Drawing.Point(14, 197);
            this.BoxOutput.Name = "BoxOutput";
            this.BoxOutput.ReadOnly = true;
            this.BoxOutput.Size = new System.Drawing.Size(126, 20);
            this.BoxOutput.TabIndex = 6;
            // 
            // OutputToughness
            // 
            this.OutputToughness.AutoSize = true;
            this.OutputToughness.Location = new System.Drawing.Point(11, 181);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(95, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teToolStripMenuItem,
            this.stToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(181, 70);
            // 
            // teToolStripMenuItem
            // 
            this.teToolStripMenuItem.Name = "teToolStripMenuItem";
            this.teToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teToolStripMenuItem.Text = "Te";
            // 
            // stToolStripMenuItem
            // 
            this.stToolStripMenuItem.Name = "stToolStripMenuItem";
            this.stToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stToolStripMenuItem.Text = "st";
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableOfToughnessToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(177, 26);
            // 
            // tableOfToughnessToolStripMenuItem
            // 
            this.tableOfToughnessToolStripMenuItem.Name = "tableOfToughnessToolStripMenuItem";
            this.tableOfToughnessToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tableOfToughnessToolStripMenuItem.Text = "Table Of Toughness";
            this.tableOfToughnessToolStripMenuItem.Click += new System.EventHandler(this.tableOfToughnessToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(224, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(223, 414);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem teToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem tableOfToughnessToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

