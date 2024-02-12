using Microsoft.AspNetCore.Mvc;
using PetManagement.Service.Interface;
using PetManagement.Shared.Models;

namespace PetManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PetManagementController : Controller
    {
        private IPersonsGetter _personsGetter {  get; set; }    
        private ISpeciesGetter _speciesGetter { get; set; }
        private IPetOwnerGetter _petOwnerGetter { get; set; }
        private IPetOwnerAdder _petOwnerAdder { get; set; }
        private IPetNameUpdater _petNameUpdater { get; set; }

        public PetManagementController(IPersonsGetter personsGetter, ISpeciesGetter speciesGetter, 
                                       IPetOwnerGetter petOwnerGetter, IPetOwnerAdder petOwnerAdder, 
                                       IPetNameUpdater petNameUpdater)
        {
            _personsGetter = personsGetter;
            _speciesGetter = speciesGetter;
            _petOwnerGetter = petOwnerGetter;
            _petOwnerAdder = petOwnerAdder;
            _petNameUpdater = petNameUpdater;
        }

        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return _personsGetter.GetAllPersons();
        }

        [HttpGet]
        public IEnumerable<Species> GetAllSpecies()
        {
            return _speciesGetter.GetAllSpecies();  
        }

        [HttpGet]
        public IEnumerable<PetOwner> GetPetOwners()
        {
            return _petOwnerGetter.GetPetOwnerList();
        }
        [HttpPut]
        public void SavePetOwnerDetails(PetOwner petOwner)
        {
            _petOwnerAdder.AddNewPetOwner(petOwner);
        }

        [HttpPut]
        public void UpdatePetName(int id, string newName)
        {
            _petNameUpdater.UpdateName(id, newName);
        }
    }
}
