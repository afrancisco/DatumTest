using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DatumProcesso.API
{
    public class Api
    {
        private HttpClient restClient = new HttpClient();

        private string URL = "https://reqres.in";
        public async Task<RequestDTO> GetUserPageRequest(string page)
        {
            var Builder = new System.UriBuilder($"{URL}/api/users/?page={page}");
            var response =  restClient.GetAsync(Builder.Uri);
            var context =  response.Result.Content.ReadAsStringAsync();
           var y= JsonConvert.DeserializeObject<RequestDTO>(context.Result);
            return y;
        }

        public async Task<RequestSingleDTO> GetUserSingleRequest(string user)
        {
            var Builder = new System.UriBuilder($"{URL}/api/users/{user}");
            var response =  restClient.GetAsync(Builder.Uri);
            var context =  response.Result.Content.ReadAsStringAsync();
            var responseObj = JsonConvert.DeserializeObject<RequestSingleDTO>(context.Result);
            return responseObj;
        }
    }
}
