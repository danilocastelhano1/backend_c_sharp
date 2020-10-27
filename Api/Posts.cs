using System;

namespace Api
{
    public class Posts
    {
        public int ID { get; set; }

        public int CategoryID { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Content { get; set; }
    }
}
