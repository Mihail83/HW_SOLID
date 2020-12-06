using System;
using System.Collections.Generic;
using System.Text;

namespace HW_SOLID
{
    class LiskovSustitution
    {
        // смысл  =  по ссылке на базовый класс можно вызвать производный,
        //который не создаст новых ошибок и не приведет к неожиданным результатам

        //
    }
    public class IndexBaseClassPost                         //Постусловия не могут быть ослаблены в производном классе.
    {                                                       //Предусловия не могут быть усилены в производном классе
        protected int index;
        public virtual int Index
        {
            get
            {                
                return index < 0 ? 0 : index;           //Постусловия---  не возвращает отр  числа
            }
            set
            {
                index = index < 0 ? 0 : value;                        //Предусловия --  диапазон больше нуля 
            }
        }
    }
    public class IndexSubClass : IndexBaseClassPost
    {
        public override int Index
        {
            get
            {                
                return index;                           //!!!!!!!!Постусловия ослаблены  ---  Может вернуть отр числа
            }
            set
            {
                index = index < 0 && index > 100 ? 0 : value;         //!!!!!!!!Предусловие усилено  диапазон от 0 до 100
            }
        }
    }
}
//  Другие признаки нарушения принципа 
//    возможны новые exeption
//    нарушение инвариантов  - яркий пример - возраст меньше нуля
//    "формальное" наследование    

public class Car { }

public class ToyCar : Car { }
// формально ToyCar может обладать теми же параметрами, что и базовый Car, но попытка применить ToyCar вместо Car
//закончится ошибками

//Нрушение LSP исправляется верной иерархией наследования 