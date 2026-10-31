using Portfolio.Models;

namespace Portfolio.Data;

public static class Career
{
    public static readonly IReadOnlyList<Experience> Experiences =
    [
        new(
            "Produs Soluções · CONDER",
            "Analista de Geoinformática",
            "05/2024 — atual",
            "img/experiences/conder.webp",
            "Desenvolvimento e entrega de soluções de geoinformação, do backend .NET às interfaces integradas ao ArcGIS.",
            [
                "Desenvolvimento de sistemas corporativos com ASP.NET, C# e Entity Framework, integrados a Oracle e PostgreSQL.",
                "Criação de widgets customizados para o ArcGIS Experience Builder e de interfaces com Blazor, React e MudBlazor.",
                "Sistema de visualização imersiva no estilo Street View, com fotografias 360° georreferenciadas.",
                "Sistema de videomonitoramento integrado a câmeras e a dados geoespaciais.",
                "Solução para gestão e carga de obras em nível estadual, na Bahia.",
                "Integração com ArcGIS Online, QGIS e serviços e camadas geoespaciais.",
                "Implantação de rotinas DevOps e pipelines de CI/CD, organizando o processo de desenvolvimento.",
                "Modernização, manutenção e evolução de sistemas existentes, com modelagem e otimização de bancos de dados.",
                "Apresentações técnicas e demonstrações de sistemas para stakeholders e clientes."
            ],
            ["C#", "ASP.NET", "Entity Framework", "Blazor", "MudBlazor", "React", "ArcGIS", "QGIS", "Oracle", "PostgreSQL", "CI/CD"]),
        new(
            "General Claims",
            "Desenvolvedor Full Stack",
            "05/2022 — 05/2024",
            "img/experiences/gclaims.webp",
            "Desenvolvimento e evolução de sistemas corporativos com .NET e Angular.",
            [
                "Desenvolvimento de sistemas com C#, .NET Framework e Angular, com foco em performance e experiência do usuário.",
                "Construção e consumo de APIs REST e Web Services para integração entre sistemas.",
                "Modelagem, consultas e otimização de bancos SQL Server.",
                "Melhorias estruturais e otimizações para performance e escalabilidade das aplicações.",
                "Evolução de aplicações existentes, com ajustes de interface e de fluxo.",
                "Participação em todo o ciclo de desenvolvimento, da concepção à entrega."
            ],
            ["C#", ".NET Framework", "Angular", "APIs REST", "SQL Server"]),
        new(
            "DivTech",
            "Estagiário em Desenvolvimento de Software",
            "05/2021 — 05/2022",
            "img/experiences/divtech.webp",
            "Desenvolvimento fullstack com ASP.NET MVC em projetos para clientes.",
            [
                "Desenvolvimento de aplicações com ASP.NET MVC no backend e HTML, CSS, Bootstrap e JavaScript no frontend.",
                "Sistemas CRUD, relatórios, APIs e integrações entre sistemas.",
                "Desenvolvimento e manutenção de bancos de dados MySQL.",
                "Participação em projetos para clientes como Vizcaya e IPMA Brasil.",
                "Trabalho com Scrum, participando das cerimônias e da organização das demandas."
            ],
            ["ASP.NET MVC", "C#", "JavaScript", "Bootstrap", "MySQL"],
            "Estágio")
    ];
}
