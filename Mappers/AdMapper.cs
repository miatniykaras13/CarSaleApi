using Mappers.Contracts;
using Models.DTO;
using Models.Models;

namespace Mappers;

public class AdMapper : IAdMapper
{
    public Ad MapToAd(AdDto adDto)
    {
        var ad = new Ad();
        ad.AdId = adDto.AdId;
        ad.Title = adDto.Title;
        ad.Description = adDto.Description;
        ad.Publisher = adDto.Publisher;
        ad.IsDeleted = adDto.IsDeleted;
        ad.AdDate = adDto.AdDate;
        ad.PriceInBy = adDto.PriceInBy;
        ad.PriceInUsd = adDto.PriceInUsd;
        return ad;
    }

    public AdDto MapToAdDto(Ad ad)
    {
        var adDto = new AdDto();
        adDto.AdId = ad.AdId;
        adDto.Title = ad.Title;
        adDto.Description = ad.Description;
        adDto.Publisher = ad.Publisher;
        adDto.IsDeleted = ad.IsDeleted;
        adDto.AdDate = ad.AdDate;
        adDto.PriceInBy = ad.PriceInBy;
        adDto.PriceInUsd = ad.PriceInUsd;
        return adDto;
    }
}