using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CV_Lab3;

public class ProjectService
{
    private readonly ApplicationDbContext _context;

    public ProjectService(ApplicationDbContext context)
    {
        _context = context;
    }

    // Hämta alla projekt
    public async Task<List<Project>> GetProjects()
    {
        return await _context.Projects.ToListAsync();
    }

    // Hämta ett projekt baserat på ID
    public async Task<Project> GetProjectById(int id)
    {
        return await _context.Projects.FindAsync(id);
    }

    // Lägg till ett nytt projekt
    public async Task AddProject(Project project)
    {
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
    }

    // Uppdatera ett befintligt projekt
    public async Task UpdateProject(Project project)
    {
        _context.Entry(project).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    // Ta bort ett projekt baserat på ID
    public async Task DeleteProject(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        _context.Projects.Remove(project);
        await _context.SaveChangesAsync();
    }
}



