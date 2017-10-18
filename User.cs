namespace MikadoDepartments
{
    public class User
    {
        private readonly Brand _brand;

        public User(Brand brand)
        {
            _brand = brand;
        }

        public Brand GetBrand()
        {
            return _brand;
        }

    }
}
