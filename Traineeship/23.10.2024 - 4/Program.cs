/*Завдання 4: Електронні пристрої Створіть базовий клас ElectronicDevice 
 * з властивістю для серійного номера та методом TurnOn(). 
 * Створіть похідні класи Smartphone та Laptop. У кожному з 
 * похідних класів додайте специфічні для них методи та властивості,
 * такі як обсяг пам'яті для смартфона та тип процесора для ноутбука.*/


namespace _23._10._2024___4
{
    public class ElectronicDevice
    {
        int id;

        public ElectronicDevice(int id)
        {
            this.id = id;
        }

        public virtual string TurnOn()
        {
            return "turn on";
        }
    }
    public class Smartphone : ElectronicDevice
    {
        public string model;
        public double memory;

        public Smartphone(string model, double memory) : base(0)
        {
            this.model = model;
            this.memory = memory;
        }
        public string Characteristics()
        {
            return this.model + this.memory;
        }
        public override string ToString()
        {
            return this.model + " " + this.memory;
        }
    }
    public class Laptop : ElectronicDevice
    {
        public string model;
        public string typeProcess;

        public Laptop(string model, string typeProcess) : base(0)
        {
            this.model = model;
            this.typeProcess = typeProcess;
        }
        public string Characteristics()
        {
            return this.model + this.typeProcess;
        }
        public override string ToString()
        {
            return this.model + " " + this.typeProcess;
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicDevice electronic = new ElectronicDevice(097745);
            Smartphone smartphone = new Smartphone("Nokia", 16);
            Laptop laptop = new Laptop("Lenovo", "Intel Core Ultra 5");
            Console.WriteLine(laptop.Characteristics());
            Console.WriteLine(smartphone.Characteristics());
        }
    }
}
