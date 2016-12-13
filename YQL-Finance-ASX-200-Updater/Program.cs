using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQL_Finance_ASX_200_Updater.Models;

using System.Collections.ObjectModel;
using System.Xml.Linq;
using System.Windows;
//using System.Windows.Threading;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace YQL_Finance_ASX_200_Updater
{
    class Program 
    {
        //private readonly DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Background);


        public ObservableCollection<Quote> Quotes { get; set; }


        public void CardDeckViewModel()
        {   
            Quotes = new ObservableCollection<Quote>();

            //Some example tickers
            //Quotes.Add(new Quote("CAR.ax"));

            //Quotes.Add(new Quote("ALQ.ax"));
            //Quotes.Add(new Quote("AMC.ax"));
            //Quotes.Add(new Quote("AMP.ax"));
            //Quotes.Add(new Quote("ANN.ax"));
            //Quotes.Add(new Quote("ANZ.ax"));
            //Quotes.Add(new Quote("APA.ax"));
            //Quotes.Add(new Quote("AST.ax"));
            //Quotes.Add(new Quote("ASX.ax"));
            //Quotes.Add(new Quote("AWC.ax"));
            //Quotes.Add(new Quote("AZJ.ax"));
            //Quotes.Add(new Quote("BEN.ax"));
            //Quotes.Add(new Quote("BHP.ax"));
            //Quotes.Add(new Quote("BKL.ax"));
            //Quotes.Add(new Quote("BLD.ax"));
            //Quotes.Add(new Quote("BOQ.ax"));
            //Quotes.Add(new Quote("BSL.ax"));
            //Quotes.Add(new Quote("BXB.ax"));
            //Quotes.Add(new Quote("CAR.ax"));
            //Quotes.Add(new Quote("CBA.ax"));
            //Quotes.Add(new Quote("CCL.ax"));
            //Quotes.Add(new Quote("CGF.ax"));
            //Quotes.Add(new Quote("CIM.ax"));
            //Quotes.Add(new Quote("COH.ax"));
            //Quotes.Add(new Quote("CPU.ax"));
            //Quotes.Add(new Quote("CSL.ax"));
            //Quotes.Add(new Quote("CSR.ax"));
            //Quotes.Add(new Quote("CTX.ax"));
            //Quotes.Add(new Quote("CWN.ax"));
            //Quotes.Add(new Quote("CYB.ax"));
            //Quotes.Add(new Quote("DLX.ax"));
            //Quotes.Add(new Quote("DMP.ax"));
            //Quotes.Add(new Quote("DOW.ax"));
            //Quotes.Add(new Quote("DUE.ax"));
            //Quotes.Add(new Quote("DXS.ax"));
            //Quotes.Add(new Quote("FLT.ax"));
            //Quotes.Add(new Quote("FMG.ax"));
            //Quotes.Add(new Quote("FXJ.ax"));
            //Quotes.Add(new Quote("GMG.ax"));
            //Quotes.Add(new Quote("GNC.ax"));
            //Quotes.Add(new Quote("GPT.ax"));
            //Quotes.Add(new Quote("HGG.ax"));
            //Quotes.Add(new Quote("HSO.ax"));
            //Quotes.Add(new Quote("HVN.ax"));
            //Quotes.Add(new Quote("IAG.ax"));
            //Quotes.Add(new Quote("IFL.ax"));
            //Quotes.Add(new Quote("ILU.ax"));
            //Quotes.Add(new Quote("INM.ax"));
            //Quotes.Add(new Quote("IOF.ax"));
            //Quotes.Add(new Quote("IPL.ax"));
            //Quotes.Add(new Quote("JBH.ax"));
            //Quotes.Add(new Quote("JHX.ax"));
            //Quotes.Add(new Quote("LLC.ax"));
            //Quotes.Add(new Quote("MFG.ax"));
            //Quotes.Add(new Quote("MGR.ax"));
            //Quotes.Add(new Quote("MPL.ax"));
            //Quotes.Add(new Quote("MQG.ax"));
            //Quotes.Add(new Quote("NAB.ax"));
            //Quotes.Add(new Quote("NCM.ax"));
            //Quotes.Add(new Quote("NST.ax"));
            //Quotes.Add(new Quote("NVT.ax"));
            //Quotes.Add(new Quote("ORA.ax"));
            //Quotes.Add(new Quote("ORG.ax"));
            //Quotes.Add(new Quote("ORI.ax"));
            //Quotes.Add(new Quote("OSH.ax"));
            //Quotes.Add(new Quote("PPT.ax"));
            //Quotes.Add(new Quote("PRY.ax"));
            //Quotes.Add(new Quote("QAN.ax"));
            //Quotes.Add(new Quote("QBE.ax"));
            //Quotes.Add(new Quote("QUB.ax"));
            //Quotes.Add(new Quote("REA.ax"));
            //Quotes.Add(new Quote("RHC.ax"));
            //Quotes.Add(new Quote("RIO.ax"));
            //Quotes.Add(new Quote("RMD.ax"));
            //Quotes.Add(new Quote("S32.ax"));
            //Quotes.Add(new Quote("SCG.ax"));
            //Quotes.Add(new Quote("SEK.ax"));
            //Quotes.Add(new Quote("SGP.ax"));
            //Quotes.Add(new Quote("SGR.ax"));
            //Quotes.Add(new Quote("SHL.ax"));
            //Quotes.Add(new Quote("SKI.ax"));
            //Quotes.Add(new Quote("SRX.ax"));
            //Quotes.Add(new Quote("STO.ax"));
            //Quotes.Add(new Quote("SUN.ax"));
            //Quotes.Add(new Quote("SYD.ax"));
            //Quotes.Add(new Quote("TAH.ax"));
            //Quotes.Add(new Quote("TCL.ax"));
            //Quotes.Add(new Quote("TLS.ax"));
            //Quotes.Add(new Quote("TPM.ax"));
            //Quotes.Add(new Quote("TTS.ax"));
            //Quotes.Add(new Quote("TWE.ax"));
            //Quotes.Add(new Quote("VCX.ax"));
            //Quotes.Add(new Quote("VOC.ax"));
            //Quotes.Add(new Quote("WBC.ax"));
            //Quotes.Add(new Quote("WES.ax"));
            //Quotes.Add(new Quote("WFD.ax"));
            //Quotes.Add(new Quote("WOW.ax"));
            //Quotes.Add(new Quote("WPL.ax"));

            Quotes.Add(new Quote("A2M.ax"));
            Quotes.Add(new Quote("AAC.ax"));
            Quotes.Add(new Quote("AAD.ax"));
            Quotes.Add(new Quote("ABC.ax"));
            Quotes.Add(new Quote("ABP.ax"));
            Quotes.Add(new Quote("ACX.ax"));
            Quotes.Add(new Quote("AGL.ax"));
            Quotes.Add(new Quote("AHG.ax"));
            Quotes.Add(new Quote("AHY.ax"));
            Quotes.Add(new Quote("ALL.ax"));
            Quotes.Add(new Quote("ALQ.ax"));
            Quotes.Add(new Quote("ALU.ax"));
            Quotes.Add(new Quote("AMC.ax"));
            Quotes.Add(new Quote("AMP.ax"));
            Quotes.Add(new Quote("ANN.ax"));
            Quotes.Add(new Quote("ANZ.ax"));
            Quotes.Add(new Quote("AOG.ax"));
            Quotes.Add(new Quote("APA.ax"));
            Quotes.Add(new Quote("API.ax"));
            Quotes.Add(new Quote("APN.ax"));
            Quotes.Add(new Quote("APO.ax"));
            Quotes.Add(new Quote("ARB.ax"));
            Quotes.Add(new Quote("AST.ax"));
            Quotes.Add(new Quote("ASX.ax"));
            Quotes.Add(new Quote("AWC.ax"));
            Quotes.Add(new Quote("AZJ.ax"));
            Quotes.Add(new Quote("BAL.ax"));
            Quotes.Add(new Quote("BAP.ax"));
            Quotes.Add(new Quote("BEN.ax"));
            Quotes.Add(new Quote("BGA.ax"));
            Quotes.Add(new Quote("BHP.ax"));
            Quotes.Add(new Quote("BKL.ax"));
            Quotes.Add(new Quote("BKW.ax"));
            Quotes.Add(new Quote("BLD.ax"));
            Quotes.Add(new Quote("BOQ.ax"));
            Quotes.Add(new Quote("BPT.ax"));
            Quotes.Add(new Quote("BRG.ax"));
            Quotes.Add(new Quote("BSL.ax"));
            Quotes.Add(new Quote("BTT.ax"));
            Quotes.Add(new Quote("BWP.ax"));
            Quotes.Add(new Quote("BXB.ax"));
            Quotes.Add(new Quote("CAR.ax"));
            Quotes.Add(new Quote("CBA.ax"));
            Quotes.Add(new Quote("CCL.ax"));
            Quotes.Add(new Quote("CCP.ax"));
            Quotes.Add(new Quote("CGC.ax"));
            Quotes.Add(new Quote("CGF.ax"));
            Quotes.Add(new Quote("CHC.ax"));
            Quotes.Add(new Quote("CIM.ax"));
            Quotes.Add(new Quote("CMW.ax"));
            Quotes.Add(new Quote("COH.ax"));
            Quotes.Add(new Quote("CPU.ax"));
            Quotes.Add(new Quote("CQR.ax"));
            Quotes.Add(new Quote("CSL.ax"));
            Quotes.Add(new Quote("CSR.ax"));
            Quotes.Add(new Quote("CTD.ax"));
            Quotes.Add(new Quote("CTX.ax"));
            Quotes.Add(new Quote("CWN.ax"));
            Quotes.Add(new Quote("CWY.ax"));
            Quotes.Add(new Quote("CYB.ax"));
            Quotes.Add(new Quote("DLX.ax"));
            Quotes.Add(new Quote("DMP.ax"));
            Quotes.Add(new Quote("DOW.ax"));
            Quotes.Add(new Quote("DUE.ax"));
            Quotes.Add(new Quote("DXS.ax"));
            Quotes.Add(new Quote("ECX.ax"));
            Quotes.Add(new Quote("EHE.ax"));
            Quotes.Add(new Quote("EVN.ax"));
            Quotes.Add(new Quote("FBU.ax"));
            Quotes.Add(new Quote("FLT.ax"));
            Quotes.Add(new Quote("FMG.ax"));
            Quotes.Add(new Quote("FPH.ax"));
            Quotes.Add(new Quote("FXJ.ax"));
            Quotes.Add(new Quote("FXL.ax"));
            Quotes.Add(new Quote("GEM.ax"));
            Quotes.Add(new Quote("GMA.ax"));
            Quotes.Add(new Quote("GMG.ax"));
            Quotes.Add(new Quote("GNC.ax"));
            Quotes.Add(new Quote("GOZ.ax"));
            Quotes.Add(new Quote("GPT.ax"));
            Quotes.Add(new Quote("GTY.ax"));
            Quotes.Add(new Quote("GUD.ax"));
            Quotes.Add(new Quote("GWA.ax"));
            Quotes.Add(new Quote("GXL.ax"));
            Quotes.Add(new Quote("GXY.ax"));
            Quotes.Add(new Quote("HGG.ax"));
            Quotes.Add(new Quote("HSO.ax"));
            Quotes.Add(new Quote("HVN.ax"));
            Quotes.Add(new Quote("IAG.ax"));
            Quotes.Add(new Quote("IFL.ax"));
            Quotes.Add(new Quote("IFN.ax"));
            Quotes.Add(new Quote("IGO.ax"));
            Quotes.Add(new Quote("ILU.ax"));
            Quotes.Add(new Quote("INM.ax"));
            Quotes.Add(new Quote("IOF.ax"));
            Quotes.Add(new Quote("IPH.ax"));
            Quotes.Add(new Quote("IPL.ax"));
            Quotes.Add(new Quote("IRE.ax"));
            Quotes.Add(new Quote("ISD.ax"));
            Quotes.Add(new Quote("IVC.ax"));
            Quotes.Add(new Quote("JBH.ax"));
            Quotes.Add(new Quote("JHC.ax"));
            Quotes.Add(new Quote("JHX.ax"));
            Quotes.Add(new Quote("LLC.ax"));
            Quotes.Add(new Quote("LNK.ax"));
            Quotes.Add(new Quote("MFG.ax"));
            Quotes.Add(new Quote("MGR.ax"));
            Quotes.Add(new Quote("MIN.ax"));
            Quotes.Add(new Quote("MMS.ax"));
            Quotes.Add(new Quote("MND.ax"));
            Quotes.Add(new Quote("MPL.ax"));
            Quotes.Add(new Quote("MQA.ax"));
            Quotes.Add(new Quote("MQG.ax"));
            Quotes.Add(new Quote("MTR.ax"));
            Quotes.Add(new Quote("MTS.ax"));
            Quotes.Add(new Quote("MYO.ax"));
            Quotes.Add(new Quote("MYR.ax"));
            Quotes.Add(new Quote("MYX.ax"));
            Quotes.Add(new Quote("NAB.ax"));
            Quotes.Add(new Quote("NCM.ax"));
            Quotes.Add(new Quote("NEC.ax"));
            Quotes.Add(new Quote("NSR.ax"));
            Quotes.Add(new Quote("NST.ax"));
            Quotes.Add(new Quote("NUF.ax"));
            Quotes.Add(new Quote("NVT.ax"));
            Quotes.Add(new Quote("NWS.ax"));
            Quotes.Add(new Quote("NXT.ax"));
            Quotes.Add(new Quote("OFX.ax"));
            Quotes.Add(new Quote("ORA.ax"));
            Quotes.Add(new Quote("ORE.ax"));
            Quotes.Add(new Quote("ORG.ax"));
            Quotes.Add(new Quote("ORI.ax"));
            Quotes.Add(new Quote("OSH.ax"));
            Quotes.Add(new Quote("OZL.ax"));
            Quotes.Add(new Quote("PGH.ax"));
            Quotes.Add(new Quote("PMV.ax"));
            Quotes.Add(new Quote("PPT.ax"));
            Quotes.Add(new Quote("PRY.ax"));
            Quotes.Add(new Quote("PTM.ax"));
            Quotes.Add(new Quote("QAN.ax"));
            Quotes.Add(new Quote("QBE.ax"));
            Quotes.Add(new Quote("QUB.ax"));
            Quotes.Add(new Quote("REA.ax"));
            Quotes.Add(new Quote("REG.ax"));
            Quotes.Add(new Quote("RFG.ax"));
            Quotes.Add(new Quote("RHC.ax"));
            Quotes.Add(new Quote("RIO.ax"));
            Quotes.Add(new Quote("RMD.ax"));
            Quotes.Add(new Quote("RRL.ax"));
            Quotes.Add(new Quote("RSG.ax"));
            Quotes.Add(new Quote("RWC.ax"));
            Quotes.Add(new Quote("S32.ax"));
            Quotes.Add(new Quote("SAI.ax"));
            Quotes.Add(new Quote("SAR.ax"));
            Quotes.Add(new Quote("SBM.ax"));
            Quotes.Add(new Quote("SCG.ax"));
            Quotes.Add(new Quote("SCP.ax"));
            Quotes.Add(new Quote("SDF.ax"));
            Quotes.Add(new Quote("SEK.ax"));
            Quotes.Add(new Quote("SFR.ax"));
            Quotes.Add(new Quote("SGM.ax"));
            Quotes.Add(new Quote("SGP.ax"));
            Quotes.Add(new Quote("SGR.ax"));
            Quotes.Add(new Quote("SHL.ax"));
            Quotes.Add(new Quote("SIP.ax"));
            Quotes.Add(new Quote("SKC.ax"));
            Quotes.Add(new Quote("SKI.ax"));
            Quotes.Add(new Quote("SKT.ax"));
            Quotes.Add(new Quote("SPK.ax"));
            Quotes.Add(new Quote("SPO.ax"));
            Quotes.Add(new Quote("SRX.ax"));
            Quotes.Add(new Quote("STO.ax"));
            Quotes.Add(new Quote("SUL.ax"));
            Quotes.Add(new Quote("SUN.ax"));
            Quotes.Add(new Quote("SVW.ax"));
            Quotes.Add(new Quote("SWM.ax"));
            Quotes.Add(new Quote("SXL.ax"));
            Quotes.Add(new Quote("SYD.ax"));
            Quotes.Add(new Quote("SYR.ax"));
            Quotes.Add(new Quote("TAH.ax"));
            Quotes.Add(new Quote("TCL.ax"));
            Quotes.Add(new Quote("TGR.ax"));
            Quotes.Add(new Quote("TLS.ax"));
            Quotes.Add(new Quote("TME.ax"));
            Quotes.Add(new Quote("TNE.ax"));
            Quotes.Add(new Quote("TPM.ax"));
            Quotes.Add(new Quote("TTS.ax"));
            Quotes.Add(new Quote("TWE.ax"));
            Quotes.Add(new Quote("VCX.ax"));
            Quotes.Add(new Quote("VOC.ax"));
            Quotes.Add(new Quote("VRT.ax"));
            Quotes.Add(new Quote("WBC.ax"));
            Quotes.Add(new Quote("WEB.ax"));
            Quotes.Add(new Quote("WES.ax"));
            Quotes.Add(new Quote("WFD.ax"));
            Quotes.Add(new Quote("WHC.ax"));
            Quotes.Add(new Quote("WOR.ax"));
            Quotes.Add(new Quote("WOW.ax"));
            Quotes.Add(new Quote("WPL.ax"));
            Quotes.Add(new Quote("WSA.ax"));


            //Quotes.Add(new Quote("MSFT"));
            //Quotes.Add(new Quote("INTC"));
            //Quotes.Add(new Quote("IBM"));
            //Quotes.Add(new Quote("RVBD"));
            //Quotes.Add(new Quote("AMZN"));
            //Quotes.Add(new Quote("BIDU"));
            //Quotes.Add(new Quote("SINA"));
            //Quotes.Add(new Quote("THI"));
            //Quotes.Add(new Quote("NVDA"));
            //Quotes.Add(new Quote("AMD"));
            //Quotes.Add(new Quote("DELL"));
            //Quotes.Add(new Quote("WMT"));
            //Quotes.Add(new Quote("GLD"));
            //Quotes.Add(new Quote("SLV"));
            //Quotes.Add(new Quote("V"));
            //Quotes.Add(new Quote("V"));
            //Quotes.Add(new Quote("MCD"));

            //get the data
            Fetch(Quotes);

            //poll every 25 seconds
            //timer.Interval = new TimeSpan(0, 0, 25);
            //timer.Tick += (o, e) => YahooStockEngine.Fetch(Quotes);

            //timer.Start();
        }

        static void Main(string[] args)
        {

            Program programInstance = new Program();
            programInstance.CardDeckViewModel();

            //Program.CardDeckViewModel();
            //Quotes = new ObservableCollection<Quote>();
            // Models.Quote Quotes = new Quote();
            //Quote q = new Quote);
            //            Quotes = new ObservableCollection<Quote>();

            //Some example tickers
            //Quotes.Add(new Quote("AAPL"));
            
           //Fetch(Quotes);
        }


        private const string BASE_URL = "http://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20({0})&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

        public static void Fetch(ObservableCollection<Quote> quotes)
        {
            string symbolList = String.Join("%2C", quotes.Select(w => "%22" + w.Symbol + "%22").ToArray());
            string url = string.Format(BASE_URL, symbolList);

            XDocument doc = XDocument.Load(url);
            Parse(quotes, doc);
        }

        private static void Parse(ObservableCollection<Quote> quotes, XDocument doc)
        {
            XElement results = doc.Root.Element("results");

            foreach (Quote quote in quotes)
            {
                XElement q = results.Elements("quote").First(w => w.Attribute("symbol").Value == quote.Symbol);

                quote.Ask = GetDecimal(q.Element("Ask").Value);
                quote.Bid = GetDecimal(q.Element("Bid").Value);
                quote.AverageDailyVolume = GetDecimal(q.Element("AverageDailyVolume").Value);
                quote.BookValue = GetDecimal(q.Element("BookValue").Value);
                quote.Change = GetDecimal(q.Element("Change").Value);
                quote.DividendShare = GetDecimal(q.Element("DividendShare").Value);
                quote.LastTradeDate = GetDateTime(q.Element("LastTradeDate") + " " + q.Element("LastTradeTime").Value);
                quote.EarningsShare = GetDecimal(q.Element("EarningsShare").Value);
                quote.EpsEstimateCurrentYear = GetDecimal(q.Element("EPSEstimateCurrentYear").Value);
                quote.EpsEstimateNextYear = GetDecimal(q.Element("EPSEstimateNextYear").Value);
                quote.EpsEstimateNextQuarter = GetDecimal(q.Element("EPSEstimateNextQuarter").Value);
                quote.DailyLow = GetDecimal(q.Element("DaysLow").Value);
                quote.DailyHigh = GetDecimal(q.Element("DaysHigh").Value);
                quote.YearlyLow = GetDecimal(q.Element("YearLow").Value);
                quote.YearlyHigh = GetDecimal(q.Element("YearHigh").Value);
                quote.MarketCapitalization = GetDecimal(q.Element("MarketCapitalization").Value);
                quote.Ebitda = GetDecimal(q.Element("EBITDA").Value);
                quote.ChangeFromYearLow = GetDecimal(q.Element("ChangeFromYearLow").Value);
                quote.PercentChangeFromYearLow = GetDecimal(q.Element("PercentChangeFromYearLow").Value);
                quote.ChangeFromYearHigh = GetDecimal(q.Element("ChangeFromYearHigh").Value);
                quote.LastTradePrice = GetDecimal(q.Element("LastTradePriceOnly").Value);
                quote.PercentChangeFromYearHigh = GetDecimal(q.Element("PercebtChangeFromYearHigh").Value); //missspelling in yahoo for field name
                quote.FiftyDayMovingAverage = GetDecimal(q.Element("FiftydayMovingAverage").Value);
                quote.TwoHunderedDayMovingAverage = GetDecimal(q.Element("TwoHundreddayMovingAverage").Value);
                quote.ChangeFromTwoHundredDayMovingAverage = GetDecimal(q.Element("ChangeFromTwoHundreddayMovingAverage").Value);
                quote.PercentChangeFromTwoHundredDayMovingAverage = GetDecimal(q.Element("PercentChangeFromTwoHundreddayMovingAverage").Value);
                quote.PercentChangeFromFiftyDayMovingAverage = GetDecimal(q.Element("PercentChangeFromFiftydayMovingAverage").Value);
                quote.Name = q.Element("Name").Value;
                quote.Open = GetDecimal(q.Element("Open").Value);
                quote.PreviousClose = GetDecimal(q.Element("PreviousClose").Value);
                quote.ChangeInPercent = GetDecimal(q.Element("ChangeinPercent").Value);
                quote.PriceSales = GetDecimal(q.Element("PriceSales").Value);
                quote.PriceBook = GetDecimal(q.Element("PriceBook").Value);
                quote.ExDividendDate = GetDateTime(q.Element("ExDividendDate").Value);
                quote.PeRatio = GetDecimal(q.Element("PERatio").Value);
                quote.DividendPayDate = GetDateTime(q.Element("DividendPayDate").Value);
                quote.PegRatio = GetDecimal(q.Element("PEGRatio").Value);
                quote.PriceEpsEstimateCurrentYear = GetDecimal(q.Element("PriceEPSEstimateCurrentYear").Value);
                quote.PriceEpsEstimateNextYear = GetDecimal(q.Element("PriceEPSEstimateNextYear").Value);
                quote.ShortRatio = GetDecimal(q.Element("ShortRatio").Value);
                quote.OneYearPriceTarget = GetDecimal(q.Element("OneyrTargetPrice").Value);
                quote.Volume = GetDecimal(q.Element("Volume").Value);
                quote.StockExchange = q.Element("StockExchange").Value;

                quote.LastUpdate = DateTime.Now;

                if(quote.ChangeInPercent < -5)
                {
                    try
                    {

                        SmtpClient mySmtpClient = new SmtpClient("email-smtp.us-west-2.amazonaws.com");

                        // set smtp-client with basicAuthentication
                        mySmtpClient.EnableSsl = true;
                        mySmtpClient.Port = 587;
                        mySmtpClient.UseDefaultCredentials = false;
                        System.Net.NetworkCredential basicAuthenticationInfo = new
                           System.Net.NetworkCredential("AKIAJN4LNQF3GS42GUOQ", "Aup8zkLSOhUUL54Qk2IWFxILN9wnZN1ktQkJijP8UUP1");
                        mySmtpClient.Credentials = basicAuthenticationInfo;

                        // add from,to mailaddresses
                        MailAddress from = new MailAddress("team@formey.com", "Share Alerter");
                        MailAddress to = new MailAddress("peterski@gmail.com", "Lets Action It");
                        MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                        // add ReplyTo
                     //   MailAddress replyto = new MailAddress("reply@example.com");
                       // myMail.ReplyToList.Add(replyTo);

                        // set subject and encoding
                        myMail.Subject = "Share price drop alert!";
                        myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                        // set body-message and encoding
                        myMail.Body = "<b>" + quote.Name.ToString() + " has dropped below 5% Today (" + quote.ChangeInPercent.ToString() + ") </b>.";
                        myMail.BodyEncoding = System.Text.Encoding.UTF8;
                        // text or html
                        myMail.IsBodyHtml = true;

                        mySmtpClient.Send(myMail);
                    }

                    catch (SmtpException ex)
                    {
                        throw new ApplicationException
                          ("SmtpException has occured: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
            }
        }

        private static decimal? GetDecimal(string input)
        {
            if (input == null) return null;

            input = input.Replace("%", "");

            decimal value;

            if (Decimal.TryParse(input, out value)) return value;
            return null;
        }

        private static DateTime? GetDateTime(string input)
        {
            if (input == null) return null;

            DateTime value;

            if (DateTime.TryParse(input, out value)) return value;
            return null;
        }


    }
}
