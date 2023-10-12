namespace dia_11_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;
            int menu=0;
            Bibliteca sanjuan = new Bibliteca();
            
            do
            {
                Console.WriteLine("Biblioteca\nIngrese el genero que desea");
                Console.WriteLine("Poesía, Ficción, Clásicos, Filosofía, Drama\n");
                genero = Console.ReadLine();
               Console.WriteLine();
                sanjuan.biblio(genero);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Ingrese \"1\" para salir, sino solo presione \"enter\"");
                int.TryParse(Console.ReadLine(), out menu);
            } while (menu !=1);   
        }
    }
}