using PetManagemenSystem.WrapperService.Interfaces;
using PetManagement.Shared.Models;
using System.Net.Http.Json;

namespace PetManagementSystem.WrapperService.Implementation
{
    public class PetOwnerGetter : IPetOwnerGetter
    {
        private readonly HttpClient _httpClient;
        public PetOwnerGetter(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<PetOwner>> GetPetOwnerList()
        {
            return await _httpClient.GetFromJsonAsync<List<PetOwner>>("PetManagement/GetAllPersons");
        }
    }
}
