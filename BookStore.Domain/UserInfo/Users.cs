using Volo.Abp.Domain.Entities;

namespace BookStore.Domain.UserInfo;

public class Users : Entity<int>
{
    public string UserNo { get; set; }
    public string UserName { get; set; }
    public int RoleId { get; set; }
    public string Password { get; set; }
}
