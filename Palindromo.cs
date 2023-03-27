
namespace TesteC
{
    class Palindromo
    {
        public string Palavra { get; set; }//Decrarando a variavel "Palavra" com publica 
        public string Verifica { get; set; }//Decrarando a variavel "Verifica" com publica

        public string Verificacao()//Iniciando a função "Verefi
        {
            
            char[] vet1 = Palavra.ToCharArray();
            char[] vet2 = Palavra.ToCharArray();

            if (Palavra.Length < 3)
            {
                Verifica = "?" ;
            }
            else
            {
                Array.Reverse(vet2);
                for (int i = 0; i < Palavra.Length; i++)
                {
                    if (vet1[i] == vet2[i])
                    {
                        Verifica = "S";   
                    }
                    else
                    {
                        Verifica = "N";
                        break;
                    }
                }

            }
            return Verifica;
        }
    }
}