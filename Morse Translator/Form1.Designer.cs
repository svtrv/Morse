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
            this.t2mbtn = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.playbtn = new System.Windows.Forms.Button();
            this.wpmTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(13, 42);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(166, 65);
            this.inputTextBox.TabIndex = 3;
            this.inputTextBox.Text = "";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(13, 117);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(166, 65);
            this.outputTextBox.TabIndex = 4;
            this.outputTextBox.Text = "";
            // 
            // playbtn
            // 
            this.playbtn.Location = new System.Drawing.Point(198, 117);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(35, 23);
            this.playbtn.TabIndex = 5;
            this.playbtn.Text = "play";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // wpmTextBox
            // 
            this.wpmTextBox.Location = new System.Drawing.Point(198, 145);
            this.wpmTextBox.Name = "wpmTextBox";
            this.wpmTextBox.Size = new System.Drawing.Size(35, 20);
            this.wpmTextBox.TabIndex = 6;
            this.wpmTextBox.Text = "20";
            this.wpmTextBox.TextChanged += new System.EventHandler(this.wpmTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Words/min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wpmTextBox);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.t2mbtn);
            this.Controls.Add(this.m2tbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m2tbtn;
        private System.Windows.Forms.Button t2mbtn;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.TextBox wpmTextBox;
        private System.Windows.Forms.Label label1;
    }
}

