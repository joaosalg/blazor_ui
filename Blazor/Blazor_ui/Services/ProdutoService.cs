using Blazor_ui.Services.DTO;
using System.Net.Http.Json;

namespace Blazor_ui.Services
{
	public class ProdutoService
	{
		public async Task<IEnumerable<ProdutoDTO>?> GetAll()
		{
			var httpclient = new HttpClient();
			httpclient.BaseAddress = new Uri("https://localhost:5001/api/v1");
			var listProduto = await httpclient.GetFromJsonAsync<IEnumerable<ProdutoDTO>>(httpclient.BaseAddress + "/Produto");
			return listProduto;
		}
	}
}
