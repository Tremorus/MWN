using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MWN.Models
{
    public class Note
    {

        public string Id { get; set; }
        [Display(Name="Author")]
        public string Owner { get; set; }
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        [Display(Name = "Creation date")]
        [DataType(DataType.Date)]
        public DateTime Created { get; set; }
        [DataType(DataType.Date)]
        public DateTime Changed { get; set; }
        public Note()
        {
            Created= Changed = DateTime.Now;
            
        }
    }
}
