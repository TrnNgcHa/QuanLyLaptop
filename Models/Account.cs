using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop.Models
{
    public class Account: Person
    {
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public int Password { get; set; }
        public int Balance { get; set; }

        public Account()
        {
            AccountID = Balance = Password = 0;
            AccountName = "";
        }

        public Account(Account acc) 
        {
            this.AccountID = acc.AccountID;
            this.PersonID = acc.PersonID;
            this.AccountName = acc.AccountName;
            this.Password = acc.Password;
            this.Balance = acc.Balance;
            this.LastName = acc.LastName;
            this.FirstName = acc.FirstName;
            this.Gender = acc.Gender;
            this.DOB = acc.DOB;
            this.PhoneNumber = acc.PhoneNumber;
            this.City = acc.City;
            this.Email = acc.Email;
            this.IdCard = acc.IdCard;
        }

        public void CopyFrom(Account acc) 
        {
            this.AccountID = acc.AccountID;
            this.PersonID = acc.PersonID;
            this.AccountName = acc.AccountName;
            this.Password = acc.Password;
            this.Balance = acc.Balance;
            this.LastName = acc.LastName;
            this.FirstName = acc.FirstName;
            this.Gender = acc.Gender;
            this.DOB = acc.DOB;
            this.PhoneNumber = acc.PhoneNumber;
            this.City = acc.City;
            this.Email = acc.Email;
            this.IdCard = acc.IdCard;
        }

        public Account(string lastname, string firstname, string gender, DateOnly dob, string phone, string city, string email, string idcard)
        {
            AccountID = Balance = Password = 0;
            AccountName = "";
            this.LastName = lastname;
            this.FirstName = firstname;
            this.Gender = gender;
            this.DOB = dob;
            this.PhoneNumber = phone;
            this.City = city;
            this.Email = email;
            this.IdCard = idcard;
        }
        public void SetAccount(string name, int password)
        {
            this.AccountName = name;
            this.Password = password;
        }

        public Account(string csvLine)
        {
            string[] values = csvLine.Split(';');
            AccountID = Convert.ToInt16(values[0]);
            PersonID = Convert.ToInt16(values[1]);
            AccountName = values[2];
            Password = Convert.ToInt32(values[3]);
            Balance = Convert.ToInt32(values[4]);
        }

        public void FillData(List<Person> ps)
        {
            foreach (Person p in ps)
            {
                if (p.PersonID == PersonID)
                {
                    LastName = p.LastName;
                    FirstName = p.FirstName;
                    Gender = p.Gender;
                    DOB = p.DOB;
                    PhoneNumber = p.PhoneNumber;
                    City = p.City;
                    Email = p.Email;
                    IdCard = p.IdCard;
                }
            }
        }

        public List<Account> GetList(string fileName = "")
        {
            List<Account> AccountList = new List<Account>();
            List<Person> PersonList = new Person().GetList();
            fileName = fileName == "" ? GlobalSetting.AccountFile : fileName;


            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row                
                if (!reader.EndOfStream) reader.ReadLine();

                string line = "";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Account acc = new Account(line);
                    acc.FillData(PersonList);
                    AccountList.Add(acc);
                }
            }
            return AccountList;
        }

    }
}
