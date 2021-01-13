using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using SQLite;


namespace Test1.Models
{
    [Table("Post")]
    public class Post
    {
        //Default
        public Post()
        {
        }

        /// <summary>
        /// Creates a Post Object
        /// </summary>
        /// <param name="title">Its a Title</param>
        /// <param name="content">The actual message</param>
        /// <param name="onClick">The function that happens onClick; 0 if none </param>
        /// <param name="webLink">The link that should open when click; 0 if none</param>
        /// <param name="backgroundColor">A hex color</param>
        /// <param name="slideShow">Gallery of images to show if specific onClick is chosen -> should be removed if onClick is changed to an object</param>
        /// <param name="posterName">Name of person that created the post</param>
        /// <param name="fontColor">Color of font for post</param>
        /// <param name="archived">Lets the application know if it should the post</param>
        /// <param name="postID">Used to identify post</param>
        public Post(int postId, string title, string content, string onClick, string webLink, string posterName = "Church", bool archived = false, bool edited = false, string backgroundColor = "779999", string backgroundImage = "", string fontColor = "000000", string slideShow = "")
        {
            this.postId = postId;
            this.title = title;
            this.content = content;
            this.onClick = onClick;
            this.webLink = webLink;
            this.backgroundColor = backgroundColor;
            this.backgroundImage = backgroundImage;
            this.posterName = posterName;
            this.archived = archived;
            this.edited = edited;
            this.slideShow = slideShow;
            this.OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://includefaith.org/"));
        }

        [PrimaryKey, AutoIncrement]
        public int postId { get; }
        public string title { get; set; }
        public string content { get; set; }
        public string onClick { get; set; }
        public string webLink { get; set; }
        public string backgroundColor { get; set; }
        public string backgroundImage { get; set; }
        public string posterName { get; set; }
        public bool archived { get; set; }
        public bool edited { get; set; }
        public string slideShow { get; set; }

        public ICommand OpenWebCommand { get; set; }
    }
}
