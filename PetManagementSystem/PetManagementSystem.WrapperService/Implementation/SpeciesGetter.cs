using PetManagemenSystem.WrapperService.Interfaces;
using PetManagement.Shared.Models;
using System.Net.Http.Json;

namespace PetManagementSystem.WrapperService.Implementation
{
    public class SpeciesGetter : ISpeciesGetter
    {
        private readonly HttpClient _httpClient;
        public SpeciesGetter(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Species>> GetAllSpecies()
        {
            return await _httpClient.GetFromJsonAsync<List<Species>>("PetManagement/GetAllSpecies");
        }
    }
}
