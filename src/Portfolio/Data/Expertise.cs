using Portfolio.Models;

namespace Portfolio.Data;

public static class Expertise
{
    public static readonly IReadOnlyList<ExpertiseArea> Areas =
    [
        new(
            "Backend .NET",
            "APIs REST, regras de negócio e integrações entre sistemas com C# e ASP.NET Core, organizadas em camadas e com persistência via Entity Framework.",
            ["C#", "ASP.NET Core", "Entity Framework", "APIs REST", "SignalR", "MediatR"]),
        new(
            "Geoinformação e GIS",
            "Soluções de visualização, monitoramento e análise territorial, com widgets próprios para o ArcGIS Experience Builder e integração com serviços e camadas geoespaciais.",
            ["ArcGIS Experience Builder", "ArcGIS Online", "ArcGIS Pro SDK", "QGIS", "NetTopologySuite"]),
        new(
            "Frontend e aplicações",
            "Interfaces web e multiplataforma com Blazor e MudBlazor, React para widgets ArcGIS, Angular em sistemas corporativos e .NET MAUI com Blazor Hybrid.",
            ["Blazor", "MudBlazor", "React", "Angular", ".NET MAUI"]),
        new(
            "Dados",
            "Modelagem, consultas complexas e otimização de bancos relacionais, com atenção a performance e integridade dos dados.",
            ["Oracle", "PostgreSQL", "SQL Server", "MySQL", "SQLite"]),
        new(
            "DevOps e arquitetura",
            "Pipelines de CI/CD, conteinerização e implantação de aplicações, com arquitetura modular e separação clara de responsabilidades.",
            ["CI/CD", "GitHub Actions", "Docker", ".NET Aspire", "Clean Architecture"])
    ];
}
