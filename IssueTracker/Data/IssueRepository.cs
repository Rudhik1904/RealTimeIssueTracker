using IssueTracker.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Data;

public class IssueRepository : IIssueRepository
{
    private readonly ApplicationDbContext _context;

    public IssueRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Issue>> GetAllIssuesAsync()
    {
        return await _context.Issues.ToListAsync();
    }

    public async Task<Issue> CreateIssueAsync(Issue issue)
    {
        _context.Issues.Add(issue);
        await _context.SaveChangesAsync();
        return issue;
    }

    public async Task<Issue> UpdateIssueAsync(Issue issue)
    {
        _context.Entry(issue).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return issue;
    }
}