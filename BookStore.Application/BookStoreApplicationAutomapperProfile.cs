using AutoMapper;
using BookStore.Application.User.Dto;
using BookStore.Domain.UserInfo;

namespace BookStore.Application;

public class BookStoreApplicationAutomapperProfile:Profile
{
    public BookStoreApplicationAutomapperProfile()
    {
        CreateMap<Users, UserDto>();
    }
}
