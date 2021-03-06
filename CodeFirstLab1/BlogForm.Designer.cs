﻿namespace CodeFirstLab1
{
    partial class BlogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlogForm));
            this.blogBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.blogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.blogBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.blogDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridView = new System.Windows.Forms.DataGridView();
            this.postIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountOfPostsLabel = new System.Windows.Forms.Label();
            this.addNewPostButton = new System.Windows.Forms.Button();
            this.findBlogButton = new System.Windows.Forms.Button();
            this.startReadingBlogButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingNavigator)).BeginInit();
            this.blogBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // blogBindingNavigator
            // 
            this.blogBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.blogBindingNavigator.BindingSource = this.blogBindingSource;
            this.blogBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.blogBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.blogBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.blogBindingNavigatorSaveItem});
            this.blogBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.blogBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.blogBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.blogBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.blogBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.blogBindingNavigator.Name = "blogBindingNavigator";
            this.blogBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.blogBindingNavigator.Size = new System.Drawing.Size(1009, 25);
            this.blogBindingNavigator.TabIndex = 0;
            this.blogBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // blogBindingSource
            // 
            this.blogBindingSource.DataSource = typeof(CodeFirstLab1.Blog);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // blogBindingNavigatorSaveItem
            // 
            this.blogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blogBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("blogBindingNavigatorSaveItem.Image")));
            this.blogBindingNavigatorSaveItem.Name = "blogBindingNavigatorSaveItem";
            this.blogBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.blogBindingNavigatorSaveItem.Text = "Save Data";
            this.blogBindingNavigatorSaveItem.Click += new System.EventHandler(this.blogBindingNavigatorSaveItem_Click);
            // 
            // blogDataGridView
            // 
            this.blogDataGridView.AutoGenerateColumns = false;
            this.blogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.blogDataGridView.DataSource = this.blogBindingSource;
            this.blogDataGridView.Location = new System.Drawing.Point(12, 28);
            this.blogDataGridView.Name = "blogDataGridView";
            this.blogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.blogDataGridView.Size = new System.Drawing.Size(408, 277);
            this.blogDataGridView.TabIndex = 1;
            this.blogDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.blogDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BlogId";
            this.dataGridViewTextBoxColumn1.HeaderText = "BlogId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Url";
            this.dataGridViewTextBoxColumn3.HeaderText = "Url";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // postDataGridView
            // 
            this.postDataGridView.AutoGenerateColumns = false;
            this.postDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn,
            this.blogIdDataGridViewTextBoxColumn});
            this.postDataGridView.DataSource = this.postBindingSource;
            this.postDataGridView.Location = new System.Drawing.Point(520, 28);
            this.postDataGridView.Name = "postDataGridView";
            this.postDataGridView.Size = new System.Drawing.Size(444, 187);
            this.postDataGridView.TabIndex = 2;
            this.postDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.postDataGridView_CellContentClick);
            // 
            // postIdDataGridViewTextBoxColumn
            // 
            this.postIdDataGridViewTextBoxColumn.DataPropertyName = "PostId";
            this.postIdDataGridViewTextBoxColumn.HeaderText = "PostId";
            this.postIdDataGridViewTextBoxColumn.Name = "postIdDataGridViewTextBoxColumn";
            this.postIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.postIdDataGridViewTextBoxColumn.Visible = false;
            this.postIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "Desc";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            this.descDataGridViewTextBoxColumn.Width = 250;
            // 
            // blogIdDataGridViewTextBoxColumn
            // 
            this.blogIdDataGridViewTextBoxColumn.DataPropertyName = "BlogId";
            this.blogIdDataGridViewTextBoxColumn.HeaderText = "BlogId";
            this.blogIdDataGridViewTextBoxColumn.Name = "blogIdDataGridViewTextBoxColumn";
            this.blogIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.blogIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(CodeFirstLab1.Post);
            // 
            // amountOfPostsLabel
            // 
            this.amountOfPostsLabel.AutoSize = true;
            this.amountOfPostsLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.amountOfPostsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amountOfPostsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amountOfPostsLabel.Location = new System.Drawing.Point(946, 228);
            this.amountOfPostsLabel.Name = "amountOfPostsLabel";
            this.amountOfPostsLabel.Size = new System.Drawing.Size(18, 19);
            this.amountOfPostsLabel.TabIndex = 3;
            this.amountOfPostsLabel.Text = "0";
            this.amountOfPostsLabel.Click += new System.EventHandler(this.amountOfPostsLabel_Click);
            // 
            // addNewPostButton
            // 
            this.addNewPostButton.Location = new System.Drawing.Point(520, 224);
            this.addNewPostButton.Name = "addNewPostButton";
            this.addNewPostButton.Size = new System.Drawing.Size(75, 23);
            this.addNewPostButton.TabIndex = 4;
            this.addNewPostButton.Text = "Dodaj posta";
            this.addNewPostButton.UseVisualStyleBackColor = true;
            this.addNewPostButton.Click += new System.EventHandler(this.addNewPostButton_Click);
            // 
            // findBlogButton
            // 
            this.findBlogButton.Location = new System.Drawing.Point(333, 311);
            this.findBlogButton.Name = "findBlogButton";
            this.findBlogButton.Size = new System.Drawing.Size(87, 23);
            this.findBlogButton.TabIndex = 5;
            this.findBlogButton.Text = "Szukaj bloga...";
            this.findBlogButton.UseVisualStyleBackColor = true;
            this.findBlogButton.Click += new System.EventHandler(this.findBlogButton_Click);
            // 
            // startReadingBlogButton
            // 
            this.startReadingBlogButton.Location = new System.Drawing.Point(233, 310);
            this.startReadingBlogButton.Name = "startReadingBlogButton";
            this.startReadingBlogButton.Size = new System.Drawing.Size(88, 23);
            this.startReadingBlogButton.TabIndex = 6;
            this.startReadingBlogButton.Text = "Czytaj blog...";
            this.startReadingBlogButton.UseVisualStyleBackColor = true;
            this.startReadingBlogButton.Click += new System.EventHandler(this.startReadingBlogButton_Click);
            // 
            // BlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 390);
            this.Controls.Add(this.startReadingBlogButton);
            this.Controls.Add(this.findBlogButton);
            this.Controls.Add(this.addNewPostButton);
            this.Controls.Add(this.amountOfPostsLabel);
            this.Controls.Add(this.postDataGridView);
            this.Controls.Add(this.blogDataGridView);
            this.Controls.Add(this.blogBindingNavigator);
            this.Name = "BlogForm";
            this.Text = "Aplikacja do zarządzania Blogami";
            this.Load += new System.EventHandler(this.BlogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingNavigator)).EndInit();
            this.blogBindingNavigator.ResumeLayout(false);
            this.blogBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource blogBindingSource;
        private System.Windows.Forms.BindingNavigator blogBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton blogBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView blogDataGridView;
        private System.Windows.Forms.DataGridView postDataGridView;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Label amountOfPostsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blogIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addNewPostButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button findBlogButton;
        private System.Windows.Forms.Button startReadingBlogButton;
    }
}