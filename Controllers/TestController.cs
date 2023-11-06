using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Back1106.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			return Ok(new
			{
				message = "App Service 後端部署"
			});
		}

	}
}
