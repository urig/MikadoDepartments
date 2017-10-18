namespace MikadoDepartments
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User(new Brand());
            var brand = user.GetBrand();
        }
    }
}
