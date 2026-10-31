namespace Portfolio.Models;

public sealed record Experience(
    string Company,
    string Role,
    string Period,
    string Image,
    string Summary,
    IReadOnlyList<string> Highlights,
    IReadOnlyList<string> Stack,
    string? Detail = null);
