//ATIVIDADE DO CURSO DE C# DA ALURA

using System;

class GameGuessTheNumber
{
    static void Main()
    {
        bool playAgain;

        do
        {
            //definindo uma classe random
            Random random = new Random();

            //definindo as variáveis a serem utilizadas no jogo
            int randomNumber = random.Next(1, 101); //passando dentro dos parenteses o parametro dos números. O programa retorna um número int específico sorteado
            int playerGuess;
            bool rightAnswer = false;

            Console.WriteLine("Welcome to the C# GUESSING GAME!");
            Console.WriteLine("Try to choose the right number between 1 and 100");

            do
            {
                Console.Write("Guess the right number: ");
                playerGuess = int.Parse(Console.ReadLine());

                if (playerGuess < randomNumber)
                {
                    Console.WriteLine("The numbe is bigger than this!");
                }
                else if (playerGuess > randomNumber)
                {
                    Console.WriteLine("The number is smaller!");
                }
                else
                {
                    Console.WriteLine("Congratulations! You got the right number!");
                    rightAnswer = true;
                }

                //uso do switch para exibir mensagens de status dos palpites
                switch (playerGuess)
                {
                    case <= 0:
                        Console.WriteLine("The number must be between 0 and 100");
                        break;
                    case > 100:
                        Console.WriteLine("The number must be between 0 and 100");
                        break;
                    default:
                        if (!rightAnswer)
                            Console.WriteLine("Try again!");
                        break;
                }
            } while (!rightAnswer);

            //perguntar, após acerto, se o usuário deseja jogar novamente
            Console.WriteLine("Do you want to play again? (y/n)");
            string answer = Console.ReadLine().ToLower();
            playAgain = (answer == "y");

        } while (playAgain);

        Console.WriteLine("Thank you for playing with us!");
    }
}