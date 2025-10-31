using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateOnly DOB { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IdCard { get; set; }  


        public Person()
        {
            PersonID = 0;
            DOB = new DateOnly(1,1,1);
            FirstName = LastName = Gender = City = Email = PhoneNumber = IdCard = "";
        }

        public Person(string lastname, string firstname, string gender, DateOnly dob, string phone, string city, string email, string idcard)
        {
            LastName = lastname;
            FirstName = firstname;
            Gender = gender;
            DOB = dob;
            PhoneNumber = phone;
            City = city;
            Email = email;
            IdCard = idcard;
        }

        public Person(string csvLine)
        {
            string[] values = csvLine.Split(';');
            PersonID = Convert.ToInt32(values[0]);
            LastName = values[1];
            FirstName = values[2];
            Gender = values[3];
            DOB = DateOnly.Parse(values[4]);
            City = values[5];
            PhoneNumber = values[6];
            Email = values[7];
            IdCard = values[8];
        }

        public List<Person> GetList(string fileName = "")
        {
            List<Person> PersonList = new List<Person>();
            fileName = fileName == "" ? GlobalSetting.PersonFile : fileName;

            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row                
                if (!reader.EndOfStream) reader.ReadLine();

                string line = "";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Person ps = new Person(line);
                    PersonList.Add(ps);
                }
            }
            return PersonList;
        }

        
    }
}
