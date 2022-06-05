using BookStore.Application.User.Dto;
using BookStore.Domain.UserInfo;
using Volo.Abp.Application.Services;

namespace BookStore.Application.User;

public interface IUserAppService:IApplicationService
{
    Task<UserDto> Get(string userNo, string password);
}
