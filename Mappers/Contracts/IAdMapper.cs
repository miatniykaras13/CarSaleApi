using Models.DTO;
using Models.Models;

namespace Mappers.Contracts;

public interface IAdMapper
{
    Ad MapToAd(AdDto adDto);
    AdDto MapToAdDto(Ad ad);
}