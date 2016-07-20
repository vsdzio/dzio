using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contract
{
  [Serializable]
  class Address
  {
    internal string Region { get; set; }
    internal string Town { get; set; }
    internal string District { get; set; }
    internal string Place { get; set; }
    internal string Street { get; set; }
    internal int HouseNo { get; set; }
    internal int Slash { get; set; }
    internal string Alpha { get; set; }
    internal string Flat { get; set; }
    internal string MailIndex { get; set; }

    internal string MailString
    {
      get
      {
        string retString = string.Empty;
        retString = (string.IsNullOrEmpty(HouseNo.ToString()) ? string.Empty : "д." + HouseNo.ToString());
        retString += (string.IsNullOrEmpty(Alpha) ? string.Empty : Alpha);
        retString += (string.IsNullOrEmpty(Slash.ToString()) ? string.Empty : "/" + Slash.ToString());
        retString += (string.IsNullOrEmpty(Flat) ? string.Empty : ", кв."+Flat);
        retString += (string.IsNullOrEmpty(Town) ? string.Empty : ", \n" + Town);
        retString += (string.IsNullOrEmpty(District) ? string.Empty :  ", \n" +District + " р-н");
        retString += (string.IsNullOrEmpty(Place) ? string.Empty : " (" + Place + ")");
        retString += (string.IsNullOrEmpty(Region) ? ", \n" +string.Empty : Region);
        retString += (string.IsNullOrEmpty(MailIndex) ? string.Empty : ", \n" + MailIndex);
        return retString;
      }
    }
  }
}
