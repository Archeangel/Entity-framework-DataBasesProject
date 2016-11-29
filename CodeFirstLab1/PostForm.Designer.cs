namespace CodeFirstLab1
{
    partial class PostForm
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
            this.titleOfNewPostTextBox = new System.Windows.Forms.TextBox();
            this.descriptionOfNewPostTextBox = new System.Windows.Forms.TextBox();
            this.titlePostLabel = new System.Windows.Forms.Label();
            this.descriptionPostLabel = new System.Windows.Forms.Label();
            this.postLabel = new System.Windows.Forms.Label();
            this.confirmAddingNewPostButton = new System.Windows.Forms.Button();
            this.cancelAddingNewPostButton = new System.Windows.Forms.Button();
            this.chooseBlogLabel = new System.Windows.Forms.Label();
            this.chooseBlogComboBox = new System.Windows.Forms.ComboBox();
            this.blogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleOfNewPostTextBox
            // 
            this.titleOfNewPostTextBox.Location = new System.Drawing.Point(103, 89);
            this.titleOfNewPostTextBox.Name = "titleOfNewPostTextBox";
            this.titleOfNewPostTextBox.Size = new System.Drawing.Size(168, 20);
            this.titleOfNewPostTextBox.TabIndex = 0;
            // 
            // descriptionOfNewPostTextBox
            // 
            this.descriptionOfNewPostTextBox.Location = new System.Drawing.Point(103, 131);
            this.descriptionOfNewPostTextBox.Multiline = true;
            this.descriptionOfNewPostTextBox.Name = "descriptionOfNewPostTextBox";
            this.descriptionOfNewPostTextBox.Size = new System.Drawing.Size(168, 100);
            this.descriptionOfNewPostTextBox.TabIndex = 1;
            // 
            // titlePostLabel
            // 
            this.titlePostLabel.AutoSize = true;
            this.titlePostLabel.Location = new System.Drawing.Point(31, 89);
            this.titlePostLabel.Name = "titlePostLabel";
            this.titlePostLabel.Size = new System.Drawing.Size(33, 13);
            this.titlePostLabel.TabIndex = 2;
            this.titlePostLabel.Text = "Title: ";
            // 
            // descriptionPostLabel
            // 
            this.descriptionPostLabel.AutoSize = true;
            this.descriptionPostLabel.Location = new System.Drawing.Point(31, 131);
            this.descriptionPostLabel.Name = "descriptionPostLabel";
            this.descriptionPostLabel.Size = new System.Drawing.Size(66, 13);
            this.descriptionPostLabel.TabIndex = 3;
            this.descriptionPostLabel.Text = "Description: ";
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postLabel.Location = new System.Drawing.Point(55, 9);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(183, 24);
            this.postLabel.TabIndex = 4;
            this.postLabel.Text = "Dodaj nowego posta";
            // 
            // confirmAddingNewPostButton
            // 
            this.confirmAddingNewPostButton.Location = new System.Drawing.Point(176, 237);
            this.confirmAddingNewPostButton.Name = "confirmAddingNewPostButton";
            this.confirmAddingNewPostButton.Size = new System.Drawing.Size(95, 23);
            this.confirmAddingNewPostButton.TabIndex = 5;
            this.confirmAddingNewPostButton.Text = "Zapisz!";
            this.confirmAddingNewPostButton.UseVisualStyleBackColor = true;
            this.confirmAddingNewPostButton.Click += new System.EventHandler(this.confirmAddingNewPostButton_Click);
            // 
            // cancelAddingNewPostButton
            // 
            this.cancelAddingNewPostButton.Location = new System.Drawing.Point(103, 237);
            this.cancelAddingNewPostButton.Name = "cancelAddingNewPostButton";
            this.cancelAddingNewPostButton.Size = new System.Drawing.Size(66, 23);
            this.cancelAddingNewPostButton.TabIndex = 6;
            this.cancelAddingNewPostButton.Text = "Anuluj";
            this.cancelAddingNewPostButton.UseVisualStyleBackColor = true;
            this.cancelAddingNewPostButton.Click += new System.EventHandler(this.cancelAddingNewPostButton_Click);
            // 
            // chooseBlogLabel
            // 
            this.chooseBlogLabel.AutoSize = true;
            this.chooseBlogLabel.Location = new System.Drawing.Point(34, 56);
            this.chooseBlogLabel.Name = "chooseBlogLabel";
            this.chooseBlogLabel.Size = new System.Drawing.Size(31, 13);
            this.chooseBlogLabel.TabIndex = 8;
            this.chooseBlogLabel.Text = "Blog:";
            // 
            // chooseBlogComboBox
            // 
            this.chooseBlogComboBox.FormattingEnabled = true;
            this.chooseBlogComboBox.Location = new System.Drawing.Point(103, 56);
            this.chooseBlogComboBox.Name = "chooseBlogComboBox";
            this.chooseBlogComboBox.Size = new System.Drawing.Size(168, 21);
            this.chooseBlogComboBox.TabIndex = 9;
            this.chooseBlogComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseBlogComboBox_SelectedIndexChanged);
            // 
            // blogBindingSource
            // 
            this.blogBindingSource.DataSource = typeof(CodeFirstLab1.Blog);
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 272);
            this.Controls.Add(this.chooseBlogComboBox);
            this.Controls.Add(this.chooseBlogLabel);
            this.Controls.Add(this.cancelAddingNewPostButton);
            this.Controls.Add(this.confirmAddingNewPostButton);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.descriptionPostLabel);
            this.Controls.Add(this.titlePostLabel);
            this.Controls.Add(this.descriptionOfNewPostTextBox);
            this.Controls.Add(this.titleOfNewPostTextBox);
            this.Name = "PostForm";
            this.Text = "Formularz dodawania posta";
            this.Load += new System.EventHandler(this.PostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleOfNewPostTextBox;
        private System.Windows.Forms.TextBox descriptionOfNewPostTextBox;
        private System.Windows.Forms.Label titlePostLabel;
        private System.Windows.Forms.Label descriptionPostLabel;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Button confirmAddingNewPostButton;
        private System.Windows.Forms.Button cancelAddingNewPostButton;
        private System.Windows.Forms.Label chooseBlogLabel;
        private System.Windows.Forms.ComboBox chooseBlogComboBox;
        private System.Windows.Forms.BindingSource blogBindingSource;
    }
}