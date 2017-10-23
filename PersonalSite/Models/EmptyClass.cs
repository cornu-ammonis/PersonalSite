using System;
namespace PersonalSite.Models
{
    public class Post
    {
        public Post()
        {
        }

        public int PostId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Body
        {
            get;
            set;
        }

        public string UrlSlug
        {
            get;
            set;
        }

        public DateTime PostedOn
        {
            get;
            set;
        }


    }
}
