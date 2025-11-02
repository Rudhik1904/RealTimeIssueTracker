using System;
using IssueTracker.Data;

namespace IssueTracker.Interfaces;
public interface IIssueRepository
{
    Task<List<Issue>> GetAllIssuesAsync();
    Task<Issue> CreateIssueAsync(Issue issue);
    Task<Issue> UpdateIssueAsync(Issue issue);
}