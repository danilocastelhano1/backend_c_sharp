using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    [Table("Category")]
    public class Category
    {
        [Column("ID")]
        public int ID { get; set; }
        [Column("Title")]
        public string Title { get; set; }
    }
}
