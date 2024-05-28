using Blazor_ui.Services.DTO;
using System.Net.Http.Json;

namespace Blazor_ui.Services
{
	public class PedidoService : BaseService<PedidoDTO>
	{
		public PedidoService(HttpClient httpClient) : base(httpClient, "/Pedido") { }

	}
}
