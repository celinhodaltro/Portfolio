namespace Portfolio.Models;

public sealed record ExpertiseArea(
    string Icon,
    string Title,
    string Description,
    IReadOnlyList<string> Technologies);
