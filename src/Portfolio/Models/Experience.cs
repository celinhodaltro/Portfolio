namespace Portfolio.Models;

public sealed record Experience(
    string Company,
    string Role,
    string Period,
    string Summary,
    IReadOnlyList<string> Highlights,
    IReadOnlyList<string> Stack);
