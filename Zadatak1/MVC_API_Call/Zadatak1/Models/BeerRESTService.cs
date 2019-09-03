using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Zadatak1.Models
{
    public class BeerRESTService
    {
        private readonly string baseURL = "https://api.punkapi.com/v2/beers";
        public async Task<string> GetDataFromApi(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();

                }
                return null;
            }
        }

        public async Task<List<Beer>> GetBeers()
        {
            string url = baseURL;
            var data = await GetDataFromApi(url);
            return JsonConvert.DeserializeObject<List<Beer>>(data);
        }

        public async Task<List<Beer>> GetBeers(IList<QueryFilter> queryParams)
        {
            UriBuilder uri = new UriBuilder(baseURL);
            var query = HttpUtility.ParseQueryString(uri.Query);

            queryParams.Where(filter => !string.IsNullOrEmpty(filter.Value))
                       .ToList()
                       .ForEach(filter => query[filter.Key] = filter.Value);

            uri.Query = query.ToString();

            var data = await GetDataFromApi(uri.Uri.ToString());
            return JsonConvert.DeserializeObject<List<Beer>>(data);
        }

        public async Task<Beer> GetRandomBeer()
        {
            string url = $"{baseURL}/random";
            var data = await GetDataFromApi(url);
            return JsonConvert.DeserializeObject<List<Beer>>(data).First();
        }

    }
}