using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSVCalculator
{
    //Интерфейс конвертируемых объектов
    interface Convertable<T>
    {
        T Convert();
    }
}
