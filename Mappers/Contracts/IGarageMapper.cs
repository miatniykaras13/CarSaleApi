using Models.DTO;
using Models.Models;

namespace Mappers.Contracts;

public interface IGarageMapper
{
    Garage MapToGarage(GarageDto garageDto);
    GarageDto MapToGarageDto(Garage garage);
}