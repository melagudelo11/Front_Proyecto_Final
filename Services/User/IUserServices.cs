using VirtualWaiter.Application.Data.DTO;

namespace VirtualWaiter.Application.Services.User
{
    public interface IUserServices
    {
        public Task<IEnumerable<UserResponseDTO>> GetUser();
        public Task<bool> Save(UserRqCreateDTO user);
        public Task<UserRequestDTO> GetUserById(string id);
        public Task<bool> Update(UserRequestDTO user);
        public Task<bool> Delete(int id);
    }
}
