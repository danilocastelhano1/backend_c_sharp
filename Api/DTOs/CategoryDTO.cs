using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        //public DateTime PublicationDate { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}
