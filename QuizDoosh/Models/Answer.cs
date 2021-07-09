using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDoosh.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int? Quiz { get; set; }
        public string Title { get; set; }

        //Construtores
        public Answer(int id, int? quiz, string title)
        {
            Id = id;
            Quiz = quiz;
            Title = title;
        }

        public Answer()
        {
        }
    }
}
