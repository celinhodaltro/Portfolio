namespace Portfolio.Models;

public sealed record ProjectSummary(
    string Name,
    string Description,
    ProjectStatus Status,
    IReadOnlyList<string> Stack,
    string? Url = null);
