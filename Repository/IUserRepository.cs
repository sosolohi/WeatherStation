using Database;


namespace Repository
{
    public interface IUserRepository
    {
        User? GetUser(int id);
    }
}
