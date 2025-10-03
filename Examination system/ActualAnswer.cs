using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal abstract class ActualAnswer
    {
        public string RealAnwer {  get; set; }
        public ActualAnswer(string _ans) {
            RealAnwer = _ans;
        }
    }
    


}
