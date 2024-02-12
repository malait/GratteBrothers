using PetManagemenSystem.WrapperService.Interfaces;
using PetManagement.Shared.Models;
using System.Net.Http.Json;

namespace PetManagementSystem.WrapperService.Implementation
{
    public class PersonsGetter : IPersonsGetter
    {
        private readonly HttpClient _httpClient;
        public PersonsGetter(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Person>> GetAllPersons()
        {
            return await _httpClient.GetFromJsonAsync<List<Person>>("PetManagement/GetAllPersons");
        }
    }
}
