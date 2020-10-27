using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Post")]
    public class Post
    {
        [Column("ID")]
        public int ID { get; set; }
        [Column("CategoryID")]
        public int CategoryID { get; set; }
        [Column("PublicationDate")]
        public DateTime PublicationDate { get; set; }
        [Column("Content")]
        public string Content { get; set; }
        
        public virtual Category Category { get; set; }
    }
}
