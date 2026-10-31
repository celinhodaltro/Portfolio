namespace Portfolio.Models;

public sealed record ExpertiseArea(
    string Title,
    string Description,
    IReadOnlyList<string> Technologies);
