using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contract
{
  [Serializable]
  class Subscriber
  {
   internal int Id { get; set; }
   internal string NameShort { get; set; }
   internal string NameFull { get; set; }
   internal string Inn { get; set; }
   internal string Acc { get; set; }
    internal Bank Bank{get; set;}
    internal Address AddrMail { get; set; }
    internal Address AddrLoca { get; set; }
    internal Address AddrRegi { get; set; }
   public string NameForConract()
   {
     string ContractString = NameFull + "\nИНН " + Inn +"\nСчёт " + Acc+ "\nБИК " + Bank.BIK + "\n" +Bank.Name + "\nКор. счёт " + Bank.CorAcc;
     return ContractString;
   }
  }
}
