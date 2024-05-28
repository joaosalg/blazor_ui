using Blazor_ui.Services.DTO;
using System.Net.Http.Json;

namespace Blazor_ui.Services
{
	public abstract class BaseService<T>
	{
		protected readonly HttpClient _httpClient;
		protected readonly string _urlGet;

		protected BaseService (HttpClient httpClient, string urlGet)
		{
			_httpClient = httpClient;
			_urlGet = urlGet;
		}

		public async Task<IEnumerable<T>?> GetAll()
		{
			var list = await _httpClient.GetFromJsonAsync<IEnumerable<T>>(_httpClient.BaseAddress + _urlGet);
			return list;
		}
	}
}
