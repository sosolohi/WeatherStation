using Database;

namespace WeatherStation;

class Program
{
    public static void Main(string[] args)
    {
        using(var myContext=new WeatherStationContext())
        {
            myContext.Database.EnsureCreated();
        }
    }
}

