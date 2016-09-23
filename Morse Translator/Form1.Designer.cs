namespace Morse_Translator
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
            this.m2tbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.t2mbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m2tbtn
            // 
            this.m2tbtn.Location = new System.Drawing.Point(13, 12);
            this.m2tbtn.Name = "m2tbtn";
            this.m2tbtn.Size = new System.Drawing.Size(51, 23);
            this.m2tbtn.TabIndex = 0;
            this.m2tbtn.Text = "M2T";
            this.m2tbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // t2mbtn
            // 
            this.t2mbtn.Enabled = false;
            this.t2mbtn.Location = new System.Drawing.Point(63, 12);
            this.t2mbtn.Name = "t2mbtn";
            this.t2mbtn.Size = new System.Drawing.Size(51, 23);
            this.t2mbtn.TabIndex = 2;
            this.t2mbtn.Text = "T2M";
            this.t2mbtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 98);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.t2mbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.m2tbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m2tbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button t2mbtn;
        private System.Windows.Forms.TextBox textBox2;
    }
}

