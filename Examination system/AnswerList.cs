using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class AnswerList
    {
        List<Answer>answers=new List<Answer>();
        public AnswerList(List<Answer>_ans)
        {
            answers = _ans;
        }
        public override string ToString()
        {
            string finalanwers="";
            foreach (var answer in answers)
            {
                finalanwers += answer.ToString();
            }
            return finalanwers;
        }
    }
}
