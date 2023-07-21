using WisdomPetMedicine.Rescue.Domain.Dto;
using WisdomPetMedicine.Rescue.Domain.Entities;

namespace WisdomPetMedicine.Rescue.Domain.Repositories;

public interface IRescueRepository
{
    Task<RescuedAnimal> GetRescuedAnimalAsync(RescuedAnimalId id);
    Task AddRescuedAnimalAsync(RescuedAnimal rescuedAnimal);
    Task UpdateRescuedAnimalAsync(RescuedAnimal rescuedAnimal);
    Task<Adopter> GetAdopterAsync(AdopterId id);
    Task AddAdopterAsync(Adopter adopter);
    Task UpdateAdopterAsync(Adopter adopter);
}
