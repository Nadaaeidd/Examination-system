using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal abstract class QuestionBase
    {
        public int Id { get; set; }
    
        public string Body { get; set; }
        public string Mark { get; set; }
        //public AnswerList AnswerList { get; set; }
        public QuestionBase(int _id,string _body,string _mark )//, AnswerList _answerlist)
        {
            Id = _id;
            Body= _body;
            Mark= _mark;
            //AnswerList= _answerlist;
        }
        public abstract void CreateQues();
       
       
    }
    internal class TrueFalseQuestion: QuestionBase
    {

        public TrueFalseQuestion(int _id,  string _body, string _mark) : base(_id,  _body, _mark)
        {
           
        }

        public override void CreateQues()
        {
            Console.WriteLine($"Question{Id}: True/False\t\t\tMArk({Mark})");
            Console.WriteLine(Body);
        }
        public override string ToString()
        {
            Console.WriteLine();
            return $"Quetion : {Id} -- Question is: {Body} -- Mark: {Mark} -- (True/False)  ";

        }
    }
    internal class ChooseOneQuestion : QuestionBase
    {

        public ChooseOneQuestion(int _id, string _body, string _mark) : base(_id,  _body, _mark)
        {

        }

        public override void CreateQues()
        {
            Console.WriteLine($"Question{Id}: Choose One \t\t\tMArk({Mark})");
            Console.WriteLine(Body);
        }
        public override string ToString()
        {
            Console.WriteLine();
            return $"Quetion : {Id} -- Question is: {Body} -- Mark: {Mark} -- (True/False)  ";

        }
    }
    internal class ChooseAllQuestion : QuestionBase
    {

        public ChooseAllQuestion(int _id, string _body, string _mark) : base(_id, _body, _mark)
        {

        }

        public override void CreateQues()
        {
            Console.WriteLine($"Question{Id}: Choose One \t\t\tMArk({Mark})");
            Console.WriteLine(Body);
        }
        public override string ToString()
        {
            Console.WriteLine();
            return $"Quetion : {Id} -- Question is: {Body} -- Mark: {Mark} -- (Choose All)  ";
            
        }
    }
}
