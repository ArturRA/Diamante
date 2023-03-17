namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Diamond is unbreakable!");

                int tamanhoDoDiamante = 0;

                #region Validar entrada
                while (true)
                {
                    Console.Write("Digite um valor impara para desenhar o diamante: ");
                    tamanhoDoDiamante = Convert.ToInt32(Console.ReadLine());

                    if (tamanhoDoDiamante % 2 == 0)
                    {
                        Console.WriteLine("Por favor digite um valor impar.");
                        Console.WriteLine("Digite qualquer tecla para tentar novamente....");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                #endregion

                int quantidadeDeSimbolosEmBranco = (tamanhoDoDiamante - 1) / 2;
                int quantidadeDeSimbolosX = 1;
                int metadeDoDiamante = (tamanhoDoDiamante - 1) / 2;

                for (int i = 0; i < tamanhoDoDiamante; i++)
                {
                    #region Excreve espaço em branco
                    for (int j = 0; j < quantidadeDeSimbolosEmBranco; j++)
                    {
                        Console.Write(" ");
                    }
                    if (i < metadeDoDiamante)
                    {
                        quantidadeDeSimbolosEmBranco--;
                    }
                    else
                    {
                        quantidadeDeSimbolosEmBranco++;
                    }
                    #endregion

                    #region Escreve os X
                    for (int j = 0; j < quantidadeDeSimbolosX; j++)
                    {
                        Console.Write("X");
                    }
                    Console.Write($"    Quantidade de X nesta linha: {quantidadeDeSimbolosX}");
                    if (i < metadeDoDiamante)
                    {
                        quantidadeDeSimbolosX += 2;
                    }
                    else
                    {
                        quantidadeDeSimbolosX -= 2;
                    }
                    #endregion

                    // Pula para a proxima linha
                    Console.WriteLine();
                }

                #region Conitinuar ou parar o programa
                string continuar = "";
                while (true)
                {
                    Console.Write("Deseja desenhar outro diamante (S/N)? ");
                    continuar = Console.ReadLine();

                    if (continuar == "S" || continuar == "s")
                    {
                        Console.WriteLine("Por favor digite um valor impar.");
                        Console.Clear();
                        break;
                    }
                    else if (continuar == "N" || continuar == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor digite uma opção valida.");
                    }

                }
                #endregion

                // Termina o programa
                if (continuar == "N" || continuar == "n")
                {
                    break;
                }
            }
        }
    }
}