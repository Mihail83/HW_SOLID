using System;
using System.Collections.Generic;
using System.Text;

namespace HW_SOLID
{
    class Book    //пример зависимости от класса, также нарушения OCP , т.к. мы не можем заменить ConsolePrinter не ИЗМЕНЯЯ класс
                  // и не можем менять ConsolePrinter, не затрагивая все классы, которые его используют
    {
        public string text;
        public ConsolePrinter Printer { get; set; }

        public void Print()
        {
            Printer.Print(text);
        }
    }
    class ConsolePrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
    // исправляем
    interface IPrinter
    {        void Print(string text);
    }

    class Book2  //теперь класс зависит от абстракции, которую легко заменять, 
                   //т.е. детали реализации метода Print зависят от абстракции
    {
        public string text;
        public IPrinter printer;

        public Book2(IPrinter printer)
        {
            this.printer = printer;
        }

        public void Print()
        {
            printer.Print(text);
        }
    }

    class ConsolePrinter2 : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать на консоли");
        }
    }

    class HtmlPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать в html");
        }
    }

}
