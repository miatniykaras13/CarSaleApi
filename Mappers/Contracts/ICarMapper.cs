using Models.DTO;
using Models.Models;

namespace Mappers.Contracts;

public interface ICarMapper
{
    Car MapToCar(CarDto carDto);
    CarDto MapToCarDto(Car car);
}