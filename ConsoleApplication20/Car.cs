using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_
{
    public enum type { petrol_engine, disel_engine , electro_engine, hybrid}
    /// <summary>
    /// 1.	Разработать один из классов на ваше усмотрение (Автомобиль)
    /// </summary>
    public partial class Car
    {
        // 2. Реализовать не менее пяти закрытых полей (различных типов), представляющих 
        // основные характеристики рассматриваемого класса.
        string car_brand;
        string model;
        type engine_type;
        double power;
        decimal BasePrice;

        //3. Создать не менее трех методов управления классом и методы доступа 
        //к его закрытым полям. 
        public void setCar_brand(string car_brand)
        {
            this.car_brand = car_brand;
        }
        public string getCar_brand()
        {
            return this.car_brand;
        }
        public void setModel(string model)
        {
            this.model=model;
        }
        public string getModel()
        {
            return this.model;
        }
        void setEngine_type(type et)
        {
            this.engine_type = et;
        }
        type getEngine_type()
        {
            return this.engine_type;
        }
        //4. Создать метод, в который передаются аргументы по ссылке. 
        public void getPower(ref double pow)
        {
            pow = this.power;
        }
        //5. Создать не менее двух статических полей (различных типов), представляющих 
        //общие характеристики объектов данного класса. 
        public static int count=0;
        public static decimal minProfit;
        //6. Обязательным требованием является реализация нескольких перегруженных 
        //конструкторов, аргументы которых определяются студентом, исходя из специфики 
        //реализуемого класса, а также реализация конструктора по умолчанию.

        //конструктор по умолчанию
        public Car()
        {
            count++;
        }
        public Car(string car_brand, string model)
        {
            this.car_brand = car_brand;
            this.model = model;
        }
        public Car(string car_brand, string model, type e_type)
        {
            this.car_brand = car_brand;
            this.model = model;
            this.engine_type = e_type;
        }
        public Car(string car_brand, string model, type e_type, double power, decimal b_price)
        {
            this.car_brand = car_brand;
            this.model = model;
            this.engine_type = e_type;
            this.power = power;
            this.BasePrice = b_price;
        }
        
        //7.	Создать статический конструктор
        static Car()
        {
            minProfit = 500;
        }

    }
}
