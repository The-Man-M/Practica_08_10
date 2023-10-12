struct libro
{

    public string Nombre;
    public string Autor;
    public int AñoPublicado;

    public void MostarInfo()
    {
        Console.WriteLine($"Nombre del libro: {this.Nombre}\nAutor del libro: {this.Autor}\nAño de publicación: {this.AñoPublicado}\n");
    }
}
struct Estante
{
    private Dictionary<string, List<libro>> Estantes = new Dictionary<string, List<libro>>();
    public Estante(List<libro> poesia, List<libro> ciencia_ficcion, List<libro> Novela_clasica, List<libro> Filosofia, List<libro> Drama)
    {
        Estantes.Add("Poesía", poesia);
        Estantes.Add("Ficción", ciencia_ficcion);
        Estantes.Add("Clásica", Novela_clasica);
        Estantes.Add("Filosofía", Filosofia);
        Estantes.Add("Drama", Drama);
    }

    public void MostrarLibrosPorGenero(string genero)
    {

        if (Estantes.ContainsKey(genero))
        {
            Console.WriteLine($"Libros de {genero}:\n");
            foreach (var libro in Estantes[genero])
            {
                libro.MostarInfo();
            }
        }
        else
        {
            Console.WriteLine($"No se encontraron libros en el género {genero}.");
        }
    }
}
enum Genero
{
    Poesía,
    Ficción,
    Clásica,
    Filosofía,
    Drama,

}
