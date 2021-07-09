using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Quiz
    {
        public int Id { get; set; }
        public int User { get; set; }
        public string Title { get; set; }
    }
}
