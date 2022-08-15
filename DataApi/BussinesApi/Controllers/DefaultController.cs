using BussinessApi.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace BussinesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class DefaultController : ControllerBase
    {
        private readonly IDistributedCache _distributedCache; //cache

        public DefaultController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<List<Currency>>  CurrencyList()
        {
            var cacheKey = DateTime.Now.Day.ToString();
            string serializedCodes;
            List<Currency> currencyList = new();
            string serializedCurrencyList;
            var redisCurrencyList = await _distributedCache.GetAsync(cacheKey);
            if (redisCurrencyList != null)
            {
                serializedCurrencyList = Encoding.UTF8.GetString(redisCurrencyList);
                currencyList = JsonConvert.DeserializeObject<List<Currency>>(serializedCurrencyList);
            }
            else
            {
                using var c = new Context();
                currencyList = c.Currencies.ToList();
                serializedCurrencyList = JsonConvert.SerializeObject(currencyList);
                redisCurrencyList = Encoding.UTF8.GetBytes(serializedCurrencyList);
                // SetAbsoluteExpiration: Mutlak olarak cacheKeyin temizlenme zamanını belirtiriz.
                // SetSlidingExpiration: Server 'a bir istek atılmazsa cacheKey silinir, SetAbsoluteExpiration 'dan çok olamaz.
                var options = new DistributedCacheEntryOptions().SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(2));
                await _distributedCache.SetAsync(cacheKey, redisCurrencyList, options);
            }

            
            return currencyList;
        }

    }

}
