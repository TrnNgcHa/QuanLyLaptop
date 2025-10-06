using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLaptop
{
    internal class Account: Person
    {
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        public Account()
        {
            AccountID = Balance = 0;
            AccountName = Password = "";
        }

    }
}
