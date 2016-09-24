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
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.playbtn = new System.Windows.Forms.Button();
            this.wpmTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.copybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.ForeColor = System.Drawing.Color.Gray;
            this.inputTextBox.Location = new System.Drawing.Point(7, 5);
            this.inputTextBox.Multiline = false;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(355, 65);
            this.inputTextBox.TabIndex = 3;
            this.inputTextBox.Text = "Enter text here...";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.inputTextBox.Enter += new System.EventHandler(this.inputTextBox_Enter);
            this.inputTextBox.Leave += new System.EventHandler(this.inputTextBox_Leave);
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.ForeColor = System.Drawing.Color.Gray;
            this.outputTextBox.Location = new System.Drawing.Point(7, 80);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(252, 65);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "";
            // 
            // playbtn
            // 
            this.playbtn.Location = new System.Drawing.Point(277, 80);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(35, 23);
            this.playbtn.TabIndex = 5;
            this.playbtn.Text = "play";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // wpmTextBox
            // 
            this.wpmTextBox.Location = new System.Drawing.Point(277, 108);
            this.wpmTextBox.Name = "wpmTextBox";
            this.wpmTextBox.Size = new System.Drawing.Size(35, 20);
            this.wpmTextBox.TabIndex = 6;
            this.wpmTextBox.Text = "20";
            this.wpmTextBox.TextChanged += new System.EventHandler(this.wpmTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Words/min";
            // 
            // copybtn
            // 
            this.copybtn.Location = new System.Drawing.Point(318, 80);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(44, 23);
            this.copybtn.TabIndex = 8;
            this.copybtn.Text = "copy";
            this.copybtn.UseVisualStyleBackColor = true;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(369, 156);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wpmTextBox);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 195);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(385, 195);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text to morse translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.TextBox wpmTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copybtn;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
    }
}

