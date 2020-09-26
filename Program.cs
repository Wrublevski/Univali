using System;

namespace Quiz_900QI
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            //First Question

            Console.WriteLine("Quiz: criado por Gabriel Vojciechovski");
            Console.WriteLine();
            Console.WriteLine("1 - Qual o sobrenome do presidente Obama");  
            Console.WriteLine();
            Console.WriteLine("a) Gaucho");
            Console.WriteLine("b) Barack");
            Console.WriteLine("c) Russen");
            Console.WriteLine("d) Obama");
            Console.WriteLine("e) Bush");
            Console.WriteLine();
            Console.Write("Resposta:");

            String resposta = Console.ReadLine();         //Resposta do jogador

            if (resposta == "d")   //Reconhecer alternativa correta
            {

                Console.WriteLine();
                Console.WriteLine("Resposta correta!");
                score = score + 2;    //Localizar variavel score e somar 2 pontos
                Console.WriteLine("Pontuação:" + score); //Mostrar score atual
                Console.WriteLine();

            }
            else  //Caso a resposta não seja a correta
            {

                Console.WriteLine();
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Pontuação: " + score); //Mostrar score atual
                Console.WriteLine();

            }
            //Second Question
            Console.WriteLine("2 - Quem fez a famosa Arapuca do indio Juca?");
            Console.WriteLine();
            Console.WriteLine("a) Tupiniquim Brasilero");
            Console.WriteLine("b) Juca");
            Console.WriteLine("c) Indio");
            Console.WriteLine("d) Dom Quixote");
            Console.WriteLine("d) Monkey Flip");
            Console.WriteLine();
            Console.Write("Resposta:");

            resposta = Console.ReadLine();

            if (resposta == "b") //Reconhecer alternativa correta
            {

                Console.WriteLine();
                Console.WriteLine("Resposta correta!");
                score = score + 2; //Localizar variavel score e somar 2 pontos
                Console.WriteLine("Pontuação:" + score); //Mostrar score atual
                Console.WriteLine();

            }
            else //Caso a resposta não seja a correta
            {

                Console.WriteLine();
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Pontuação: " + score); //Mostrar score atual
                Console.WriteLine();

            }
            //Third Question
            Console.WriteLine("3 - Quem tinha as manha do Homem Aranha ?");
            Console.WriteLine();
            Console.WriteLine("a) Peter Parker");
            Console.WriteLine("b) Duende Verde");
            Console.WriteLine("c) Doutor Octopus");
            Console.WriteLine("d) Cabeça de Teia");
            Console.WriteLine("e) Homem Aranha");
            Console.WriteLine();
            Console.Write("Resposta:");

            resposta = Console.ReadLine();

            if (resposta == "e") //Reconhecer alternativa correta
            {

                Console.WriteLine();
                Console.WriteLine("Resposta correta!");
                score = score + 2; //Localizar variavel score e somar 2 pontos
                Console.WriteLine("Pontuação:" + score); //Mostrar score atual
                Console.WriteLine();

            }
            else //Caso a resposta não seja a correta
            {

                Console.WriteLine();
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Pontuação: " + score); //Mostrar score atual
                Console.WriteLine();

            }
            //Fourth Question
            Console.WriteLine("4 - Quais peças o Santana 518 não tem ? ");
            Console.WriteLine();
            Console.WriteLine("a) Disco de Freio");
            Console.WriteLine("b) Injeção Eletrônica");
            Console.WriteLine("c) Colar");
            Console.WriteLine("d) Oh o barulho tenente");
            Console.WriteLine("d) Não tem carburador");
            Console.WriteLine("e) Pô pastor ta querendo me sacanear");

            Console.WriteLine();
            Console.Write("Resposta:");

            resposta = Console.ReadLine();

            if (resposta == "b") //Reconhecer alternativa correta
            {

                Console.WriteLine();
                Console.WriteLine("Resposta correta!");
                score = score + 2; //Localizar variavel score e somar 2 pontos
                Console.WriteLine("Pontuação:" + score); //Mostrar score atual
                Console.WriteLine();

            }
            else //Caso a resposta não seja a correta
            {

                Console.WriteLine();
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Pontuação: " + score); //Mostrar score atual
                Console.WriteLine();

            }
            //Fifth Question
            Console.WriteLine("5 - Por que os kamikazes usavam capacete? ");
            Console.WriteLine();
            Console.WriteLine("a) O Capacete faz parte da Farda");
            Console.WriteLine("b) Segurança em caso da missão falhar");
            Console.WriteLine("c) Boa pergunta");
            Console.WriteLine("d) Para explodir em segurança");
            Console.WriteLine("e) Não me faça perguntas difíceis ");
            Console.WriteLine();
            Console.Write("Resposta:");

            resposta = Console.ReadLine();

            if (resposta == "a") //Reconhecer alternativa correta
            {

                Console.WriteLine();
                Console.WriteLine("Resposta correta!");
                score = score + 2; //Localizar variavel score e somar 2 pontos
                Console.WriteLine("Pontuação:" + score); //Mostrar score atual
                Console.WriteLine();

            }
            else //Caso a resposta não seja a correta
            {

                Console.WriteLine();
                Console.WriteLine("Resposta errada!");
                Console.WriteLine("Pontuação: " + score); //Mostrar score atual
                Console.WriteLine();

            }
            //End
            Console.WriteLine("Pontuação final: " + score);             //Resultado final 

            Console.WriteLine("Obrigado por emprestar seu glorioso tempo ao meu Quiz");  //Mensagem final 
            Console.ReadLine();
        }
    }
}