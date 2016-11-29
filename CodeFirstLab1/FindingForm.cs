using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstLab1
{
    public partial class FindingForm : Form
    {
        private BlogContext _bc;

        public FindingForm(BlogContext bc)
        {
            InitializeComponent();
            this._bc = bc;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _bc.Database.Log = message => Trace.WriteLine(message); // obserwowanie generowanego kodu SQL i momentu jego wykonania

            Blog blog = _bc.Blogs
                .Include("Posts")
                .Where(b => b.Name == nameOfSearchedBlogTextBox.Text.ToString())
                .FirstOrDefault<Blog>(); // Include() - Eager Loading

            if (blog == null)
            {
                MessageBox.Show("404 - Blog not found");
                return;
            }

            foundedPostDataGridView.DataSource = blog.Posts;
            foundBlogNameContainLabel.Text = nameOfSearchedBlogTextBox.Text;
            foundBlogUrlContainLabel.Text = blog.Url.ToString();

        }

        private void cancelFindingButton_Click(object sender, EventArgs e)
        {
            FindingForm.ActiveForm.Close();
        }
    }
}
