using ERP.Cryptography;
using ERP.Models;
using ERP.Models.ApiRequests;
using ERP.Models.ApiResponses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace ERP.Api
{
    class ERPApi
    {
        private HttpClient _client = new HttpClient();

        public ERPApi()
        {
            _client.BaseAddress = new Uri("http://localhost:8080/api");
            _client.DefaultRequestHeaders.Add("X-KILLERBEE-APP", "ERP");
        }

        public async Task<LoginResponse> Login(UsernameAndPasswordRequest request)
        {
            LoginResponse authResp = null;
            try
            {
                var response = await _client.PostAsync("/auth", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
                response.EnsureSuccessStatusCode();
                authResp = await response.Content.ReadFromJsonAsync<LoginResponse>();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.StackTrace);
            }

            return authResp;
        }

        public async Task<List<Frisbee>> GetFrisbee()
        {
            var response = await _client.GetAsync("/frisbee");
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadFromJsonAsync<List<Frisbee>>();
            return resp;
        }
    }
}
