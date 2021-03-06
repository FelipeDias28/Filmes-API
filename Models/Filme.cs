using System.ComponentModel.DataAnnotations;

namespace Filmes_API.Models
{
    public class Filme
    {
        public int id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")] // Campo obrigatório
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "o gênero não pode passar de 30 caracteres")] // limite de caracteres
        public string Genero { get; set; }

        [Range(1,600, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 600 minutos")] // Impondo limite
        public int Duracao { get; set; }
    }
}
