using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace restApiYaniuk
{
   public class ConsimpleRestClient 
    {
        static readonly HttpClient client = new HttpClient();
        const string ConsimpleUri = "https://tester.consimple.pro/";

        public async Task<OverallData> GetOverallData()
        {
            try
            {
                var response = await client.GetAsync(ConsimpleUri);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStreamAsync();
                var responseDeserialize =  await JsonSerializer.DeserializeAsync<OverallData>(responseBody);
                return responseDeserialize;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }           
        }
    }
}
