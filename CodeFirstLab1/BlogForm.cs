using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Diagnostics;

namespace CodeFirstLab1
{
    public partial class BlogForm : Form
    {

        int blogId = 0;

        private BlogContext bc = new BlogContext();

        public BlogForm()
        {
            InitializeComponent();

        }

        private void BlogForm_Load(object sender, EventArgs e)
        {

            bc.Blogs.Load();
            bc.Posts.Load();

            this.blogBindingSource.DataSource = bc.Blogs.Local.ToBindingList();

        }

        private void blogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bc.SaveChanges();
        }

        private void blogDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bc.Database.Log = message => Trace.WriteLine(message);

            foreach (DataGridViewRow row in blogDataGridView.SelectedRows)
            {
                blogId = Int32.Parse(row.Cells[0].Value.ToString());
            }

            BindingList<Post> posts = bc.Posts.Local.ToBindingList();

            Console.WriteLine(blogId);

            IEnumerable<Post> postsEnumerable = posts.Where(p => p.BlogId == blogId);

            this.postBindingSource.DataSource = postsEnumerable;

            amountOfPostsLabel.Text = postsEnumerable.Count().ToString();

            
        }

        private void addNewPostButton_Click(object sender, EventArgs e)
        {
            PostForm pf = new PostForm(bc);

            pf.ShowDialog();
        }

        private void findBlogButton_Click(object sender, EventArgs e)
        {
            FindingForm ff = new FindingForm(bc);

            ff.ShowDialog();
        }

        private void startReadingBlogButton_Click(object sender, EventArgs e)
        {
            ReadingBlogForm rbf = new ReadingBlogForm(blogId);

            rbf.ShowDialog();
        }

        private void postDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void amountOfPostsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
