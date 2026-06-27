using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServerTimeWeb.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public string ServerTime { get; set; } = string.Empty;

    public void OnGet()
    {
        // Get the current server date and time using DateTime.Now
        ServerTime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
    }
}
