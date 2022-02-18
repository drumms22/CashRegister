using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
namespace CashRegister
{
	public class RequestHandler
	{

		String strRequest = "";
		List<object> returnData = new List<object>();

		public RequestHandler()
		{
		}

		public RequestHandler makeRequest()
        {
			return new RequestHandler();
        }

		public List<object> fetch()
        {
			Console.WriteLine("Fetching....");

			returnData = getProducts();

			return returnData;
			
        }

		private List<object> getProducts()
        {
			List<object> products = new List<object>();
			products.Add(new Product("abcd1234", 123, "Test", "This is a test!", 9.99f, 10));
			products.Add(new Product("efgh5678", 123, "Test2", "This is test 2!", 12.99f, 10));
			products.Add(new Product("ijkl9876", 123, "Test3", "This is test 3!", 19.99f, 10));

			return products;
        }

        public async Task<string> PostCallAPI(string url, object jsonObject)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(url, content);
                    if (response != null)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        return jsonString;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }


    }
}
