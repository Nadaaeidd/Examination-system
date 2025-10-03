using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examination_system
{
    internal class QuestionList:List<QuestionBase>
    {
        List<QuestionBase> list = new List<QuestionBase>();

        public new void Add(QuestionBase question)
        {

            base.Add(question);
            using (StreamWriter log = new StreamWriter("iti.txt",true))
            {
                log.WriteLine(question);
            }
            
        }
    }
}
