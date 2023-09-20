using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ServiceTest.Services
{
    public class TriviaService
    {
        private HttpClient client;
        private JsonSerializerOptions options;
        const string url = @"https://zr8z94hw-44376.euw.devtunnels.ms/AmericanQuestions/";

        public TriviaService()
        {
            client = new HttpClient();
            options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, WriteIndented=true };
        }

        public async Task<string> CheckConnection()
        {

            try
            {
                var response = await client.GetAsync($"{url}GetQuestions");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                else
                    return "Error";
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return null;
        }



    }
}
