/*
 * Your rights to use code governed by this license https://github.com/AlexWan/OsEngine/blob/master/LICENSE
 * Ваши права на использование кода регулируются данной лицензией http://o-s-a.net/doc/license_simple_engine.pdf
*/

using OsEngine.Charts.CandleChart.Indicators;
using OsEngine.Entity;
using OsEngine.Indicators;
using OsEngine.Language;
using OsEngine.Market;
using OsEngine.Market.Servers;
using OsEngine.Market.Servers.Tester;
using OsEngine.Market.Servers.TraderNet.Entity;
using OsEngine.Market.Servers.YahooFinance.Entity;
using OsEngine.OsTrader.Panels;
using OsEngine.OsTrader.Panels.Attributes;
using OsEngine.OsTrader.Panels.Tab;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using System.Windows.Forms;
using TL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace OsEngine.Robots.Screeners
{
    [Bot("PumpDetectorScreener")]
    public class PumpDetectorScreener : BotPanel
    {
        private BotTabScreener _tabScreener;
       // public StrategyParameterDecimal MaxPoses100;
      //  public StrategyParameterDecimal MaxPoses100S;
      //  public StrategyParameterDecimal MaxPoses100L;
        public StrategyParameterString Regime;

        public StrategyParameterInt MaxPositions;
        public StrategyParameterDecimal MaxPositionsls;
        public StrategyParameterInt MaxPositions1;
        public StrategyParameterInt MaxPositionsL;
        public StrategyParameterInt MaxPositionsS;
        public StrategyParameterInt MaxPositionsL1;
        public StrategyParameterInt MaxPositionsS1;
        public StrategyParameterInt MaxPositionsL2;
        public StrategyParameterInt MaxPositionsS2;
        public StrategyParameterInt MaxPositionsL3;
        public StrategyParameterInt MaxPositionsS3;
        public StrategyParameterInt MaxPositionsLt;
        public StrategyParameterInt MaxPositionsSt;

        public StrategyParameterInt SecondsToAnalyze;

        //public StrategyParameterDecimal MoveToEntry;
     //   public StrategyParameterDecimal MoveToEntryV;
      //  public StrategyParameterDecimal MoveToEntry1;
       // public StrategyParameterDecimal Voll;
        public StrategyParameterString VolumeType;

        public StrategyParameterDecimal Volume;
        public StrategyParameterDecimal Volume1;

        public StrategyParameterString TradeAssetInPortfolio;

        public StrategyParameterDecimal ProfitPercent;
        public StrategyParameterDecimal ProfitPercentr;
        public StrategyParameterDecimal ProfitPercent1;

        public StrategyParameterDecimal StopPercent;
        public StrategyParameterDecimal StopPercentl;
        public StrategyParameterDecimal StopPercent1;
        public StrategyParameterDecimal macd41;
        public StrategyParameterDecimal macd411;
        public StrategyParameterDecimal macd42;
        public StrategyParameterDecimal macd43;
       // public StrategyParameterDecimal Profit11min;
        public StrategyParameterDecimal Stop11min;
        public StrategyParameterDecimal Profit11;
        public StrategyParameterDecimal Profit1100;
       // public StrategyParameterDecimal Profit111;
        public StrategyParameterDecimal Profit1111;
       // public StrategyParameterDecimal Stop11;
        public StrategyParameterDecimal Profit11min1;
        public StrategyParameterDecimal Profit11min1b;
        public StrategyParameterDecimal Profit11min10;
        public StrategyParameterDecimal Profit11min10p;
        public StrategyParameterDecimal Stop11min1;
        //  public StrategyParameterDecimal Profit11min2;
        //  public StrategyParameterDecimal MaxPoses1002min;

        public StrategyParameterInt MaxPoses10b;
        public StrategyParameterInt MaxPoses10;
        public StrategyParameterInt MaxPoses10s;

        public StrategyParameterBool SmaFilterIsOn;
       // public StrategyParameterDecimal SmaFilterIsOn22;
      //  public StrategyParameterDecimal SmaFilterIsOn22k;
      //  public StrategyParameterDecimal SmaFilterIsOn33;
      //  public StrategyParameterDecimal SmaFilterIsOn333;
      //  public StrategyParameterDecimal SmaFilterIsOn2222;
      //  public StrategyParameterDecimal SmaFilterIsOn3333;

      //  public StrategyParameterDecimal SmaFilterIsOn332;
       // public StrategyParameterBool SmaFilterIsOn1;
        //public StrategyParameterBool SmaFilterIsOn11;
     //   public StrategyParameterBool SmaFilterIsOn110;
        public StrategyParameterBool SmaFilterIsOn2;
      //  public StrategyParameterBool SmaFilterIsOn2V;
      //  public StrategyParameterBool SmaFilterIsOn2Z;
      //  public StrategyParameterBool SmaFilterIsOn20;
        public StrategyParameterBool SmaFilterIsOn30;
       // public StrategyParameterBool SmaFilterIsOn31;
     //   public StrategyParameterBool SmaFilterIsOn12;
      //  public StrategyParameterBool SmaFilterIsOn120;
        //public StrategyParameterBool SmaFilterIsOn100;
        public StrategyParameterBool SmaFilterIsOn200;
        public StrategyParameterBool SmaFilterIsOn200STREND;
        public StrategyParameterBool SmaFilterIsOn2000;
        public StrategyParameterBool SmaFilterIsOn300;
        public StrategyParameterBool SmaFilterIsOn300macd;
        public StrategyParameterBool SmaFilterIsOn300macd2;
      //  public StrategyParameterBool SmaFilterIsOn300b;
        public StrategyParameterBool SmaFilterIsOn300bb;
        public StrategyParameterBool SmaFilterIsOn300bbb;
        public StrategyParameterBool SmaFilterIsOn300s;
        public StrategyParameterBool SmaFilterIsOn300ar;
        public StrategyParameterBool SmaFilterIsOn300l;
        public StrategyParameterBool SmaFilterIsOn300k;
        // public StrategyParameterBool SmaFilterIsOn2000B;
        public StrategyParameterBool SmaFilterIsOn2001;
        public StrategyParameterBool SmaFilterIsOn2001p;
        public StrategyParameterBool SmaFilterIsOn2000pl;
        public StrategyParameterBool SmaFilterIsOn20012;
        public StrategyParameterBool SmaFilterIsOn20002;
        public StrategyParameterBool SmaFilterIsOn20002p;
        public StrategyParameterBool SmaFilterIsOn2002;
        public StrategyParameterBool SmaFilterIsOn2002p;
        //public StrategyParameterBool SmaFilterIsOn201;
       // public StrategyParameterBool SmaFilterIsOn2011;
       // public StrategyParameterBool SmaFilterIsOn20112;
        // public StrategyParameterBool SmaFilterIsOn201S;
       // public StrategyParameterBool SmaFilterIsOn10;
       // public StrategyParameterBool SmaFilterIsOn1010;
       // public StrategyParameterBool SmaFilterIsOn1000;
       // public StrategyParameterBool SmaFilterIsOn1001;
       // public StrategyParameterBool SmaFilterIsOnSD;
     //   public StrategyParameterBool SmaFilterIsOnSP;
      //  public StrategyParameterBool SmaFilterIsOnSB;
       // public StrategyParameterBool SmaFilterIsOnSPR;

        public StrategyParameterInt SmaFilterLen;
        public StrategyParameterInt SmaFilterLen1;
     //   public StrategyParameterBool SmaFilterIsOn3;
       // public StrategyParameterBool SmaFilterIsOnsar;
      //  public StrategyParameterBool SmaFilterIsOnSMA;
      //  public StrategyParameterBool SmaFilterIsOnSMAP;
     //   public StrategyParameterDecimal SmaFilterLenup;
       // public StrategyParameterDecimal SmaFilterLendown;

      //  public StrategyParameterDecimal macd;
      //  public StrategyParameterDecimal macd10;
        public StrategyParameterDecimal macd2;
        public StrategyParameterDecimal macd22;
        public StrategyParameterDecimal macd220;
      //  public StrategyParameterDecimal macd0;
        public StrategyParameterDecimal macdsar;
        public StrategyParameterDecimal macdsarv;
        public StrategyParameterDecimal macdsarvb;
        public StrategyParameterDecimal macdsarVOL;
        public StrategyParameterDecimal macdsarvolst;
        public StrategyParameterDecimal macd1;
       // public StrategyParameterDecimal macd3;
      //  public StrategyParameterDecimal macd3d;
        public StrategyParameterDecimal macd44;
        public StrategyParameterDecimal macd45;
        //  private Aindicator _volatilityStagesOnIndex;
        public StrategyParameterDecimal StopMult;
        public StrategyParameterDecimal Stop;
        public StrategyParameterDecimal Stopst;
        public StrategyParameterDecimal Stopvl;
        // public StrategyParameterDecimal StopMult1;
        // public StrategyParameterDecimal StopMult2;
        // public StrategyParameterDecimal StopMult3;
       // public StrategyParameterDecimal mm;
        public StrategyParameterDecimal Profit12;
        //public StrategyParameterDecimal Stop12;
        public StrategyParameterDecimal macdd6;
      //  public StrategyParameterDecimal macd20;
      //  public StrategyParameterDecimal macd3332;
       // public StrategyParameterDecimal macd333;
        public StrategyParameterDecimal macdd6K;
        public StrategyParameterDecimal macdd6V;
       // public StrategyParameterDecimal macdd6V1;
        //public StrategyParameterDecimal macdd6V11;
       // public StrategyParameterDecimal macd100;
        //public StrategyParameterDecimal macd1010;
        public StrategyParameterDecimal funding;
      //  public StrategyParameterDecimal macd101010;
       // public StrategyParameterDecimal macd10;
        public StrategyParameterDecimal macd400;
        public StrategyParameterDecimal macd401;
        //public StrategyParameterDecimal macd1000;
       // public StrategyParameterDecimal macd1000P;
       // public StrategyParameterDecimal macd101;
        public StrategyParameterDecimal MaxPositions0;
       // public StrategyParameterInt MaxPoses0;
      //  public StrategyParameterDecimal MaxPoses110;
       // public StrategyParameterDecimal MaxPoses111;
       // public StrategyParameterInt MaxPoses0S;
        public StrategyParameterDecimal MaxPoses700000;
        public StrategyParameterDecimal MaxPoses800000;
        public StrategyParameterDecimal MaxPoses800000t;
        //public StrategyParameterDecimal MaxPoses70000;
        public StrategyParameterDecimal Profit11min1K;
        public StrategyParameterDecimal Profit1100b;
        public StrategyParameterDecimal Profit11min1Kt;
        public StrategyParameterDecimal Profit11min1Ktp;
        public StrategyParameterDecimal Profit11min1Kb;
        public StrategyParameterDecimal Profit11min1Kbs;
        public StrategyParameterDecimal Profit11min1K20;
        public StrategyParameterDecimal Profit11min20;
        public StrategyParameterDecimal Profit11min1K11;
        public StrategyParameterDecimal Profit11min1max;
       // public StrategyParameterDecimal Profit11min1S;
        public StrategyParameterDecimal Stop11min1K;
        public StrategyParameterDecimal ProfitLong;
        public StrategyParameterDecimal ProfitShort;
        public StrategyParameterDecimal macdv;
        public StrategyParameterDecimal macdvmax;
        //  private StrategyParameterInt _clusterToTrade;
        //  private StrategyParameterInt _clustersLookBack;
        // private VolatilityStageClusters _volatilityStageClusters = new VolatilityStageClusters();
       // private StrategyParameterInt _secToAnalysis;
       // private DateTime _lastTimeSetClusters;
        public PumpDetectorScreener(string name, StartProgram startProgram) : base(name, startProgram)
        {
            TabCreate(BotTabType.Screener);
            _tabScreener = TabsScreener[0];

            _tabScreener.NewTickEvent += _tabScreener_NewTickEvent;
            _tabScreener.PositionOpeningSuccesEvent += _tabScreener_PositionOpeningSuccesEvent;
            _tabScreener.PositionClosingSuccesEvent += PositionClosingSuccesEvent1;
            // _volatilityStagesOnIndex
            // = IndicatorsFactory.CreateIndicatorByName("VolatilityStagesAW", name + "VolatilityStagesAW", false);
            // _tabScreener.CreateCandleIndicator(1, "VolatilityAverage", new List<string>() {  }, "NewArea");
           // _screenerTab.CreateCandleIndicator(1, "Sma", new List<string>() { _smaLength.ValueInt.ToString(), "Close" }, "Prime");
            _tabScreener.CreateCandleIndicator(1, "VolatilityAverage", null, "Area2");
            _tabScreener.CreateCandleIndicator(2, "Sma", null, "Prime");

            // _aroon = IndicatorsFactory.CreateIndicatorByName("Aroon", name + "Aroon", false);
            //  _aroon = (Aindicator)_tab.CreateCandleIndicator(_aroon, "AroonArea");
            //  ((IndicatorParameterInt)_aroon.Parameters[0]).ValueInt = _aroonLength.ValueInt;
            // _aroon.Save();
           // _tabScreener.CreateCandleIndicator(3, "Aroon", new List<string>() { 14, 70, 70 }, "Prime");

            _tabScreener.CreateCandleIndicator(3, "SuperTrend_indicator", null, "Prime");
            _tabScreener.CreateCandleIndicator(4, "ParabolicPriceChannel_indicator", null, "Prime");
            _tabScreener.CreateCandleIndicator(5, "MACD", null, "NewArea2");
            // Voll = CreateParameter("волатильность сма", 0m, 1, 1000, 1);
            // MaxPoses110 = CreateParameter("ОИ текущий", 0m, 1, 1000, 1);
            // MaxPoses111 = CreateParameter("ОИ -свеча", 0m, 1, 1000, 1);
            //MaxPoses0 = CreateParameter("К-во пвр Long счетчик", 0, 1, 1000, 1);
            // MaxPoses0S = CreateParameter("К-во пвр Short счетчик", 0, 1, 1000, 1);
            MaxPoses10 = CreateParameter("К-во позиций счетчик", 1, 1, 1000, 1);
            //  MaxPoses10 = CreateParameter("К-во позиций счетчик", 1, 1, 1000, 1);
            MaxPoses10b = CreateParameter("К-во позиций Long счетчик", 0, 1, 1000, 1);
            MaxPoses10s = CreateParameter("К-во позиций Short счетчик", 0, 1, 1000, 1);
           // MaxPoses70000 = CreateParameter("Total Profit  abs", 0m, 1m, 1000m, 1m);
            MaxPoses700000 = CreateParameter("Total Profit abs типа журнал", 0m, 1m, 1000m, 1m);
            MaxPoses800000 = CreateParameter("текущий Pnl", 0m, 1m, 1000m, 1m);
            MaxPoses800000t = CreateParameter("режим тестера Pnl0/1", 0m, 1m, 1000m, 1m);
            //   MaxPoses100 = CreateParameter(" текущийпроцент прибыли всехпоз", 0m, 1m, 1000m, 1m);
            //  MaxPoses100L = CreateParameter(" LOng текущийпроцент прибыли всехпоз", 0m, 1m, 1000m, 1m);
            // MaxPoses100S = CreateParameter(" SHort текущийпроцент прибыли всехпоз", 0m, 1m, 1000m, 1m);

            //MaxPoses1002min = CreateParameter("контроль сработаетProfit ", 0m, 1m, 1000m, 1m);
            SmaFilterIsOn = CreateParameter("Sma filter is on", true, "фильтры");

            SmaFilterLen = CreateParameter("Sma filter Len", 5, 100, 300, 10, "фильтры");

           // SmaFilterIsOn1 = CreateParameter("Sma2 белая ввверхвнизfilter is on", false, "фильтры");
         //   SmaFilterIsOn11 = CreateParameter("выше белой is on", false, "фильтры");
          //  SmaFilterIsOn110 = CreateParameter("выше белой is on докупка", false, "фильтры");
           // SmaFilterIsOn12 = CreateParameter("ниже белой is on", false, "фильтры");
           // SmaFilterIsOn120 = CreateParameter("ниже белой докупка is on", false, "фильтры");
           // SmaFilterIsOn3 = CreateParameter("Sma3 filter is on", false, "фильтры");
          //  SmaFilterLenup = CreateParameter("Sma filter огрвверх", 5m, 100, 300, 10, "фильтры");
           // SmaFilterLendown = CreateParameter("Sma filter огрвниз", 0.5m, 100, 300, 10m, "фильтры");


            SmaFilterIsOn2 = CreateParameter("вол filter is on", false, "фильтры");
          //  SmaFilterIsOn2V = CreateParameter("пок по вол вол filter is on", false, "фильтры");
          //  SmaFilterIsOn2Z = CreateParameter("ЗЮКАЛОвол filter is on", false, "фильтры");
           // SmaFilterIsOn22k = CreateParameter("вол filter к-т gокупка по кри зюкало", 0m, 100, 300, 10m, "фильтры");
           // SmaFilterIsOn22 = CreateParameter("вол filter к-т покупка", 0m, 100, 300, 10m, "фильтры");
           // SmaFilterIsOn33 = CreateParameter("вол filter к-т докупка", 0m, 100, 300, 10m, "фильтры");

            //SmaFilterIsOn2222 = CreateParameter("вол00 filter к-т покупка", 0m, 100, 300, 10m, "фильтры");
          //  SmaFilterIsOn3333 = CreateParameter("вол00 filter к-т докупка", 0m, 100, 300, 10m, "фильтры");

         //   SmaFilterIsOn333 = CreateParameter("вол filter к-т докупка по кри зюкало", 0m, 100, 300, 10m, "фильтры");
          //  SmaFilterIsOn332 = CreateParameter("вол2 filter вол докупка", 0m, 100, 300, 10m, "фильтры");

            SmaFilterIsOn30 = CreateParameter("выше красной не покупать", false, "фильтры");
           // SmaFilterIsOn31 = CreateParameter("ниже красной не покупать", false, "фильтры");


           // SmaFilterIsOn20 = CreateParameter("ЗЮ filter is on", false, "фильтры");
          //  macd20 = CreateParameter("ЗЮ волатильность ", 1m, 1m, 1, 100m, "фильтры");

            Regime = CreateParameter("Regime", "Off", new[] { "Off", "On", "OnlyLong", "OnlyShort" });
            macd41 = CreateParameter("фильтрпостоимости макс ", 10m, 1m, 1, 100m, "фильтры");
            macd411 = CreateParameter("фильтрпостоимости мин ", 0m, 1m, 1, 100m, "фильтры");
            macd42 = CreateParameter("проц+", 0m, 1m, 1, 100m);
            macd43 = CreateParameter("проц-", 0m, 1m, 1, 100m);
            macd44 = CreateParameter("фильтрпо волатильности макс ", 0m, 1m, 1, 100m, "фильтры");
            macd45 = CreateParameter("фильтрповолатильности мин ", 3m, 1m, 1, 100m, "фильтры");
            macd400 = CreateParameter("фильтр ОИ покупка ", 1m, 1m, 1, 100m, "фильтры");
            macd401 = CreateParameter("фильтр ОИ докупка ", 1m, 1m, 1, 100m, "фильтры");
            macdv = CreateParameter("фильтр 24 обьемusdt min ", 10000000m, 1m, 1, 100000000000m, "фильтры");
            macdvmax = CreateParameter("фильтр 24 обьемusdt max ", 0m, 1m, 1, 100000000000m, "фильтры");
            // funging = CreateParameter("Значение фандинга для входа в позицию", 0.01m, 0m, 0m, 0m, tabName);
            funding = CreateParameter("макс значение фандинга ", 0.1m, 1m, 1, 100m, "фильтры");
            // funding = CreateParameter("макс значение фандинга ", 0,1m, 1m, 1, 100m, "фильтры");
            // _clusterToTrade = CreateParameter("Volatility cluster to trade", 0, 1, 3, 1);
            // _clustersLookBack = CreateParameter("Volatility cluster lookBack", 100, 10, 300, 1);
            // _secToAnalysis = CreateParameter("секунд to work", 5, 1, 10, 1 "покупка/докупка");
            // _secToAnalysis = CreateParameter("секунд работа", 10, 1, 10, 1 ,"покупка/докупка");
            SecondsToAnalyze = CreateParameter("раз в сколько СЕКУНД работа", 10, 0, 20, 1, "покупка/докупка");
            MaxPositions0 = CreateParameter("максимум поз всего ", 100m, 0, 20, 1, "покупка/докупка");
            MaxPositionsls = CreateParameter("макспозLongилиShort 1 пара ", 3m, 0, 20, 1, "покупка/докупка");
            MaxPositions = CreateParameter("Max positions Long докупка", 50, 0, 20, 1, "покупка/докупка");
            MaxPositions1 = CreateParameter("Max positions Short докупка",50, 0, 20, 1, "покупка/докупка");
            MaxPositionsL = CreateParameter("к-во пар Long покупка текущая", 5, 0, 20, 1, "покупка/докупка");
            MaxPositionsS = CreateParameter("к-во пор Short покупка текущая", 5, 0, 20, 1, "покупка/докупка");
            MaxPositionsLt = CreateParameter("к-во пар Long покупка начальное", 5, 0, 20, 1, "покупка/докупка");
            MaxPositionsSt = CreateParameter("к-во пор Short покупка начальное", 5, 0, 20, 1, "покупка/докупка");
            MaxPositionsL1 = CreateParameter("к-во пар Long покупкауровень1", 5, 0, 20, 1, "покупка/докупка");
            MaxPositionsS1 = CreateParameter("к-во пор Short покупкауровень1", 5, 0, 20, 1, "покупка/докупка");
            MaxPositionsL2 = CreateParameter("к-во пар Long покупкауровень2", 5, 0, 20, 1, "покупка/докупка");
            MaxPositionsS2 = CreateParameter("к-во пор Short покупкауровень2", 5, 0, 20, 1, "покупка/докупка");
            MaxPositionsL3 = CreateParameter("к-во пар Long покупкауровень3", 5, 0, 20, 1, "покупка/докупка");
            MaxPositionsS3 = CreateParameter("к-во пор Short покупкауровень3", 5, 0, 20, 1, "покупка/докупка");
            SmaFilterIsOn2002 = CreateParameter("Покупка  измеряемвол-ть по красной SMA on", false, "покупка/докупка");
            SmaFilterIsOn2001 = CreateParameter("докупка  измеряем  вол-ть по краснойSMA on", false, "покупка/докупка");
            SmaFilterIsOn2001p = CreateParameter("докупка  измеряем  вол-ть по параболик on", false, "покупка/докупка");
            SmaFilterIsOn20012 = CreateParameter("докупка  измеряем вол-тьпокраснойSMAиНижней on", false, "покупка/докупка");
            SmaFilterIsOn2002p = CreateParameter("Покупка  измеряемвол-ть по параболик on", false, "покупка/докупка");



            // macd10 = CreateParameter(" 2поз1пара ", 0m, 1m, 1, 100m, "покупка/докупка");
           // macd = CreateParameter(" Ппамп режим  покупка ", 0m, 1m, 1, 100m, "покупка/докупка");
           // macd3 = CreateParameter(" Ппамп режим  покупка3 ", 0m, 1m, 1, 100m, "покупка/докупка");
        //    macd333 = CreateParameter(" + режим  покупка по вол) ", 0m, 1m, 1, 100m, "покупка/докупка");
           // macd0 = CreateParameter(" + режим  покупка по красной(0-нет/1-да) ", 0m, 1m, 1, 100m, "покупка/докупка");
            //SmaFilterIsOnsar = CreateParameter("фильтр параболикдлякраснойпокуп", false, "покупка/докупка");
            macdsar = CreateParameter(" + режим  покупка параболик(0-нет/1-да) ", 1m, 1m, 1, 100m, "покупка/докупка");
            macdsarv = CreateParameter(" + режим покупка параболик к-твол<>красная ", 0m, 1m, 1, 100m, "покупка/докупка");
            macdsarvb = CreateParameter(" + режим покупка параболик к-твол<>белая", 0m, 1m, 1, 100m, "покупка/докупка");
            macdsarVOL = CreateParameter(" +свечи к-т вол ", 0m, 1m, 1, 100m, "покупка/докупка");
            macdsarvolst = CreateParameter(" +ST к-т вол ", 0m, 1m, 1, 100m, "покупка/докупка");
            SmaFilterIsOn300 = CreateParameter("шип <> красной filter is on", true, "покупка/докупка");
           // SmaFilterIsOn300b = CreateParameter("парабоик счит вх вол вышенижебел", false, "покупка/докупка");
            SmaFilterIsOn300s = CreateParameter("парабоик фильтр <> белая", false, "покупка/докупка");
            SmaFilterIsOn300ar = CreateParameter("парабоик фильтр SuperTrend_indicator", false, "покупка/докупка");
            SmaFilterIsOn300l = CreateParameter("парабоик фильтр пер параболик", false, "покупка/докупка");
            SmaFilterIsOn300k = CreateParameter("парабоик фильтр пер красной", false, "покупка/докупка");
            SmaFilterIsOn300bb = CreateParameter("парабоик фильтр пер белой", false, "покупка/докупка");
            SmaFilterIsOn300bbb = CreateParameter("парабоик фильтр <> белой", false, "покупка/докупка");
            SmaFilterIsOn300macd = CreateParameter("парабоик фильтр macd", true, "покупка/докупка");
            SmaFilterIsOn300macd2 = CreateParameter("парабоик фильтр macd2", false, "покупка/докупка");
           // macd100 = CreateParameter(" + режим  покупка/докупка зюкало) ", 0m, 1m, 1, 100m, "покупка/докупка");
           // macd3332 = CreateParameter("+ фильтр ДЛЯ покупка по волFALSE) ", 0m, 1m, 1, 100m, "покупка/докупка");
            
            //SmaFilterIsOn201 = CreateParameter("<>candles-3close к пок по вол filter is on", true, "покупка/докупка");
           
          //  macd3d = CreateParameter(" отбитие для  покупка3 вол труе", 0m, 1m, 1, 100m, "покупка/докупка");
          //  SmaFilterIsOn2011 = CreateParameter("<>candles-3close к памп3 filter is on", true, "покупка/докупка");
           // SmaFilterIsOn20112 = CreateParameter("фильтр синяя вол памп3 и вол filter is on", false, "покупка/докупка");
            // SmaFilterIsOn201S = CreateParameter("<>candles-3close SHORT к пок по вол filter is on", false, "покупка/докупка");
           
          //  SmaFilterIsOn1000 = CreateParameter(" режим  зюкало только'хэджирование", false, "покупка/докупка");
           // SmaFilterIsOn1001 = CreateParameter(" режим  красная только'хэджирование", false, "покупка/докупка");
           // SmaFilterIsOn10 = CreateParameter("+ режим  покупка зюкало Short", true, "покупка/докупка");
           // SmaFilterIsOn100 = CreateParameter("+ режим  покупка красная Short", true, "покупка/докупка");
           // SmaFilterIsOn1010 = CreateParameter("+ режим  покупка вол Long", true, "покупка/докупка");
           // macd1000 = CreateParameter(" + режим  покупка ЗЮ) ", 0m, 1m, 1, 100m, "покупка/докупка");
            //macd1000P = CreateParameter("ЗЮ мин процент синей) ", 20m, 1m, 1, 100m, "покупка/докупка");
            
            macd2 = CreateParameter(" шорт  допокупка ", 1m, 1m, 1, 100m, "покупка/докупка");
            macd22 = CreateParameter(" РЕЖИМ   АВТО ", 0m, 1m, 1, 100m, "покупка/докупка");
            macd220 = CreateParameter(" РЕЖИМ   К-ВО ПОК авто", 2m, 1m, 1, 100m, "покупка/докупка");

            macd1 = CreateParameter("3солдата режим  покупка ", 0m, 1m, 1, 100m, "фильтры");
            
         //   SmaFilterIsOnSP = CreateParameter("покупка изм вол-ть по верх красным on", false, "покупка/докупка");
          //  SmaFilterIsOnSD = CreateParameter("докупка изм вол-ть по верх красным on", false, "покупка/докупка");
           // SmaFilterIsOnSB = CreateParameter("докупка  изм вол-ть по белой on", false, "покупка/докупка");
          //  SmaFilterIsOnSMAP = CreateParameter("режим покупка по вол filter белая SMA is on", false, "покупка/докупка");
          //  SmaFilterIsOnSMA = CreateParameter("режим докупка по вол filter белая SMA is on", false, "покупка/докупка");
            macdd6 = CreateParameter("  режим  допокупка по проценту ", 0m, 1m, 1, 100m, "покупка/докупка");
            macdd6K = CreateParameter("  режим  допокупка красная ", 0m, 1m, 1, 100m, "покупка/докупка");
            macdd6V = CreateParameter("  режим  допокупка по вол ", 0.5m, 1m, 1, 100m, "покупка/докупка");
            SmaFilterIsOn200 = CreateParameter("<>candles-3close к док по вол filter is on", false, "покупка/докупка");
            //SmaFilterIsOn200STREND = CreateParameter("SUPERTREND по вол filter is on", true, "покупка/докупка");
            // macdd6V1 = CreateParameter("  режим  допокупка по вол1 ", 1m, 1m, 1, 100m, "покупка/докупка");
            //  macdd6V11 = CreateParameter(" вол1 к-т>< докупки", 1m, 1m, 1, 100m, "покупка/докупка");
           // macd101 = CreateParameter(" + режим  докупка зюкало) ", 0m, 1m, 1, 100m, "покупка/докупка");
          //  macd1010 = CreateParameter(" + режим  докупка ЗЮ) ", 0m, 1m, 1, 100m, "покупка/докупка");
           // macd10= CreateParameter(" памп3 режим  докупка ) ", 0m, 1m, 1, 100m, "покупка/докупка");
           // macd101010 = CreateParameter("расстояние до докупки пампрежимдокупка ) ", 0m, 1m, 1, 100m, "покупка/докупка");

            
          //  MoveToEntryV = CreateParameter("Move to entry по вол", 1m, 0, 20, 1, "покупка/докупка");
           // MoveToEntry = CreateParameter("Move to entry", 1m, 0, 20, 1, "покупка/докупка");
           // MoveToEntry1 = CreateParameter("Move to entry внизхыост", 1m, 0, 20, 1, "покупка/докупка");
          //  mm = CreateParameter("множитель ", 3m, 1m, 1, 100m, "покупка/докупка");

            VolumeType = CreateParameter("Volume type", "Contract currency", new[] { "Contracts", "Contract currency", "Deposit percent" });

            Volume = CreateParameter("Volume", 20, 1.0m, 50, 4);
            Volume1 = CreateParameter("Volumeдокупка множитель  ", 1.1m, 1.0m, 50, 4);

            TradeAssetInPortfolio = CreateParameter("Asset in portfolio", "Prime");
            SmaFilterIsOn2000 = CreateParameter("профит  безубыток изм вол по краснымSMA on", false, "профит/стоп");
            SmaFilterIsOn20002 = CreateParameter("профит  безубыток изм вол по SMAиНижней on", false, "профит/стоп");
            SmaFilterIsOn20002p = CreateParameter("профит  линияреал изм вол по параболик", false, "профит/стоп");

            ProfitPercent = CreateParameter("Profit вол линия", 1m, 0, 20, 1m, "профит/стоп");
            ProfitPercentr = CreateParameter("Profit вол линия реал", 0.9m, 0, 20, 1m, "профит/стоп");
            SmaFilterIsOn2000pl = CreateParameter("вол линия реал on", false, "профит/стоп");
           

            StopPercent = CreateParameter("Stop вол линия шорт", 20m, 0, 20, 1m, "профит/стоп");
            StopPercentl = CreateParameter("Stop вол линия лонг", 20m, 0, 20, 1m, "профит/стоп");
            Stopvl = CreateParameter("Stop вол линия повол", 0m, 0, 20, 1m, "профит/стоп");
            Stop = CreateParameter("TRALINGtop параболик(процент)", 0m, 0, 20, 1m, "профит/стоп");
            Stopst = CreateParameter("stop ST", 0m, 0, 20, 1m, "профит/стоп");


            //  StopPercent1 = CreateParameter("Stop пр свечке", 0m, 0, 20, 1m);

            // Profit11min = CreateParameter("Profit  позиций всех откр пар", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            //  Stop11min = CreateParameter("Stop  позиций всех откр пар", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            //  ProfitLong = CreateParameter("Profit Long позиций всех откр пар", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            // ProfitShort = CreateParameter("Profit Short позиций всех откр пар", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min10 = CreateParameter("ProfitLongна1откр поз$поPNL ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min10p = CreateParameter("значениеPNL когда сработает профит", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min1K11 = CreateParameter(" PNL КОНТРОЛЬ ТЕКУЩИЙ  ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
           
            Profit11min1 = CreateParameter("ProfitLong всехоткрпар эквити absolute(%отСтавки) ", 10m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min1max = CreateParameter("огранmin поз сраб Profitэквити absolute ", 3m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min1K = CreateParameter("Profit  эквити КОНТРОЛЬ ТЕКУЩИЙ ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min1Kt = CreateParameter("эквити ТЕКУЩая ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min1Ktp = CreateParameter("Profit эквити предыдущийКОНТРОЛЬ ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Stop11min1 = CreateParameter("StopLong всехоткрпар эквити absolute ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Stop11min1K = CreateParameter("StopLong  контроль эквити absolute ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min1b = CreateParameter(" Profit всехпар эквити absolute побиржев$ ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min1Kb = CreateParameter("ProfitLong сработает профит биржа ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min1Kbs = CreateParameter("ProfitLong текущий сейчас биржа", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            // Profit11min1S = CreateParameter(" Profit или шорт или лонгэквити absolute ", 0m, 0.5m, 5, 0.1m, "профит/стоп");

            Profit11min20 = CreateParameter("ProfitLong всехоткрпар эквити absolute доб пар ", 20m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11min1K20 = CreateParameter("ProfitLong эквити КОНТРОЛЬ ТЕКУЩИЙ добпар ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
           
           // Profit111 = CreateParameter("трал  Long по красной", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            
            //SmaFilterIsOn2000B = CreateParameter("профит безубыток изм вол по белой on", false, "профит/стоп");
           // SmaFilterIsOnSPR = CreateParameter("профит безубыток изм вол верх кр ",false , "профит/стоп");
            Profit1111 = CreateParameter("к-т Profit лонг/шорт БЕЗУБЫТОК СВЕЧИПОВОЛ", 1.5m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit1100 = CreateParameter("ProfitЗЮ по вол перес красной ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit1100b = CreateParameter("ProfitЗЮ по вол перес краснойсвечи ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit11 = CreateParameter("Profit БЕЗУБЫТОК СВЕЧИ ПО ВОЛ реалтайм ", 2m, 0.5m, 5, 0.1m, "профит/стоп");
           // Stop11 = CreateParameter("Stop Long красная", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            Profit12 = CreateParameter("Profit БЕЗУБЫТОК СВЕЧИ ПО ВОЛ", 2m, 0.5m, 5, 0.1m, "профит/стоп");
          //  Stop12 = CreateParameter("Stop  СВЕЧИПОВОЛ", 0m, 0.5m, 5, 0.1m, "профит/стоп");
            // Profit11min1 = CreateParameter("трейлинг позиции", 0m, 0.5m, 5, 0.1m);
            StopMult = CreateParameter("трал профита безубыток в вол,0-неттрала", 0.1m, 0.1m, 5, 0.1m, "профит/стоп");
            //  StopMult1 = CreateParameter(" Stop mult1 тралА ПО ТИКАМ 0-нет трала", 0m, 0.1m, 5, 0.1m, "профит/стоп");
            // StopMult2 = CreateParameter(" Profit mult1 тралА ПО ТИКАМ 0-нет трала", 0m, 0.1m, 5, 0.1m, "профит/стоп");
            // StopMult3 = CreateParameter("Stop mult трала по н красной,если 0-нет трала", 0.1m, 0.1m, 5, 0.1m, "профит/стоп");
            // ProfitPercent1 = CreateParameter("Profit множителб", 1.5m, 0, 20, 1m, "профит/стоп");
            // Profit11min2 = CreateParameter("трейлинг позиции  Sma", 0m, 0.5m, 5, 0.1m);
            // SmaFilterLen1 = CreateParameter("Sma трейлинг Len", 50, 100, 300, 10);
            //Profit11min2 = CreateParameter("трейлинг позиции", 0m, 0.5m, 5, 0.1m);

            Description = OsLocalization.Description.DescriptionLabel93;

            if (startProgram == StartProgram.IsTester)
            {
                List<IServer> servers = ServerMaster.GetServers();

                if (servers != null
                    && servers.Count > 0
                     && servers[0].ServerType == ServerType.Tester)
                {
                    TesterServer server = (TesterServer)servers[0];
                    server.TestingStartEvent += Server_TestingStartEvent;
                }
            }
        }
        private void Server_TestingStartEvent()
        {
            _checkMoveTimes.Clear();
        }
        /*
        private void Server_TestingStartEvent()
        {
            _checkMoveTimes.Clear();
        }
        */
        public override string GetNameStrategyType()
        {
            return "PumpDetectorScreener";
        }

        public override void ShowIndividualSettingsDialog()
        {

        }
        void PositionClosingSuccesEvent1(Position positions, BotTabSimple tab)
        {
          //  int z0 = tab.Securiti.DecimalsVolume;
           // decimal contractPrice = tab.PriceBestAsk;
           // decimal volume = decimal.Round(positions.OpenVolume / contractPrice, z0);
            // volume = Volume.ValueDecimal / contractPrice;


            // volume = Math.Round(volume, 6);
            // int z0 = tab.Securiti.DecimalsVolume;
            // volume = decimal.Round(volume, z0);


           //decimal Profit11min11 = Volume * Profit11min1.ValueDecimal / 100;
           // Profit11min1K.ValueDecimal = Profit11min1Ktp.ValueDecimal + Profit11min11;

            //List<Position> position = tab.PositionsOpenAll;
            // Lastintro02.ValueDecimal = 1;

            //if (MaxPosesS.ValueDecimal != 0)
            //{
            // MaxPoses0S.ValueInt = MaxPoses0.ValueInt;

            //MaxPoses.ValueInt --;
            //if (MaxPoses.ValueInt <= MaxPosesS1.ValueInt)
            // {
            //  MaxPositionsCount.ValueInt = MaxPosesmin.ValueInt;
            //  MaxPoses22.ValueDecimal = 0;
            // Volume0.ValueDecimal = Volume.ValueDecimal;

            MaxPositionsS.ValueInt = MaxPositionsSt;
            MaxPositionsL.ValueInt = MaxPositionsLt;

            // }




            // }



        }
        // trade logic

        // private List<CheckMoveTime> _checkMoveTimes = new List<CheckMoveTime>();
        /*
        private void LogicOpenPosition(List<Candle> candlesSecurity,Trade newTrade, BotTabSimple tab)
        {
           // List<Candle> candlesSecurity = tab.CandlesFinishedOnly;
            
        */
        /*
        private void LogicClosePositionD(List<Candle> candlesSecurity,Trade newTrade, BotTabSimple tab)
        {

            

        }
        */
        /*
        private void LogicClosePositionR ()
        {
            

        }
        */
        /*
        private void LogicOpenPosition(List<Candle> candlesSecurity, Trade newTrade, BotTabSimple tab)
        {
            


        }
        */
        private Dictionary<string, CheckMoveTime> _checkMoveTimes = new Dictionary<string, CheckMoveTime>();
        private void _tabScreener_NewTickEvent(Trade newTrade, BotTabSimple tab)
        {



            
            if (tab.IsConnected == false
                || tab.IsReadyToTrade == false)
            {
                return;
            }
            CheckMoveTime myTime = null;

            if (_checkMoveTimes.TryGetValue(tab.Connector.SecurityName, out myTime) == false)
            {
                myTime = new CheckMoveTime();
                myTime.SecName = tab.Connector.SecurityName;
                _checkMoveTimes.Add(tab.Connector.SecurityName, myTime);
            }

            if (myTime.LastCheckTime.AddSeconds(SecondsToAnalyze.ValueInt) >= newTrade.Time)
            {
                return;
            }

            myTime.LastCheckTime = newTrade.Time;
            List<Trade> trades = tab.Trades;

            if (tab.Trades == null)
            {
                return;
            }
            if (newTrade.Price == 0)
            {
                return;
            }
            if (macd41.ValueDecimal != 0 && newTrade.Price > macd41.ValueDecimal)
            {
                return;
            }
            if (macd411.ValueDecimal != 0 && newTrade.Price < macd411.ValueDecimal)
            {
                return;
            }
            List<Candle> candlesSecurity = tab.CandlesAll;
            if (candlesSecurity.Count == 0
               )
            {
                return;
            }
            decimal Profit11min11 = Volume.ValueDecimal * Profit11min1.ValueDecimal *(AllPositionsShortCount+ AllPositionsLongCount)/ 100;
            


            if (candlesSecurity.Count < 300)
            {
                return;
            }
           
            //int pcount = 0;
            //int pcount1 = 0;
            //int pcounts = 0;
            // int pcountb = 0;
            //t scount = 0;
            // decimal p100 = 0;
            //  decimal p100L = 0;
            // decimal p100S = 0;
            // decimal p200 = 0;
            // decimal p201 = 0;
            //** decimal n = 0;
            // decimal p101 = 0;
            // decimal p101S = 0;
            //decimal p101L = 0;
            //  decimal in0 = 0;
            //  decimal in1 = 0;
            //  decimal in3 = 0;
            // decimal in4 = 0;
            // decimal inrsi1 = 0;
            // decimal inrsi = 0;
            //decimal MaxPoses100ValueDecimal = 0;

            //  decimal in4 = 0;
            //Position positionBuy = tab.PositionsOpenAll.Find(pos => pos.Direction == Side.Buy);
            // Position positionSell = tab.PositionsOpenAll.Find(pos => pos.Direction == Side.Sell);
            /*
            for (int i = 0; i < _tabScreener.Tabs.Count; i++)
            {
                // List<Position> posOnThisTab = _screener.Tabs[i].PositionsOpenAll;
                List<Position> posOnThisTab1 = _tabScreener.Tabs[i].PositionOpenShort;
                List<Position> posOnThisTab2 = _tabScreener.Tabs[i].PositionOpenLong;

                List<Position> posOnThisTab = _tabScreener.Tabs[i].PositionsOpenAll;
                List<Position> posOnThisTab4 = _tabScreener.Tabs[i].PositionsAll;

                // List<Position> position = tab.PositionsOpenAll;

                if (posOnThisTab2.Count != 0)
                {

                    pcount++;

                }
                if (posOnThisTab1.Count != 0)
                {

                    pcount1++;

                }
                /*
                for (int n = 0; n < posOnThisTab2.Count; n++)
                {



                    p100L += posOnThisTab2[n].ProfitOperationPersent;

                    // List<Position> poses1 = _screenerTab.PositionsOpenAll;
                    // if (ind888.ValueDecimal == 1 && PositionsCount!=0)
                    // {

                    //   _screenerTab.CloseAllPositionAtMarket();
                    // }

                    // p1 +=(candles[candles.Count - 1].Close- posOnThisTab[l].EntryPrice)/ candles[candles.Count - 1].Close*100;




                }
                */
            /*
            for (int n = 0; n < posOnThisTab1.Count; n++)
            {



                p100S += posOnThisTab1[n].ProfitOperationPersent;

                // List<Position> poses1 = _screenerTab.PositionsOpenAll;
                // if (ind888.ValueDecimal == 1 && PositionsCount!=0)
                // {

                //   _screenerTab.CloseAllPositionAtMarket();
                // }

                // p1 +=(candles[candles.Count - 1].Close- posOnThisTab[l].EntryPrice)/ candles[candles.Count - 1].Close*100;




            }
            */
            /*

            for (int n = 0; n < posOnThisTab.Count; n++)
            {



                p100 += posOnThisTab[n].ProfitOperationPersent;

                // List<Position> poses1 = _screenerTab.PositionsOpenAll;
                // if (ind888.ValueDecimal == 1 && PositionsCount!=0)
                // {

                //   _screenerTab.CloseAllPositionAtMarket();
                // }

                // p1 +=(candles[candles.Count - 1].Close- posOnThisTab[l].EntryPrice)/ candles[candles.Count - 1].Close*100;




            }
            */
            /*
            for (int v = 0; v < posOnThisTab4.Count; v++)
            {
                p200 += posOnThisTab4[v].ProfitPortfolioPunkt;
                // p200 = p200 - (p200 * 0.1m / 100);
            }
            */
            /*
            for (int n = 0; n < posOnThisTab2.Count; n++)
            {



                p200 += posOnThisTab2[n].ProfitOperationPersent;



                // p1 +=(candles[candles.Count - 1].Close- posOnThisTab[l].EntryPrice)/ candles[candles.Count - 1].Close*100;




            }
            */



            // }



            //  p101 += p100;
            // p201 += p200;
            //  p101L += p100L;
            // p101S += p100S;
            MaxPoses10.ValueInt = PositionsCount;
            // MaxPoses10.ValueInt = PositionsCount;
            if (MaxPoses10.ValueInt == 0)
            {
                MaxPositionsS.ValueInt = MaxPositionsSt;
                MaxPositionsL.ValueInt = MaxPositionsLt; 

            }

            
            MaxPoses10s.ValueInt = AllPositionsShortCount;
            MaxPoses10b.ValueInt = AllPositionsLongCount;
           // MaxPoses100ValueDecimal = decimal.Round(p101, 2);
            //  MaxPoses100.ValueDecimal = MaxPoses100ValueDecimal;
            //   MaxPoses100L.ValueDecimal = decimal.Round(p101L, 2);
            //   MaxPoses100S.ValueDecimal = decimal.Round(p101S, 2);
            // MaxPoses70000.ValueDecimal = p201;
            MaxPoses700000.ValueDecimal = TotalProfitAbs;
            Profit11min1Kt.ValueDecimal = MaxPoses700000.ValueDecimal;

            Portfolio myPortfolio = tab.Portfolio;

            MaxPoses800000.ValueDecimal = myPortfolio.UnrealizedPnl;
            Profit11min1K11.ValueDecimal = myPortfolio.UnrealizedPnl;
           // if (MaxPoses800000t.ValueDecimal == 1)
            //{
             //   MaxPoses800000.ValueDecimal = 1;

          //  }
            if (MaxPoses800000.ValueDecimal<0 && Math.Abs(MaxPoses800000.ValueDecimal)> Volume.ValueDecimal)
            {
                MaxPositionsS.ValueInt = MaxPositionsS1.ValueInt;
                MaxPositionsL.ValueInt = MaxPositionsL1.ValueInt;

            }
            if (MaxPoses800000.ValueDecimal < 0 && Math.Abs(MaxPoses800000.ValueDecimal) >  2*Volume.ValueDecimal)
            {
                MaxPositionsS.ValueInt = MaxPositionsS2.ValueInt;
                MaxPositionsL.ValueInt = MaxPositionsL2.ValueInt;

            }
            if (MaxPoses800000.ValueDecimal < 0 && Math.Abs(MaxPoses800000.ValueDecimal) > 3 * Volume.ValueDecimal)
            {
                MaxPositionsS.ValueInt = MaxPositionsS3.ValueInt;
                MaxPositionsL.ValueInt = MaxPositionsL3.ValueInt;

            }
            // myPortfolio.ValueCurrent
            //  MaxPoses0.ValueInt = pcount;
            // MaxPoses0S.ValueInt = pcount1;

            /*
            if (macd2.ValueDecimal != 0 &&  MaxPoses10s.ValueInt < MaxPoses10b.ValueInt)
            {
                MaxPositionsS.ValueInt = MaxPoses10b.ValueInt;

            }
            */
            // decimal Profit11min1K1 = decimal.MaxValue;
            // if (MaxPoses700000.ValueDecimal == 0)
            // {
            //if (Profit11min1K.ValueDecimal != 0)
            // {

            //   Profit11min1K.ValueDecimal = Profit11min1.ValueDecimal;
            // Profit11min1K1 = Profit11min10.ValueDecimal;
            // Profit11min1K11.ValueDecimal = Profit11min10.ValueDecimal;
            //  Profit11min1K.ValueDecimal = Profit11min1S.ValueDecimal;

            // }
            //  if (Profit11min1K11.ValueDecimal != 0)
            //  {

            //Profit11min1K.ValueDecimal = Profit11min1.ValueDecimal;
            // Profit11min1K1 = Profit11min10.ValueDecimal;
            //   Profit11min1K11.ValueDecimal = Profit11min10.ValueDecimal;
            //  Profit11min1K.ValueDecimal = Profit11min1S.ValueDecimal;

            //  }

            //  }

            
            if (MaxPoses700000.ValueDecimal != 0  && Profit11min1.ValueDecimal != 0 && PositionsCount >= Profit11min1max.ValueDecimal && MaxPoses700000.ValueDecimal != 0 /*&& MaxPoses70000.ValueDecimal > Profit11min1K.ValueDecimal*/ && MaxPoses700000.ValueDecimal > Profit11min1K.ValueDecimal/*+ Math.Abs(MaxPoses7000.ValueDecimal) * Profit11min1.ValueDecimal/100*/ ) /** PositionsCount + PositionsCount * 0.15m*/
            {

                if (PositionsCount != AllPositionsLongCount + AllPositionsShortCount)
                {

                    return;
                }
                /*
                if (PositionsCount > Profit11min1max.ValueDecimal)
                {

                    return;
                }
                */
                //IsActiv = false;
                if (MaxPoses700000.ValueDecimal == 0)
                {

                    return;
                }
                List<Position> poses = _tabScreener.PositionsOpenAll;
                if (PositionsCount != poses.Count)
                {

                    return;
                }
                //  for (int i = 0; i < poses.Count; i++)
                //  {
                //    if (poses[i].State != PositionStateType.Open)
                //   {
                //      return;
                //  }



                ////  tab.CloseAllAtMarket();
                // _tabScreener.CloseAllPositionAtMarket();

                //  }
                
                _tabScreener.CloseAllPositionAtMarket();

                // _tabScreener.CloseAllPositionAtMarket();
                // MaxPoses7000.ValueDecimal = 0;
                Profit11min1K.ValueDecimal = Profit11min1Kt;
                Profit11min1Ktp.ValueDecimal = Profit11min1Kt;


                // return;
            }


            Stop11min1K.ValueDecimal = /*MaxPoses700000.ValueDecimal*/Profit11min1K.ValueDecimal - Stop11min1.ValueDecimal;

            //stop
            if (MaxPoses700000.ValueDecimal != 0 && Stop11min1.ValueDecimal != 0 && PositionsCount >= Profit11min1max.ValueDecimal && MaxPoses700000.ValueDecimal != 0 /*&& MaxPoses70000.ValueDecimal > Profit11min1K.ValueDecimal*/ && MaxPoses700000.ValueDecimal < Stop11min1K.ValueDecimal/*+ Math.Abs(MaxPoses7000.ValueDecimal) * Profit11min1.ValueDecimal/100*/ ) /** PositionsCount + PositionsCount * 0.15m*/
            {

                if (PositionsCount != AllPositionsLongCount + AllPositionsShortCount)
                {

                    return;
                }
                /*
                if (PositionsCount > Profit11min1max.ValueDecimal)
                {

                    return;
                }
                */
                //IsActiv = false;
                if (MaxPoses700000.ValueDecimal == 0)
                {

                    return;
                }
                // List<Position> poses = _tabScreener.PositionsOpenAll;
                //  for (int i = 0; i < poses.Count; i++)
                //  {
                //    if (poses[i].State != PositionStateType.Open)
                //   {
                //      return;
                //  }



                ////  tab.CloseAllAtMarket();
                // _tabScreener.CloseAllPositionAtMarket();

                //  }

                _tabScreener.CloseAllPositionAtMarket();

                // _tabScreener.CloseAllPositionAtMarket();
                // MaxPoses7000.ValueDecimal = 0;
                // Profit11min1K.ValueDecimal = /*MaxPoses700000.ValueDecimal*/Profit11min1K.ValueDecimal + Profit11min1.ValueDecimal;
                // Stop11min1K.ValueDecimal = /*MaxPoses700000.ValueDecimal*/Profit11min1K.ValueDecimal - Stop11min1.ValueDecimal; 
               // Profit11min1K.ValueDecimal = /*MaxPoses700000.ValueDecimal*/Stop11min1K.ValueDecimal + Profit11min1.ValueDecimal;
                // return;
            }

            // Profit11min1Kb.ValueDecimal= myPortfolio.ValueCurrent - myPortfolio.ValueBegin;
            Profit11min1Kbs.ValueDecimal = myPortfolio.ValueCurrent;
            if ( Profit11min1b.ValueDecimal != 0 && myPortfolio.ValueCurrent != 0  && PositionsCount >= Profit11min1max.ValueDecimal  /*&& MaxPoses70000.ValueDecimal > Profit11min1K.ValueDecimal*/ && myPortfolio.ValueCurrent > Profit11min1Kb.ValueDecimal/*+ Math.Abs(MaxPoses7000.ValueDecimal) * Profit11min1.ValueDecimal/100*/ ) /** PositionsCount + PositionsCount * 0.15m*/
            {

                if (PositionsCount != AllPositionsLongCount + AllPositionsShortCount)
                {

                    return;
                }
                /*
                if (PositionsCount > Profit11min1max.ValueDecimal)
                {

                    return;
                }
                */
                //IsActiv = false;
                if (myPortfolio.ValueCurrent == 0)
                {

                    return;
                }
                // List<Position> poses = _tabScreener.PositionsOpenAll;
                //  for (int i = 0; i < poses.Count; i++)
                //  {
                //    if (poses[i].State != PositionStateType.Open)
                //   {
                //      return;
                //  }



                ////  tab.CloseAllAtMarket();
                // _tabScreener.CloseAllPositionAtMarket();

                //  }

                _tabScreener.CloseAllPositionAtMarket();

                // _tabScreener.CloseAllPositionAtMarket();
                // MaxPoses7000.ValueDecimal = 0;
                // Profit11min1K.ValueDecimal = MaxPoses700000.ValueDecimal + Profit11min1.ValueDecimal;

                // return;
                Profit11min1Kb.ValueDecimal = myPortfolio.ValueCurrent+ Profit11min1b.ValueDecimal/* - myPortfolio.ValueBegin*/;
            }
            if (  PositionsCount !=0 ) /** PositionsCount + PositionsCount * 0.15m*/
            {
                Profit11min10p.ValueDecimal = Profit11min10.ValueDecimal * (AllPositionsLongCount + AllPositionsShortCount);

            }
            
            if (Profit11min10.ValueDecimal != 0 && Profit11min10.ValueDecimal!=0 && PositionsCount!=0 && PositionsCount >= Profit11min1max.ValueDecimal && MaxPoses800000.ValueDecimal > 0 && Profit11min1K11.ValueDecimal> Profit11min10.ValueDecimal* (AllPositionsLongCount + AllPositionsShortCount)  /*&& MaxPoses70000.ValueDecimal > Profit11min1K.ValueDecimal*//*+ Math.Abs(MaxPoses7000.ValueDecimal) * Profit11min1.ValueDecimal/100*/ ) /** PositionsCount + PositionsCount * 0.15m*/
            {

                if (PositionsCount != AllPositionsLongCount + AllPositionsShortCount)
                {

                    return;
                }
               
               _tabScreener.CloseAllPositionAtMarket();



                // _tabScreener.CloseAllPositionAtMarket();
                // MaxPoses7000.ValueDecimal = 0;

                // return;
            }
            Aindicator SuperTrend_indicator = (Aindicator)tab.Indicators[2];
          //  decimal arup = SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1];
           // decimal arup2 = SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 2];
            // decimal ardown = aroon.DataSeries[1].Last;
            Aindicator ps = (Aindicator)tab.Indicators[3];
           // decimal ps0 = ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1];
            Aindicator mcd = (Aindicator)tab.Indicators[4];
            //  ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 2]
            // List<Position> poses = _screener.PositionsOpenAll;

            // CheckJournals();
            
            //  return profit;
           // if (ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1] == 0)
          //  {
               // return;
          //  }
            
            //  _screener.CloseAllPositionAtMarket();

            List<Position> openPositions = tab.PositionsOpenAll;
            Aindicator sma = (Aindicator)tab.Indicators[1];
            decimal _currentFunding = tab.Funding.CurrentValue;
            decimal _current24v = tab.SecurityVolumes.Volume24hUSDT;
            // LogicOpenPositions1(candlesSecurity, tab);
           // decimal cr10s =( (sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100);
           // decimal cr10l = ((sma.DataSeries[1].Last - sma.DataSeries[0].Last) / sma.DataSeries[0].Last * 100);
            if (openPositions.Count == 0 /*tab.PositionsOpenAll.Count != 0*/)
            {


                if (funding.ValueDecimal !=0 && Math.Abs(_currentFunding) > Math.Abs(funding.ValueDecimal))
                {
                    return;
                }
                if (macdv.ValueDecimal != 0 && _current24v < macdv.ValueDecimal)
                {
                    return;
                }
                if (macdvmax.ValueDecimal != 0 && _current24v > macdvmax.ValueDecimal)
                {
                    return;
                }
                // LogicOpenPosition(candlesSecurity, newTrade, tab);
                // List<Position> openPositions = tab.PositionsOpenAll;
                /*
                if (openPositions.Count == 0
                    && _clusterToTrade.ValueInt != 0)
                {
                    if (_lastTimeSetClusters == DateTime.MinValue
                     || _lastTimeSetClusters != candlesSecurity[^1].TimeStart)
                    {
                        _volatilityStageClusters.Calculate(_tabScreener.Tabs, _clustersLookBack.ValueInt);
                        _lastTimeSetClusters = candlesSecurity[^1].TimeStart;
                    }

                    if (_clusterToTrade.ValueInt == 1)
                    {
                        if (_volatilityStageClusters.ClusterOne.Find(source => source.Connector.SecurityName == tab.Connector.SecurityName) == null)
                        {
                            return;
                        }
                    }
                    else if (_clusterToTrade.ValueInt == 2)
                    {
                        if (_volatilityStageClusters.ClusterTwo.Find(source => source.Connector.SecurityName == tab.Connector.SecurityName) == null)
                        {
                            return;
                        }
                    }
                    else if (_clusterToTrade.ValueInt == 3)
                    {
                        if (_volatilityStageClusters.ClusterThree.Find(source => source.Connector.SecurityName == tab.Connector.SecurityName) == null)
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                */
                // List<Position> openPositionsS1 = tab.PositionOpenShort;
                // List<Position> openPositionsL1 = tab.PositionOpenLong;
                //  List<Candle> candles = tab.CandlesAll;

                if (Regime.ValueString == "Off")
                {
                    return;
                }

                //  CheckMoveTime myTime = null;
                /*
                  for (int i = 0; i < _checkMoveTimes.Count; i++)
                  {
                      if (_checkMoveTimes[i].SecName == tab.Connector.SecurityName
                      && _checkMoveTimes[i].SecClass == tab.Connector.SecurityClass)
                      {
                          myTime = _checkMoveTimes[i];
                          break;
                      }
                  }

                  if (myTime == null)
                  {
                      myTime = new CheckMoveTime();
                      myTime.SecClass = tab.Connector.SecurityClass;
                      myTime.SecName = tab.Connector.SecurityName;
                      _checkMoveTimes.Add(myTime);
                  }

                  if (myTime.LastCheckTime.AddSeconds(SecondsToAnalyze.ValueInt) >= newTrade.Time)
                  {
                      return;
                  }
                  myTime.LastCheckTime = newTrade.Time;
                  if ( candlesSecurity[^1].TimeStart.AddMinutes(60) < newTrade.Time)
                  {
                      return;
                  }
                  // myTime.LastCheckTime = newTrade.Time;
                  decimal startPrice = decimal.MaxValue;
                  decimal startPrice1 = decimal.MinValue;

                  List<Trade> trades = tab.Trades;
                  // List<Candle> candles = tab.CandlesAll;

                  int secondsCount = 0;
                  int secondNow = newTrade.Time.Second;
                  int secondNow1 = newTrade.Time.Second;
                  for (int i = trades.Count - 1; i >= 0; i--)
                  {
                      if (trades[i].Price!= startPrice)
                      {
                          startPrice = trades[i].Price;
                      }


                      if (trades[i].Time.Second != secondNow)
                      {
                          secondsCount++;
                          secondNow = trades[i].Time.Second;
                      }

                      if (secondsCount < SecondsToAnalyze.ValueInt)
                      {
                          break;
                      }
                  }
                */
                // newTrade.Price= startPrice;

                /*
                if (startPrice == decimal.MaxValue)
                {
                    return;
                }
                decimal movePercent = ((newTrade.Price - startPrice) / startPrice) * 100;
                decimal movePercent1 = ((newTrade.Price - startPrice1) / (newTrade.Price)) * 100;

                macd42.ValueDecimal = movePercent;
                macd43.ValueDecimal = movePercent1;
                */


                //  decimal movePercent = 0;
                //  decimal movePercent1 = 0;
                // decimal lastClose = candlesSecurity[candlesSecurity.Count - 1].Close;
                //  decimal lastOpen = candlesSecurity[candlesSecurity.Count - 1].Open;
                //  decimal lastHigh = candlesSecurity[candlesSecurity.Count - 1].High;
                //  decimal lastLow = candlesSecurity[candlesSecurity.Count - 1].Low;

                // Aindicator sma = (Aindicator)tab.Indicators[1];

                /*
                if (macd41.ValueDecimal != 0 && newTrade.Price > macd41.ValueDecimal)
                {
                    return;
                }
                if (macd411.ValueDecimal != 0 && newTrade.Price < macd411.ValueDecimal)
                {
                    return;
                }
                */
                Aindicator volaIndicatorOnSecurity = (Aindicator)tab.Indicators[0];
               // Aindicator sma = (Aindicator)tab.Indicators[1];

                decimal p = 0;
                if (sma.DataSeries[0].Last==0 || sma.DataSeries[2].Last ==0|| sma.DataSeries[4].Last==0)
                {
                    return;
                }
                if (volaIndicatorOnSecurity.DataSeries[0].Last == 0 || volaIndicatorOnSecurity.DataSeries[1].Last == 0 )
                {
                    return;
                }
                if (openPositions.Count == 0)
                {
                    
                    decimal cr5 = volaIndicatorOnSecurity.DataSeries[0].Last;

                   
                    //LogicOpenPosition(candlesSecurity,newTrade, tab);
                    
                    
                    // Aindicator volaIndicatorOnSecurity = (Aindicator)tab.Indicators[0];
                    decimal cr = volaIndicatorOnSecurity.DataSeries[1].Last;
                    decimal cr10 = volaIndicatorOnSecurity.DataSeries[1].Last;
                    //  decimal VolSma1 = (sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[0].Last * 100;
                    //   decimal VolSmaB = (sma.DataSeries[2].Last - sma.DataSeries[4].Last) / sma.DataSeries[2].Last * 100;
                    if (macd44.ValueDecimal != 0 && cr5 > macd44.ValueDecimal)
                    {
                        return;
                    }

                    
                    if (macd45.ValueDecimal != 0 && cr5 < macd45.ValueDecimal)
                    {
                        return;
                    }
                    // List<Position> openPositions = tab.PositionsOpenAll;
                    if (cr == 0)
                    {
                        return;
                    }
                    if (cr10 == 0)
                    {
                        return;
                    }
                   // if (VolSma1 == 0)
                   // {
                       // return;
                   // }
                    if ((AllPositionsShortCount + AllPositionsLongCount) >= MaxPositions0.ValueDecimal)
                    {
                        return;
                    }
                    if (AllPositionsLongCount >= MaxPositionsL.ValueInt && AllPositionsShortCount >= MaxPositionsS.ValueInt)
                    {
                        return;
                    }
                    /*
                    if (AllPositionsShortCount >= MaxPositionsS.ValueInt)
                    {
                        return;
                    }
                    */
                    List<Position> openPositionsS1 = tab.PositionOpenShort;
                    List<Position> openPositionsL1 = tab.PositionOpenLong;
                    if (SmaFilterIsOn2002.ValueBool == true)
                    {
                        //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                        // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                        //cr10 = volaIndicatorOnSecurity.DataSeries[0].Last;
                        cr10 = (sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100;
                    }
                    if (SmaFilterIsOn2002p.ValueBool == true)
                    {
                        //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                        // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                        // curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                        cr10 = (ps.DataSeries[0].Values[candlesSecurity.Count - 1] - ps.DataSeries[1].Values[candlesSecurity.Count - 1]) / ps.DataSeries[1].Values[candlesSecurity.Count - 1] * 100;
                    }
                    // decimal curVolaInPercent13 = (sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[0].Last * 100;
                    /*
                    if (SmaFilterIsOnSP.ValueBool == true)
                    {
                        //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                        // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                        cr10 = VolSma1;
                    }
                    */
                    /*
                    if (SmaFilterIsOnSB.ValueBool == true)
                    {
                        //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                        // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                        cr10 = VolSmaB;
                    }
                    */
                    decimal sma0 = sma.DataSeries[2].Last;
                    decimal sma1 = sma.DataSeries[2].Values[candlesSecurity.Count - 2];
                    // decimal cr5 = volaIndicatorOnSecurity.DataSeries[0].Last;




                   

                    if (Regime.ValueString != "OnlyShort" && macdsar.ValueDecimal != 0 && ((macdsarvolst.ValueDecimal != 0 && newTrade.Price > (sma.DataSeries[4].Last - (sma.DataSeries[4].Last * macdsarvolst.ValueDecimal * cr10 / 100)) && SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 2] < (sma.DataSeries[4].Last - (sma.DataSeries[4].Last * macdsarvolst.ValueDecimal * cr10 / 100))) || (macdsarvolst.ValueDecimal == 0)) && /*((SmaFilterIsOn300l.ValueBool == true && newTrade.Price > ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1]) || (SmaFilterIsOn300l.ValueBool == false)) && */((newTrade.Price > sma.DataSeries[2].Last && SmaFilterIsOn300s.ValueBool == true) || ( SmaFilterIsOn300s.ValueBool == false) ) && ((( (candlesSecurity[candlesSecurity.Count - 1].Low < sma.DataSeries[4].Last)  ) && SmaFilterIsOn300.ValueBool == true) || ( SmaFilterIsOn300.ValueBool == false))   /*&& candlesSecurity[candlesSecurity.Count - 1].Close > ps0 */ )

                    {
                        if (macdsarv.ValueDecimal != 0 && (ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1] > (sma.DataSeries[4].Last - sma.DataSeries[4].Last * macdsarv.ValueDecimal * cr10 / 100)))
                        {

                            return;


                        }
                        if (macdsarvb.ValueDecimal != 0 && (ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1] > (sma.DataSeries[2].Last - sma.DataSeries[2].Last * macdsarvb.ValueDecimal * cr10 / 100)))
                        {

                            return;


                        }
                        
                        /*
                        if (macdsarVOL.ValueDecimal != 0  && newTrade.Price < (sma.DataSeries[4].Last -( sma.DataSeries[4].Last * macdsarVOL.ValueDecimal * cr10 / 100)))
                        {

                            return;


                        }
                        */
                        if (macdsarVOL.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 2].Low > (sma.DataSeries[4].Last - (sma.DataSeries[4].Last * macdsarVOL.ValueDecimal * cr10 / 100)))
                        {

                            return;


                        }

                        if (SmaFilterIsOn300ar.ValueBool == true && candlesSecurity[candlesSecurity.Count - 1].Close < SuperTrend_indicator.DataSeries[2].Values[SuperTrend_indicator.DataSeries[2].Values.Count - 2])
                        {

                            return;


                        }
                        if (SmaFilterIsOn300l.ValueBool == true && candlesSecurity[candlesSecurity.Count - 1].Close < ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 2])
                        {

                            return;


                        }
                        if (SmaFilterIsOn300k.ValueBool == true && newTrade.Price < sma.DataSeries[4].Last)
                        {
                           
                                return;
                            

                        }
                        if (SmaFilterIsOn300k.ValueBool == true && SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1] > sma.DataSeries[4].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300k.ValueBool == true && candlesSecurity[candlesSecurity.Count - 2].Low > sma.DataSeries[4].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bbb.ValueBool == true && newTrade.Price < sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true && newTrade.Price < sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true &&  SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1] > sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true && candlesSecurity[candlesSecurity.Count - 2].Low > sma.DataSeries[2].Last )
                        {

                            return;


                        }
                        if (SmaFilterIsOn30.ValueBool == true)
                        {
                            if (newTrade.Price > sma.DataSeries[4].Last)
                            {
                                return;
                            }

                        }

                        if (SmaFilterIsOn300macd == true && mcd.DataSeries[1].Last < mcd.DataSeries[2].Last /*&& mcd.DataSeries[1].Values[candlesSecurity.Count - 1] < mcd.DataSeries[1].Values[candlesSecurity.Count - 2]*/)
                        {
                            return;






                        }
                        if (SmaFilterIsOn300macd2 == true &&  mcd.DataSeries[0].Last >= 0)
                        {
                            return;






                        }
                        if (macd22.ValueDecimal != 0 && AllPositionsLongCount >= macd220.ValueDecimal && AllPositionsShortCount < AllPositionsLongCount)
                        {
                            return;
                        }
                       
                        /*
                        if (macd45.ValueDecimal != 0 && cr5 < macd45.ValueDecimal)
                        {
                            return;
                        }
                        */
                        if (p != 0)
                        {


                            return;

                        }

                       
                        if (AllPositionsLongCount >= MaxPositionsL.ValueInt)
                        {
                            return;
                        }
                        if ((AllPositionsShortCount + AllPositionsLongCount) >= MaxPositions0.ValueDecimal)
                        {
                            return;
                        }
                        if (macd400.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 1].OpenInterest < candlesSecurity[candlesSecurity.Count - 3].OpenInterest)
                        {
                            return;
                        }
                        /*
                        if ( MaxPoses0.ValueInt >= MaxPositionsL.ValueInt)
                        {
                            return;
                        }
                        if ((MaxPoses0.ValueInt+ MaxPoses0.ValueInt) >= MaxPositions0.ValueDecimal)
                        {
                            return;
                        }
                        */
                        /*
                        if ((MaxPoses0.ValueInt + MaxPoses0S.ValueInt) > MaxPositions0.ValueDecimal)
                        {
                            return;
                        }
                        */

                        /*
                        if ((MaxPoses0.ValueInt + MaxPoses0S.ValueInt) > MaxPositions0.ValueDecimal)
                        {
                            return;
                        }
                        */
                        /*
                        if (openPositionsS1.Count != 0 && MaxPoses0.ValueInt+ MaxPoses0S.ValueInt >= MaxPositions0.ValueDecimal)
                        {
                            return;
                        }
                        */
                        decimal cr51 = volaIndicatorOnSecurity.DataSeries[0].Last;
                        
                        /*
                        if (SmaFilterIsOn11.ValueBool == true && newTrade.Price < sma.DataSeries[2].Last)
                        {


                            return;

                        }
                        if (SmaFilterIsOn12.ValueBool == true && newTrade.Price > sma.DataSeries[2].Last)
                        {


                            return;

                        }
                        */
                      

                       

                     

                        if (SmaFilterIsOn2.ValueBool == true)
                        {
                            decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            if (cur1 < cr1)
                            {
                                return;
                            }
                           
                        }
                        else
                        if (SmaFilterIsOn2.ValueBool == false)
                        {
                            decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            if (cur1 > cr1)
                            {
                                return;
                            }
                           
                        }



                        if (SmaFilterIsOn.ValueBool == true)
                        {
                            decimal smaValue = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 1);
                            decimal smaPrev = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 3);
                            if (smaValue < smaPrev)
                            {
                                return;
                            }

                        }
                        /*
                        decimal lastMa = sma.DataSeries[2].Last;
                        decimal lastBestBuy = tab.PriceBestBid;
                        decimal lastBestSell = tab.PriceBestAsk;

                        if (lastMa == 0
                            || lastBestBuy == 0
                            || lastBestSell == 0)
                        {
                            return;
                        }


                        // проверяем чтобы цены были не дальше 1% от машки

                        if (Math.Abs(lastMa / lastBestBuy) > 1.01m ||
                            Math.Abs(lastMa / lastBestBuy) < 0.99m)
                        {
                            return;
                        }

                        if (Math.Abs(lastMa / lastBestSell) > 1.01m ||
                            Math.Abs(lastMa / lastBestSell) < 0.99m)
                        {
                            return;
                        }
                        */
                        /*
                        decimal lastMa0 = sma.DataSeries[2].Last;
                        decimal lastMa1 = sma.DataSeries[4].Last;
                        if (SmaFilterIsOn1.ValueBool == true)
                        {
                            if (lastMa0 < lastMa1)
                            {
                                return;
                            }






                            /*
                            if (newTrade.Price < sma.DataSeries[0].Values[candlesSecurity.Count - 2])
                            {
                                return;
                            }
                            */
                            // decimal volume = GetVolume(tab);
                            // tab.BuyAtMarket(volume);
                      //  }
                       

                        //List<Position> openPositions2 = tab.PositionOpenShort;
                        List<Position> openPositions3 = tab.PositionOpenLong;
                        if (openPositions.Count != 0)
                        {
                            return;
                        }
                        if (AllPositionsLongCount >= MaxPositionsL.ValueInt)
                        {
                            return;
                        }
                        if (macd1.ValueDecimal != 0 && (candlesSecurity[candlesSecurity.Count - 3].Open > candlesSecurity[candlesSecurity.Count - 3].Close
                        || candlesSecurity[candlesSecurity.Count - 2].Open > candlesSecurity[candlesSecurity.Count - 2].Close
                        || candlesSecurity[candlesSecurity.Count - 1].Open > candlesSecurity[candlesSecurity.Count - 1].Close))
                        {

                            decimal volume = GetVolume(tab);
                            if (p != 0)
                            {


                                return;

                            }
                            tab.BuyAtMarket(volume);
                            p = 1;
                            return;
                        }
                        if (macd1.ValueDecimal == 0)
                        {
                            if (openPositions3.Count != 0)
                            {
                                return;
                            }
                            decimal volume = GetVolume(tab);
                            if (p != 0)
                            {


                                return;

                            }
                            tab.BuyAtMarket(volume);
                            p = 1;
                            return;
                        }
                        return;


                    }
                    else
                    // decimal ME = -MoveToEntry1.ValueDecimal * cr5;
                    
                    
                    
                    
                    if (Regime.ValueString != "OnlyLong" && macdsar.ValueDecimal!= 0  && ((macdsarvolst.ValueDecimal != 0 && newTrade.Price < (sma.DataSeries[0].Last + (sma.DataSeries[0].Last * macdsarvolst.ValueDecimal * cr10 / 100)) && SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 2] > (sma.DataSeries[0].Last + (sma.DataSeries[0].Last * macdsarvolst.ValueDecimal * cr10 / 100))) || (macdsarvolst.ValueDecimal == 0)) && ((newTrade.Price < sma.DataSeries[2].Last && SmaFilterIsOn300s.ValueBool == true) || (SmaFilterIsOn300s.ValueBool == false)) && ((( candlesSecurity[candlesSecurity.Count - 1].High > sma.DataSeries[0].Last) && SmaFilterIsOn300.ValueBool == true) || (SmaFilterIsOn300.ValueBool == false)) 
                          /*&& candlesSecurity[candlesSecurity.Count - 1].Close < ps0 */ )

                        
                    {
                            /*
                        if (macdsarVOL.ValueDecimal != 0  && newTrade.Price > (sma.DataSeries[0].Last + (sma.DataSeries[0].Last * macdsarVOL.ValueDecimal * cr10 / 100)))
                        {

                            return;


                        }
                            */
                        if (macdsarVOL.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 2].High < (sma.DataSeries[0].Last + (sma.DataSeries[0].Last * macdsarVOL.ValueDecimal * cr10 / 100)))
                        {

                            return;


                        }    
                        
                        
                        if (macdsarv.ValueDecimal != 0 && (ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1] < (sma.DataSeries[0].Last + sma.DataSeries[0].Last * macdsarv.ValueDecimal * cr10 / 100) ))
                        {

                            return;


                        }
                        if (macdsarvb.ValueDecimal != 0 && (ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1] < (sma.DataSeries[2].Last + sma.DataSeries[2].Last * macdsarvb.ValueDecimal * cr10 / 100) ))
                        {

                            return;


                        }
                          
                        if (SmaFilterIsOn300ar.ValueBool == true && candlesSecurity[candlesSecurity.Count - 1].Close > SuperTrend_indicator.DataSeries[2].Values[SuperTrend_indicator.DataSeries[2].Values.Count - 2])
                        {
                           
                                return;
                            

                        }
                        if (SmaFilterIsOn300l.ValueBool == true && candlesSecurity[candlesSecurity.Count - 1].Close > ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 2])
                        {
                           
                                return;
                            

                        }
                        if (SmaFilterIsOn300k.ValueBool == true && newTrade.Price > sma.DataSeries[0].Last)
                        {
                           
                                return;
                            

                        }
                        if (SmaFilterIsOn300k.ValueBool == true && SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1] < sma.DataSeries[0].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300k.ValueBool == true && candlesSecurity[candlesSecurity.Count - 2].High < sma.DataSeries[0].Last)
                        {

                            return;


                        }
                         if (SmaFilterIsOn300bbb.ValueBool == true && newTrade.Price > sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true && newTrade.Price > sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true && SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1] < sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true && candlesSecurity[candlesSecurity.Count - 2].High < sma.DataSeries[2].Last )
                        {

                            return;


                        }
                        if (SmaFilterIsOn30.ValueBool == true)
                        {
                            if (newTrade.Price < sma.DataSeries[0].Last)
                            {
                                return;
                            }

                        }
                        if (SmaFilterIsOn300macd == true  && mcd.DataSeries[1].Last > mcd.DataSeries[2].Last /*&& mcd.DataSeries[1].Values[candlesSecurity.Count - 1] > mcd.DataSeries[1].Values[candlesSecurity.Count - 2]*/)
                        {
                            return;






                        }
                        if (SmaFilterIsOn300macd2 == true  && mcd.DataSeries[0].Last <= 0 )
                        {
                            return;






                        }
                       
                        if (macd22.ValueDecimal != 0 && AllPositionsShortCount >= macd220.ValueDecimal && AllPositionsShortCount > AllPositionsLongCount)
                        {
                            return;
                        }
                        if (AllPositionsShortCount >= MaxPositionsS.ValueInt)
                        {
                            return;
                        }
                        if ((AllPositionsShortCount + AllPositionsLongCount) >= MaxPositions0.ValueDecimal)
                        {
                            return;
                        }
                        if (macd400.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 1].OpenInterest < candlesSecurity[candlesSecurity.Count - 3].OpenInterest)
                        {
                            return;
                        }

                        decimal cr51 = volaIndicatorOnSecurity.DataSeries[0].Last;
                      
                        if (SmaFilterIsOn2.ValueBool == true)
                        {
                            decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            if (cur1 < cr1)
                            {
                                return;
                            }
                           
                        }
                        else
                        if (SmaFilterIsOn2.ValueBool == false)
                        {
                            decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            if (cur1 > cr1)
                            {
                                return;
                            }

                        }
                        /*
                        if (( MaxPoses0.ValueInt + MaxPoses0S.ValueInt) > MaxPositions0.ValueDecimal)
                        {
                            return;
                        }
                        */
                        /*
                        if (openPositionsL1.Count != 0 && MaxPoses0S.ValueInt >= MaxPositionsS.ValueInt * 2)
                        {
                            return;
                        }
                        */
                        /*
                      if ((MaxPoses0.ValueInt + MaxPoses0S.ValueInt) > MaxPositions0.ValueDecimal)
                      {
                          return;
                      }
                       */
                       

                        /*
                        if (openPositionsL1.Count == 0 && MaxPoses0S.ValueInt >= MaxPositionsS.ValueInt)
                        {
                            return;
                        }
                        */
                        /*
                        if (SmaFilterIsOn11.ValueBool == true && newTrade.Price > sma.DataSeries[2].Last)
                        {


                            return;

                        }
                        if (SmaFilterIsOn12.ValueBool == true && newTrade.Price < sma.DataSeries[2].Last)
                        {


                            return;

                        }

                        */

                        if (SmaFilterIsOn.ValueBool == true)
                        {
                            decimal smaValue = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 1);
                            decimal smaPrev = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 3);
                            if (smaValue > smaPrev)
                            {
                                return;
                            }

                        }


                        decimal lastMa0 = sma.DataSeries[2].Last;
                        decimal lastMa1 = sma.DataSeries[2].Values[candlesSecurity.Count - 2];
                        

                        if (macd1.ValueDecimal != 0 && (candlesSecurity[candlesSecurity.Count - 3].Close > candlesSecurity[candlesSecurity.Count - 3].Open
                       || candlesSecurity[candlesSecurity.Count - 2].Close > candlesSecurity[candlesSecurity.Count - 2].Open
                       || candlesSecurity[candlesSecurity.Count - 1].Close > candlesSecurity[candlesSecurity.Count - 1].Open))
                        {
                            return;
                        }

                        List<Position> openPositions2 = tab.PositionOpenShort;
                        // List<Position> openPositions3 = tab.PositionOpenLong;
                        if (openPositions.Count != 0)
                        {
                            return;
                        }
                        if (AllPositionsShortCount >= MaxPositionsS.ValueInt)
                        {
                            return;
                        }
                        decimal volume = GetVolume(tab);
                        if (p != 0)
                        {


                            return;

                        }
                        tab.SellAtMarket(volume);
                        p = 1;
                        return;

                    }
                    
                    //****************
                   





                }




            }
            else
            if (openPositions.Count != 0 /*tab.PositionsOpenAll.Count != 0*/)
            {
                //LogicClosePositionD(candlesSecurity,newTrade, tab);
                //List<Candle> candlesSecurity = tab.CandlesAll;
                Aindicator volaIndicatorOnSecurity = (Aindicator)tab.Indicators[0];
                decimal cr = volaIndicatorOnSecurity.DataSeries[1].Last;
                decimal cr10 = volaIndicatorOnSecurity.DataSeries[1].Last;
               // Aindicator sma = (Aindicator)tab.Indicators[1];
               if (sma.DataSeries[0].Last==0 || sma.DataSeries[2].Last ==0|| sma.DataSeries[4].Last==0)
               {
                    return;
               }
               if (volaIndicatorOnSecurity.DataSeries[0].Last == 0 || volaIndicatorOnSecurity.DataSeries[1].Last == 0 )
               {
                    return;
               }
               // decimal VolSma1 = (sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[0].Last * 100;
             //   decimal VolSmaB = (sma.DataSeries[2].Last - sma.DataSeries[4].Last) / sma.DataSeries[2].Last * 100;
                List<Position> openPositionsS1 = tab.PositionOpenShort;
                List<Position> openPositionsL1 = tab.PositionOpenLong;
               if (SmaFilterIsOn2002.ValueBool == true)
               {
                   decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                   decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                   cr10 = volaIndicatorOnSecurity.DataSeries[0].Last;
               }
               if (SmaFilterIsOn2002p.ValueBool == true)
               {
                                        decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                                        decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                                        //curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                   cr10 = (ps.DataSeries[0].Values[candlesSecurity.Count - 1]- ps.DataSeries[1].Values[candlesSecurity.Count - 1])/ ps.DataSeries[0].Values[candlesSecurity.Count - 1]*100;
               }
                /*
                if (SmaFilterIsOnSP.ValueBool == true)
                {
                    //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                    // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                    cr10 = VolSma1;
                }
                */
                /*
                if (SmaFilterIsOnSB.ValueBool == true)
                {
                    //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                    // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                    cr10 = VolSmaB;
                }
                */
                //decimal sma0 = sma.DataSeries[2].Last;
                // decimal sma1 = sma.DataSeries[2].Values[candlesSecurity.Count - 2];
               decimal cr5 = volaIndicatorOnSecurity.DataSeries[0].Last;


                // Voll.ValueDecimal = Math.Round(VolSma1, 5);
                /*
                if (MaxPoses0.ValueInt>= MaxPositions0.ValueDecimal)
                {
                    return;
                }
                */
                //  MaxPoses110.ValueDecimal = candlesSecurity[candlesSecurity.Count - 1].OpenInterest;
                //   MaxPoses111.ValueDecimal = candlesSecurity[candlesSecurity.Count - 3].OpenInterest;
                // tab.PositionsOpenAll.Count == 0

                // List<Position> openPositions2 = tab.PositionOpenShort;
                //  List<Position> openPositions3 = tab.PositionOpenLong;
                //List<Candle> candlesSecurity = tab.CandlesAll;
                // Position openPositionsL = openPositions3[openPositions3.Count - 1];
                //  Position openPositionsS = openPositions2[openPositions2.Count - 1];

               List<Position> openPositions1 = tab.PositionsOpenAll;






               List<Position> posesOpenBySecurityS = tab.PositionOpenShort;
               List<Position> posesOpenBySecurityL = tab.PositionOpenLong;




                //  List<Position> openPositions1 = tab.PositionsOpenAll;
               List<Position> openPositions2 = tab.PositionOpenShort;
               List<Position> openPositions3 = tab.PositionOpenLong;
                //   List<Candle> candlesSecurity = tab.CandlesAll;
                //  Position openPositionsL = openPositions3[openPositions3.Count - 1];
                //  Position openPositionsS = openPositions2[openPositions2.Count - 1];
                // Position openPositionsS = openPositions2[openPositions2.Count - 1];

               Aindicator volaIndicatorOnSecurity1 = (Aindicator)tab.Indicators[0];
               if (volaIndicatorOnSecurity.DataSeries[0].Last == 0 || volaIndicatorOnSecurity.DataSeries[1].Last == 0)
               {
                     return;
               }
               decimal curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[1].Last;
               if (SmaFilterIsOn2000.ValueBool == true)
               {
                    //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                    // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                   // curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                    curVolaInPercent1= (sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100;
               }
               if (SmaFilterIsOn20002.ValueBool == true)
               {
                    //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                    // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                   // curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                    curVolaInPercent1= ((sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100)+(curVolaInPercent1)/2;
               }
               if (SmaFilterIsOn20002p.ValueBool == true)
               {
                                        //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                                        // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                                        // curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                       curVolaInPercent1 = (ps.DataSeries[0].Values[candlesSecurity.Count - 1]- ps.DataSeries[1].Values[candlesSecurity.Count - 1])/ ps.DataSeries[1].Values[candlesSecurity.Count - 1]*100;
               }

                /*
                if (SmaFilterIsOn2000B.ValueBool == true)
                {
                    //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                    // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                    curVolaInPercent1 = VolSmaB;
                }
                */
                /*
                if (SmaFilterIsOnSPR.ValueBool == true)
                {
                    //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                    // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                    curVolaInPercent1 = VolSma1;
                }
                */
                decimal curVolaInPercent10 = volaIndicatorOnSecurity1.DataSeries[1].Last; 
               if (SmaFilterIsOn2001.ValueBool == true)
               {
                    //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                    // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                    //curVolaInPercent10 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                    curVolaInPercent10 = (sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100;
               }
               if (SmaFilterIsOn20012.ValueBool == true)
               {
                //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                // curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                    curVolaInPercent10 = ((sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100) + (curVolaInPercent10) / 2;
               }
               if (SmaFilterIsOn2001p.ValueBool == true)
               {
                        //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                        // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                        // curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                        curVolaInPercent10 = (ps.DataSeries[0].Values[candlesSecurity.Count - 1] - ps.DataSeries[1].Values[candlesSecurity.Count - 1]) / ps.DataSeries[1].Values[candlesSecurity.Count - 1] * 100;
               }
                /*
                if (SmaFilterIsOnSD.ValueBool == true)
                {
                    //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                    // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                    curVolaInPercent10 = VolSma1;
                }
                */
                // List<Trade> trades = tab.Trades;
                decimal P = macdd6V.ValueDecimal;
                decimal PP = macdd6V.ValueDecimal;
                    /*
               if (curVolaInPercent10>=10)
               {


                         P=0.5m;
                         PP = 0.5m;

               }
               else
               {


                         P=1m;
                         PP = 0.5m;

               }
                    */
               if (openPositionsL1.Count != 0)
               {
                    Position openPositionsL = openPositions3[openPositions3.Count - 1];

                    // if (openPositions[0].State != PositionStateType.Open)
                    //  {
                    // continue;
                    // }
                    // List<Candle> candlesSecurity1 = tab.CandlesAll;
                    /// Aindicator volaIndicatorOnSecurity = (Aindicator)tab.Indicators[0];

                    // decimal curVolaInPercent1 = volaIndicatorOnSecurity.DataSeries[0].Last;

                    //******************************
                    

                    //decimal ME = -MoveToEntry1.ValueDecimal * cr5;

                    
                    if (Regime.ValueString != "OnlyLong" && macdsar.ValueDecimal != 0  && ((macdsarvolst.ValueDecimal != 0 && newTrade.Price< (sma.DataSeries[0].Last + ((sma.DataSeries[0].Last * (macdsarvolst.ValueDecimal * cr10)) / 100)) && SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1] > (sma.DataSeries[0].Last + ((sma.DataSeries[0].Last * (macdsarvolst.ValueDecimal * cr10)) / 100))) || (macdsarvolst.ValueDecimal == 0)) && macdsar.ValueDecimal != 0  && ((newTrade.Price < sma.DataSeries[2].Last && SmaFilterIsOn300s.ValueBool == true) || (SmaFilterIsOn300s.ValueBool == false)) && ((( candlesSecurity[candlesSecurity.Count - 1].High > sma.DataSeries[0].Last) && SmaFilterIsOn300.ValueBool == true) || ( SmaFilterIsOn300.ValueBool == false)) &&    /*&& candlesSecurity[candlesSecurity.Count - 1].Close < ps0*/  openPositionsS1.Count == 0)
                    

                    {
                        if (macdsarv.ValueDecimal != 0 && (ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1] < (sma.DataSeries[0].Last + sma.DataSeries[0].Last * macdsarv.ValueDecimal * cr10 / 100) ))
                        {

                            return;


                        }
                        if (macdsarvb.ValueDecimal != 0 && (ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1] < (sma.DataSeries[2].Last + sma.DataSeries[2].Last * macdsarvb.ValueDecimal * cr10 / 100) ))
                        {

                            return;


                        }
                        

                        /*
                        if (macdsarVOL.ValueDecimal != 0  && newTrade.Price > (sma.DataSeries[0].Last + (sma.DataSeries[0].Last * macdsarVOL.ValueDecimal * cr10 / 100)))
                        {

                            return;


                        }
                        */

                        if (macdsarVOL.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 2].High < (sma.DataSeries[0].Last + (sma.DataSeries[0].Last * macdsarVOL.ValueDecimal * cr10 / 100)))
                        {

                            return;


                        }
                        if (SmaFilterIsOn300ar.ValueBool == true && candlesSecurity[candlesSecurity.Count - 1].Close > SuperTrend_indicator.DataSeries[2].Values[SuperTrend_indicator.DataSeries[2].Values.Count - 2])
                        {
                           
                                return;
                            

                        } 
                        if (SmaFilterIsOn300l.ValueBool == true && candlesSecurity[candlesSecurity.Count - 1].Close > ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 2])
                        {
                           
                                return;
                            

                        }
                            
                        if (SmaFilterIsOn300k.ValueBool == true && newTrade.Price > sma.DataSeries[0].Last)
                        {
                           
                                return;
                            

                        }
                        if (SmaFilterIsOn300k.ValueBool == true && SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1] < sma.DataSeries[0].Last)
                        {

                            return;


                        }
                         
                        if (SmaFilterIsOn300k.ValueBool == true && candlesSecurity[candlesSecurity.Count - 2].High < sma.DataSeries[0].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bbb.ValueBool == true && newTrade.Price > sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true && newTrade.Price > sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true && SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1] < sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true && candlesSecurity[candlesSecurity.Count - 1].High < sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn30.ValueBool == true)
                        {
                            if (newTrade.Price < sma.DataSeries[0].Last)
                            {
                                return;
                            }

                        }
                        if (SmaFilterIsOn300macd == true && candlesSecurity[candlesSecurity.Count - 1].High < sma.DataSeries[2].Last && mcd.DataSeries[1].Last > mcd.DataSeries[2].Last /*&& mcd.DataSeries[1].Values[candlesSecurity.Count - 1] > mcd.DataSeries[1].Values[candlesSecurity.Count - 2]*/)
                        {
                            return;






                        }
                        if (SmaFilterIsOn300macd2 == true   && mcd.DataSeries[0].Last <= 0)
                        {
                            return;






                        }
                        /*
                        if (AllPositionsShortCount >= MaxPositions1.ValueInt)
                        {
                            return;
                        }
                        */
                        /*
                        if (MaxPoses0S.ValueInt >= MaxPositionsS.ValueInt)
                        {
                            return;
                        }
                        */

                        if ((AllPositionsShortCount + AllPositionsLongCount) >= MaxPositions0.ValueDecimal)
                        {
                            return;
                        }

                        if (macd400.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 1].OpenInterest < candlesSecurity[candlesSecurity.Count - 3].OpenInterest)
                        {
                            return;
                        }

                        if (openPositions3.Count == 0)
                        {
                            return;
                        }
                        /*
                        if (SmaFilterIsOn11.ValueBool == true && newTrade.Price > sma.DataSeries[2].Last)
                        {


                            return;

                        }
                        */
                        /*
                        if (SmaFilterIsOn11.ValueBool == true && newTrade.Price > sma.DataSeries[2].Last)
                        {


                            return;

                        }
                        */
                        decimal cr51 = volaIndicatorOnSecurity.DataSeries[0].Last;
                       
                        /*
                        if (SmaFilterIsOn12.ValueBool == true && newTrade.Price < sma.DataSeries[2].Last)
                        {


                            return;

                        }
                        */
                      
                        if (SmaFilterIsOn2.ValueBool == true)
                        {
                            decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            if (cur1 < cr1)
                            {
                                return;
                            }
                          
                        }
                        else
                        if (SmaFilterIsOn2.ValueBool == false)
                        {
                            decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            if (cur1 > cr1)
                            {
                                return;
                            }

                        }
                        /*
                        if (AllPositionsShortCount >= MaxPositions1.ValueInt)
                        {
                            return;
                        }
                        */
                        if (SmaFilterIsOn.ValueBool == true)
                        {
                            decimal smaValue = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 1);
                            decimal smaPrev = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 3);
                            if (smaValue > smaPrev)
                            {
                                return;
                            }

                        }


                        decimal lastMa0 = sma.DataSeries[2].Last;
                        decimal lastMa1 = sma.DataSeries[2].Values[candlesSecurity.Count - 2];
                       

                        if (macd1.ValueDecimal != 0 && (candlesSecurity[candlesSecurity.Count - 3].Close > candlesSecurity[candlesSecurity.Count - 3].Open
                       || candlesSecurity[candlesSecurity.Count - 2].Close > candlesSecurity[candlesSecurity.Count - 2].Open
                       || candlesSecurity[candlesSecurity.Count - 1].Close > candlesSecurity[candlesSecurity.Count - 1].Open))
                        {
                            return;
                        }
                        // List<Position> openPositions2 = tab.PositionOpenShort;
                        // List<Position> openPositions3 = tab.PositionOpenLong;
                        if (openPositions2.Count != 0)
                        {
                            return;
                        }
                        decimal volume = GetVolume(tab);
                        tab.SellAtMarket(volume);
                        return;

                    }
                    //***********
                    //decimal ME = -MoveToEntry1.ValueDecimal * cr5;
                    
                    //************************


                    if (curVolaInPercent1 <= 0)
                    {
                        return;
                    }



                    if (Profit12.ValueDecimal != 0)
                    {
                        for (int j = 0; j < openPositions3.Count; j++)
                        {
                            /*
                            if (openPositions3[j].State != PositionStateType.Open)
                            {
                                return;
                            }
                            */
                            if (openPositions3[j].OpenOrders[0].MyTrades == null
                                    || openPositions3[j].OpenOrders[0].MyTrades.Count == 0)
                            {
                                // trades on the order have not arrived yet. It is too early to process the position
                                return;
                            }

                            if (StopMult.ValueDecimal != 0 && ((candlesSecurity[candlesSecurity.Count - 1].Close > (openPositions3[j].EntryPrice + (openPositions3[j].EntryPrice * (curVolaInPercent1 * Profit12.ValueDecimal) / 100) * Profit1111.ValueDecimal))/*|| (newTrade.Price > openPositions3[j].EntryPrice + (openPositions3[j].EntryPrice * (curVolaInPercent1 * Profit12.ValueDecimal) / 100))*/))
                            {
                                decimal stopPrice = tab.PriceBestBid;


                                stopPrice = stopPrice - (stopPrice / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                tab.CloseAtTrailingStopMarket(openPositions3[j], stopPrice);






                            }
                            /*
                            if (StopMult.ValueDecimal == 0 && candlesSecurity[candlesSecurity.Count - 1].Close > openPositions3[j].EntryPrice + (openPositions3[j].EntryPrice * (curVolaInPercent1 * Profit12.ValueDecimal) / 100))
                            {

                                decimal stopPrice = openPositions3[j].EntryPrice;
                                tab.CloseAtTrailingStopMarket(openPositions3[j], stopPrice);





                            }
                            */





                        }


                        //  tab.CloseAtTrailingStop(openPositions2[j], stopPrice, stopPrice);












                    }




                    if (Profit1100.ValueDecimal != 0 && newTrade.Price > sma.DataSeries[0].Values[sma.DataSeries[0].Values.Count - 1] /*&& newTrade.Price > (openPositions3[0].EntryPrice + (openPositions3[0].EntryPrice * (curVolaInPercent1 * Profit1100.ValueDecimal) / 100) * Profit1111.ValueDecimal)*/)
                    {
                        for (int j = 0; j < openPositions3.Count; j++)
                        {
                            /*
                            if (openPositions3[j].State != PositionStateType.Open)
                            {
                                return;
                            }
                            */
                            //decimal curVolaInPercent11 = Math.Abs((ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1] - ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1]) / ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1] * 100);
                            if (openPositions3[j].OpenOrders[0].MyTrades == null
                                    || openPositions3[j].OpenOrders[0].MyTrades.Count == 0)
                            {
                                // trades on the order have not arrived yet. It is too early to process the position
                                return;
                            }
                            if (newTrade.Price >= (openPositions3[j].EntryPrice + (openPositions3[j].EntryPrice * (curVolaInPercent1 * Profit1100.ValueDecimal) / 100) * Profit1111.ValueDecimal))
                            {
                                decimal stopPrice = newTrade.Price;
                               //decimal stopPrice = SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1];


                                decimal stopPrice1 = stopPrice - (stopPrice / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                tab.CloseAtTrailingStopMarket(openPositions3[j], stopPrice1);






                            }







                        }


                        // tab.CloseAtMarket(openPositionsL, openPositionsL.OpenVolume);


                    }
                    if (Profit1100b.ValueDecimal != 0 &&   newTrade.Price  >= sma.DataSeries[0].Last /*&& newTrade.Price >= arup*/)
                    {
                            for (int j = 0; j < openPositions3.Count; j++)
                            {
                                /*
                                if (openPositions3[j].State != PositionStateType.Open)
                                {
                                    return;
                                }
                                */
                                if (openPositions3[j].OpenOrders[0].MyTrades == null
                                        || openPositions3[j].OpenOrders[0].MyTrades.Count == 0)
                                {
                                    // trades on the order have not arrived yet. It is too early to process the position
                                    return;
                                }
                                if (StopMult.ValueDecimal != 0  && newTrade.Price > (openPositions3[j].EntryPrice + (openPositions3[j].EntryPrice * (curVolaInPercent1 * Profit1100b.ValueDecimal) / 100) * Profit1111.ValueDecimal))
                                {
                                    decimal stopPrice = newTrade.Price;
                                    //decimal stopPrice = SuperTrend_indicator.DataSeries[2].Last;


                                    decimal stopPrice1 = stopPrice - (stopPrice / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                    tab.CloseAtTrailingStopMarket(openPositions3[j], stopPrice1);






                                }







                            }


                            // tab.CloseAtMarket(openPositionsL, openPositionsL.OpenVolume);


                    }
                    if (Profit11.ValueDecimal != 0)
                    {
                        for (int j = 0; j < openPositions3.Count; j++)
                        {
                            /*
                            if (openPositions3[j].State != PositionStateType.Open)
                            {
                                return;
                            }
                            */
                            if (openPositions3[j].OpenOrders[0].MyTrades == null
                                    || openPositions3[j].OpenOrders[0].MyTrades.Count == 0)
                            {
                                // trades on the order have not arrived yet. It is too early to process the position
                                return;
                            }
                            if (StopMult.ValueDecimal != 0 && newTrade.Price <= SuperTrend_indicator.DataSeries[2].Last && newTrade.Price > (openPositions3[j].EntryPrice + (openPositions3[j].EntryPrice * (curVolaInPercent1 /** Profit11.ValueDecimal*/) / 100) * Profit1111.ValueDecimal))
                            {
                                    //decimal stopPrice = newTrade.Price;
                                    //decimal stopPrice = arup;


                                    // decimal stopPrice1 = stopPrice - (stopPrice / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                    // tab.CloseAtTrailingStopMarket(openPositions3[j], stopPrice1);
                                   // decimal profitOrderPrice =
                                   // openPositions3[j].EntryPrice + (openPositions3[j].EntryPrice * (curVolaInPercent1 * Profit11.ValueDecimal / 100));
                                    tab.CloseAtMarket(openPositions3[j], openPositions3[j].OpenVolume);
                                   // tab.CloseAtProfitMarket(openPositions3[j], profitOrderPrice);





                            }







                        }


                        // tab.CloseAtMarket(openPositionsL, openPositionsL.OpenVolume);


                    }
                    if (ProfitPercentr.ValueDecimal != 0)
                    {
                            for (int j = 0; j < openPositions3.Count; j++)
                            {
                            /*
                            if (openPositions3[j].State != PositionStateType.Open)
                            {
                                return;
                            }
                            */
                            if (openPositions3[j].OpenOrders[0].MyTrades == null
                                    || openPositions3[j].OpenOrders[0].MyTrades.Count == 0)
                            {
                                // trades on the order have not arrived yet. It is too early to process the position
                                return;
                            }
                           // curVolaInPercent10 = Math.Abs((sma.DataSeries[4].Last - sma.DataSeries[0].Last) / sma.DataSeries[0].Last * 100);
                            if (SmaFilterIsOn2000pl ==true )
                            {//
                                  //  if (SmaFilterIsOn20002p.ValueBool == true)
                                  //  {
                                        //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                                        // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                                        // curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                                      //  curVolaInPercent1 = (ps.DataSeries[0].Values[candlesSecurity.Count - 1]- ps.DataSeries[1].Values[candlesSecurity.Count - 1])/ ps.DataSeries[0].Values[candlesSecurity.Count - 1]*100;
                                  //  }
                                   // curVolaInPercent1 = Math.Abs((ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1] - ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1]) / ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1] * 100);
                                   // curVolaInPercent1 = Math.Abs((sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100);
                                    decimal stopPrice = (openPositions3[j].EntryPrice + (openPositions3[j].EntryPrice * (curVolaInPercent1 * ProfitPercentr.ValueDecimal) / 100) * Profit1111.ValueDecimal);
                                   // decimal stopPrice1 = SuperTrend_indicator.DataSeries[2].Values[SuperTrend_indicator.DataSeries[2].Values.Count - 1];
                                    if ( /*newTrade.Price >= stopPrice1 && */newTrade.Price >= stopPrice)
                                    {
                                      //  decimal curVolaInPercent11 = Math.Abs((ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1] - ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1]) / ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1] * 100);
                                        decimal stopPrice11 = newTrade.Price - (newTrade.Price / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                        //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                                        // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                                        // curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                                        tab.CloseAtTrailingStopMarket(openPositions3[j], stopPrice11);
                                    }

                                    // decimal stopPrice1 = stopPrice - (stopPrice / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                    // tab.CloseAtTrailingStopMarket(openPositions3[j], stopPrice1);
                                    // decimal profitOrderPrice =
                                    // openPositions3[j].EntryPrice + (openPositions3[j].EntryPrice * (curVolaInPercent1 * Profit11.ValueDecimal / 100));
                                    //tab.CloseAtMarket(openPositions3[j], openPositions3[j].OpenVolume);
                                   // tab.CloseAtProfitMarket(openPositions3[j], stopPrice);





                            }







                           }


                        // tab.CloseAtMarket(openPositionsL, openPositionsL.OpenVolume);


                    }
                    if (Stop.ValueDecimal != 0)
                    {
                            for (int j = 0; j < openPositions3.Count; j++)
                            {
                                /*
                                if (openPositions3[j].State != PositionStateType.Open)
                                {
                                    return;
                                }
                                */
                                if (openPositions3[j].OpenOrders[0].MyTrades == null
                                        || openPositions3[j].OpenOrders[0].MyTrades.Count == 0)
                                {
                                    // trades on the order have not arrived yet. It is too early to process the position
                                    return;
                                }
                                if (newTrade.Price < SuperTrend_indicator.DataSeries[2].Last)
                                {
                                    //decimal stopPrice = newTrade.Price;
                                    decimal stopPrice = openPositions3[j].EntryPrice - openPositions3[j].EntryPrice* Stop.ValueDecimal/100;
                                    


                                    decimal stopPrice1 = stopPrice ;
                                    tab.CloseAtTrailingStopMarket(openPositions3[j], stopPrice1);






                                }







                            }


                            // tab.CloseAtMarket(openPositionsL, openPositionsL.OpenVolume);


                    }
                    if (Stopst.ValueDecimal != 0)
                    {
                            for (int j = 0; j < openPositions3.Count; j++)
                            {
                                /*
                                if (openPositions3[j].State != PositionStateType.Open)
                                {
                                    return;
                                }
                                */
                                if (openPositions3[j].OpenOrders[0].MyTrades == null
                                        || openPositions3[j].OpenOrders[0].MyTrades.Count == 0)
                                {
                                    // trades on the order have not arrived yet. It is too early to process the position
                                    return;
                                }
                                if (candlesSecurity[candlesSecurity.Count - 1].Close < SuperTrend_indicator.DataSeries[2].Last)
                                {
                                   decimal stopPrice = newTrade.Price;
                                   // decimal stopPrice = openPositions3[j].EntryPrice - openPositions3[j].EntryPrice* Stopst.ValueDecimal/100;
                                    


                                    decimal stopPrice1 = stopPrice ;
                                    tab.CloseAtStopMarket(openPositions3[j], stopPrice);






                                }







                            }


                            // tab.CloseAtMarket(openPositionsL, openPositionsL.OpenVolume);


                    }

                    List<Position> position = tab.PositionOpenLong;
                   
                    if (macdd6.ValueDecimal != 0   && newTrade.Price < (openPositions3[openPositions3.Count - 1].EntryPrice - openPositions3[openPositions3.Count - 1].EntryPrice * macdd6.ValueDecimal / 100)
                         && Regime.ValueString != "OnlyShort")
                    {
                        //MaxPositionsls
                        if (position.Count >= MaxPositionsls.ValueDecimal)
                        {
                            return;
                        }
                        if (openPositions3[openPositions3.Count - 1].State != PositionStateType.Open)
                        {
                            return;
                        }
                        if (macd401.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 1].OpenInterest < candlesSecurity[candlesSecurity.Count - 2].OpenInterest)
                        {
                            return;
                        }
                        if (AllPositionsLongCount >= MaxPositions.ValueInt)
                        {
                            return;
                        }
                        //  decimal lastEntryOrderPrice = openPositions1[openPositions1.Count - 1].EntryPrice;
                        /*
                        if (newTrade.Price > lastEntryOrderPrice1 - lastEntryOrderPrice1 * macdd6.ValueDecimal / 100)
                        {
                            return;
                        }
                        */
                        

                        int z0 = tab.Securiti.DecimalsVolume;
                        decimal volume = decimal.Round(GetVolume(tab) * Volume1.ValueDecimal, z0); 
                        
                      //  volume = decimal.Round(volume * Volume1.ValueDecimal, z0);
                        tab.BuyAtMarket(volume);
                        return;
                    }
                    
                    // lastEntryOrderPrice1 = openPositions3[openPositions3.Count - 1].EntryPrice;
                    if (macdd6K.ValueDecimal != 0   && newTrade.Price > sma.DataSeries[4].Last && (candlesSecurity[candlesSecurity.Count - 1].Open < sma.DataSeries[4].Last || candlesSecurity[candlesSecurity.Count - 2].Low < sma.DataSeries[4].Last) && newTrade.Price < (openPositions3[openPositions3.Count - 1].EntryPrice - openPositions3[openPositions3.Count - 1].EntryPrice * macdd6K.ValueDecimal * curVolaInPercent10 / 100)
                       && newTrade.Price > candlesSecurity[candlesSecurity.Count - 2].Open && Regime.ValueString != "OnlyShort")
                    {
                        if (position.Count >= MaxPositionsls.ValueDecimal)
                        {
                            return;
                        }
                        if (SmaFilterIsOn.ValueBool == true)
                        {
                            decimal smaValue = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 1);
                            decimal smaPrev = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 3);
                            if (smaValue < smaPrev)
                            {
                                return;
                            }

                        }

                        if (curVolaInPercent10 < 1)
                        {
                            return;
                        }
                        if (openPositions3[openPositions3.Count - 1].State != PositionStateType.Open)
                        {
                            return;
                        }
                       
                        if (AllPositionsLongCount >= MaxPositions.ValueInt)
                        {
                            return;
                        }
                        if (macd401.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 1].OpenInterest < candlesSecurity[candlesSecurity.Count - 2].OpenInterest)
                        {
                            return;
                        }
                        /*
                        decimal lastEntryOrderPrice = openPositions3[openPositions3.Count - 1].EntryPrice;
                        if (newTrade.Price > lastEntryOrderPrice1 - lastEntryOrderPrice1 * macdd6K.ValueDecimal * curVolaInPercent10 / 100)
                        {
                            return;
                        }
                        */
                        
                        if (newTrade.Price > (openPositions3[openPositions3.Count - 1].EntryPrice - openPositions3[openPositions3.Count - 1].EntryPrice / 100 * macdd6K.ValueDecimal * curVolaInPercent10))
                        {
                            return;
                        }
                        int z0 = tab.Securiti.DecimalsVolume;
                        decimal volume = decimal.Round(GetVolume(tab) * Volume1.ValueDecimal, z0);
                        tab.BuyAtMarket(volume);
                        return;
                    }
                        // lastEntryOrderPrice1 = openPositions3[openPositions3.Count - 1].EntryPrice;

                        //  lastEntryOrderPrice1 = openPositions3[openPositions3.Count - 1].EntryPrice;
                        // decimal lastEntryOrderPrice2 = openPositions3[openPositions3.Count - 1].EntryPrice;
                    //curVolaInPercent10 = Math.Abs((sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100);
                    if (macdd6V.ValueDecimal != 0 && newTrade.Price < (openPositions3[openPositions3.Count - 1].EntryPrice - (openPositions3[openPositions3.Count - 1].EntryPrice * P * curVolaInPercent10) / 100 )&& ((SmaFilterIsOn200.ValueBool == true  && newTrade.Price > candlesSecurity[candlesSecurity.Count - 3].Open) || (SmaFilterIsOn200.ValueBool == false))  &&/*arup > ardown && arup > 50 &&*/ ((SmaFilterIsOn200.ValueBool == true && candlesSecurity[candlesSecurity.Count - 2].Close > candlesSecurity[candlesSecurity.Count - 2].Open && candlesSecurity[candlesSecurity.Count - 2].Open < (openPositions3[openPositions3.Count - 1].EntryPrice - openPositions3[openPositions3.Count - 1].EntryPrice / 100 * P * curVolaInPercent10)) || (SmaFilterIsOn200.ValueBool == false ))
                        && Regime.ValueString != "OnlyShort")
                    {
                        if (position.Count >= MaxPositionsls.ValueDecimal)
                        {
                            return;
                        }
                        
                        if (curVolaInPercent10 < 1)
                        {
                            return;
                        }
                        if (openPositions3[openPositions3.Count - 1].State != PositionStateType.Open)
                        {
                            return;
                        }
                        if (AllPositionsLongCount >= MaxPositions.ValueInt)
                        {
                            return;
                        }
                        if (macd401.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 1].OpenInterest > candlesSecurity[candlesSecurity.Count - 2].OpenInterest)
                        {
                            return;
                        }
                        // decimal lastEntryOrderPrice = openPositions1[openPositions1.Count - 1].EntryPrice;
                        // if (newTrade.Price > lastEntryOrderPrice - (lastEntryOrderPrice1 * macdd6V.ValueDecimal * curVolaInPercent1) / 100)
                        //  {
                        //   return;
                        //  }
                        /*
                        if (SmaFilterIsOn110.ValueBool == true && newTrade.Price < sma.DataSeries[4].Last)
                        {


                            return;

                        }
                      */
                        if (newTrade.Price > sma.DataSeries[4].Last)
                        {

                            return;

                        }

                        
                        /*
                        if (SmaFilterIsOn3333.ValueDecimal != 0)
                        {
                            decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            if (cur1 > VolSma1 * SmaFilterIsOn3333.ValueDecimal)
                            {
                                return;
                            }
                        }
                        */
                        /*
                        if (SmaFilterIsOn120.ValueBool == true && newTrade.Price > sma.DataSeries[2].Last)
                        {


                            return;

                        }
                        */
                        //decimal volume = GetVolume(tab);

                        /*
                        if (newTrade.Price > lastEntryOrderPrice2 - lastEntryOrderPrice2 * macdd6V.ValueDecimal * curVolaInPercent10 / 100)
                        {
                            return;
                        }
                        */
                      
                        /*
                        if (newTrade.Price > (openPositions3[openPositions3.Count - 1].EntryPrice - openPositions3[openPositions3.Count - 1].EntryPrice / 100 * macdd6V.ValueDecimal * curVolaInPercent10))
                        {
                            return;
                        }
                        */
                        int z0 = tab.Securiti.DecimalsVolume;
                        decimal volume = decimal.Round(GetVolume(tab) * Volume1.ValueDecimal, z0);
                        tab.BuyAtMarket(volume);
                        return;
                    }
                    // lastEntryOrderPrice1 = openPositions3[openPositions3.Count - 1].EntryPrice;
                   
                }
                List<Position> openPositions4 = tab.PositionOpenShort;
                if (openPositionsS1.Count != 0)
                {
                    Position openPositionsS = posesOpenBySecurityS[posesOpenBySecurityS.Count - 1];

                    // List<Candle> candlesSecurity = tab.CandlesAll;


                    if (curVolaInPercent10 <= 0)
                    {
                        return;
                    }
                    
                    //****************
                    
                    if (Regime.ValueString != "OnlyShort" && macdsar.ValueDecimal != 0  && ((macdsarvolst.ValueDecimal != 0 && newTrade.Price > (sma.DataSeries[4].Last - (sma.DataSeries[4].Last * macdsarvolst.ValueDecimal * cr10 / 100)) && SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 2] < (sma.DataSeries[4].Last - (sma.DataSeries[4].Last * macdsarvolst.ValueDecimal * cr10 / 100))) || (macdsarvolst.ValueDecimal == 0)) && (( newTrade.Price > sma.DataSeries[2].Last && SmaFilterIsOn300s.ValueBool == true) || (SmaFilterIsOn300s.ValueBool == false)) && ((( candlesSecurity[candlesSecurity.Count - 1].Low < sma.DataSeries[4].Last) && SmaFilterIsOn300.ValueBool == true) || (SmaFilterIsOn300.ValueBool == false)) && /*&& candlesSecurity[candlesSecurity.Count - 1].Close > ps0*/   openPositionsL1.Count == 0  )


                    {
                        if (macdsarv.ValueDecimal != 0 && (ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1] > (sma.DataSeries[4].Last - sma.DataSeries[4].Last * macdsarv.ValueDecimal * cr10 / 100) ))
                        {

                            return;


                        }
                        if (macdsarvb.ValueDecimal != 0 && (ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 1] > (sma.DataSeries[2].Last - sma.DataSeries[2].Last * macdsarvb.ValueDecimal * cr10 / 100) ))
                        {

                            return;


                        }
                        /*
                        if (macdsarVOL.ValueDecimal != 0 && newTrade.Price < (sma.DataSeries[4].Last - (sma.DataSeries[4].Last * macdsarVOL.ValueDecimal * cr10 / 100)))
                        {

                            return;


                        }
                        */
                        if (macdsarVOL.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 2].Low > (sma.DataSeries[4].Last - (sma.DataSeries[4].Last * macdsarVOL.ValueDecimal * cr10 / 100)))
                        {

                            return;


                        }
                        
                         
                        if (SmaFilterIsOn300ar.ValueBool == true && candlesSecurity[candlesSecurity.Count - 1].Close < SuperTrend_indicator.DataSeries[2].Values[SuperTrend_indicator.DataSeries[2].Values.Count - 2])
                        {
                           
                                return;
                            

                        }
                        if (SmaFilterIsOn300l.ValueBool == true && candlesSecurity[candlesSecurity.Count - 1].Close < ps.DataSeries[2].Values[ps.DataSeries[2].Values.Count - 2])
                        {
                           
                                return;
                            

                        }

                        if (SmaFilterIsOn300k.ValueBool == true && newTrade.Price < sma.DataSeries[4].Last)
                        {
                           
                                return;
                            

                        }
                        if (SmaFilterIsOn300k.ValueBool == true && SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1] > sma.DataSeries[4].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300k.ValueBool == true && candlesSecurity[candlesSecurity.Count - 2].Low > sma.DataSeries[4].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bbb.ValueBool == true && newTrade.Price < sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true && newTrade.Price < sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true &&  SuperTrend_indicator.DataSeries[2].Values[candlesSecurity.Count - 1] > sma.DataSeries[2].Last)
                        {

                            return;


                        }
                        if (SmaFilterIsOn300bb.ValueBool == true && candlesSecurity[candlesSecurity.Count - 1].Low > sma.DataSeries[2].Last )
                        {

                            return;


                        }
                        if (SmaFilterIsOn30.ValueBool == true)
                        {
                            if (newTrade.Price > sma.DataSeries[4].Last)
                            {
                                return;
                            }

                        }
                        if (SmaFilterIsOn300macd == true  && mcd.DataSeries[1].Last< mcd.DataSeries[2].Last /*&& mcd.DataSeries[1].Values[candlesSecurity.Count - 1] < mcd.DataSeries[1].Values[candlesSecurity.Count - 2]*/)
                        {
                            return;






                        }
                        if (SmaFilterIsOn300macd2 == true  &&  mcd.DataSeries[0].Last >= 0)
                        {
                            return;






                        }
                        if (macd400.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 1].OpenInterest < candlesSecurity[candlesSecurity.Count - 3].OpenInterest)
                        {
                            return;
                        }
                        /*
                        if (AllPositionsLongCount >= MaxPositions.ValueInt)
                        {
                            return;
                        }
                        */
                        /*
                        if (MaxPoses0.ValueInt >= MaxPositionsL.ValueInt)
                        {
                            return;
                        }
                        */

                        if ((AllPositionsShortCount + AllPositionsLongCount) >= MaxPositions0.ValueDecimal)
                        {
                            return;
                        }

                        decimal cr51 = volaIndicatorOnSecurity.DataSeries[0].Last;
                       



                        

                      

                        if (SmaFilterIsOn2.ValueBool == true)
                        {
                            decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            if (cur1 < cr1)
                            {
                                return;
                            }
                           
                        }
                        else
                        if (SmaFilterIsOn2.ValueBool == false)
                        {
                            decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            if (cur1 > cr1)
                            {
                                return;
                            }

                        }
                        /*
                        if (AllPositionsLongCount >= MaxPositions.ValueInt)
                        {
                            return;
                        }
                        */
                        if (SmaFilterIsOn.ValueBool == true)
                        {
                            decimal smaValue = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 1);
                            decimal smaPrev = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 3);
                            if (smaValue < smaPrev)
                            {
                                return;
                            }

                        }
                        /*
                        decimal lastMa = sma.DataSeries[2].Last;
                        decimal lastBestBuy = tab.PriceBestBid;
                        decimal lastBestSell = tab.PriceBestAsk;

                        if (lastMa == 0
                            || lastBestBuy == 0
                            || lastBestSell == 0)
                        {
                            return;
                        }


                        // проверяем чтобы цены были не дальше 1% от машки

                        if (Math.Abs(lastMa / lastBestBuy) > 1.01m ||
                            Math.Abs(lastMa / lastBestBuy) < 0.99m)
                        {
                            return;
                        }

                        if (Math.Abs(lastMa / lastBestSell) > 1.01m ||
                            Math.Abs(lastMa / lastBestSell) < 0.99m)
                        {
                            return;
                        }
                        */
                        /*
                        decimal lastMa0 = sma.DataSeries[2].Last;
                        decimal lastMa1 = sma.DataSeries[4].Last;
                        if (SmaFilterIsOn1.ValueBool == true)
                        {
                            if (lastMa0 > lastMa1)
                            {
                                return;
                            }






                            /*
                            if (newTrade.Price < sma.DataSeries[0].Values[candlesSecurity.Count - 2])
                            {
                                return;
                            }
                            */
                            // decimal volume = GetVolume(tab);
                            // tab.BuyAtMarket(volume);
                        //}


                        

                        //List<Position> openPositions2 = tab.PositionOpenShort;
                        //  List<Position> openPositions3 = tab.PositionOpenLong;
                        if (openPositions3.Count != 0)
                        {
                            return;
                        }
                        if (macd1.ValueDecimal != 0 && (candlesSecurity[candlesSecurity.Count - 3].Open > candlesSecurity[candlesSecurity.Count - 3].Close
                        || candlesSecurity[candlesSecurity.Count - 2].Open > candlesSecurity[candlesSecurity.Count - 2].Close
                        || candlesSecurity[candlesSecurity.Count - 1].Open > candlesSecurity[candlesSecurity.Count - 1].Close))
                        {

                            decimal volume = GetVolume(tab);
                            tab.BuyAtMarket(volume);
                            return;
                        }
                        if (macd1.ValueDecimal == 0)
                        {

                            decimal volume = GetVolume(tab);
                            tab.BuyAtMarket(volume);
                            return;
                        }



                    }
                    //*************
                    
                    //***************


                    /*
                    if (ProfitPercent.ValueDecimal != 0)
                    {
                        for (int j = 0; j < openPositions4.Count; j++)
                        {
                            if (openPositions4[j].State != PositionStateType.Open)
                            {
                                return;
                            }


                            decimal profitOrderPrice =
                            openPositions4[j].EntryPrice - openPositions4[j].EntryPrice * (ProfitPercent.ValueDecimal * curVolaInPercent1 / 100);

                            //  tab.CloseAtStopMarket(position, stopPrice);
                            tab.CloseAtProfitMarket(openPositions4[j], profitOrderPrice);



                            //stopPrice = tab.PriceBestBid;




                        }
                        //decimal stopPrice =
                        // position.EntryPrice + position.EntryPrice * (StopPercent.ValueDecimal / 100);

                    }
                    */
                    if (Profit12.ValueDecimal != 0)
                    {
                        for (int j = 0; j < posesOpenBySecurityS.Count; j++)
                        {
                            /*
                            if (posesOpenBySecurityS[j].State != PositionStateType.Open)
                            {
                                return;
                            }
                            */
                            if (posesOpenBySecurityS[j].OpenOrders[0].MyTrades == null
                                    || posesOpenBySecurityS[j].OpenOrders[0].MyTrades.Count == 0)
                            {
                                // trades on the order have not arrived yet. It is too early to process the position
                                return;
                            }
                            if (StopMult.ValueDecimal != 0 && ((candlesSecurity[candlesSecurity.Count - 1].Close < posesOpenBySecurityS[j].EntryPrice - (posesOpenBySecurityS[j].EntryPrice * (curVolaInPercent1 * Profit12.ValueDecimal)) / 100) /*|| (newTrade.Price < posesOpenBySecurityS[j].EntryPrice - (posesOpenBySecurityS[j].EntryPrice * (curVolaInPercent1 * Profit12.ValueDecimal) / 100))*/))
                            {
                                decimal stopPrice = tab.PriceBestBid;


                                stopPrice = stopPrice + (stopPrice / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                tab.CloseAtTrailingStopMarket(posesOpenBySecurityS[j], stopPrice);






                            }
                            /*
                            if (StopMult.ValueDecimal == 0 && candlesSecurity[candlesSecurity.Count - 1].Close < posesOpenBySecurityS[j].EntryPrice - (posesOpenBySecurityS[j].EntryPrice * (curVolaInPercent1 * Profit12.ValueDecimal)) / 100)
                            {

                                decimal stopPrice = posesOpenBySecurityS[j].EntryPrice;
                                tab.CloseAtTrailingStopMarket(posesOpenBySecurityS[j], stopPrice);





                            }
                            */





                        }


                        //  tab.CloseAtTrailingStop(openPositions2[j], stopPrice, stopPrice);












                    }

                    if (Profit11.ValueDecimal != 0)
                    {
                        for (int j = 0; j < posesOpenBySecurityS.Count; j++)
                        {
                            /*
                            if (posesOpenBySecurityS[j].State != PositionStateType.Open)
                            {
                                return;
                            }
                            */
                            if (posesOpenBySecurityS[j].OpenOrders[0].MyTrades == null
                                    || posesOpenBySecurityS[j].OpenOrders[0].MyTrades.Count == 0)
                            {
                                // trades on the order have not arrived yet. It is too early to process the position
                                return;
                            }
                            if (StopMult.ValueDecimal != 0 && newTrade.Price >= SuperTrend_indicator.DataSeries[2].Last && newTrade.Price < posesOpenBySecurityS[j].EntryPrice - (posesOpenBySecurityS[j].EntryPrice * (curVolaInPercent1 /** Profit11.ValueDecimal *// 100)))
                            {
                                //decimal stopPrice = newTrade.Price;
                              //  decimal stopPrice = arup;


                               // decimal stopPrice1 = stopPrice + (stopPrice / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                               // tab.CloseAtTrailingStopMarket(posesOpenBySecurityS[j], stopPrice1);
                               // decimal profitOrderPrice =
                              // posesOpenBySecurityS[j].EntryPrice - (posesOpenBySecurityS[j].EntryPrice * (curVolaInPercent1 * Profit11.ValueDecimal / 100));
                                    // tab.CloseAtStopMarket(position, stopPrice);
                                    // tab.CloseAtProfitMarket(posesOpenBySecurityS[j], profitOrderPrice);
                                    tab.CloseAtMarket(posesOpenBySecurityS[j], posesOpenBySecurityS[j].OpenVolume);





                            }







                        }
                    }

                    if (ProfitPercentr.ValueDecimal != 0)
                    {
                          for (int j = 0; j < posesOpenBySecurityS.Count; j++)
                          {
                            /*
                            if (openPositions3[j].State != PositionStateType.Open)
                            {
                                return;
                            }
                            */
                            if (posesOpenBySecurityS[j].OpenOrders[0].MyTrades == null
                                    || posesOpenBySecurityS[j].OpenOrders[0].MyTrades.Count == 0)
                            {
                                // trades on the order have not arrived yet. It is too early to process the position
                                return;
                            }
                           // curVolaInPercent1= Math.Abs((sma.DataSeries[4].Last - sma.DataSeries[0].Last) / sma.DataSeries[0].Last * 100);
                          // curVolaInPercent1 = Math.Abs((sma.DataSeries[4].Last - sma.DataSeries[0].Last) / sma.DataSeries[0].Last * 100);
                            if (SmaFilterIsOn2000pl ==true )
                            {
                                 //   curVolaInPercent1 = Math.Abs((sma.DataSeries[4].Last - sma.DataSeries[0].Last) / sma.DataSeries[0].Last * 100);

                                  //  curVolaInPercent1 = Math.Abs((sma.DataSeries[4].Last - sma.DataSeries[0].Last) / sma.DataSeries[0].Last * 100);
                                   // curVolaInPercent1 = Math.Abs((ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1] - ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1]) / ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1] * 100);
                                    decimal stopPrice = posesOpenBySecurityS[j].EntryPrice - (posesOpenBySecurityS[j].EntryPrice * (curVolaInPercent1 * ProfitPercentr.ValueDecimal / 100));
                                    //decimal stopPrice1 = SuperTrend_indicator.DataSeries[2].Values[SuperTrend_indicator.DataSeries[2].Values.Count - 1];
                                    if (/*newTrade.Price <= stopPrice1 &&*/ newTrade.Price <= stopPrice)
                                    {
                                       // decimal curVolaInPercent11 = Math.Abs((ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1] - ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1]) / ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1] * 100);
                                        decimal stopPrice11 = newTrade.Price + (newTrade.Price / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                        //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                                        // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                                        // curVolaInPercent1 = volaIndicatorOnSecurity1.DataSeries[0].Last;
                                        tab.CloseAtTrailingStopMarket(posesOpenBySecurityS[j], stopPrice11);
                                    }

                                    // decimal stopPrice1 = stopPrice - (stopPrice / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                    // tab.CloseAtTrailingStopMarket(openPositions3[j], stopPrice1);
                                    // decimal profitOrderPrice =
                                    // openPositions3[j].EntryPrice + (openPositions3[j].EntryPrice * (curVolaInPercent1 * Profit11.ValueDecimal / 100));
                                    //tab.CloseAtMarket(openPositions3[j], openPositions3[j].OpenVolume);
                                    //tab.CloseAtProfitMarket(posesOpenBySecurityS[j], stopPrice);





                            }







                          }

                        // tab.CloseAtMarket(openPositionsS, openPositionsS.OpenVolume);


                    }
                    if (Profit1100.ValueDecimal != 0 && newTrade.Price <= sma.DataSeries[4].Values[sma.DataSeries[4].Values.Count - 1] /*&& newTrade.Price <= posesOpenBySecurityS[0].EntryPrice - (posesOpenBySecurityS[0].EntryPrice * (curVolaInPercent1 * Profit1100.ValueDecimal / 100))*/)
                        {
                        for (int j = 0; j < posesOpenBySecurityS.Count; j++)
                        {
                            /*
                            if (posesOpenBySecurityS[j].State != PositionStateType.Open)
                            {
                                return;
                            }
                            */
                           // decimal curVolaInPercent11 = Math.Abs((ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1] - ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1]) / ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1] * 100);
                            if (posesOpenBySecurityS[j].OpenOrders[0].MyTrades == null
                                    || posesOpenBySecurityS[j].OpenOrders[0].MyTrades.Count == 0)
                            {
                                // trades on the order have not arrived yet. It is too early to process the position
                                return;
                            }
                            if (  newTrade.Price <= posesOpenBySecurityS[j].EntryPrice - (posesOpenBySecurityS[j].EntryPrice * (curVolaInPercent1 * Profit1100.ValueDecimal / 100)))
                            {
                               decimal stopPrice = newTrade.Price;
                               //decimal stopPrice = SuperTrend_indicator.DataSeries[2].Last;


                                decimal stopPrice1 = stopPrice + (stopPrice / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                tab.CloseAtTrailingStopMarket(posesOpenBySecurityS[j], stopPrice1);






                            }







                        }


                        // tab.CloseAtMarket(openPositionsS, openPositionsS.OpenVolume);


                    }
                    if (Profit1100b.ValueDecimal != 0 &&  newTrade.Price  <= sma.DataSeries[4].Last /*&& newTrade.Price <= arup*/)
                    {
                            for (int j = 0; j < posesOpenBySecurityS.Count; j++)
                            {
                                /*
                                if (posesOpenBySecurityS[j].State != PositionStateType.Open)
                                {
                                    return;
                                }
                                */
                                if (posesOpenBySecurityS[j].OpenOrders[0].MyTrades == null
                                        || posesOpenBySecurityS[j].OpenOrders[0].MyTrades.Count == 0)
                                {
                                    // trades on the order have not arrived yet. It is too early to process the position
                                    return;
                                }
                                if (StopMult.ValueDecimal != 0 &&  newTrade.Price < posesOpenBySecurityS[j].EntryPrice - (posesOpenBySecurityS[j].EntryPrice * (curVolaInPercent1 * Profit1100b.ValueDecimal / 100)))
                                {
                                    // decimal stopPrice = newTrade.Price;
                                    decimal stopPrice = newTrade.Price;


                                    decimal stopPrice1 = stopPrice + (stopPrice / 100) * (curVolaInPercent1 * StopMult.ValueDecimal);
                                    tab.CloseAtTrailingStopMarket(posesOpenBySecurityS[j], stopPrice1);






                                }







                            }


                            // tab.CloseAtMarket(openPositionsS, openPositionsS.OpenVolume);


                    }
                    if (Stop.ValueDecimal != 0)
                    {
                            for (int j = 0; j < posesOpenBySecurityS.Count; j++)
                            {
                                /*
                                if (openPositions3[j].State != PositionStateType.Open)
                                {
                                    return;
                                }
                                */
                                if (posesOpenBySecurityS[j].OpenOrders[0].MyTrades == null
                                        || posesOpenBySecurityS[j].OpenOrders[0].MyTrades.Count == 0)
                                {
                                    // trades on the order have not arrived yet. It is too early to process the position
                                    return;
                                }
                                if (newTrade.Price < SuperTrend_indicator.DataSeries[2].Last)
                                {
                                    //decimal stopPrice = newTrade.Price;
                                    decimal stopPrice = posesOpenBySecurityS[j].EntryPrice + posesOpenBySecurityS[j].EntryPrice * Stop.ValueDecimal / 100;
                                    // decimal stopPrice = tab.PriceBestBid;




                                    //stopPrice = stopPrice + (stopPrice / 100) * (curVolaInPercent1 * Stop.ValueDecimal);
                                    tab.CloseAtTrailingStopMarket(posesOpenBySecurityS[j], stopPrice);






                                }







                            }
                           
                           

                            // tab.CloseAtMarket(openPositionsL, openPositionsL.OpenVolume);


                    }
                    if (Stopst.ValueDecimal != 0)
                    {
                            for (int j = 0; j < posesOpenBySecurityS.Count; j++)
                            {
                                /*
                                if (openPositions3[j].State != PositionStateType.Open)
                                {
                                    return;
                                }
                                */
                                if (posesOpenBySecurityS[j].OpenOrders[0].MyTrades == null
                                        || posesOpenBySecurityS[j].OpenOrders[0].MyTrades.Count == 0)
                                {
                                    // trades on the order have not arrived yet. It is too early to process the position
                                    return;
                                }
                                if (candlesSecurity[candlesSecurity.Count - 1].Close > SuperTrend_indicator.DataSeries[2].Last)
                                {
                                    decimal stopPrice = newTrade.Price;
                                    //decimal stopPrice = posesOpenBySecurityS[j].EntryPrice + posesOpenBySecurityS[j].EntryPrice * Stop.ValueDecimal / 100;
                                    // decimal stopPrice = tab.PriceBestBid;




                                    //stopPrice = stopPrice + (stopPrice / 100) * (curVolaInPercent1 * Stop.ValueDecimal);
                                    tab.CloseAtStopMarket(posesOpenBySecurityS[j], stopPrice);






                                }







                            }
                           
                           

                            // tab.CloseAtMarket(openPositionsL, openPositionsL.OpenVolume);


                    }

                    if (macd2.ValueDecimal == 0)
                    {
                        return;
                    }
                    /*
                    decimal lastEntryOrderPrice22 = decimal.MaxValue;
                    for (int j = 0; j < posesOpenBySecurityS.Count; j++)
                    {



                        // tab.CloseAtTrailingStop(openPositionsL, stopPrice, stopPrice);


                        lastEntryOrderPrice22 = posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice;
                       // lastEntryOrderPrice22 = posesOpenBySecurityS.Count-1.;





                        //  tab.CloseAtTrailingStop(openPositions2[j], stopPrice, stopPrice);



                    }
                    */
                    // decimal lastEntryOrderPrice10 = lastEntryOrderPrice22;
                    //  decimal lastEntryOrderPrice1 = openPositions4[openPositions4.Count - 1].EntryPrice;
                    // decimal lastEntryOrderPrice2 = openPositions2[openPositions2.Count - 1].EntryPrice;
                    //  posesOpenBySecurityS[posesOpenBySecurityS.Count - 1]
                    List<Position> position1 = tab.PositionOpenShort;
                    
                    if (macdd6.ValueDecimal != 0 && newTrade.Price > (posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice + posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice * macdd6.ValueDecimal / 100)
                         && Regime.ValueString != "OnlyLong")
                    {
                        if (position1.Count >= MaxPositionsls.ValueDecimal)
                        {
                            return;
                        }
                        if (posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].State != PositionStateType.Open)
                        {
                            return;
                        }
                        if (macd401.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 1].OpenInterest > candlesSecurity[candlesSecurity.Count - 3].OpenInterest)
                        {
                            return;
                        }
                        if (AllPositionsShortCount >= MaxPositions1.ValueInt)
                        {
                            return;
                        }
                        //  decimal lastEntryOrderPrice = openPositions1[openPositions1.Count - 1].EntryPrice;
                        /*
                        if (newTrade.Price < lastEntryOrderPrice1 + lastEntryOrderPrice1 * macdd6.ValueDecimal / 100)
                        {
                            return;
                        }
                        */
                      

                        int z0 = tab.Securiti.DecimalsVolume;
                        decimal volume = decimal.Round(GetVolume(tab) * Volume1.ValueDecimal, z0);
                        tab.SellAtMarket(volume);
                        return;
                    }

                    
                    // lastEntryOrderPrice10 = openPositions2[openPositions2.Count - 1].EntryPrice;
                    if (macdd6K.ValueDecimal != 0 && newTrade.Price < sma.DataSeries[0].Last && (candlesSecurity[candlesSecurity.Count - 1].Open > sma.DataSeries[0].Last || candlesSecurity[candlesSecurity.Count - 2].High > sma.DataSeries[0].Last) && newTrade.Price > (posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice + posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice * macdd6K.ValueDecimal * curVolaInPercent10 / 100)
                        && newTrade.Price < candlesSecurity[candlesSecurity.Count - 2].Open && Regime.ValueString != "OnlyLong")
                    {
                        if (position1.Count >= MaxPositionsls.ValueDecimal)
                        {
                            return;
                        }
                        if (SmaFilterIsOn.ValueBool == true)
                        {
                            decimal smaValue = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 1);
                            decimal smaPrev = Sma(candlesSecurity, SmaFilterLen.ValueInt, candlesSecurity.Count - 3);
                            if (smaValue > smaPrev)
                            {
                                return;
                            }

                        }
                        if (curVolaInPercent10 < 1)
                        {
                            return;
                        }
                        if (posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].State != PositionStateType.Open)
                        {
                            return;
                        }
                       
                        if (AllPositionsLongCount >= MaxPositions.ValueInt)
                        {
                            return;
                        }
                        if (macd401.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 1].OpenInterest < candlesSecurity[candlesSecurity.Count - 2].OpenInterest)
                        {
                            return;
                        }
                        //decimal lastEntryOrderPrice = openPositions3[openPositions3.Count - 1].EntryPrice;
                        if (newTrade.Price < posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice + posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice * macdd6K.ValueDecimal * curVolaInPercent10 / 100)
                        {
                            return;
                        }
                        

                        int z0 = tab.Securiti.DecimalsVolume;
                        decimal volume = decimal.Round(GetVolume(tab) * Volume1.ValueDecimal, z0);
                        tab.SellAtMarket(volume);
                        return;
                    }
                    //curVolaInPercent10= (sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100;
                    curVolaInPercent10 = Math.Abs((sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100);
                        // lastEntryOrderPrice10 = openPositions2[openPositions2.Count - 1].EntryPrice;
                    if (macdd6V.ValueDecimal != 0 && newTrade.Price > (posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice + (posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice * (P) * curVolaInPercent10) / 100) && ((SmaFilterIsOn200.ValueBool == true && newTrade.Price < candlesSecurity[candlesSecurity.Count - 3].Open) || (SmaFilterIsOn200.ValueBool == false)) /*&& arup < ardown*/ /*&& ardown > 50 */&& ((SmaFilterIsOn200.ValueBool == true && candlesSecurity[candlesSecurity.Count - 2].Close < candlesSecurity[candlesSecurity.Count - 2].Open && candlesSecurity[candlesSecurity.Count - 2].Open > (posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice + posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice / 100 * P * curVolaInPercent10)) || (SmaFilterIsOn200.ValueBool ==false  ))
                       && Regime.ValueString != "OnlyLong")
                    {
                        if (position1.Count >= MaxPositionsls.ValueDecimal)
                        {
                            return;
                        }
                        

                        if (curVolaInPercent10 < 1)
                        {
                            return;
                        }
                        if (posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].State != PositionStateType.Open)
                        {
                            return;
                        }
                        if (macd401.ValueDecimal != 0 && candlesSecurity[candlesSecurity.Count - 1].OpenInterest > candlesSecurity[candlesSecurity.Count - 2].OpenInterest)
                        {
                            return;
                        }
                        if (AllPositionsShortCount >= MaxPositions1.ValueInt)
                        {
                            return;
                        }
                        if (newTrade.Price < sma.DataSeries[0].Last)
                        {

                            return;

                        }
                        // decimal lastEntryOrderPrice = openPositions1[openPositions1.Count - 1].EntryPrice;

                        /*
                        if (SmaFilterIsOn110.ValueBool == true && newTrade.Price > sma.DataSeries[2].Last)
                        {


                            return;

                        }
                        */

                      
                        /*
                        if (SmaFilterIsOn3333.ValueDecimal != 0)
                        {
                            decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            //decimal cur1 = volaIndicatorOnSecurity.DataSeries[0].Last;
                            // decimal cr1 = volaIndicatorOnSecurity.DataSeries[1].Last;
                            if (cur1 > VolSma1 * SmaFilterIsOn3333.ValueDecimal)
                            {
                                return;
                            }
                        }
                        */
                        /*
                        if (SmaFilterIsOn120.ValueBool == true && newTrade.Price < sma.DataSeries[2].Last)
                        {


                            return;

                        }
                        */

                        int z0 = tab.Securiti.DecimalsVolume;
                        decimal volume = decimal.Round(GetVolume(tab) * Volume1.ValueDecimal, z0);

                      
                        /*
                        if (newTrade.Price < posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice + (posesOpenBySecurityS[posesOpenBySecurityS.Count - 1].EntryPrice * macdd6V.ValueDecimal * curVolaInPercent1) / 100)
                        {
                            return;
                        }
                        */
                        tab.SellAtMarket(volume);
                        return;
                    }
                    // lastEntryOrderPrice10 = openPositions2[openPositions2.Count - 1].EntryPrice;
                    

                }




            }
            //Thread.Sleep(100);










        }

        private decimal Sma(List<Candle> candlesSecurity, int len, int index)
        {
            if (candlesSecurity.Count == 0
                || index >= candlesSecurity.Count
                || index <= 0)
            {
                return 0;
            }

            decimal summ = 0;

            int countPoints = 0;

            for (int i = index; i >= 0 && i > index - len; i--)
            {
                countPoints++;
                summ += candlesSecurity[i].High;
            }

            if (countPoints == 0)
            {
                return 0;
            }

            return summ / countPoints;



        }
        private decimal Sma1(List<Candle> candlesSecurity, int len, int index)
        {
            if (candlesSecurity.Count == 0
                || index >= candlesSecurity.Count
                || index <= 0)
            {
                return 0;
            }

            decimal summ = 0;

            int countPoints = 0;

            for (int i = index; i >= 0 && i > index - len; i--)
            {
                countPoints++;
                summ += candlesSecurity[i].Low;
            }

            if (countPoints == 0)
            {
                return 0;
            }

            return summ / countPoints;
        }
        private void _tabScreener_PositionOpeningSuccesEvent(Position position, BotTabSimple tab)
        {
            int z0 = tab.Securiti.DecimalsVolume;
            decimal contractPrice = tab.PriceBestAsk;
            decimal volume = decimal.Round(position.OpenVolume / contractPrice, z0);
           // volume = Volume.ValueDecimal / contractPrice;


            // volume = Math.Round(volume, 6);
           // int z0 = tab.Securiti.DecimalsVolume;
           // volume = decimal.Round(volume, z0);


            decimal Profit11min11 = Volume * Profit11min1.ValueDecimal  / 100;
            Profit11min1K.ValueDecimal = Profit11min1K.ValueDecimal + Profit11min11;
            Aindicator volaIndicatorOnSecurity1 = (Aindicator)tab.Indicators[0];
            //decimal curVolaInPercent12 = volaIndicatorOnSecurity1.DataSeries[1].Last;
            Aindicator sma = (Aindicator)tab.Indicators[1];
            Aindicator ps = (Aindicator)tab.Indicators[3];

            // decimal Profit11min11 = Volume.ValueDecimal * Profit11min1.ValueDecimal * (AllPositionsShortCount + AllPositionsLongCount) / 100;
            //Profit11min1K.ValueDecimal = /*MaxPoses700000.ValueDecimal*/Profit11min1K.ValueDecimal + Profit11min1;
            if (sma.DataSeries[0].Last == 0 || sma.DataSeries[2].Last == 0 || sma.DataSeries[4].Last == 0)
            {
                return;
            }
            decimal curVolaInPercent13 = Math.Abs((sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100);
            decimal curVolaInPercent12 = Math.Abs((sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100);
            if (position.Direction == Side.Buy)
            {
                
                // decimal curVolaInPercent13 = Math.Abs((ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1] - ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1]) / ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1] * 100);
                // decimal curVolaInPercent12 = Math.Abs((ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1] - ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1]) / ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1] * 100);
                if (ProfitPercent.ValueDecimal != 0)
                {
                    //  decimal stopPrice =
                    // position.EntryPrice - position.EntryPrice * (StopPercent.ValueDecimal / 100);
                    decimal profitOrderPrice =
                    position.EntryPrice + (position.EntryPrice * (ProfitPercent.ValueDecimal * curVolaInPercent13 * Profit1111.ValueDecimal / 100));
                    // tab.CloseAtStopMarket(position, stopPrice);
                    tab.CloseAtProfitMarket(position, profitOrderPrice);
                }
                if (StopPercentl.ValueDecimal != 0)
                {
                    decimal stopPrice =
                    position.EntryPrice - position.EntryPrice * (StopPercentl.ValueDecimal/*  curVolaInPercent12*/ / 100);
                    // decimal profitOrderPrice =
                    // position.EntryPrice + position.EntryPrice * (ProfitPercent.ValueDecimal / 100);
                    tab.CloseAtStopMarket(position, stopPrice);
                    //  tab.CloseAtProfitMarket(position, profitOrderPrice);
                }
                if (Stopvl.ValueDecimal != 0)
                {
                    decimal stopPrice =
                    position.EntryPrice - position.EntryPrice * (Stopvl.ValueDecimal*  curVolaInPercent12 / 100);
                    // decimal profitOrderPrice =
                    // position.EntryPrice + position.EntryPrice * (ProfitPercent.ValueDecimal / 100);
                    tab.CloseAtStopMarket(position, stopPrice);
                    //  tab.CloseAtProfitMarket(position, profitOrderPrice);
                }


            }
            if (position.Direction == Side.Sell)
            {
                //curVolaInPercent12 = Math.Abs((sma.DataSeries[0].Last - sma.DataSeries[4].Last) / sma.DataSeries[4].Last * 100);
              //  decimal curVolaInPercent13 = Math.Abs((ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1] - ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1]) / ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1] * 100);
               // decimal curVolaInPercent12 = Math.Abs((ps.DataSeries[1].Values[ps.DataSeries[1].Values.Count - 1] - ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1]) / ps.DataSeries[0].Values[ps.DataSeries[0].Values.Count - 1] * 100);
                if (StopPercent.ValueDecimal != 0)
                {
                    decimal stopPrice =
                    position.EntryPrice + position.EntryPrice * (StopPercent.ValueDecimal /* curVolaInPercent12 *// 100);
                    //  decimal profitOrderPrice =
                    //  position.EntryPrice - position.EntryPrice * (ProfitPercent.ValueDecimal / 100);

                    tab.CloseAtStopMarket(position, stopPrice);
                    // tab.CloseAtProfitMarket(position, profitOrderPrice);
                }
                if (Stopvl.ValueDecimal != 0)
                {
                    decimal stopPrice =
                    position.EntryPrice + position.EntryPrice * (Stopvl.ValueDecimal * curVolaInPercent12 / 100);
                    //  decimal profitOrderPrice =
                    //  position.EntryPrice - position.EntryPrice * (ProfitPercent.ValueDecimal / 100);

                    tab.CloseAtStopMarket(position, stopPrice);
                    // tab.CloseAtProfitMarket(position, profitOrderPrice);
                }
                if (ProfitPercent.ValueDecimal != 0)
                {
                    //decimal stopPrice =
                    // position.EntryPrice + position.EntryPrice * (StopPercent.ValueDecimal / 100);
                    decimal profitOrderPrice =
                        position.EntryPrice - position.EntryPrice * (ProfitPercent.ValueDecimal * curVolaInPercent12 / 100);

                    //  tab.CloseAtStopMarket(position, stopPrice);
                    tab.CloseAtProfitMarket(position, profitOrderPrice);
                }
                
            }

        }

        private decimal GetVolume(BotTabSimple tab)
        {
            decimal volume = 0;

            if (VolumeType.ValueString == "Contracts")
            {
                volume = Volume.ValueDecimal;
            }
            else if (VolumeType.ValueString == "Contract currency")
            {
                decimal contractPrice = tab.PriceBestAsk;
                volume = Volume.ValueDecimal / contractPrice;


                // volume = Math.Round(volume, 6);
                int z0 = tab.Securiti.DecimalsVolume;
                volume = decimal.Round(volume, z0);
            }
            else if (VolumeType.ValueString == "Deposit percent")
            {
                Portfolio myPortfolio = tab.Portfolio;

                if (myPortfolio == null)
                {
                    return 0;
                }

                decimal portfolioPrimeAsset = 0;

                if (TradeAssetInPortfolio.ValueString == "Prime")
                {
                    portfolioPrimeAsset = myPortfolio.ValueCurrent;
                }
                else
                {
                    List<PositionOnBoard> positionOnBoard = myPortfolio.GetPositionOnBoard();

                    if (positionOnBoard == null)
                    {
                        return 0;
                    }

                    for (int i = 0; i < positionOnBoard.Count; i++)
                    {
                        if (positionOnBoard[i].SecurityNameCode == TradeAssetInPortfolio.ValueString)
                        {
                            portfolioPrimeAsset = positionOnBoard[i].ValueCurrent;
                            break;
                        }
                    }
                }

                if (portfolioPrimeAsset == 0)
                {
                    SendNewLogMessage("Can`t found portfolio " + TradeAssetInPortfolio.ValueString, Logging.LogMessageType.Error);
                    return 0;
                }

                decimal moneyOnPosition = portfolioPrimeAsset * (Volume.ValueDecimal / 100);

                decimal qty = moneyOnPosition / tab.PriceBestAsk / tab.Securiti.Lot;

                if (tab.StartProgram == StartProgram.IsOsTrader)
                {
                    qty = Math.Round(qty, tab.Securiti.DecimalsVolume);
                }
                else
                {
                    qty = Math.Round(qty, 7);
                }

                return qty;
            }

            return volume;
        }
    }

    public class CheckMoveTime
    {
        public string SecName;

        public DateTime LastCheckTime;
    }
}
//добавил код скринера
