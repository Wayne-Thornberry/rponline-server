using Newtonsoft.Json;
using Pro.Trading.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CTrading
{
    public class CTradingAPI
    {
        public void DeleteItem(object[] args)
        {
            try
            { 
                var client = new HttpClient();
                var api = new TradingAPI("http://pro-trading-webapi", client);
                var x = api.DeleteItemAsync(new DeleteItemRequest()
                {
                    Name = args[0].ToString(),
                }); 
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.ToString());
            }
        }

        public object ListItem()
        {
            try
            {
                var client = new HttpClient();
                var api = new TradingAPI("http://pro-trading-webapi", client);
                var x = api.ListItemsAsync();
                return JsonConvert.SerializeObject(x.Result.Items);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString()); 
            }
            return null;
        }

        public void PutItem(object[] args)
        {
            try
            {
                var client = new HttpClient();
                var api = new TradingAPI("http://pro-trading-webapi", client);
                var x = api.InsertItemAsync(new InsertItemRequest()
                {
                    Item = new Item()
                    {
                        Name = args[0].ToString(),
                        Price = new Random().Next()
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
