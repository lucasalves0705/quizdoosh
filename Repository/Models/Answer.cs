using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Answer
    {
        public int Id { get; set; }
        public int? Quiz { get; set; }
        public string Title { get; set; }
    }
}
