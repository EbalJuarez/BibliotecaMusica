using System.ComponentModel.DataAnnotations;

namespace BibliotecaMusica.Clases
{
    public class Album
    {
        [Required(ErrorMessage = "El titulo del album es obligatorio.")]
        public string? Titulo {  get; set; }
        [Required(ErrorMessage = "El nombre del artista es obligatorio.")]
        public string? Artista { get; set; }

        public List<Cancion> Listado_Canciones { get; set; } = new List<Cancion>();
        [Required(ErrorMessage = "La fecha es obligatoria.")]
        public DateTime? Fecha_Publicacion { get; set; }
    }
}
