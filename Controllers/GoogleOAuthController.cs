using Microsoft.AspNetCore.Mvc;
using PinMapWebServer.Services;

namespace PinMapWebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleOAuthController : ControllerBase
    {
        private readonly IGoogleOAuthService _googleOAuthService;

        public GoogleOAuthController(IGoogleOAuthService googleOAuthService)
        {
            _googleOAuthService = googleOAuthService;



        }

        /// <summary>
        /// User Login
        /// </summary>
        [HttpPost]
        public void Post()
        {
            _googleOAuthService.UserLogin();
        }
    }
}
