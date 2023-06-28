using Microsoft.EntityFrameworkCore;
using OrganizEtec.Models;
using OrganizEtec.Models.Enuns;

namespace OrganizEtec.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Integrante> Integrantes { get; set; }
        public DbSet<Tema> Temas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projeto>().HasData
            (
                new Projeto() { Id = 1, Nome = "RotaLimpa", Prazo = Convert.ToDateTime("2023-06-23"), Inicio = Convert.ToDateTime("2023-06-09"), Materia = ClasseEnum.PTCC },
                new Projeto() { Id = 2, Nome = "Finalização do frontend", Prazo = Convert.ToDateTime("2023-06-22"), Inicio = Convert.ToDateTime("2023-06-08"), Materia = ClasseEnum.PWII },
                new Projeto() { Id = 3, Nome = "OrganizEtec", Prazo = Convert.ToDateTime("2023-06-20"), Inicio = Convert.ToDateTime("2023-06-13"), Materia = ClasseEnum.DS },
                new Projeto() { Id = 4, Nome = "React Native", Prazo = Convert.ToDateTime("2023-06-21"), Inicio = Convert.ToDateTime("2023-06-14"), Materia = ClasseEnum.PAM },
                new Projeto() { Id = 5, Nome = "Atividade BD", Prazo = Convert.ToDateTime("2023-06-19"), Inicio = Convert.ToDateTime("2023-06-12"), Materia = ClasseEnum.BDII }
            );

            modelBuilder.Entity<Integrante>().HasData
            (
                new Integrante() { Id = 1, Nome = "Alex Vitor" },
                new Integrante() { Id = 2, Nome = "Antonio Mauricio" },
                new Integrante() { Id = 3, Nome = "Breno Lisboa" },
                new Integrante() { Id = 4, Nome = "Gustavo Leite" },
                new Integrante() { Id = 5, Nome = "Rafael Thomas" },
                new Integrante() { Id = 6, Nome = "Vitor Silva" }
            );

            modelBuilder.Entity<Tema>().HasData
            (
                new Tema() { Id = 1, Nome = "Criar uma pagina a sua ecolha", ProjetoId = 2, IntegranteId = 1 },
                new Tema() { Id = 2, Nome = "Finalizar atividade do dia 12/06", ProjetoId = 5, IntegranteId = 1 },
                new Tema() { Id = 3, Nome = "Finalizar projeto do da API", ProjetoId = 3, IntegranteId = 1 },
                new Tema() { Id = 4, Nome = "Narrativa Caso de Uso 1/2", ProjetoId = 1, IntegranteId = 1 },
                new Tema() { Id = 5, Nome = "Narrativa Caso de Uso 2/2", ProjetoId = 1, IntegranteId = 4 },
                new Tema() { Id = 6, Nome = "Sprint 03 - Apresentação Diagramas UML 1 1/2", ProjetoId = 1, IntegranteId = 2 },
                new Tema() { Id = 7, Nome = "Sprint 03 - Apresentação Diagramas UML 1 2/2", ProjetoId = 1, IntegranteId = 6 },
                new Tema() { Id = 8, Nome = "Diagrama de Classe 1/2", ProjetoId = 1, IntegranteId = 1 },
                new Tema() { Id = 9, Nome = "Diagrama de Classe 2/2", ProjetoId = 1, IntegranteId = 4 },
                new Tema() { Id = 10, Nome = "Modelo Lógico BD 1/2", ProjetoId = 1, IntegranteId = 4 },
                new Tema() { Id = 11, Nome = "Modelo Lógico BD 2/2", ProjetoId = 1, IntegranteId = 5 },
                new Tema() { Id = 12, Nome = "Scripts BD 1/2", ProjetoId = 1, IntegranteId = 1 },
                new Tema() { Id = 13, Nome = "Scripts BD 2/2", ProjetoId = 1, IntegranteId = 2 },
                new Tema() { Id = 14, Nome = "Sprint 04 - Apresentação Diagramas UML 1 1/2", ProjetoId = 1, IntegranteId = 2 },
                new Tema() { Id = 15, Nome = "Sprint 04 - Apresentação Diagramas UML 1 2/2", ProjetoId = 1, IntegranteId = 6 },
                new Tema() { Id = 16, Nome = "Logo da Empresa 1/2", ProjetoId = 1, IntegranteId = 3 },
                new Tema() { Id = 17, Nome = "Logo da Empresa 2/2", ProjetoId = 1, IntegranteId = 5 }
            );
        }
    }
}