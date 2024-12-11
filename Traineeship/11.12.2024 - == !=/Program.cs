/*Є георграфічні точки на карті (довго і широта), 
створити клас географічних точок.
Реалізувати == != для нього*/
namespace _11._12._2024________
{
    public class GeograficalPoints
    {
        public double latitude;
        public double longitude;

        public GeograficalPoints(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public static bool operator ==(GeograficalPoints first, GeograficalPoints second)
        {
            if (first.latitude == second.latitude && first.longitude == second.longitude)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(GeograficalPoints first, GeograficalPoints second)
        {
            if (first.latitude != second.latitude || first.longitude != second.longitude)
            {
                return true;
            }
            return false;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                GeograficalPoints geograficalPoints1 = new GeograficalPoints(45.767899, 56.686668);
                GeograficalPoints geograficalPoints2 = new GeograficalPoints(45.767899, 56.686668);
                Console.WriteLine(geograficalPoints1 ==  geograficalPoints2);

            }
        }
    }
}
