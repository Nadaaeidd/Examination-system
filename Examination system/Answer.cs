using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal abstract class Answer
    {
        public int  Id { get; set; }
        public abstract void CreateAnswer();

    }
    internal class AnswerTrueFalse : Answer
    {
        public override void CreateAnswer()
        {
            Console.WriteLine("1)- True");
            Console.WriteLine("2)- False");
        }
        public override string ToString()
        {
            return $"1)True\n2)False";
        }
    }
    internal class AnswerChooseAll : Answer
    {
        List<string> answers=new List<string>();
        public AnswerChooseAll(List<string>_ans)
        {
            answers = _ans;
            
        }
        public override void CreateAnswer()
        {
            int counter = 1;
            foreach (var answer in answers) {
                Console.WriteLine($"{counter}){ answer}");
                counter++;
            }
        }
        public override string ToString()
        {
            string re = "";
            int counter = 0;
         
            foreach (var answer in answers)
            {
                re += $"{++counter}--{answer}\t \t";
                
            }
            
            return re;
        }
    }
    internal class AnswerChooseOne : Answer
    {
        List<string> answers = new List<string>();
        public AnswerChooseOne(List<string> _ans)
        {
            answers = _ans;
        }
        public override void CreateAnswer()
        {
            int counter = 1;
            foreach (var answer in answers)
            {
                Console.WriteLine($"{counter}){answer}");
                counter++;
            }
        }
        public override string ToString()
        {
            string re = "";
            int counter = 0;

            foreach (var answer in answers)
            {
                re += $"{++counter}--{answer}\t \t";

            }

            return re;
        }
    }

}
