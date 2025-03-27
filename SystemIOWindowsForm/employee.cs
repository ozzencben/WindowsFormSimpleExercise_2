using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWindowsForm
{
    public class employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string fullname { get; set; }

        public override string ToString()
        {
            return Name + "  " + Surname;
        }

        public string employeInformationBring()
        {
            return string.Format("Name : {0} Surname : {1}  Email : {2}  CompanyName : {3} Country : {4} ",Name,Surname,Email,Country,Company);
        }
    }
}
