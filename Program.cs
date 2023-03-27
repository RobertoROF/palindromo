
namespace TesteC
{
    class Program
    {
        static void Main(string[] arg)
        {
            Palindromo p = new Palindromo(); // Iniciando a variavel p
            System.Console.WriteLine("Digite"); //Pedindo para o usuário digitar uma palavra 
            p.Palavra = Console.ReadLine().ToUpper(); // Atribuindo que o usuário digitou a "Palavra" e deixando todas as letras maiúsculas
            System.Console.WriteLine(p.Verificacao());//Executando a função "Vereficacao" e escrevndo o seu retorno
        }
    }
}