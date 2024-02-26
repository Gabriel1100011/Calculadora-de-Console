using Calculadora1_5;
public class Maquina
{   public static void Main()
    {
        static void Carregando()
        {
            Console.WriteLine("Carregando.");
            Thread.Sleep(200); Console.Clear();
            Console.WriteLine("Carregando..");
            Thread.Sleep(200); Console.Clear();
            Console.WriteLine("Carregando...");
            Thread.Sleep(200); Console.Clear();
            Console.WriteLine("Carregando.");
            Thread.Sleep(150);
            Console.Clear();

        }
        Carregando();
        static void Inicio()
        {
            //Titulo
            Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██╗░░░██╗██████╗░░█████╗░
██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██║░░░██║██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██║░░░██║██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██║░░░██║██╔══██╗██║░░██║
╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║╚██████╔╝██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝░╚═════╝░╚═╝░░╚═╝░╚════╝░");
            Console.WriteLine(@"
▄▀█ █▀▄▀█ █▀█ █▀█ ▄▀█   █▀▀ █▀▄ █ ▀█▀ █ █▀█ █▄░█
█▀█ █░▀░█ █▄█ █▀▄ █▀█   ██▄ █▄▀ █ ░█░ █ █▄█ █░▀█");
            //Pede a escolha do calculo
            Calculos.Escolha();
        } Inicio();
        }
}