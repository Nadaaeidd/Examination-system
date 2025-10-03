using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Exam
    {
        public DateTime StartDate { get; set; }= DateTime.Now;
        public DateTime EndDate =>StartDate.AddHours(1);
        public int NumberOfQuestions { get; set; }
        public Dictionary<QuestionBase, Answer> QandA { get; set; }=new Dictionary<QuestionBase, Answer>();

        public string Subject {  get; set; }
        public string ExamType { get; set; }
        public Exam(int _numberOfQuestions,Dictionary<QuestionBase, Answer>_qa,string _subject,string _examType)
        {
            NumberOfQuestions = _numberOfQuestions;
            QandA = _qa;
            Subject = _subject;
            ExamType = _examType;
        }
        void PrintExamFormat()
        {
            Console.WriteLine($"Exam starts at ({StartDate})--------Ends at ({EndDate})--------Total Quetion Number: {NumberOfQuestions}");
            Console.WriteLine("             -----------------------------------------------------------------------------------            ");
            Console.WriteLine();
            foreach (var item in QandA)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
        void PrintExamFormat(List<string> answers)
        {
            Console.WriteLine($"Exam starts at ({StartDate})--------Ends at ({EndDate})--------Total Quetion Number: {NumberOfQuestions}");
            Console.WriteLine("             -----------------------------------------------------------------------------------            ");
            Console.WriteLine();
            int counter = 0;
            foreach (var item in QandA)
            {
                Console.WriteLine($"{item.Key}Correct Answer--{answers[counter++]}");
                Console.WriteLine(item.Value);
            }
        }
        public void ShowFinalExam()
        {
            PrintExamFormat();
        }
        public void ShowPracticeExam(List<string> ans)
        {
            PrintExamFormat();
            Console.WriteLine("Do you want to see the answers ?  Y/N");
            if( char.TryParse(Console.ReadLine(), out char answer))
            {
                answer=char.ToUpper(answer);
                if (answer == 'Y')
                {
                    Console.Clear();
                    PrintExamFormat(ans);
                }


            }
            else
            {
                Console.WriteLine("Invalid Data...Please try Again");
            }


        }


    }
}
