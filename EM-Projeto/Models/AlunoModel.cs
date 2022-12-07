using System.ComponentModel.DataAnnotations;

namespace EM_Projeto.Models
{
    public class AlunoModel
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
        public EnumeradorSexo Sexo { get; set; }
    }
}