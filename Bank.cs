using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contract
{
  [Serializable]
  public class Bank
  {   
    internal string BIK { get; set; }
    internal string CorAcc { get; set; }
    internal string Name { get; set; }
  }
}
