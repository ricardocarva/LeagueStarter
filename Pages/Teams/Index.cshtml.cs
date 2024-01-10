using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using League.Models;
using League.Data;
using System.Linq;

namespace League.Pages.Teams
{
  public class IndexModel : PageModel
  {
    private readonly LeagueContext _context;

    public IndexModel(LeagueContext context)
    {
      _context = context;
    }

    public List<Conference> Conferences { get; set; }
    public List<Division> Divisions { get; set; }
    public List<Team> Teams { get; set; }
    public async Task OnGetAsync()
    {
      Conferences = await _context.Conferences.ToListAsync();
      Divisions = await _context.Divisions.ToListAsync();
      Teams = await _context.Teams.ToListAsync();

    }

    public List<Division> GetConferenceDivisions(string ConferenceId)
    {
      return Divisions.Where(d => d.ConferenceId.Equals(ConferenceId)).ToList();
    }

    public List<Team> GetDivisionTeams(string DivisionId)
    {
      return Teams.Where(t => t.DivisionId.Equals(DivisionId)).ToList();
    }
  }
}
