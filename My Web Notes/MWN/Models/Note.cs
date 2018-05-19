﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWN.Models
{
    public class Note
    {
        public string Id { get; set; }
        public string Owner { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Changed { get; set; }
    }
}
