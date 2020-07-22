using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient)
        {
            this._apiClient = apiClient;
        }

        public async Task Transfer(TransferDto transferDto)
        {
            var uri = "https://localhost:5001/api/Banking";
            var content = new StringContent(
                JsonConvert.SerializeObject(transferDto), 
                Encoding.UTF8, 
                "application/json");

            var response = await _apiClient.PostAsync(uri, content);
            response.EnsureSuccessStatusCode();
        }
    }
}
