class Bibliteca
{
    string _genero = " Poesía";

    public void biblio(int categoria)
    {
        List<libro> p = new List<libro>();
        {
            p.Add(new libro() { Nombre = "Poesia 1", Autor = "autor desconocido", AñoPublicado = 2000 });
            p.Add(new libro() { Nombre = "Poesia 2", Autor = "autor desconocido", AñoPublicado = 2000 });
            p.Add(new libro() { Nombre = "Poesia 3", Autor = "autor desconocido", AñoPublicado = 2000 });

        }
        List<libro> cf = new List<libro>();
        {
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        }
        List<libro> nc = new List<libro>();
        {
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        }
        List<libro> f = new List<libro>();
        {
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        }
        List<libro> d = new List<libro>();
        {
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
            new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        }
        Estante estante = new Estante(p,cf,nc,f,d);

        if (Enum.TryParse<Genero>(_genero, out Genero resultado))
        {
            Console.WriteLine(resultado);
        }
        else
        {
            
        }

        estante.MostrarLibrosPorGenero("Poesía");
        
    }
}