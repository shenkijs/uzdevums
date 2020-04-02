using System.Collections.Generic;

namespace quiz.Models
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; } = new List<string>();

        public int CorrectAnswerIndex { get; set; }

        public int? GivenAnswerIndex { get; set; }
    }
}