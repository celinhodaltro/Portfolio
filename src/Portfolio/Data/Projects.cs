using MudBlazor;
using Portfolio.Models;

namespace Portfolio.Data;

public static class Projects
{
    private const string Repositories = "https://github.com/celinhodaltro";

    public static readonly IReadOnlyList<FeaturedProject> Featured =
    [
        new(
            "Ursulla",
            "Projeto pessoal · MMORPG",
            ProjectStatus.InDevelopment,
            "MMORPG multiplayer com engine própria em .NET: cliente renderizado com Silk.NET e OpenGL e backend modular com ASP.NET Core e SignalR.",
            "Construir um jogo online de ponta a ponta sem engine comercial, controlando renderização, rede, regras de jogo e infraestrutura.",
            [
                "Engine própria com módulos de renderização do mundo, assets, interface com ImGui e rede.",
                "Sistemas próprios de mundo, criaturas, combate e construção, além de crafting, profissões e economia.",
                "Serviço de autenticação e servidor de jogo em tempo real com SignalR, PostgreSQL e Redis.",
                "Orquestração local da stack com .NET Aspire e Dockerfiles por serviço.",
                "Editor de mapas, CLI de desenvolvimento e ferramentas para geração de assets e texturas."
            ],
            "Projeto autoral: arquitetura, engine, backend, ferramentas e regras de jogo.",
            [".NET 9", "Silk.NET", "OpenGL", "ImGui.NET", "ASP.NET Core", "SignalR", "EF Core", "PostgreSQL", "Redis", ".NET Aspire"],
            [new("Versões anteriores", $"{Repositories}/Ursulla-Online-Server")],
            AccessNote: "Código-fonte em repositório privado",
            CoverIcon: Icons.Material.Filled.SportsEsports),
        new(
            "ExpForge",
            "Open source · CLI",
            ProjectStatus.Published,
            "Ferramenta de linha de comando em .NET para criar e manter widgets do ArcGIS Experience Builder, distribuída como pacote npm.",
            "A criação de widgets do Experience Builder envolve muita estrutura repetitiva. O ExpForge automatiza esse trabalho e padroniza o resultado.",
            [
                "Comandos para criar e renomear widgets e gerar novos componentes a partir de templates.",
                "Geração automática de documentação dos widgets.",
                "Instalação global via npm, com binários publicados a partir do .NET.",
                "Site de documentação próprio desenvolvido em Blazor."
            ],
            "Criação e manutenção do projeto: arquitetura em camadas, comandos, empacotamento npm, testes e documentação.",
            [".NET 9", "C#", "MediatR", "FluentValidation", "xUnit", "npm", "ArcGIS Experience Builder", "Blazor"],
            [
                new("Repositório", $"{Repositories}/ExpForge"),
                new("Documentação", "https://celinhodaltro.github.io/ExpForge.Documentation/"),
                new("npm", "https://www.npmjs.com/package/expforge")
            ],
            "img/projects/expforge.webp",
            "Logotipo do ExpForge",
            Commands: ["npm install -g expforge", "expforge --help"]),
        new(
            "Street View 360°",
            "Produs Soluções · CONDER",
            ProjectStatus.Professional,
            "Visualização imersiva de ruas com fotografias 360° georreferenciadas, integrada a mapas no ArcGIS Experience Builder.",
            "Permite inspecionar o território a partir do nível da rua, diretamente sobre o mapa, sem depender de ferramentas externas.",
            [
                "Pontos de captura exibidos sobre a ortofoto, cada um ligado a uma fotografia 360°.",
                "Visualizador panorâmico sobreposto ao mapa, com navegação entre cenas.",
                "Indicador de orientação e modo de tela cheia."
            ],
            "Desenvolvimento da solução e da integração com as fotografias georreferenciadas.",
            ["React", "ArcGIS Experience Builder", "ArcGIS", "Dados geoespaciais"],
            [],
            "img/projects/street-view-360.webp",
            "Mapa com pontos de captura e visualizador 360° de uma rua aberto sobre a ortofoto",
            "Sistema corporativo, sem código público"),
        new(
            "Videomonitoramento de obras",
            "Produs Soluções · CONDER",
            ProjectStatus.Professional,
            "Serviço de monitoramento de câmeras vinculadas a obras, com verificação de disponibilidade, captura de imagens e detecção de objetos.",
            "Acompanhar muitas câmeras manualmente não escala. O sistema verifica cada câmera periodicamente e registra o que foi observado.",
            [
                "Cadastro de câmeras associadas às obras e integração com os dados geoespaciais.",
                "Verificação periódica da saúde das câmeras, com histórico de status e log de eventos.",
                "Captura de frames em janelas de análise agendadas, executadas por serviços em segundo plano.",
                "Detecção de objetos nas imagens com modelos YOLO executados via ONNX Runtime."
            ],
            "Desenvolvimento do backend: API, serviços de análise, integração com as câmeras e persistência em Oracle.",
            ["ASP.NET Core", "Background Services", "OpenCvSharp", "LibVLCSharp", "YOLO", "ONNX Runtime", "EF Core", "Oracle", "MediatR"],
            [],
            AccessNote: "Sistema corporativo, sem código público",
            CoverIcon: Icons.Material.Filled.Videocam),
        new(
            "TGIS",
            "Projeto pessoal · GIS",
            ProjectStatus.InDevelopment,
            "Motor GIS próprio em .NET para visualizar e editar dados geoespaciais, com interface em Blazor Hybrid sobre .NET MAUI.",
            "Explorar, de forma independente de plataformas comerciais, como funciona um sistema de informação geográfica por dentro.",
            [
                "Engine com projeção Web Mercator, sistema de tiles, índice espacial e câmera de mapa.",
                "Pipeline de renderização com estilos e simbolização, incluindo WebGL.",
                "Leitura de GeoJSON e gerenciamento de camadas.",
                "Editor com ferramentas de edição e propriedades, persistência em SQLite com NetTopologySuite."
            ],
            "Projeto autoral: engine, arquitetura e interface.",
            [".NET", "Blazor Hybrid", ".NET MAUI", "Radzen", "NetTopologySuite", "SQLite", "WebGL"],
            [],
            AccessNote: "Código-fonte em repositório privado",
            CoverIcon: Icons.Material.Filled.Layers)
    ];

