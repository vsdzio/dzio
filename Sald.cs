using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contract
{
  [Serializable]
  class Sald
  {
    int ContractId { get; set; }
    int SubScriberId { get; set; }
    int Yno { get; set; }
    int Mno { get; set; }
    decimal PlanBeg { get; set; }
    decimal FactBeg { get; set; }
    decimal PenyBeg { get; set; }
    decimal PlanNow { get; set; }
    decimal FactNow { get; set; }
    decimal PenyFactNow { get; set; }
    decimal PlanEnd { get; set; }
    decimal FactEnd { get; set; }
    decimal PenyEnd { get; set; }
  }
}
