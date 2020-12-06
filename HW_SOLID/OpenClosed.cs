using System;
using System.Collections.Generic;
using System.Text;

namespace HW_SOLID
{
    class OpenClosed
    {
        ////   После    SingleResposibility   остались  классы транспорт и они уже используються в программе, 
        ///тронешь и ком последствий
        ///
        /// понадобился   водный транспорт -  Не изменяем существующий код, а добавляем(наследование и реализации интерфейсов)
        public class WaterTransport : TrueTransport
        {
            public override void Move()
            {
                Console.WriteLine("ship is sailing");
            }
        }
        









    }
}
