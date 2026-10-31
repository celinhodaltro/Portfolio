# Portfólio

Portfólio profissional de João Marcelo Daltro Marques, desenvolvido com Blazor WebAssembly e publicado no GitHub Pages.

**Acesse:** [celinhodaltro.github.io/Portfolio](https://celinhodaltro.github.io/Portfolio/)

## Tecnologias

- .NET 10 e Blazor WebAssembly
- MudBlazor, com identidade visual inspirada em Steven Universo
- CSS isolado por componente
- GitHub Actions para build e publicação no GitHub Pages

## Estrutura

```
src/Portfolio
├── Components
│   ├── Dialogs      detalhes de experiências, projetos e contato
│   ├── Layout       layout principal e tema
│   ├── Sections     seções da página inicial
│   └── Shared       componentes reutilizáveis
├── Data             conteúdo do portfólio: perfil, experiências e projetos
├── Models           tipos usados pelo conteúdo
├── Pages            páginas roteáveis
└── wwwroot          estilos globais, scripts, imagens e currículo
```

O conteúdo fica concentrado em `Data`. Para incluir uma experiência ou um projeto, basta adicionar um item na lista correspondente; os componentes de `Sections` apenas apresentam esses dados.

## Executando localmente

Pré-requisito: [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

```bash
git clone https://github.com/celinhodaltro/Portfolio.git
cd Portfolio
dotnet run --project src/Portfolio
```

## Publicação

Cada push na branch `main` executa o workflow `deploy.yml`, que publica o projeto e atualiza a branch `gh-pages`.
