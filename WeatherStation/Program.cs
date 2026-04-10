using Database;
using Repository;

namespace WeatherStation;

class Program
{
    public static void Main(string[] args)
    {
        using (var myContext = new WeatherStationContext())
        {
            myContext.Database.EnsureCreated();
            var user = new UserRepository(myContext);
            user.GetUser(1);
            var user222 = user.GetUser(2);
            Console.WriteLine(user222.Name);
        }




    }
}

