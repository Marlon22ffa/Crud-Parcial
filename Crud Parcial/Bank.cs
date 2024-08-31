using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Parcial
{
    public class Bank
    {
        public int AccountID { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
