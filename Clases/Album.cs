namespace BibliotecaMusica.Clases
{
    public class Album
    {
        public string Titulo {  get; set; }
        public string Artista { get; set; }

        public List<Cancion> Listado_Canciones = new List<Cancion>(); 
        public DateTime Fecha_Publicacion { get; set; }
    }
}
