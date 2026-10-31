using Portfolio.Models;

namespace Portfolio.Data;

public static class Profile
{
    public const string Name = "João Marcelo Daltro Marques";
    public const string ShortName = "João Marcelo";
    public const string Role = "Desenvolvedor .NET";
    public const string Location = "Salvador, BA";
    public const string Coordinates = "12°58′S 38°30′W";
    public const string Email = "celinhodaltro@gmail.com";
    public const string GitHub = "https://github.com/celinhodaltro";
    public const string LinkedIn = "https://www.linkedin.com/in/joaomarcelomarques/";
    public const string WhatsApp = "https://wa.me/5571992834507";
    public const string Resume = "docs/curriculo/Curriculo-Joao-Marcelo-Daltro-Marques.pdf";

    public const string Headline =
        "Experiência em desenvolvimento de sistemas corporativos, soluções GIS, geoinformação e aplicações web.";

    public const string Introduction =
        "Construo sistemas de ponta a ponta com C#, ASP.NET Core e Blazor: APIs, integrações, bancos de dados e interfaces. " +
        "Na Produs Soluções, atuando na CONDER, desenvolvo soluções de geoinformação integradas ao ArcGIS, " +
        "da visualização imersiva com fotografias 360° ao videomonitoramento e à gestão de obras em nível estadual.";

    public static readonly IReadOnlyList<string> Focus =
    [
        "Sistemas corporativos com .NET",
        "Geoinformação e ArcGIS",
        "Aplicações web com Blazor, React e Angular",
        "DevOps e CI/CD"
    ];

    public static readonly Education Education =
        new("Bacharelado em Ciência da Computação", "Unopar Anhanguera", "Em andamento · conclusão prevista para 2028");

    public static readonly IReadOnlyList<ContactChannel> Channels =
    [
        new("E-mail", Email, $"mailto:{Email}"),
        new("LinkedIn", "in/joaomarcelomarques", LinkedIn),
        new("GitHub", "celinhodaltro", GitHub),
        new("WhatsApp", "+55 71 99283-4507", WhatsApp)
    ];
}
