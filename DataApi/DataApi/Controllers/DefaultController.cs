using DataApi.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace DataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        
        [HttpPost]
        public IActionResult CurrencyAdd(Currency currency)
        {
			VeriCek();
            return Ok();
        }

		private void VeriCek()
		{
			DateTime now = DateTime.Now;
			int month = now.Month;
			int day = now.Day;
			int i = 0;
			List<Currency> crList = new();
			while (i < 60)
			{
				try
				{
					XmlTextReader reader = new XmlTextReader(createUrl(day, month));
					reader.ReadToFollowing("Currency");
					while (reader.Read())
					{
						Currency currency = new Currency();
						currency.Date = day + "/" + month + "/" + 2022;
						reader.ReadToFollowing("Unit");
						currency.Unit = reader.ReadString();
						reader.ReadToFollowing("Isim");
						currency.Isim = reader.ReadString();
						reader.ReadToFollowing("CurrencyName");
						currency.CurrencyName = reader.ReadString();
						reader.ReadToFollowing("ForexBuying");
						currency.ForexBuying = reader.ReadString();
						reader.ReadToFollowing("ForexSelling");
						currency.ForexSelling = reader.ReadString();
						reader.ReadToFollowing("BanknoteBuying");
						currency.BanknoteBuying = reader.ReadString();
						reader.ReadToFollowing("BanknoteSelling");
						currency.BanknoteSelling = reader.ReadString();
						reader.ReadToFollowing("CrossRateUSD");
						currency.CrossRateUSD = reader.ReadString();
						reader.ReadToFollowing("CrossRateOther");
						currency.CrossRateOther = reader.ReadString();
						crList.Add(currency);
					}
					if (day > 1)
					{
						day--;
					}
					else
					{
						month--;
						day = 31;
					}
				}
				catch (Exception)
				{
					day--;
				}
				i++;
			}
			foreach (var item in crList)
			{
				using var c = new Context();
				c.Add(item);
				c.SaveChanges();
			}
		}

		public static String createUrl(int day, int month)
		{
			String URLString = "https://www.tcmb.gov.tr/kurlar";
			//https://www.tcmb.gov.tr/kurlar/202208/12082022.xml

			if (month < 10 && day < 10)
			{
				URLString = URLString + "/" + "2022" + "0" + month.ToString() + "/0" + day.ToString() + "0" + month.ToString() + "" + "2022" + ".xml";
			}
			else if (month > 10 && day < 10)
			{
				URLString = URLString + "/" + "2022" + month.ToString() + "/0" + day.ToString() + month.ToString() + "" + "2022" + ".xml";
			}
			else if (month < 10 && day > 10)
			{
				URLString = URLString + "/" + "2022" + "0" + month.ToString() + "/" + day.ToString() + "0" + month.ToString() + "" + "2022" + ".xml";
			}
			else
			{
				URLString = URLString + "/" + "2022" + month.ToString() + "/" + day.ToString() + month.ToString() + "" + "2022" + ".xml";
			}
			return URLString;
		}
	}
}
