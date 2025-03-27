using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWindowsForm
{
    public class dataOptions
    {
        public List<employee> employees = new List<employee>();

        public dataOptions()
        {

        }

        public List<employee> GetEmployes(int piece)
        {
            List<employee> employeeList = new List<employee>();

            for (int i = 0; i < piece; i++)
            {
                int id = 0;
                employee temp = new employee();
                temp.ID = 1000 + id++;
                temp.Name = FakeData.NameData.GetFirstName();
                temp.Surname = FakeData.NameData.GetSurname();
                temp.Email = FakeData.NetworkData.GetEmail();
                temp.Country = FakeData.PlaceData.GetCountry();
                temp.Company = FakeData.NameData.GetCompanyName();
                temp.fullname = temp.Name + "  " + temp.Surname;
                employeeList.Add(temp);
            }

            return employeeList;
        }

        public void AddEmployee(string path, List<employee> employeList)
        {
            for (int i = 0; i < employeList.Count; i++)
            {
                DirectoryInfo countryInformation = null;
                if (Directory.Exists(path + "\\" + employeList[i].Country))
                {
                    countryInformation = new DirectoryInfo(path + "\\" + employeList[i].Country);
                }
                else
                {
                    countryInformation = Directory.CreateDirectory(path + "\\" + employeList[i].Country);
                }

                FileStream fs = File.Create(countryInformation.FullName +"\\"+ employeList[i].Name + "." + employeList[i].Surname + ".txt");
                byte[] employeInformatıon = new UTF8Encoding(true).GetBytes(employeList[i].employeInformationBring());
                fs.Write(employeInformatıon, 0, employeInformatıon.Length);
                fs.Close();
            }
        }
    }
}
