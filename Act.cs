using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contract
{
  [Serializable]
  class Act
  {
    int ContractId { get; set; }
    int SubScriberId { get; set; }
    DateTime OnDate { get; set; }
    decimal Plan { get; set; }
    decimal Fact { get; set; }
    decimal Debt { get; set; }
    int Days { get; set; }
    decimal PenyProc { get; set; }
    string CalcPenyString { get; set; }
    decimal Peny { get; set; }
    decimal PlanItogo { get; set; }
    decimal FactItogo { get; set; }
    decimal PenyItogo { get; set; }

  }
}
