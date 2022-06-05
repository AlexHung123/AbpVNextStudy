using BookStore.Application.User.Dto;
using BookStore.Domain.UserInfo;
using BookStore.EntityFramworkCore;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BookStore.Application.User;

public class UserAppService : ApplicationService, IUserAppService
{
    private IRepository<Users> _userRepository;

    public UserAppService(IRepository<Users> userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserDto> Get(string userNo, string password)
    {
        var user = await _userRepository.GetAsync(m=>m.UserNo == userNo && m.Password == password);
        var dto = ObjectMapper.Map<Users, UserDto>(user);
        return dto;
    }

}
