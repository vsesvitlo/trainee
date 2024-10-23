/*Завдання 1: Студенти та група Створіть клас Student,
 * який має властивості ім'я, прізвище та оцінка. 
 *  Далі створіть клас Group, який містить список студентів. 
 * Реалізуйте методи для додавання студента до групи та обчислення середньої оцінки по групі.*/

using System;

public class Student
{
   public string name;
   public string surname;
   public int mark;

    public Student(string name, string surname, int mark)
    {
        this.name = name;
        this.surname = surname;
        this.mark = mark;
    }
}
public class Group
{
    Student[] group;

    public Group(Student[] group)
    {
        this.group = group;
    }


    public void AddStudents(Student student)
    {
        int groupNew = group.Length + 1;
        Student[] grNew = new Student[groupNew];
        for (int i = 0, j = 0; i < grNew.Length; i++, j++)
        {
            if (grNew[grNew.Length - 1] == group[j])
            {
                grNew[i] = group[j];
            }
            else
            {
                grNew[grNew.Length - 1] = student;
            }
        }
    }

    public int Calc()
    {
        return group.Length;
    }

    public double AverageMark()
    {
        int sum = 0;
        for (int i = 0; i < group.Length; i++)
        {
            sum += group[i].mark;
        }
        double result = sum / group.Length;
        return result;
    }
}
namespace _23._10._2024___5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student("John", "Smith", 4);
            Student studentTwo = new Student("Ann", "Lampl", 5);
            Student studentTree = new Student("Ben", "Truro", 3);
            Student[] groupA= { studentOne, studentTwo };
            Group first = new Group(groupA);
           //?? Group A  =   first.AddStudent(studentOne);
       
            Console.WriteLine(first.Calc());
            Console.WriteLine(first.AverageMark());
        }
    }
}
