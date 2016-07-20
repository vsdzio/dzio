using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Contract
{
  public  enum ePayType { арендная_плата, пени, субаренда, фактическое_использование, }
    //Периодичность внесения платежей
  public enum eFreq { ежегодно = 1, раз_в_полугодие = 2, ежеквартально = 4, ежемесячно = 12, }
    //какого периода относительно текущего
  public enum eDueOffset { предыдущего = -1, текущего = 0, следующего = 1, }
    //Сколько месяцев от начала текущего периода
  public enum eDueDuration { месяца = 1, квартала = 3, полугодия = 6, года = 12, }

    [Serializable]
    public class Contract
    {
      int Id { get; set; }
      string Nom { get; set; }
      DateTime dSig { get; set; }
      DateTime dBeg { get; set; }
      DateTime dEnd { get; set; }
      DateTime dGos { get; set; }
      DateTime dBrk { get; set; }

      static List<Subscriber> Subscribers = new List<Subscriber>();
      static List<Period> Periods = new List<Period>();
      static List<Plan> Plans = new List<Plan>();
      static List<Fact> Facts = new List<Fact>();
      static List<Post> Posts = new List<Post>();
      static List<Sald> Salds = new List<Sald>();
      static List<Result> Pesults = new List<Result>();
      static List<Act> Acts = new List<Act>();

      BindingSource bsSubscrList = new BindingSource();
      BindingSource bsPeriodsList = new BindingSource();
      BindingSource bsPlansList = new BindingSource();
      BindingSource bsFactsList = new BindingSource();
      BindingSource bsPostsList = new BindingSource();
      BindingSource bsSaldsList = new BindingSource();
      BindingSource bsResultsList = new BindingSource();
      BindingSource bsActsList = new BindingSource();


      BindingList<Subscriber> blSubscribersList = new BindingList<Subscriber>(Subscribers);
      BindingList<Period> blPeriodsList = new BindingList<Period>(Periods);
      BindingList<Plan> blPlansList = new BindingList<Plan>(Plans);
      BindingList<Fact> blFactsList = new BindingList<Fact>(Facts);
      BindingList<Post> blPostsList = new BindingList<Post>(Posts);
      BindingList<Sald> blSaldsList = new BindingList<Sald>(Salds);
      BindingList<Result> blResultsList = new BindingList<Result>(Pesults);
      BindingList<Act> blActsList = new BindingList<Act>(Acts);
      public Contract()
      {
        LoadContract();
      }

      void LoadContract()
      {
        bsSubscrList.DataSource = blSubscribersList;
        bsPeriodsList.DataSource = blPeriodsList;
        bsPlansList.DataSource = blPlansList;
        bsFactsList.DataSource = blFactsList;
        bsPostsList.DataSource = blPostsList;
        bsSaldsList.DataSource = blSaldsList;
        bsResultsList.DataSource = blResultsList;
        bsActsList.DataSource = blActsList;
      }
      public void Init(string p_CNo, DateTime p_DSig, DateTime p_DBeg, DateTime p_DEnd, decimal p_PaySize, eFreq p_freq, DateTime p_firstDdue)
      {
        dBeg = p_DBeg;
        dSig = p_DSig;
        dEnd = p_DEnd;
        Nom = p_CNo;
        //TODO Find In Database

        Period p = new Period();
        p.dBeg = dBeg;
        p.dEnd = dEnd;
        p.PaySize = p_PaySize;
        p.Ptype = ePayType.арендная_плата;
        p.FirstDdue = p_firstDdue;
        p.Freq = p_freq;
        Periods.Add(p);

        Plans = p.PlanList;
      }

      public void ChangePeriodData() { }
      public void AddChangesToPeriod() { }
    }
}
