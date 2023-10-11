class Bibliteca
{    int _genero;
 
    public void nom(int categoria)
    {
        List<libro> p = new List<libro>();
        {
            p.Add(new libro() { Nombre = "Poesia 1", Autor = "autor desconocido", AñoPublicado = 2000 });
            p.Add(new libro() { Nombre = "Poesia 2", Autor = "autor desconocido", AñoPublicado = 2000 });
            p.Add(new libro() { Nombre = "Poesia 3", Autor = "autor desconocido", AñoPublicado = 2000 });

        }
        Estante ESTANTE = new Estante(p);

        //libro CF_libro1 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        //libro CF_libro2 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        //libro CF_libro3 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
      
        //libro NC_libro1 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        //libro NC_libro2 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        //libro NC_Plibro3 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
      
        //libro F_libro1 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        //libro F_libro2 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        //libro F_Plibro3 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
      
        //libro D_libro1 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        //libro D_libro2 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
        //libro D_Plibro3 = new libro() { Nombre = "", Autor = "", AñoPublicado = 0 };
      

        switch (categoria)
        {
            case 1:
                ESTANTE.poesia();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }
}