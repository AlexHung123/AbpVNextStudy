using Volo.Abp.Application.Dtos;

namespace BookStore.Application.User.Dto;

public class UserDto:EntityDto<int>
{
    public string UserNo { get; set; }
    public string UserName { get; set; }
    public int RoleId { get; set; }
    public string Password { get; set; }
}
