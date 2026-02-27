using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly WeatherStationContext _dbContext;
        public UserRepository (WeatherStationContext dbContext)
        {
            _dbContext= dbContext;
        }
        public User? GetUser(int id)
        {
           return _dbContext.Set<User>()
                .FirstOrDefault(x=>x.Id==id);
        }
    }
}
