using System;
using System.Collections.Generic;
using System.Text;

namespace HW_SOLID
{
    
        //Класс должен работать для одной цели и обрабатывать логически связанные действия/данные
        //
        //
        public class FalseTransport
        {
            public string Name;             //  +   NoComment
            public int weight;              //  +   Любая транспорт обладает весом
            public void Move(){ }           //  +   Любой транспорт может(должен) двигаться
            public void Fly() { }           //  -   автомобиль не может летать, у экземпляра класса будут ненужные возможности
                                            //      и лишние возможности на ошибку
            public void Dig() { }           //  -   аналогично Fly -  копать может строителная техника, но не авто
        }
        //  как-то так
        public class TrueTransport
        {
            public string Name;
            public int weight;
            public virtual void Move()
            {
                Console.WriteLine("car rides");
            }
        }
        public class FlyTransport : TrueTransport
        {            
            public override void Move()
            {
                Console.WriteLine("plane flies");
            }
        }

        public class Digger : TrueTransport
        {
            public override void Move()
            {
                Console.WriteLine("Digger rides");
            }
            public void Dig()
            {
                Console.WriteLine("Digger DIG");
            }
        }









}

