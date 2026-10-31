namespace Portfolio.Models;

public sealed record FeaturedProject(
    string Name,
    string Context,
    ProjectStatus Status,
    string Summary,
    string Problem,
    IReadOnlyList<string> Features,
    string Contribution,
    IReadOnlyList<string> Stack,
    IReadOnlyList<ProjectLink> Links,
    string? Image = null,
    string? ImageAlt = null,
    string? AccessNote = null,
    IReadOnlyList<string>? Commands = null,
    string? CoverIcon = null);
