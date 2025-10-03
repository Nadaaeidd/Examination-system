using System.Collections.Generic;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<QuestionBase, Answer> QApair = new Dictionary<QuestionBase, Answer>();
            QApair.Add(new TrueFalseQuestion(1, "C# is Fully OOP langue ?", "10"), new AnswerTrueFalse());
            QApair.Add(new TrueFalseQuestion(2, "JS is Fully OOP langue ?","10"), new AnswerTrueFalse());
            QApair.Add(new TrueFalseQuestion(3, "Object is a Proto Type ?", "10"), new AnswerTrueFalse());
            QApair.Add(new ChooseAllQuestion(4, "Which one is an OOP Principle?", "20"), new AnswerChooseAll(new List<string> { "Inhertance", "Polymorephzm", "Abstraction", "Encapsulation" }));
            QApair.Add(new ChooseOneQuestion(5, "Which one is case Sansetive Language?", "20"), new AnswerChooseOne(new List<string>() { "C#", "JS", "HTML", "CSS" }));


            Console.WriteLine("Choose type of exam...(1 or 2)");
            Console.WriteLine("1)Final Exam");
            Console.WriteLine("2)Practice Exam");
            int choise=int.Parse(Console.ReadLine());
            Console.Clear();
            Exam exam = new Exam(10, QApair, "General", "Final Exam");
            if (choise == 1)
            {
                
                exam.ShowFinalExam();
            }
            else if(choise == 2) 
            {
                exam.ShowPracticeExam(new List<string> { "True", "False", "True", "All of the above", "C#" });
            }



            //Answer answer = new AnswerTrueFalse();

            //List<Answer> answers = new List<Answer> { answer };
            //AnswerList answerList = new AnswerList(answers);


            //List<string> ans1 = new List<string>() { "Inhertance", "Polymorephzm", "Abstraction", "Encapsulation" };
            //List<Answer> answerChooseAlls = new List<Answer>();
            //answerChooseAlls.Add(new AnswerChooseAll(ans1));
            //AnswerList answerList2 = new AnswerList(answerChooseAlls);

            //List<string> choneans = new List<string>() { "C#", "JS", "HTML", "CSS" };
            //List<Answer> anweonechoose = new List<Answer>();
            //anweonechoose.Add(new AnswerChooseOne(choneans));
            //AnswerList list3 = new AnswerList(anweonechoose);




            //TrueFalseQuestion question = new TrueFalseQuestion(1, "C# is Fully OOP langue ?", "10");
            //TrueFalseQuestion question2 = new TrueFalseQuestion(2, "JS is Fully OOP langue ?", "10");
            //TrueFalseQuestion question3 = new TrueFalseQuestion(3, "Class is a Proto Type ?", "10");
            //ChooseAllQuestion question4 = new ChooseAllQuestion(4, "Which one is an OOP Principle?", "20");
            //ChooseOneQuestion question5 = new ChooseOneQuestion(5, "Which one is case Sansetive Language?", "20");
            //QuestionList questionList = new QuestionList();
            //questionList.Add(question);
            //questionList.Add(question2);
            //questionList.Add(question3);
            //questionList.Add(question4);
            //questionList.Add(question5);


        }
    }
}
