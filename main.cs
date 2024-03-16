using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int BolaSorteada = random.Next(1, 21); //variavel que vai sortear um número de 1 a 20.
        int alvo = BolaSorteada; // variavel onde o algo é armazenado.
        int palpiteMaximo = 20; //variavel onde o palpite maximo é armazenado.
        int palpiteMinimo = 1; //variavel onde o palpite minimo é armazenado.
        int pontuacao = 0; // variavel onde a pontuação é armazenada. 
        Console.WriteLine("Bem-vindo ao jogo de advinhação, o jogo consiste da seguinte forma:\n1. O computador vai puxar uma bola entre 1 e 20 para jogar em um alvo.\n2. O alvo na primeira rodada será o número da bola retirada pelo computador.\n3. Você precisa acertar o alvo.\n4. Caso erre, o computador irá devolver a bola e sortear uma nova bola, podendo repetir a bola anterior.\n5. O novo alvo será o alvo anterior + número da nova bola.\n6. Caso acerte, você ganha o jogo.\n7. Caso continue errando os alvos vão sendo somados até chegar a 100 pontos.\n8. Ao chegar a 100 pontos o computador vence.");
        Console.WriteLine("Boa sorte, jogador! ;)");
        Console.WriteLine("");

        Console.WriteLine("O que deseja?\n1 - Iniciar o jogo\n2 - Exemplo do jogo"); // um extra, uma opção para ver um exemplo de jogo.
        int opcao = int.Parse(Console.ReadLine()); // variavel onde a opção é armazenada.
        if (opcao == 2) // se a opção 2 for escolhida sera mostrado o exemplo a seguir.
        {
            Console.WriteLine("Vamos ao exemplo!\nNa primeira rodada o computador tira uma bola (5)\nLembrando que você não sabe qual o número da bola ^-^\nEntão o alvo será 5\nVocê chuta 2\nInfelizmente você errou, o computador devolverá a bola e sorteará uma nova bola\nA bola sorteada agora é 10\nO alvo será = alvo antigo (5) + bola nova (10)\nO alvo então será = 15\nSe você digitar 15, você acertou :)\nSenão, você errou :(\nSorteando uma nova bola e o novo alvo será alvo antigo (15) + nova bola(?)!");
        }
        Console.WriteLine("");
        Console.WriteLine("Jogo Iniciando..."); // inicio do jogo
        Console.WriteLine("");
        while (pontuacao < 100) // enquanto a pontuação for menor que 100, o jogo vai continuar se repetindo.
        {
            Console.Write($"Uma nova bola foi sorteada, em qual seu palpite:{palpiteMinimo} Max:{palpiteMaximo}\n"); // É informado ao jogador que ele deve chutar um numero, levando em consideração o palpite minimo e maximo.
            int palpite = int.Parse(Console.ReadLine()); // verifica se o palpite esta dentro dos valores determinados.

            while (palpite < palpiteMinimo || palpite > palpiteMaximo)
            {
                Console.WriteLine($"Digite um valor dentro de {palpiteMinimo} e {palpiteMaximo}");
                palpite = int.Parse(Console.ReadLine()); // caso o palpite seja menor que o palpite minimo ou maior que o palpite maximo, o progama pede para digitar um valor dentro do intervalo. 
            }

            if (palpite == alvo) // verificação se o palpite é igual ao alvo
            {
                Console.WriteLine($"Parabéns, você acertou o alvo {alvo}!");
                break; // caso o palpite seja igual ao alvo, o jogo é finalizado e o joagador vence.
            }
          else // caso o palpite não seja igual ao alvo o jogo continua, mas somando pontos a cada rodada.
            {
                BolaSorteada = random.Next(1, 21); // sorteio de uma nova bola
                Console.WriteLine($"Você errou! O alvo selecionado era: {alvo}"); // informao ao jogador que o palpite está errado e mostra o alvo anteriormente escolhido.
                palpiteMinimo = alvo + 1; // o palpite minimo é atualizado para o alvo anterior + 1
                palpiteMaximo = alvo + 20; // o palpite maximo é atualizado para o alvo anterior + 20
                pontuacao = alvo; // a pontuação é atualizada para o alvo anterior. 
                alvo = alvo + BolaSorteada;  //  agora o alvo é atualizado para o alvo anterior + a nova bola sorteada.
            }
        }
        Console.WriteLine($"O computador ultrapassou 100 pontos. O computador venceu!"); // mensaguem de que os pontos se acumularam ate 100 e o computador venceu.
    }


}