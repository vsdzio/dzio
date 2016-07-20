using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contract
{
[Serializable]
  class Period
  {
  internal int Id { get; set; }
  internal int ContractId { get; set; }
  internal int SubScriberId { get; set; }
  internal DateTime dBeg { get; set; }
  internal DateTime dEnd { get; set; }
  internal DateTime FirstDdue { get; set; }
  internal Decimal PaySize { get; set; }
  internal ePayType Ptype { get; set; }
  internal eFreq Freq { get; set; }

  internal List<Plan> PlanList { get{ return FilledPlan(dBeg, dEnd, PaySize, Freq, FirstDdue); } }

  private List<Plan> FilledPlan(DateTime p_dBeg, DateTime p_dEnd, decimal p_PaySize, eFreq p_freq, DateTime p_firstDdue)
  {
    int MonthCount = (p_dEnd.Year - p_dBeg.Year) * 12 - (p_dEnd.Month - p_dBeg.Month);
    List<Plan> plan = new List<Plan>();
    Plan p = new Plan();
    for (int i = 0; i < MonthCount; i++)
    {

      if (i.Equals(0))
      {
        p.dBeg = p_dBeg;
        p.dEnd = p.dBeg.AddDays(-p.dBeg.Day).AddDays(DateTime.DaysInMonth(p.dBeg.Year, p.dBeg.Month));        
        SetPaySizaCalc(p_PaySize, p);
      }
      if (i < MonthCount)
      {
        p.dBeg = p.dBeg.AddMonths(i).AddDays(1 - DateTime.DaysInMonth(p.dBeg.AddMonths(1).Year, p.dBeg.AddMonths(1).Month));
        p.dEnd = p.dBeg.AddMonths(1).AddDays(1 - DateTime.DaysInMonth(p.dBeg.AddMonths(1).Year, p.dBeg.AddMonths(1).Month));
        p.PaySizeFull = p_PaySize;

        SetPaySizaCalc(p_PaySize, p);
      }

      if (i.Equals(MonthCount))
      {
        p.dBeg = p.dBeg.AddMonths(i).AddDays(1 - DateTime.DaysInMonth(p.dBeg.AddMonths(1).Year, p.dBeg.AddMonths(1).Month));
        p.dEnd = p_dEnd;
       
        SetPaySizaCalc(p_PaySize, p);  
      }

        p.dDue = p_firstDdue.AddMonths(12 / (int)p_freq);         
        if (p.dDue.DayOfWeek.Equals(DayOfWeek.Sunday)) p.dDue = p.dDue.AddDays(1);
        if (p.dDue.DayOfWeek.Equals(DayOfWeek.Saturday)) p.dDue = p.dDue.AddDays(2);

      plan.Add(p);
    }
    return plan;
  }

  private static void SetPaySizaCalc(decimal p_PaySize, Plan p)
  {
    TimeSpan interval = p.dEnd - p.dBeg;
    p.Days = interval.Days;
    p.kfxDays = Math.Round((decimal)p.Days / (decimal)DateTime.DaysInMonth(p.dBeg.Year, p.dBeg.Month),4);
    p.PaySizeCalc = Math.Round(p_PaySize * p.kfxDays,2, MidpointRounding.ToEven);
    p.PaySizeFull = p_PaySize;
  }
  


  }
}
