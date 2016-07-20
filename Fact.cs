using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contract
{
  [Serializable]
  class Fact
  {
    int ContractId { get; set; }
    int SubScriberId { get; set; }
    decimal PayedSize { get; set; }
    ePayType PayType { get; set; }
    DateTime DatePost { get; set; }
  }
}
