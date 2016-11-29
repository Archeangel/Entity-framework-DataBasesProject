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
    public partial class ReadingBlogForm : Form
    {
        private BlogContext _bc;
        private int _blogId;
        private Blog blog;
        private IQueryable<Post> posts; 
        private int currentPost = 0;

        public ReadingBlogForm(int blogId)
        {
            InitializeComponent();
            this._blogId = blogId;
            this._bc = new BlogContext();

            _bc.Database.Log = message => Trace.WriteLine(message);

            blog = _bc.Blogs.Where(b => b.BlogId == _blogId).FirstOrDefault();
            if (blog == null)
            {
                MessageBox.Show("Brak takiego bloga.");
                return;
            }
            else
            {
                urlBlogReadingBlogLabel.Text = blog.Url;
                blogNameReadingBlogLabel.Text = blog.Name;
            }
            

        }

        private void nextPostFromBlogButton_Click(object sender, EventArgs e)
        {
            currentPost += 1;
            LoadPost();            
        }

        private void prevPostFromBlogButtom_Click(object sender, EventArgs e)
        {
            currentPost -= 1;
            LoadPost();            
        }

        private void readButton_Click(object sender, EventArgs e)
        {

            readButton.Visible = false;
            postTitleLabel.Visible = true;
            titleReadingPostLabel.Visible = true;
            descriptionReadingBlogRichTextBox.Visible = true;
            nextPostFromBlogButton.Visible = true;
            prevPostFromBlogButtom.Visible = true;
            countButton.Visible = true; 
     
            // Lazy loading:
            // IQueryable wspiera LazyLoading
            _bc.Database.Log = message => Trace.WriteLine(message);

            posts = _bc.Posts.Where(p => p.BlogId == _blogId).OrderBy(p => p.PostId).AsQueryable();
            currentPost = 0;

            descriptionReadingBlogRichTextBox.Text = posts.FirstOrDefault().Desc;
            titleReadingPostLabel.Text = posts.FirstOrDefault().Title;
        }

        private void LoadPost()
        {
            Post post;

            _bc.Database.Log = message => Trace.WriteLine(message);

            if (currentPost < 0 || currentPost >= posts.Count())
            {
                post = null;
                currentPost = 0;
                ReadingBlogForm.ActiveForm.Update();
            }
            else
            {             
                post = posts.Skip(currentPost).Take(1).FirstOrDefault();
            }            

            if (post == null)
            {
                MessageBox.Show("Brak kolejnych postów");
                return;
            }

            descriptionReadingBlogRichTextBox.Text = post.Desc;
            titleReadingPostLabel.Text = post.Title;

        }

        private void saveYourScoreOfTheBlogButton_Click(object sender, EventArgs e)
        {
            blog.Marks += Double.Parse(yourScoreOfTheBlogTextBox.Text);
            blog.AmountOfMarks += 1;
            
            scoreOfTheBlogContainLabel.Text = (blog.Marks / blog.AmountOfMarks).ToString();

            this._bc.SaveChanges();
        }

      
        private void countButton_Click(object sender, EventArgs e)
        {            

            using (BlogContext context = new BlogContext())
            {
                context.Database.Log = message => Trace.WriteLine(message);

                var listOfPosts = (from b in context.Blogs
                                   from p in context.Posts
                                   where b.BlogId == _blogId 
                                      && b.BlogId == p.BlogId
                                   select b.Posts)
                                   .ToList()
                                   .Count();

                postTitleContainLabel.Text = listOfPosts.ToString();
                postTitleContainLabel.Visible = true;
            }

            
        }

    }
}
