using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Controller : ITodo
    {
        private async Task<dynamic> Restaraunts(string url)
        {
            using (HttpClient client = CreateClient(url))
            {
                // Get the game status for the specified gameID                
                HttpResponseMessage response = await client.GetAsync("/BoggleService.svc/games/" + gameId + (brief ? "?Brief:yes" : ""), token);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject(responseContent);
                }
                return null;
            }
        }

        private string Akey = "aUnq3MkC7YMvWG12fZBMcmQ3ovtlapIn2owaVPeq";

        private HttpClient CreateClient(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            return client;
        }
    }


}
