using System;
using System.Collections.Generic;
using System.Text;

namespace HW_SOLID
{                                   //интерфейс должен содержать логически непротиворечивые действия, а
    public interface IphoneFalse    // объект должен получить только те методы, которые ему нужны
    {
        void Call();
        void IncomingCall();
        void Photo();
        void MakeVideo();
    }                       //совр телефоны, могут все, и вроде интерфейс Iphone описывает возможности 
                            //но НЕ применим к фотоаппарату или видеокамере, т.к. они не умеют звонить
                            //Исправим....
    public interface Iphone
    {
        void Call();            
        void IncomingCall();
    }
    public interface IPhoto
    {
        void Photo();
    }
    public interface Ivideo
    {
        void MakeVideo();
    }

    public class Phone : Iphone, IPhoto, Ivideo
    {
        public void Call()
        {
           // реализация 
        }

        public void IncomingCall()
        {
            // реализация 
        }

        public void MakeVideo()
        {
            // реализация 
        }

        public void Photo()
        {
            // реализация 
        }
    }
    //  теперь интерфейсы можно использовать повторно, а классы получат только то, что необходимо
}
