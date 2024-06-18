using Microsoft.Extensions.Options;
using VirtualWaiter.Application.Data.Common;
using VirtualWaiter.Application.Data.DTO;

namespace VirtualWaiter.Application.Services.Eaterytable
{
    public class EaterytableServices : IEaterytableServices
    {
        readonly HttpClient _httpClient;
        readonly AppSettings _appSettings;

        public EaterytableServices(HttpClient httpClient, IOptions<AppSettings> appsetting)
        {

            _appSettings = appsetting.Value;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_appSettings.BaseUrl);
        }

        public async Task<bool> Delete(int id)
        {
            BaseServices<bool, int> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Delete(id, _appSettings.DeleteEaterytableAddress);
        }

        public async Task<EaterytableRequestDTO> GetEaterytableById(string id)
        {
            BaseServices<EaterytableRequestDTO, string> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Get(id, _appSettings.GetEaterytableByIdAddress);
        }

        public async Task<IEnumerable<EaterytableResponseDTO>> GetEaterytable()
        {
            BaseServices<IEnumerable<EaterytableResponseDTO>, string> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Get(string.Empty, _appSettings.GetEaterytableAddress);
        }

        public async Task<bool> Save(EaterytableRqCreateDTO eaterytable)
        {

            BaseServices<bool, EaterytableRqCreateDTO> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Post(eaterytable, _appSettings.PostEaterytableAddress);

        }

        public async Task<bool> Update(EaterytableRequestDTO eaterytable)
        {
            BaseServices<bool, EaterytableRequestDTO> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Put(eaterytable, _appSettings.UpdateEaterytableAddress);
        }
    }
}
