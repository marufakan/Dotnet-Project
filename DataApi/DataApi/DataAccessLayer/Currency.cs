using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi
{
	public class Currency
	{
		[Key]
		public int CurrencyID { get; set; }
		public String Unit { get; set; }
		public String Isim { get; set; }
		public String CurrencyName { get; set; }
		public String ForexBuying { get; set; }
		public String ForexSelling { get; set; }
		public String BanknoteBuying { get; set; }
		public String BanknoteSelling { get; set; }
		public String CrossRateUSD { get; set; }
		public String CrossRateOther { get; set; }
		public String Date { get; set; }
	}
}
