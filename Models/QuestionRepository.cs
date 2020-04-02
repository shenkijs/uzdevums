using System.Collections.Generic;

namespace quiz.Models
{
    public static class QuestionRepository
    {
        public static List<Question> Questions {get;set;} = new List<Question>();
        static QuestionRepository(){
            Questions.Add(new Question(){
                Answers=new List<string>(){"Māja","Ceļš","Mašīna"},
                Text="Tavs jautājums?",
                CorrectAnswerIndex=0,
            });
             Questions.Add(new Question(){
                Answers=new List<string>(){"viens","divi","tris"},
                Text="kurš skaitlis?",
                CorrectAnswerIndex=0,
            });
             Questions.Add(new Question(){
                Answers=new List<string>(){"a","b","b"},
                Text="kurš burts?",
                CorrectAnswerIndex=0,
            });
             Questions.Add(new Question(){
                Answers=new List<string>(){"ai","au","ie"},
                Text="kura zilbe?",
                CorrectAnswerIndex=0,
            });
        }
        // public static Question GetQuestion(int number)
        // {
        //     return Question.Questions[number];
        // }
        // public static void UserAnswered(int number, int answer)
        // {
        //     GetQuestion(number).CorrectAnswerIndex = answer;
        // }
    }
}