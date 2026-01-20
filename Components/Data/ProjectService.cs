using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

namespace dev_portfolio.Components.Data;
public class ProjectService(DevDbContext db)
{
  private readonly DevDbContext _db = db;

  public async Task<List<Project>> GetProjectsAsync() => 
    await _db.Projects.ToListAsync();
}
