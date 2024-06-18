using VirtualWaiter.Application.Data.DTO;

namespace VirtualWaiter.Application.Services.Eaterytable
{
    public interface IEaterytableServices
    {
        public Task<IEnumerable<EaterytableResponseDTO>> GetEaterytable();
        public Task<bool> Save(EaterytableRqCreateDTO eaterytable);
        public Task<EaterytableRequestDTO> GetEaterytableById(string id);
        public Task<bool> Update(EaterytableRequestDTO product);
        public Task<bool> Delete(int id);
    }
}
