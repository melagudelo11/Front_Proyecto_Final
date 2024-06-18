using VirtualWaiter.Application.Data.Common;

namespace VirtualWaiter.Application.Services
{
    public class BaseServices<T, K>
    {
        readonly HttpClient _httpClient;
        readonly AppSettings _settings;

        public BaseServices(HttpClient httpClient, AppSettings appSettings)
        {
            _httpClient = httpClient;
            _settings = appSettings;
        }

        public async Task<T> Get(K parameter, string urlService)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<T>($"{_settings.BaseUrl}{string.Format(urlService, parameter)}");
                return result!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> Post(K parameter, string urlService)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync($"{_settings.BaseUrl}{urlService}", parameter);
                var response = await result.Content.ReadFromJsonAsync<T>();
                return response!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> Put(K parameter, string urlService)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"{_settings.BaseUrl}{urlService}", parameter);
                var response = await result.Content.ReadFromJsonAsync<T>();
                return response!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> Delete(K parameter, string urlService)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"{_settings.BaseUrl}{string.Format(urlService, parameter)}");
                var response = await result.Content.ReadFromJsonAsync<T>();
                return response!;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
