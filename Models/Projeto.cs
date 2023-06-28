using OrganizEtec.Models.Enuns;
using System;

namespace OrganizEtec.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ClasseEnum Materia { get; set; }
        public DateTime Prazo { get; set; }
        public DateTime Inicio { get; set; }
    }
}