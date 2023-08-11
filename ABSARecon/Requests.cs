using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSARecon
{
    public class FileDetails
    {
        public string FilePath { get; set; }
        public string FileNameWithoutExtension { get; set; }

    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CustomerSheetModel
    {
        public int BRA_CODE { get; set; }
        public int CUS_NUM { get; set; }
        public int CUR_CODE { get; set; }
        public int LED_CODE { get; set; }
        public int SUB_ACCT_CODE { get; set; }
        public string CUST_NAME { get; set; }
        public double DEBIT_AMT { get; set; }
        public double CREDIT_AMT { get; set; }
        public double CRNT_BAL { get; set; }
        public int TELL_ID { get; set; }
        public int ORIGT_BRA_CODE { get; set; }
        public string ADDRESS { get; set; }
        public int SEQUENCE { get; set; }
        public int ORIGT_TRA_SEQ2 { get; set; }
        public string DOC_NUM { get; set; }
        public string TRA_DATE { get; set; }
        public string VAL_DATE { get; set; }
        public string ACT_TRA_DATE { get; set; }
        public int UPD_TIME { get; set; }
        public int EXPL_CODE { get; set; }
        public string EXPLXT { get; set; }
        public string REMARKS { get; set; }
        public string REFERENCE { get; set; }
    }



 

    public class VISADATA
    {
        public string NUM { get; set; }
        public string DATE { get; set; }
        public string TIME { get; set; }
        [JsonProperty("CARD NUMBER")]
        public string CARDNUMBER { get; set; }
        public string NUMBER { get; set; }
        public string CODE { get; set; }
        public string AMOUNT { get; set; }
        public string CUR { get; set; }
      
        [JsonProperty("AMOUNT (US")]
        public string AMOUNTUS { get; set; }
        [JsonProperty("D)")]
        public string D { get; set; }
        public int ConvertNumberToInteger { get; set; }
    }

    public class CleanedData
    {
        public string NUM { get; set; }
        public string DATE { get; set; }
        public string TIME { get; set; }
        [JsonProperty("CARD NUMBER")]
        public string CARDNUMBER { get; set; }
        public string NUMBER { get; set; }
        public string CODE { get; set; }
        public string AMOUNT { get; set; }
        public string CUR { get; set; }

        [JsonProperty("AMOUNT (US")]
        public string AMOUNTUS { get; set; }
        [JsonProperty("D)")]
        public string D { get; set; }
     
    }

    public class CleanedDataTwo
    {
        public string NUM { get; set; }
        public string DATE { get; set; }
        public string TIME { get; set; }
        [JsonProperty("CARD NUMBER")]
        public string CARDNUMBER { get; set; }
        public string NUMBER { get; set; }
       
        public string AMOUNT { get; set; }
        public string CUR { get; set; }

        [JsonProperty("AMOUNT (US")]
        public string AMOUNTUS { get; set; }
        [JsonProperty("D)")]
        public string D { get; set; }

    }

    public class CleanedDataThree
    {
        public string NUM { get; set; }
        public string DATE { get; set; }
        public string TIME { get; set; }
        [JsonProperty("CARD NUMBER")]
        public string CARDNUMBER { get; set; }
        public string NUMBER { get; set; }

        public string AMOUNT { get; set; }
        public string CUR { get; set; }

        [JsonProperty("AMOUNT (US")]
        public string AMOUNTUS { get; set; }
        [JsonProperty("D)")]
        public string D { get; set; }

    }



    public class CardCentre
    {
        public int branch_number { get; set; }
        public int account_number { get; set; }
        public string short_name { get; set; }
        public string posting_date { get; set; }
        public int dr_cr_ind { get; set; }
        public int transaction_code { get; set; }
        public object narrative { get; set; }
        public int currency_number { get; set; }
        public string currency_amount { get; set; }
        public double currency_balance { get; set; }
        public int terminal_number { get; set; }
        public int terminal_sequence_number { get; set; }
        public int originating_branch { get; set; }
        public int account_type { get; set; }
        public string stmnt_date_and_time { get; set; }
        public int serial_number { get; set; }
        public string source_system { get; set; }
    }

    public class cleanCardCentre
    {
        
       
        public object narrative { get; set; }
        public object Narrative { get; set; }
        public string currency_amount { get; set; }
        public string stmnt_date_and_time { get; set; }
    }

}
