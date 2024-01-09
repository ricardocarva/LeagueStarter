using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace League.Pages
{
  public class TeamModel : PageModel
  {
    private readonly ILogger<IndexModel> _logger;

    public TeamModel(ILogger<IndexModel> logger)
    {
      _logger = logger;
    }

    public void OnGet()
    {

    }
  }
}
