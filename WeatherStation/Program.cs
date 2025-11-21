using Database;

namespace WeatherStation;

class Program
{
    public static void Main(string[] args)
    {
        //   Console.WriteLine("Hello, World!");
        // User user = new User();
        //Sensor sencor = new Sencor();
        User user1 = new User("Ja", 999);

        User user2 = new User("Ja", 999);
        Sensor sensor = new Sensor();
    }
}

