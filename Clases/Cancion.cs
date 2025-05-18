using System.ComponentModel.DataAnnotations;

namespace BibliotecaMusica.Clases
{
    public class Cancion
    {
        [Required(ErrorMessage = "El nombre de la canción es obligatorio.")]
        public string? Nombre_Cancion { get; set; }

        [Required(ErrorMessage = "La duración es obligatoria.")]
        public string? Duracion { get; set; }

        [Required(ErrorMessage = "El artista es obligatorio.")]
        public string? Artista { get; set; }
    }
}
