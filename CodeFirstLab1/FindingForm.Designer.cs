namespace CodeFirstLab1
{
    partial class FindingForm
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
            this.titleOfFindingFormLabel = new System.Windows.Forms.Label();
            this.foundedPostDataGridView = new System.Windows.Forms.DataGridView();
            this.nameOfSearchedBlogTextBox = new System.Windows.Forms.TextBox();
            this.nameOfSearchedBlogLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelFindingButton = new System.Windows.Forms.Button();
            this.foundBlogNameLabel = new System.Windows.Forms.Label();
            this.foundBlogNameContainLabel = new System.Windows.Forms.Label();
            this.foundBlogUrlLabel = new System.Windows.Forms.Label();
            this.foundBlogUrlContainLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foundedPostDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleOfFindingFormLabel
            // 
            this.titleOfFindingFormLabel.AutoSize = true;
            this.titleOfFindingFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleOfFindingFormLabel.Location = new System.Drawing.Point(118, 23);
            this.titleOfFindingFormLabel.Name = "titleOfFindingFormLabel";
            this.titleOfFindingFormLabel.Size = new System.Drawing.Size(124, 24);
            this.titleOfFindingFormLabel.TabIndex = 0;
            this.titleOfFindingFormLabel.Text = "Znajdź bloga:";
            // 
            // foundedPostDataGridView
            // 
            this.foundedPostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foundedPostDataGridView.Location = new System.Drawing.Point(12, 155);
            this.foundedPostDataGridView.Name = "foundedPostDataGridView";
            this.foundedPostDataGridView.Size = new System.Drawing.Size(358, 150);
            this.foundedPostDataGridView.TabIndex = 1;
            // 
            // nameOfSearchedBlogTextBox
            // 
            this.nameOfSearchedBlogTextBox.Location = new System.Drawing.Point(167, 77);
            this.nameOfSearchedBlogTextBox.Name = "nameOfSearchedBlogTextBox";
            this.nameOfSearchedBlogTextBox.Size = new System.Drawing.Size(132, 20);
            this.nameOfSearchedBlogTextBox.TabIndex = 2;
            // 
            // nameOfSearchedBlogLabel
            // 
            this.nameOfSearchedBlogLabel.AutoSize = true;
            this.nameOfSearchedBlogLabel.Location = new System.Drawing.Point(86, 80);
            this.nameOfSearchedBlogLabel.Name = "nameOfSearchedBlogLabel";
            this.nameOfSearchedBlogLabel.Size = new System.Drawing.Size(75, 13);
            this.nameOfSearchedBlogLabel.TabIndex = 3;
            this.nameOfSearchedBlogLabel.Text = "Nazwa bloga: ";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(224, 103);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelFindingButton
            // 
            this.cancelFindingButton.Location = new System.Drawing.Point(295, 311);
            this.cancelFindingButton.Name = "cancelFindingButton";
            this.cancelFindingButton.Size = new System.Drawing.Size(75, 23);
            this.cancelFindingButton.TabIndex = 5;
            this.cancelFindingButton.Text = "Anuluj";
            this.cancelFindingButton.UseVisualStyleBackColor = true;
            this.cancelFindingButton.Click += new System.EventHandler(this.cancelFindingButton_Click);
            // 
            // foundBlogNameLabel
            // 
            this.foundBlogNameLabel.AutoSize = true;
            this.foundBlogNameLabel.Location = new System.Drawing.Point(13, 136);
            this.foundBlogNameLabel.Name = "foundBlogNameLabel";
            this.foundBlogNameLabel.Size = new System.Drawing.Size(75, 13);
            this.foundBlogNameLabel.TabIndex = 6;
            this.foundBlogNameLabel.Text = "Nazwa bloga: ";
            // 
            // foundBlogNameContainLabel
            // 
            this.foundBlogNameContainLabel.AutoSize = true;
            this.foundBlogNameContainLabel.Location = new System.Drawing.Point(94, 136);
            this.foundBlogNameContainLabel.Name = "foundBlogNameContainLabel";
            this.foundBlogNameContainLabel.Size = new System.Drawing.Size(10, 13);
            this.foundBlogNameContainLabel.TabIndex = 7;
            this.foundBlogNameContainLabel.Text = "-";
            // 
            // foundBlogUrlLabel
            // 
            this.foundBlogUrlLabel.AutoSize = true;
            this.foundBlogUrlLabel.Location = new System.Drawing.Point(212, 136);
            this.foundBlogUrlLabel.Name = "foundBlogUrlLabel";
            this.foundBlogUrlLabel.Size = new System.Drawing.Size(69, 13);
            this.foundBlogUrlLabel.TabIndex = 8;
            this.foundBlogUrlLabel.Text = "Adres bloga: ";
            // 
            // foundBlogUrlContainLabel
            // 
            this.foundBlogUrlContainLabel.AutoSize = true;
            this.foundBlogUrlContainLabel.Location = new System.Drawing.Point(293, 136);
            this.foundBlogUrlContainLabel.Name = "foundBlogUrlContainLabel";
            this.foundBlogUrlContainLabel.Size = new System.Drawing.Size(10, 13);
            this.foundBlogUrlContainLabel.TabIndex = 9;
            this.foundBlogUrlContainLabel.Text = "-";
            // 
            // FindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 342);
            this.Controls.Add(this.foundBlogUrlContainLabel);
            this.Controls.Add(this.foundBlogUrlLabel);
            this.Controls.Add(this.foundBlogNameContainLabel);
            this.Controls.Add(this.foundBlogNameLabel);
            this.Controls.Add(this.cancelFindingButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nameOfSearchedBlogLabel);
            this.Controls.Add(this.nameOfSearchedBlogTextBox);
            this.Controls.Add(this.foundedPostDataGridView);
            this.Controls.Add(this.titleOfFindingFormLabel);
            this.Name = "FindingForm";
            this.Text = "Wyszukiwarka blogów";
            ((System.ComponentModel.ISupportInitialize)(this.foundedPostDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleOfFindingFormLabel;
        private System.Windows.Forms.DataGridView foundedPostDataGridView;
        private System.Windows.Forms.TextBox nameOfSearchedBlogTextBox;
        private System.Windows.Forms.Label nameOfSearchedBlogLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelFindingButton;
        private System.Windows.Forms.Label foundBlogNameLabel;
        private System.Windows.Forms.Label foundBlogNameContainLabel;
        private System.Windows.Forms.Label foundBlogUrlLabel;
        private System.Windows.Forms.Label foundBlogUrlContainLabel;
    }
}