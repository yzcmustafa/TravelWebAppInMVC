using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebAppInMVC.Models.Classes
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string CommentEnd { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }
}