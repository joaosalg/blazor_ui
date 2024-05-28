using Blazor_ui.Services.DTO;
using System.Net.Http.Json;

namespace Blazor_ui.Services
{
	public class PedidoService
	{
		public async Task<IEnumerable<PedidoDTO>?> GetAll()
		{
			var httpclient = new HttpClient();
			httpclient.BaseAddress = new Uri("https://localhost:5001/api/v1");
			var listProduto = await httpclient.GetFromJsonAsync<IEnumerable<PedidoDTO>>(httpclient.BaseAddress + "/Pedido");
			return listProduto;
		}
	}
}
