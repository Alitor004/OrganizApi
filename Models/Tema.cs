namespace OrganizEtec.Models
{
    public class Tema
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Projeto Projeto { get; set; }
        public int ProjetoId { get; set; }
        public Integrante Responsavel { get; set; }
        public int IntegranteId { get; set; }
    }
}