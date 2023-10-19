using System;

namespace Creative_Task
{
    abstract public class Company
    {
        public string full_name { get; set; }
        public int year_create { get; set; }
        public string name_creater { get; set; }
        public void Full_Name()
        {
            Console.WriteLine($"Полное имя компании - {full_name}");
        }
        public void Year_Create()
        {
            Console.WriteLine($"Компания была основана в {year_create} году");
        }
        public void Name_Creator()
        {
            Console.WriteLine($"Создателем компании является {name_creater}");
        }

    }
    public class Coke_Cola : Company
    {

    }
    public class Microsoft : Company
    {

    }
    public class Intel : Company
    {

    }

}
