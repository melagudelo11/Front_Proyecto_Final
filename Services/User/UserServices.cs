using Microsoft.Extensions.Options;
using VirtualWaiter.Application.Data.Common;
using VirtualWaiter.Application.Data.DTO;

namespace VirtualWaiter.Application.Services.User
{
    public class UserServices: IUserServices
    {
        readonly HttpClient _httpClient;
        readonly AppSettings _appSettings;

        public UserServices(HttpClient httpClient, IOptions<AppSettings> appsetting)
        {

            _appSettings = appsetting.Value;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_appSettings.BaseUrl);
        }

        public async Task<bool> Delete(int id)
        {
            BaseServices<bool, int> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Delete(id, _appSettings.DeleteUserAddress);
        }

        public async Task<UserRequestDTO> GetUserById(string id)
        {
            BaseServices<UserRequestDTO, string> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Get(id, _appSettings.GetUserByIdAddress);
        }

        public async Task<IEnumerable<UserResponseDTO>> GetUser()
        {
            BaseServices<IEnumerable<UserResponseDTO>, string> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Get(string.Empty, _appSettings.GetUserAddress);
        }

        public async Task<bool> Save(UserRqCreateDTO user)
        {

            BaseServices<bool, UserRqCreateDTO> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Post(user, _appSettings.PostUserAddress);

        }

        public async Task<bool> Update(UserRequestDTO user)
        {
            BaseServices<bool, UserRequestDTO> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Put(user, _appSettings.UpdateUserAddress);
        }
    }
}
