using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using myEventCloud.Roles.Dto;
using myEventCloud.Users.Dto;

namespace myEventCloud.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
