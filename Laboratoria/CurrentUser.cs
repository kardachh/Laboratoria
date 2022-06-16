using System.Collections.Generic;

namespace Laboratoria
{
    internal struct CurrentUser
    {
        public static CurrentUser userData = new CurrentUser();

        public static void Logout()
        {
            userData = new CurrentUser();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int id_type { get; set; }
        public string image { get; set; }
        public ICollection<order> order { get; set; }
        public typeUser typeUser { get; set; }
    }

}
