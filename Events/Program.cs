using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void MyFunc(string data);
    class MyClass
    {
        public string Str { get; set; }
        public MyClass() { }
        public MyClass(string str) { Str = str; }
        public void Space(string str)
        {
            var text = string.Empty;
            foreach (var s in str)
            {
                text += s + "_";
            }
            Console.WriteLine(text);
        }
        public void Reverse(string str)
        {
            var text = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                text += str[str.Length - 1 - i];
            }              
            
            Console.WriteLine(text);            
        }
    }
    class Run
    {
      public void RunFunc(MyFunc func,string str)
        {
            func.Invoke(str);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter string");
              var str = Console.ReadLine();
            MyClass cls = new MyClass(str);
            MyFunc funcDell = new MyFunc(cls.Reverse);
            funcDell += cls.Space;


            Run run = new Run();
            run.RunFunc(funcDell, str);
        }
    }
}
