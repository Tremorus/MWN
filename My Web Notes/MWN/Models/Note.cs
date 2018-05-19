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
        public string Owner { get; set; }
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Changed { get; set; }
        public Note()
        {
            Created= Changed = DateTime.Now;
            
        }
    }
}
