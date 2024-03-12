using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CV_Lab3;

public class SkillService
{
    private readonly ApplicationDbContext _context;

    public SkillService(ApplicationDbContext context)
    {
        _context = context;
    }

    // Hämta alla skills
    public async Task<List<Skill>> GetSkills()
    {
        return await _context.Skills.ToListAsync();
    }

    // Hämta en skills baserat på ID
    public async Task<Skill> GetSkillById(int id)
    {
        return await _context.Skills.FindAsync(id);
    }

    // Lägg till en ny skills
    public async Task AddSkill(Skill skill)
    {
        _context.Skills.Add(skill);
        await _context.SaveChangesAsync();
    }

    // Uppdatera en befintlig skills
    public async Task UpdateSkill(Skill skill)
    {
        _context.Entry(skill).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    // Ta bort en skills baserat på ID
    public async Task DeleteSkill(int id)
    {
        var skill = await _context.Skills.FindAsync(id);
        _context.Skills.Remove(skill);
        await _context.SaveChangesAsync();
    }
}



