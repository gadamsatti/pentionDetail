using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PentionDetails.Models
{
    public class PentionDetailModel
    {
      
            public int Id { get; set; }
            public String Aadhar { get; set; }
            public String Name { get; set; }
            public DateTime DOB { get; set; }
            public String PAN { get; set; }
            public decimal SalaryEarned { get; set; }
            public decimal Allowances { get; set; }
            public string PensionType { get; set; }
            public String BankName { get; set; }
            public String AccountNumber { get; set; }
            public string BankType { get; set; }

        }
    }
