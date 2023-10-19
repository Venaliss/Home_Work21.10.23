using System;

namespace Creative_Task
{
    /*Тема - Многонациональные компании*/

    abstract public class Company /*Абстрактный класс */
    {
        public abstract int Get_Year();
        public abstract string Get_Name();
        public abstract string Get_Name_Creator();
        public abstract byte Get_Capital();
    }
    class Coke_Cola : Company /*Класс наследник*/
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public string Name_Creator { get; set; }
        public byte Capital { get; set; }

        public override int Get_Year() => Year;
        public override string Get_Name() => Name;
        public override string Get_Name_Creator() => Name_Creator;
        public override byte Get_Capital() => Capital;

        public string product;
        public Coke_Cola()
        {
            product = "Soda";
        }
        public void PrintProduct(string name)
        {
            Console.WriteLine($"Основным продуктом компании {name} является {product} Coke-Cola.");
        }
        public void WriteYear(int year, string name)
        {
            Console.WriteLine($"Компания {name} была основана в {year}.");
        }
        public void WriteName(string name)
        {
            Console.WriteLine($"Полным именем компании является {name}.");
        }
        public void WriteNameCreator(string name_creator)
        {
            Console.WriteLine($"Имя основателя компании {name_creator}.");
        }
        public void WriteCapital(byte capital)
        {
            Console.WriteLine($"Общий капитал компании равен {capital} млрд.");
        }
    }
    class Intel : Company /*Класс наследник*/
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public string Name_Creator { get; set; }
        public byte Capital { get; set; }

        public override int Get_Year() => Year;
        public override string Get_Name() => Name;
        public override string Get_Name_Creator() => Name_Creator;
        public override byte Get_Capital() => Capital;

        public string product;
        public Intel()
        {
            product = "электронные устройства и компьютерные компоненты";
        }
        public void PrintProduct(string name)
        {
            Console.WriteLine($"Основным продуктом компании {name} являются {product}.");
        }
        public void WriteYear(int year, string name)
        {
            Console.WriteLine($"\nКомпания {name} была основана в {year}.");
        }
        public void WriteName(string name)
        {
            Console.WriteLine($"Полным именем компании является {name}.");
        }
        public void WriteNameCreator(string name_creator)
        {
            Console.WriteLine($"Имена основателей компании {name_creator}.");
        }
        public void WriteCapital(byte capital)
        {
            Console.WriteLine($"Общий капитал компании равен {capital} млрд.");
        }
    }
    class Fillials /*Класс Филлиал*/
    {
        public string Company { get; set; }
        public int Imployee { get; set; }
        public int Count_Fillials { get; set; }
        public string Name { get; set; }

        public string Get_Name_Company() => Company;
        public int Get_Count_Imployee() => Imployee;
        public int Get_Count_Fillials() => Count_Fillials;
        public string Fillial_Name() => Name;

        public string country;
        Random rnd = new Random();
        
        public void WriteCompany(string company, int imployee)
        {
            Console.WriteLine($"Название компании и число сотрудников: {company}, {imployee}");  
        }
        public Fillials()
        {
            Console.Write($"\nВведите страну филлиала {Get_Name_Company()}:");
            country = Console.ReadLine();
            Count_Fillials = rnd.Next(1, 100);
            Console.Write("\nВведите наименование филлиала:");
            Name = Console.ReadLine();
        }
        public void WriteCountryFillial()
        {
            Console.WriteLine($"Страна в которой находится филлиал:{country}");
        }
        public void WriteCountFillial()
        {
            Console.WriteLine($"Количество филлиалов в стране равна {Count_Fillials}");
        }
        public void WriteNameFillial()
        {
            Console.WriteLine($"Полное имя филлиала компании в стране {country}:{Name}");
        }
    }
    class Program
    {
        static void Main()
        {
            /*Первый класс Coke-Cola являющийся наследником класса Company*/
            Coke_Cola coke = new Coke_Cola {Year = 1829, Name = "The Coca-Cola Company", Name_Creator = "John Stith Pemberton", Capital = 25 };
            coke.WriteYear(coke.Get_Year(), coke.Get_Name());
            coke.WriteNameCreator(coke.Get_Name_Creator());
            coke.WriteCapital(coke.Get_Capital());
            Coke_Cola product = new Coke_Cola();
            product.PrintProduct(coke.Get_Name());

            /*Второй класс Intel являющийся наследником класса Company*/
            Intel intel = new Intel { Year = 1968, Name = "Intel Corporation", Name_Creator = "Гордон Мур, Роберт Нойс, Эндрю Гроув", Capital = 24 };
            intel.WriteYear(intel.Get_Year(), intel.Get_Name());
            intel.WriteNameCreator(intel.Get_Name_Creator());
            intel.WriteCapital(intel.Get_Capital());
            Intel product_int = new Intel();
            product_int.PrintProduct(intel.Get_Name());


            /*Третий класс Fillials*/
            Console.WriteLine("\nНазвание компании Nestle");
            Fillials write = new Fillials {Company = "Nestle", Imployee = 87544};
            write.WriteCompany(write.Get_Name_Company(), write.Get_Count_Imployee());
            write.WriteCountryFillial();
            write.WriteCountFillial();
            write.WriteNameFillial();

            Console.ReadKey();
        }
    }
}
