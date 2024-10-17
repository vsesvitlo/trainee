/*815
 Змоделюйте облік користувачів на сайті.

Створіть клас з ім’ям User. Створіть два атрибути first_name і last_name, 
а потім ще кілька атрибутів, які зазвичай зберігаються у профілі користувача. 
Напишіть метод describe_user який виводить повне ім’я користувача. 
Створіть ще один метод greeting_user() для виведення персонального вітання для користувача. 
Викличте обидва методи для користувача.

Додайте атрибут login_attempts (спроби входу в обліковий запис) у клас User.
Напишіть метод increment_login_attempts(), що збільшує значення login_attempts на 1.
Напишіть інший метод з ім’ям reset_login_attempts(), обнуляє значення login_attempts. 
Створіть екземпляр класу User і викличте increment_login_attempts() кілька разів. 
Виведіть значення login_attempts, щоб переконатися у тому, що значення було змінено правильно, 
а потім викличте reset_login_attempts(). Знову виведіть login_attempts і переконайтеся у тому, що значення обнулилося.

Адміністратор - особливий різновид користувача. Напишіть клас з ім’ям Admin, що успадковує від класу User.
Додайте атрибут privileges для зберігання списку рядків виду «Allowed to add message»,
«Allowed to delete users», «Allowed to ban users» і т. д. Напишіть метод show_privileges() 
для виведення набору привілеїв адміністратора. Створіть екземпляр класу Admin і викличте метод.

Напишіть клас Privileges. Клас повинен містити всього один атрибут privileges зі списком, 
який треба забрати із класу Admin. Водночас, необхідно перемістити метод show_privileges() 
у клас Privileges із класу Admin. Створіть екземпляр priv як атрибут класу Admin. 
Створіть новий екземпляр класу Admin і використайте метод для виведення списку привілеїв.

Додатково. Збережіть клас User в одному модулі, а класи Privileges і Admin у іншому модулі.
В окремому файлі створіть екземпляр класу Admin і викличте метод show_privileges(), щоб перевірити, що все працює вірно.

У вихідних даних наведений можливий варіант результатів виконання завдань.

Вхідні дані:

Немає
Вихідні дані:

a)
Bilbo Baggins
Hello, Bilbo Baggins
b)
3
0
c), d)
Allowed to add message
Allowed to delete users
Allowed to ban users
*/namespace _12._10._2024___815
{
    public class User {
        public string first_name;
        public string last_name;
        public int age;
        public string adress;
        public int login_attempts;

        public User(string first_name, string last_name, int age, string adress, int login_attempts)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.adress = adress;
            this.login_attempts = 1;
        }
       // public User Admin;
 
        public User Describe_user()
        {
            User creation = new User(this.first_name, this.last_name, this.age, this.adress, 1);
            return creation;
        }
        public override string ToString()
        {
            return this.first_name.ToString() + " " + this.last_name.ToString();
        }
        public string Greeting_user()
        {
            return "Hello" + " " + ToString();
        }
        public int Increment_login_attempts() {
            login_attempts++;
            return login_attempts;
        }

        public int Reset_login_attempts() {
        login_attempts = 0;
        return login_attempts;
        }
        //+ " " + this.age.ToString() + " " + this.adress.ToString()
        /*
         * Адміністратор - особливий різновид користувача. Напишіть клас з ім’ям Admin, що успадковує від класу User.
Додайте атрибут privileges для зберігання списку рядків виду «Allowed to add message»,
«Allowed to delete users», «Allowed to ban users» і т. д. Напишіть метод show_privileges() 
для виведення набору привілеїв адміністратора. Створіть екземпляр класу Admin і викличте метод.

       */
        
    }
    public class Admin
    {
    public class User;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User creation = new User("John", "Smith", 22, "New Zeland Abc 23", 1);
            Console.WriteLine(creation.Describe_user());
            Console.WriteLine(creation.Greeting_user());
            Console.WriteLine(creation.Increment_login_attempts());
            Console.WriteLine(creation.Increment_login_attempts());
            Console.WriteLine(creation.Increment_login_attempts());
            Console.WriteLine(creation.Increment_login_attempts());
            Console.WriteLine(creation.Reset_login_attempts());
        }
    }
}
