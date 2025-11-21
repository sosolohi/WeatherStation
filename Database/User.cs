namespace Database
{
    public class User
    {
        public int Id { get; set; }
        string Name { get; set; }
        private static int counter = 0;
        public User(string name, int id)
        {
            this.Id = id;
            this.Name = name;
            counter++;
        }
    }
}