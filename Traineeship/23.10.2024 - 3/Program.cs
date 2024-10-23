/*Завдання 3: Робітники Створіть базовий клас Employee,
 * який містить ім'я працівника та метод для розрахунку зарплати. 
 * Створіть два класи-нащадки: Manager та Worker. 
 * У класі Manager зарплата повинна розраховуватись як оклад плюс бонус,
 * а у класі Worker — залежно від кількості відпрацьованих годин.*/

using System.Runtime.InteropServices;

namespace _23._10._2024___3
{
    public class Employee
    {
        public string name;

        public Employee(string name)
        {
            this.name = name;
        }
        public virtual string CalcWage()
        {
            return "Unique sum";
        } 
    }
    class Manager : Employee
    {
       
       public double mainSum;
       public double addBonus;

        public Manager( double mainSum, double addBonus) : base("name")
        {
            this.mainSum = mainSum;
            this.addBonus = addBonus;
        }
        public override string CalcWage()
        {
            double wage = this.mainSum + this.addBonus;
            return wage.ToString();
        }
    }

    class Worker : Employee
    {
       public double sumPerHour;
       public double hours;

        public Worker(double sumPerHour, double hours) : base("name") 
        {
            this.sumPerHour = sumPerHour;
            this.hours = hours;
        }

        public override string CalcWage()
        {
            double wage = this.sumPerHour * this.hours;
            return wage.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jill");
            Manager manager = new Manager(1500, 600);
            Worker worker = new Worker(133.44, 8.5);
            Console.WriteLine(manager.CalcWage());
            Console.WriteLine(worker.CalcWage());
        }
    }
}
