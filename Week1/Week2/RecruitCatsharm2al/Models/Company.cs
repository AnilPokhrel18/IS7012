using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatsharm2al.Models
{
    public class Company
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int AccountHolderId { get; set; }
        public int PhoneNum { get; set; }
        public long Address { get; set; }
        public List<BankAccount> BankAccountID { get; set; }
    }
}