    public static readonly IReadOnlyList<ProjectSummary> Others =
    [
        new(
            "SICAGIS",
            "Sistema de informações geográficas.",
            ProjectStatus.Professional,
            ["GIS"]),
        new(
            "Informs DevOps Center",
            "Centralizador das rotinas de CI/CD dos sistemas Informs, da CONDER.",
            ProjectStatus.Professional,
            ["DevOps", "CI/CD", "Runners"]),
        new(
            "OrderService",
            "Gestão de pedidos com Clean Architecture, CQRS e DDD: API em .NET e frontend em Angular, com bancos em contêineres Docker.",
            ProjectStatus.Study,
            [".NET", "Angular", "MediatR", "SQL Server", "MongoDB", "Docker"],
            $"{Repositories}/OrderService"),
        new(
            "GoodHamburger",
            "Cardápio e pedidos de hamburgueria com API ASP.NET e cliente Blazor WebAssembly, com testes automatizados.",
            ProjectStatus.Study,
            ["ASP.NET Core", "Blazor", "MediatR", "xUnit"],
            $"{Repositories}/GoodHamburger"),
        new(
            "AutoApplicator",
            "Aplicativo desktop para organizar vagas, perfis de busca e perguntas de candidaturas, com automação de navegador.",
            ProjectStatus.Experimental,
            [".NET MAUI", "Blazor Hybrid", "Playwright", "EF Core", "SQLite"],
            $"{Repositories}/AutoApplicatorRh"),
        new(
            "Bot 2D Top Down",
            "Bot genérico para RPGs top-down, com captura de tela e visão computacional para executar rotinas configuráveis.",
            ProjectStatus.Experimental,
            [".NET MAUI", "Blazor", "MudBlazor", "OpenCvSharp"],
            $"{Repositories}/Bot_2D_TopDown"),
        new(
            "Ursulla Bot",
            "Bot para o Discord que organiza sessões de jogo, controlando valor por pessoa e classe escolhida.",
            ProjectStatus.Experimental,
            [".NET", "NetCord", "PostgreSQL"],
            Image: "img/projects/ursulla-bot.webp"),
        new(
            "Vínculo",
            "API para centralizar dados do cidadão em contextos de governança pública, organizada por módulos de domínio.",
            ProjectStatus.Archived,
            ["ASP.NET Core", "EF Core", "PostgreSQL", "JWT", "xUnit"],
            $"{Repositories}/Vinculo",
            "img/projects/vinculo.webp"),
        new(
            "Auth",
            "API de autenticação com ASP.NET Identity e tokens JWT, persistida em PostgreSQL.",
            ProjectStatus.Archived,
            ["ASP.NET Core", "Identity", "JWT", "PostgreSQL"],
            $"{Repositories}/Auth"),
        new(
            "ArcGIS Pro Add-in",
            "Add-in para o ArcGIS Pro que cria uma feature class em File Geodatabase e insere pontos na extensão do mapa ativo.",
            ProjectStatus.Study,
            ["ArcGIS Pro SDK", "C#", "WPF"],
            $"{Repositories}/NewFeaturesTestAddin"),
        new(
            "Projeto Fatura",
            "Cadastro e consulta de faturas com relatórios exportados para Excel e testes de unidade.",
            ProjectStatus.Archived,
            ["ASP.NET MVC", "EF Core", "EPPlus", "xUnit"],
            $"{Repositories}/ProjetoFatura",
            "img/projects/projeto-fatura.webp"),
        new(
            "Blazor Hybrid Base",
            "Base de projeto que compartilha páginas e componentes entre uma aplicação web Blazor e um app .NET MAUI.",
            ProjectStatus.Archived,
            ["Blazor", ".NET MAUI"],
            $"{Repositories}/AppHybridWithBlazor"),
        new(
            "Portfólio",
            "Este site, feito com Blazor WebAssembly e MudBlazor e publicado no GitHub Pages por um pipeline no GitHub Actions.",
            ProjectStatus.Published,
            ["Blazor WebAssembly", "MudBlazor", "GitHub Actions"],
            $"{Repositories}/Portfolio",
            "img/projects/portfolio.webp")
    ];
}
