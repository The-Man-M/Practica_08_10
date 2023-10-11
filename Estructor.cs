struct libro
{
    public string Nombre;
    public string Autor;
    public int AñoPublicado;

    public void MostarInfo()
    {
        Console.WriteLine($"Nombre del libro: {this.Nombre}\nAutor del libro: {this.Autor}\nAño de publicación: {this.AñoPublicado}");
    }
}
struct Estante
{
    List<libro> libros = new List<libro> ();
    public Estante(List<libro> poesia)
    {
        libros.Add(poesia);
    }
    public void poesia()
    {
        foreach (var poesia in libros)
        {
            Console.WriteLine(poesia.Nombre);
        }
    }


}