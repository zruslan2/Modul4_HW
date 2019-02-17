using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_
{
    public partial class Car
    {
        //9. Создать дополнительный метод для данного класса в другом файла, 
        //используя ключевое слово partial.
        void print()
        {
            Console.WriteLine("Производитель автомобиля: {0}\nМодель: {1}\nТип двигателя: {2}\nМощность: {3}\nБазовая цена: {4}", this.car_brand, this.model, this.engine_type.ToString(), this.BasePrice);
        }
    }
}
