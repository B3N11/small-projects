
namespace flashCards
{
    partial class Form2
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
            this.ok_button = new System.Windows.Forms.Button();
            this.other_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(12, 286);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(320, 23);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // other_textBox
            // 
            this.other_textBox.Location = new System.Drawing.Point(12, 8);
            this.other_textBox.Multiline = true;
            this.other_textBox.Name = "other_textBox";
            this.other_textBox.ReadOnly = true;
            this.other_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.other_textBox.Size = new System.Drawing.Size(320, 272);
            this.other_textBox.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.other_textBox);
            this.Controls.Add(this.ok_button);
            this.MaximumSize = new System.Drawing.Size(360, 360);
            this.MinimumSize = new System.Drawing.Size(360, 360);
            this.Name = "Form2";
            this.Text = "Other Card Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox other_textBox;
    }
}