namespace CodeFirstLab1
{
    partial class ReadingBlogForm
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
            this.nextPostFromBlogButton = new System.Windows.Forms.Button();
            this.prevPostFromBlogButtom = new System.Windows.Forms.Button();
            this.postTitleLabel = new System.Windows.Forms.Label();
            this.titleReadingPostLabel = new System.Windows.Forms.Label();
            this.descriptionReadingBlogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.blogReadingBlogLabel = new System.Windows.Forms.Label();
            this.blogNameReadingBlogLabel = new System.Windows.Forms.Label();
            this.urlReadingBlogLabel = new System.Windows.Forms.Label();
            this.urlBlogReadingBlogLabel = new System.Windows.Forms.Label();
            this.scoreOfTheBlogLabel = new System.Windows.Forms.Label();
            this.scoreOfTheBlogContainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yourScoreOfTheBlogTextBox = new System.Windows.Forms.TextBox();
            this.saveYourScoreOfTheBlogButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.postTitleContainLabel = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextPostFromBlogButton
            // 
            this.nextPostFromBlogButton.Location = new System.Drawing.Point(416, 12);
            this.nextPostFromBlogButton.Name = "nextPostFromBlogButton";
            this.nextPostFromBlogButton.Size = new System.Drawing.Size(75, 23);
            this.nextPostFromBlogButton.TabIndex = 0;
            this.nextPostFromBlogButton.Text = "Następny";
            this.nextPostFromBlogButton.UseVisualStyleBackColor = true;
            this.nextPostFromBlogButton.Visible = false;
            this.nextPostFromBlogButton.Click += new System.EventHandler(this.nextPostFromBlogButton_Click);
            // 
            // prevPostFromBlogButtom
            // 
            this.prevPostFromBlogButtom.Location = new System.Drawing.Point(12, 12);
            this.prevPostFromBlogButtom.Name = "prevPostFromBlogButtom";
            this.prevPostFromBlogButtom.Size = new System.Drawing.Size(75, 23);
            this.prevPostFromBlogButtom.TabIndex = 1;
            this.prevPostFromBlogButtom.Text = "Poprzedni";
            this.prevPostFromBlogButtom.UseVisualStyleBackColor = true;
            this.prevPostFromBlogButtom.Visible = false;
            this.prevPostFromBlogButtom.Click += new System.EventHandler(this.prevPostFromBlogButtom_Click);
            // 
            // postTitleLabel
            // 
            this.postTitleLabel.AutoSize = true;
            this.postTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postTitleLabel.Location = new System.Drawing.Point(164, 9);
            this.postTitleLabel.Name = "postTitleLabel";
            this.postTitleLabel.Size = new System.Drawing.Size(134, 24);
            this.postTitleLabel.TabIndex = 2;
            this.postTitleLabel.Text = "Liczba postów:";
            this.postTitleLabel.Visible = false;
            // 
            // titleReadingPostLabel
            // 
            this.titleReadingPostLabel.AutoSize = true;
            this.titleReadingPostLabel.Font = new System.Drawing.Font("Verdana", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleReadingPostLabel.Location = new System.Drawing.Point(41, 135);
            this.titleReadingPostLabel.Name = "titleReadingPostLabel";
            this.titleReadingPostLabel.Size = new System.Drawing.Size(68, 26);
            this.titleReadingPostLabel.TabIndex = 4;
            this.titleReadingPostLabel.Text = "Title";
            this.titleReadingPostLabel.Visible = false;
            // 
            // descriptionReadingBlogRichTextBox
            // 
            this.descriptionReadingBlogRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionReadingBlogRichTextBox.Location = new System.Drawing.Point(12, 176);
            this.descriptionReadingBlogRichTextBox.Name = "descriptionReadingBlogRichTextBox";
            this.descriptionReadingBlogRichTextBox.ReadOnly = true;
            this.descriptionReadingBlogRichTextBox.Size = new System.Drawing.Size(479, 167);
            this.descriptionReadingBlogRichTextBox.TabIndex = 5;
            this.descriptionReadingBlogRichTextBox.Text = "Description";
            this.descriptionReadingBlogRichTextBox.Visible = false;
            // 
            // blogReadingBlogLabel
            // 
            this.blogReadingBlogLabel.AutoSize = true;
            this.blogReadingBlogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blogReadingBlogLabel.Location = new System.Drawing.Point(34, 54);
            this.blogReadingBlogLabel.Name = "blogReadingBlogLabel";
            this.blogReadingBlogLabel.Size = new System.Drawing.Size(53, 24);
            this.blogReadingBlogLabel.TabIndex = 6;
            this.blogReadingBlogLabel.Text = "Blog:";
            // 
            // blogNameReadingBlogLabel
            // 
            this.blogNameReadingBlogLabel.AutoSize = true;
            this.blogNameReadingBlogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blogNameReadingBlogLabel.Location = new System.Drawing.Point(93, 54);
            this.blogNameReadingBlogLabel.Name = "blogNameReadingBlogLabel";
            this.blogNameReadingBlogLabel.Size = new System.Drawing.Size(119, 24);
            this.blogNameReadingBlogLabel.TabIndex = 7;
            this.blogNameReadingBlogLabel.Text = "Nazwa bloga";
            // 
            // urlReadingBlogLabel
            // 
            this.urlReadingBlogLabel.AutoSize = true;
            this.urlReadingBlogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.urlReadingBlogLabel.Location = new System.Drawing.Point(34, 89);
            this.urlReadingBlogLabel.Name = "urlReadingBlogLabel";
            this.urlReadingBlogLabel.Size = new System.Drawing.Size(38, 24);
            this.urlReadingBlogLabel.TabIndex = 8;
            this.urlReadingBlogLabel.Text = "Url:";
            // 
            // urlBlogReadingBlogLabel
            // 
            this.urlBlogReadingBlogLabel.AutoSize = true;
            this.urlBlogReadingBlogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.urlBlogReadingBlogLabel.Location = new System.Drawing.Point(93, 89);
            this.urlBlogReadingBlogLabel.Name = "urlBlogReadingBlogLabel";
            this.urlBlogReadingBlogLabel.Size = new System.Drawing.Size(112, 24);
            this.urlBlogReadingBlogLabel.TabIndex = 9;
            this.urlBlogReadingBlogLabel.Text = "Adres bloga";
            // 
            // scoreOfTheBlogLabel
            // 
            this.scoreOfTheBlogLabel.AutoSize = true;
            this.scoreOfTheBlogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreOfTheBlogLabel.Location = new System.Drawing.Point(280, 54);
            this.scoreOfTheBlogLabel.Name = "scoreOfTheBlogLabel";
            this.scoreOfTheBlogLabel.Size = new System.Drawing.Size(72, 24);
            this.scoreOfTheBlogLabel.TabIndex = 10;
            this.scoreOfTheBlogLabel.Text = "Ocena:";
            // 
            // scoreOfTheBlogContainLabel
            // 
            this.scoreOfTheBlogContainLabel.AutoSize = true;
            this.scoreOfTheBlogContainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreOfTheBlogContainLabel.Location = new System.Drawing.Point(369, 54);
            this.scoreOfTheBlogContainLabel.Name = "scoreOfTheBlogContainLabel";
            this.scoreOfTheBlogContainLabel.Size = new System.Drawing.Size(86, 24);
            this.scoreOfTheBlogContainLabel.TabIndex = 11;
            this.scoreOfTheBlogContainLabel.Text = "Zagłosuj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(280, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Twoja ocena:";
            // 
            // yourScoreOfTheBlogTextBox
            // 
            this.yourScoreOfTheBlogTextBox.Location = new System.Drawing.Point(410, 89);
            this.yourScoreOfTheBlogTextBox.Name = "yourScoreOfTheBlogTextBox";
            this.yourScoreOfTheBlogTextBox.Size = new System.Drawing.Size(49, 20);
            this.yourScoreOfTheBlogTextBox.TabIndex = 13;
            this.yourScoreOfTheBlogTextBox.Text = "5,0";
            this.yourScoreOfTheBlogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // saveYourScoreOfTheBlogButton
            // 
            this.saveYourScoreOfTheBlogButton.Location = new System.Drawing.Point(373, 116);
            this.saveYourScoreOfTheBlogButton.Name = "saveYourScoreOfTheBlogButton";
            this.saveYourScoreOfTheBlogButton.Size = new System.Drawing.Size(85, 23);
            this.saveYourScoreOfTheBlogButton.TabIndex = 14;
            this.saveYourScoreOfTheBlogButton.Text = ".";
            this.saveYourScoreOfTheBlogButton.UseVisualStyleBackColor = true;
            this.saveYourScoreOfTheBlogButton.Click += new System.EventHandler(this.saveYourScoreOfTheBlogButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(373, 145);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(85, 23);
            this.readButton.TabIndex = 15;
            this.readButton.Text = "Załaduj posty";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // postTitleContainLabel
            // 
            this.postTitleContainLabel.AutoSize = true;
            this.postTitleContainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postTitleContainLabel.Location = new System.Drawing.Point(304, 9);
            this.postTitleContainLabel.Name = "postTitleContainLabel";
            this.postTitleContainLabel.Size = new System.Drawing.Size(20, 24);
            this.postTitleContainLabel.TabIndex = 16;
            this.postTitleContainLabel.Text = "0";
            this.postTitleContainLabel.Visible = false;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(344, 10);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(40, 23);
            this.countButton.TabIndex = 17;
            this.countButton.Text = "Licz!";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Visible = false;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // ReadingBlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 355);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.postTitleContainLabel);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.saveYourScoreOfTheBlogButton);
            this.Controls.Add(this.yourScoreOfTheBlogTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreOfTheBlogContainLabel);
            this.Controls.Add(this.scoreOfTheBlogLabel);
            this.Controls.Add(this.urlBlogReadingBlogLabel);
            this.Controls.Add(this.urlReadingBlogLabel);
            this.Controls.Add(this.blogNameReadingBlogLabel);
            this.Controls.Add(this.blogReadingBlogLabel);
            this.Controls.Add(this.descriptionReadingBlogRichTextBox);
            this.Controls.Add(this.titleReadingPostLabel);
            this.Controls.Add(this.postTitleLabel);
            this.Controls.Add(this.prevPostFromBlogButtom);
            this.Controls.Add(this.nextPostFromBlogButton);
            this.Name = "ReadingBlogForm";
            this.Text = "Zawartość bloga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextPostFromBlogButton;
        private System.Windows.Forms.Button prevPostFromBlogButtom;
        private System.Windows.Forms.Label postTitleLabel;
        private System.Windows.Forms.Label titleReadingPostLabel;
        private System.Windows.Forms.RichTextBox descriptionReadingBlogRichTextBox;
        private System.Windows.Forms.Label blogReadingBlogLabel;
        private System.Windows.Forms.Label blogNameReadingBlogLabel;
        private System.Windows.Forms.Label urlReadingBlogLabel;
        private System.Windows.Forms.Label urlBlogReadingBlogLabel;
        private System.Windows.Forms.Label scoreOfTheBlogLabel;
        private System.Windows.Forms.Label scoreOfTheBlogContainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yourScoreOfTheBlogTextBox;
        private System.Windows.Forms.Button saveYourScoreOfTheBlogButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label postTitleContainLabel;
        private System.Windows.Forms.Button countButton;
    }
}