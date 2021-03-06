
namespace flashCards
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filePath_textBox = new System.Windows.Forms.TextBox();
            this.readFile_button = new System.Windows.Forms.Button();
            this.separator_textBox = new System.Windows.Forms.TextBox();
            this.deckName_textBox = new System.Windows.Forms.TextBox();
            this.next_button = new System.Windows.Forms.Button();
            this.content_textBox = new System.Windows.Forms.TextBox();
            this.previous_button = new System.Windows.Forms.Button();
            this.flip_button = new System.Windows.Forms.Button();
            this.shuffle_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.open_textBox = new System.Windows.Forms.Button();
            this.other_button = new System.Windows.Forms.Button();
            this.cardCount_textBox = new System.Windows.Forms.TextBox();
            this.decks_comboBox = new System.Windows.Forms.ComboBox();
            this.deleteDeck_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filePath_textBox
            // 
            this.filePath_textBox.Location = new System.Drawing.Point(12, 41);
            this.filePath_textBox.Name = "filePath_textBox";
            this.filePath_textBox.PlaceholderText = "File path";
            this.filePath_textBox.Size = new System.Drawing.Size(212, 23);
            this.filePath_textBox.TabIndex = 0;
            // 
            // readFile_button
            // 
            this.readFile_button.Location = new System.Drawing.Point(12, 70);
            this.readFile_button.Name = "readFile_button";
            this.readFile_button.Size = new System.Drawing.Size(318, 23);
            this.readFile_button.TabIndex = 1;
            this.readFile_button.Text = "Generate flashcards";
            this.readFile_button.UseVisualStyleBackColor = true;
            this.readFile_button.Click += new System.EventHandler(this.readFile_button_Click);
            // 
            // separator_textBox
            // 
            this.separator_textBox.Location = new System.Drawing.Point(232, 12);
            this.separator_textBox.MaxLength = 1;
            this.separator_textBox.Name = "separator_textBox";
            this.separator_textBox.PlaceholderText = "Separator";
            this.separator_textBox.Size = new System.Drawing.Size(98, 23);
            this.separator_textBox.TabIndex = 2;
            // 
            // deckName_textBox
            // 
            this.deckName_textBox.Location = new System.Drawing.Point(12, 12);
            this.deckName_textBox.Name = "deckName_textBox";
            this.deckName_textBox.PlaceholderText = "Name of the new card deck";
            this.deckName_textBox.Size = new System.Drawing.Size(212, 23);
            this.deckName_textBox.TabIndex = 4;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(173, 141);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(157, 23);
            this.next_button.TabIndex = 5;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // content_textBox
            // 
            this.content_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.content_textBox.Location = new System.Drawing.Point(12, 282);
            this.content_textBox.Multiline = true;
            this.content_textBox.Name = "content_textBox";
            this.content_textBox.ReadOnly = true;
            this.content_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.content_textBox.Size = new System.Drawing.Size(318, 261);
            this.content_textBox.TabIndex = 6;
            this.content_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // previous_button
            // 
            this.previous_button.Location = new System.Drawing.Point(12, 141);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(157, 23);
            this.previous_button.TabIndex = 7;
            this.previous_button.Text = "Previous";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // flip_button
            // 
            this.flip_button.Location = new System.Drawing.Point(12, 230);
            this.flip_button.Name = "flip_button";
            this.flip_button.Size = new System.Drawing.Size(318, 46);
            this.flip_button.TabIndex = 8;
            this.flip_button.Text = "Flip";
            this.flip_button.UseVisualStyleBackColor = true;
            this.flip_button.Click += new System.EventHandler(this.flip_button_Click);
            // 
            // shuffle_button
            // 
            this.shuffle_button.Location = new System.Drawing.Point(173, 170);
            this.shuffle_button.Name = "shuffle_button";
            this.shuffle_button.Size = new System.Drawing.Size(157, 23);
            this.shuffle_button.TabIndex = 9;
            this.shuffle_button.Text = "Shuffle";
            this.shuffle_button.UseVisualStyleBackColor = true;
            this.shuffle_button.Click += new System.EventHandler(this.shuffle_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(12, 170);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(157, 23);
            this.reset_button.TabIndex = 10;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // open_textBox
            // 
            this.open_textBox.Location = new System.Drawing.Point(232, 40);
            this.open_textBox.Name = "open_textBox";
            this.open_textBox.Size = new System.Drawing.Size(98, 24);
            this.open_textBox.TabIndex = 11;
            this.open_textBox.Text = "Open";
            this.open_textBox.UseVisualStyleBackColor = true;
            this.open_textBox.Click += new System.EventHandler(this.open_textBox_Click);
            // 
            // other_button
            // 
            this.other_button.Location = new System.Drawing.Point(12, 199);
            this.other_button.Name = "other_button";
            this.other_button.Size = new System.Drawing.Size(318, 25);
            this.other_button.TabIndex = 12;
            this.other_button.Text = "Show other";
            this.other_button.UseVisualStyleBackColor = true;
            this.other_button.Click += new System.EventHandler(this.other_button_Click);
            // 
            // cardCount_textBox
            // 
            this.cardCount_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardCount_textBox.Enabled = false;
            this.cardCount_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardCount_textBox.Location = new System.Drawing.Point(12, 545);
            this.cardCount_textBox.Name = "cardCount_textBox";
            this.cardCount_textBox.ReadOnly = true;
            this.cardCount_textBox.Size = new System.Drawing.Size(318, 22);
            this.cardCount_textBox.TabIndex = 13;
            this.cardCount_textBox.Text = "0 / 0";
            this.cardCount_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // decks_comboBox
            // 
            this.decks_comboBox.FormattingEnabled = true;
            this.decks_comboBox.Location = new System.Drawing.Point(12, 107);
            this.decks_comboBox.Name = "decks_comboBox";
            this.decks_comboBox.Size = new System.Drawing.Size(212, 23);
            this.decks_comboBox.TabIndex = 14;
            // 
            // deleteDeck_button
            // 
            this.deleteDeck_button.Location = new System.Drawing.Point(232, 107);
            this.deleteDeck_button.Name = "deleteDeck_button";
            this.deleteDeck_button.Size = new System.Drawing.Size(98, 23);
            this.deleteDeck_button.TabIndex = 15;
            this.deleteDeck_button.Text = "Delete";
            this.deleteDeck_button.UseVisualStyleBackColor = true;
            this.deleteDeck_button.Click += new System.EventHandler(this.deleteDeck_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 580);
            this.Controls.Add(this.deleteDeck_button);
            this.Controls.Add(this.decks_comboBox);
            this.Controls.Add(this.cardCount_textBox);
            this.Controls.Add(this.other_button);
            this.Controls.Add(this.open_textBox);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.shuffle_button);
            this.Controls.Add(this.flip_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.content_textBox);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.deckName_textBox);
            this.Controls.Add(this.separator_textBox);
            this.Controls.Add(this.readFile_button);
            this.Controls.Add(this.filePath_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 619);
            this.MinimumSize = new System.Drawing.Size(360, 619);
            this.Name = "Form1";
            this.Text = "FlashCards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath_textBox;
        private System.Windows.Forms.Button readFile_button;
        private System.Windows.Forms.TextBox separator_textBox;
        private System.Windows.Forms.TextBox deckName_textBox;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.TextBox content_textBox;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button flip_button;
        private System.Windows.Forms.Button shuffle_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button open_textBox;
        private System.Windows.Forms.Button other_button;
        private System.Windows.Forms.TextBox cardCount_textBox;
        private System.Windows.Forms.ComboBox decks_comboBox;
        private System.Windows.Forms.Button deleteDeck_button;
    }
}

