namespace Portfolio.Models;

public static class ProjectStatusExtensions
{
    public static string ToLabel(this ProjectStatus status) => status switch
    {
        ProjectStatus.Published => "Publicado",
        ProjectStatus.InDevelopment => "Em desenvolvimento",
        ProjectStatus.Professional => "Projeto profissional",
        ProjectStatus.Experimental => "Experimental",
        ProjectStatus.Study => "Estudo",
        ProjectStatus.Archived => "Arquivado",
        _ => status.ToString()
    };

    public static string ToCssModifier(this ProjectStatus status) => status switch
    {
        ProjectStatus.Published => "published",
        ProjectStatus.InDevelopment => "in-development",
        ProjectStatus.Professional => "professional",
        ProjectStatus.Experimental => "experimental",
        ProjectStatus.Study => "study",
        _ => "archived"
    };
}
