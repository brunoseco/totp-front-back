using AspNetCore.Totp;
using Microsoft.AspNetCore.Mvc;

namespace back_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class TOTPController : ControllerBase
{
    private readonly ILogger<TOTPController> _logger;

    public TOTPController(ILogger<TOTPController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public int[] Get()
    {
        var generator = new TotpGenerator();
        var code = generator.GetValidTotps("beb228c5-cf4b-4ac9-8ba5-fd0e677ee56e", TimeSpan.FromSeconds(60));
        return code.ToArray();
    }
}
