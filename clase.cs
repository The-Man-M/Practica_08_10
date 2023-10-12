class Bibliteca
{
    public void biblio(string _genero)
    {
        List<libro> p = new List<libro>
{
    new libro() { Nombre = "Poesia 1", Autor = "Autor 1", AñoPublicado = 2000 },
    new libro() { Nombre = "Poesia 2", Autor = "Autor 2", AñoPublicado = 2005 },
    new libro() { Nombre = "Poesia 3", Autor = "Autor 3", AñoPublicado = 2010 }
};

        List<libro> cf = new List<libro>
{
    new libro() { Nombre = "Ciencia Ficción 1", Autor = "Autor A", AñoPublicado = 1990 },
    new libro() { Nombre = "Ciencia Ficción 2", Autor = "Autor B", AñoPublicado = 1995 },
    new libro() { Nombre = "Ciencia Ficción 3", Autor = "Autor C", AñoPublicado = 2000 }
};

        List<libro> nc = new List<libro>
{
    new libro() { Nombre = "Novela Clásica 1", Autor = "Autor X", AñoPublicado = 1850 },
    new libro() { Nombre = "Novela Clásica 2", Autor = "Autor Y", AñoPublicado = 1875 },
    new libro() { Nombre = "Novela Clásica 3", Autor = "Autor Z", AñoPublicado = 1900 }
};

        List<libro> f = new List<libro>
{
    new libro() { Nombre = "Filosofía 1", Autor = "Filósofo A", AñoPublicado = 400  },
    new libro() { Nombre = "Filosofía 2", Autor = "Filósofo B", AñoPublicado = 300  },
    new libro() { Nombre = "Filosofía 3", Autor = "Filósofo C", AñoPublicado = 200  }
};

        List<libro> d = new List<libro>
{
    new libro() { Nombre = "Drama 1", Autor = "Autor Drama", AñoPublicado = 2015 },
    new libro() { Nombre = "Drama 2", Autor = "Autor Drama", AñoPublicado = 2017 },
    new libro() { Nombre = "Drama 3", Autor = "Autor Drama", AñoPublicado = 2020 }
};

        Estante estante = new Estante(p, cf, nc, f, d);

        if (Enum.TryParse<Genero>(_genero, out Genero resultado))
        {

        }
        else
        {
            Console.WriteLine($"No se encontraron libros en el género {_genero}.");
        }

        estante.MostrarLibrosPorGenero(_genero);

    }
}