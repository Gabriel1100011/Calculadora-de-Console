namespace Calculadora1_5
{
    public class Calculos

    {
        public static double num1;
        public static double num2;
        public static double result;
        public static void Escolha()
        {
            string entrada;
            Console.WriteLine("\nO que deseja fazer?\n" +
                "+    Soma\n-    Subtração\n*    Multiplicação\n/    Divisão\n" +
                "V    Raiz Quadrada");

            entrada = Console.ReadLine();
                 if (entrada == "+") { Soma(); }
            else if (entrada == "-") { Subtracao(); }
            else if (entrada == "*") { Multiplicacao(); }
            else if (entrada == "/") { Divisao(); }
            else if (entrada == "v") { Raiz(); }
            else { Console.WriteLine("Tente novamente."); }
            Thread.Sleep(1000);
            Console.Clear();
            Maquina.Main();

        }
        public static void Input()
        {          
            Console.WriteLine("Primeiro numero:");
            string num1string = Console.ReadLine();
            
            bool isInt = double.TryParse(num1string, out num1);
            if (isInt == false)
            {
                Console.WriteLine("ERRO! Escreva um numero inteiro");
                Thread.Sleep(1000);
                Console.Clear(); Input();
            }
             
            Console.WriteLine("Segundo numero:");
            string num2string = Console.ReadLine();

            
            bool isInt2 = double.TryParse(num2string, out num2);
            if (isInt2 == false)
            {
                Console.WriteLine("ERRO! Escreva um numero inteiro");
                Thread.Sleep(1000);
                Console.Clear(); Input();
            }

        }
        public static void Soma()
        {
            Console.Clear();
            Input();
            void Operacao()
            {
                result = num1 + num2;
            }
            Operacao();
            Final();
        }
        public static void Subtracao()
        {
            Console.Clear();
            Input();
            void Operacao()
            {
                result = num1 - num2;
            }
            Operacao();
            Final();
        }
        public static void Multiplicacao()
        {
            Console.Clear();
            Input();
            void Operacao()
            {
                result = num1 * num2;
            }
            Operacao();
            Final();
        }
        public static void Divisao()
        {
            Console.Clear();
            Input();
            void Operacao()
            {
                result = num1 / num2;
            }
            Operacao();
            Final();
        }
        public static void Raiz()
        {
            Console.Clear();
            Console.WriteLine("Raiz quadrada (2) ou cubica (3)?");
            string input = Console.ReadLine();
            double raiz; 
            bool isInt = double.TryParse(input, out raiz);
            if (raiz == 2)
                RaizQuadrada();
            else if (raiz == 3)
                RaizCubica();
            
            void RaizQuadrada()
            {
                Console.WriteLine("Escreva o numero:");
                string num1string = Console.ReadLine();

                bool isInt = double.TryParse(num1string, out num1);
                
                result = Math.Sqrt(num1);
            }
            void RaizCubica()
            {
                Console.WriteLine("Escreva o numero:");
                string num1string = Console.ReadLine();

                bool isInt = double.TryParse(num1string, out num1);
                
                result = Math.Cbrt(num1);
            }
            Final();
        }
        public static void Final()
        {
            Console.Clear();
            Console.WriteLine($"Resultado: {result}");
            Thread.Sleep(1500);

            Console.WriteLine("Enter para voltar ao inicio.");
            Console.ReadKey();

            Maquina.Main();
        }
    }
}
