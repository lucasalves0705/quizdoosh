using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDoosh.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public int User { get; set; }
        public string Title { get; set; }

        //Construtores
        public Quiz(int id, int user, string title)
        {
            Id = id;
            User = user;
            Title = title;
        }

        public Quiz()
        {
        }
    }
}
