using System.Collections.Generic;

namespace MikadoDepartments
{
    public class Brand
    {
        public ICollection<User> Users { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
    }
}
