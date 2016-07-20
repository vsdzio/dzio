using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contract
{
  [Serializable]
  class Post
  {
    int ContractId { get; set; }
    int SubScriberId { get; set; }int Yno { get; set; }
    int Mno { get; set; }
    int IsClosed { get; set; }
    DateTime DatePost { get; set; }
    decimal Plan { get; set; }
    decimal Fact { get; set; }
    decimal PlanCorr { get; set; }
    decimal FactCorr { get; set; }
  }
}
