using Blazor_ui.Services.DTO;
using System.Net.Http.Json;

namespace Blazor_ui.Services
{
	public class ProdutoService : BaseService<ProdutoDTO>
	{
		public ProdutoService(HttpClient httpClient) : base(httpClient, "/Produto") { }


	}
}
