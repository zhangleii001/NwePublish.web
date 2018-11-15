using System;
using System.Collections.Generic;
using System.Text;

namespace NewPublish.Model.Entity
{
    public class News
    {
        public News()
        {
            this.NewsComment = new HashSet<NewsComment>();
        }
        public int Id { get; set; }
        public int NewClassifyId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Contents { get; set; }
        public DateTime PublishDate { get; set; }
        public string Remark { get; set; }
        public  virtual  NewsClassify NewsClassify { get; set; }
        public ICollection< NewsComment > NewsComment { get; set; }
    }
}
