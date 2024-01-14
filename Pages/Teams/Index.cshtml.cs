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
using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.AspNetCore.Http;

namespace League.Pages.Teams
{
  public class IndexModel : PageModel
  {
    // inject the Entity Framework context
    private readonly LeagueContext _context;

    public IndexModel(LeagueContext context)
    {
      _context = context;
    }

    public List<Conference> Conferences { get; set; }
    public List<Division> Divisions { get; set; }
    public List<Team> Teams { get; set; }

    //allow storage of a favorite team
    [BindProperty(SupportsGet = true)]
    public string FavoriteTeam { get; set; }
    public SelectList AllTeams { get; set; }
    [BindProperty(SupportsGet = true)]
    public string SortField { get; set; } = "Location";

        public async Task OnGetAsync()
    {
        // load all leagues, conferences, and divisions
        Conferences = await _context.Conferences.ToListAsync();
        Divisions = await _context.Divisions.ToListAsync();
        Teams = await _context.Teams.ToListAsync();

        switch (SortField)
        {
                case ("Location"): 
                    Teams = Teams.OrderBy(t => t.Location).ToList();
                    break;
                case ("Name"):
                    Teams = Teams.OrderBy(t => t.Name).ToList();
                    break;
                case ("Win"):
                    Teams = Teams.OrderByDescending(t => t.Win).ToList();
                    break;
                case ("Loss"):
                    Teams = Teams.OrderByDescending(t => t.Loss).ToList();
                    break;
                case ("Tie"):
                    Teams = Teams.OrderByDescending(t => t.Tie).ToList();
                    break;
                default:
                    Teams = Teams.OrderBy(t => t.Location).ToList();
                    break;
            }

        // make a list of teams for the favorite select dropdown
        IQueryable<string> teamQuery = from t in _context.Teams
                                    orderby t.TeamId
                                    select t.TeamId;

        AllTeams = new SelectList(await teamQuery.ToListAsync());


        // if a favorite exists manage the cookie

        if (FavoriteTeam != null)
        {
            HttpContext.Session.SetString("_Favorite", FavoriteTeam);
        }
        else
        {
            FavoriteTeam = HttpContext.Session.GetString("_Favorite");
        }
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
