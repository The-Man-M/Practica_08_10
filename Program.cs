namespace dia_11_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu =1;
            Bibliteca sanjuan = new Bibliteca();
            
            do
            {
                
                sanjuan.biblio(menu);

                Console.WriteLine("Biblioteca");
                Console.WriteLine("1. Poemas\n2. Ciencia ficción\n3. Novelas clásicas\n4. Filosofía\n5. Drama\n6. Salir\n");

                while (!int.TryParse(Console.ReadLine(), out menu) || (menu<1|| menu>6))
                {

                    Console.WriteLine("Ingrese valor valido\n");
                    Console.WriteLine("1. Poemas\n2. Ciencia ficción\n3. Novelas clásicas\n4. Filosofía\n5. Drama\n6. Salir\n");


                }


            } while (menu !=6);   
        }
    }
}