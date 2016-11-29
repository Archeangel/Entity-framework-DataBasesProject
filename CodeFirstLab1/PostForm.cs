using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstLab1
{
    public partial class PostForm : Form
    {
        private int _blogId;
        private BlogContext _bc;

        public PostForm(BlogContext bc)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this._bc = bc;
        }

        private void cancelAddingNewPostButton_Click(object sender, EventArgs e)
        {
            PostForm.ActiveForm.Close();
        }

        private void confirmAddingNewPostButton_Click(object sender, EventArgs e)
        {
            using (BlogContext context = new BlogContext())
            {
                _blogId = (from b in context.Blogs
                           where b.Name == chooseBlogComboBox.SelectedItem.ToString()
                           select b.BlogId).FirstOrDefault();
            }

            Post post = new Post()
            {
                BlogId = _blogId,
                Desc = descriptionOfNewPostTextBox.Text,
                Title = titleOfNewPostTextBox.Text
            };

            _bc.Posts.Add(post);

            _bc.SaveChanges();

            PostForm.ActiveForm.Close();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            chooseBlogComboBox.Items.Add("Choose a blog...");
            chooseBlogComboBox.SelectedItem = chooseBlogComboBox.Items[0];

            using (BlogContext context = new BlogContext())
            {
                var blogs = from b in context.Blogs
                            orderby b.Name
                            select b.Name;

                foreach (var item in blogs)
                {
                    chooseBlogComboBox.Items.Add(item);
                }

            }
        }

        private void chooseBlogComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
