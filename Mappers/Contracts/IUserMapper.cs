using Models.DTO;
using Models.Models;

namespace Mappers.Contracts;

public interface IUserMapper
{
    User MapToUser(UserDto userDto);
    UserDto MapToUserDto(User user);
}