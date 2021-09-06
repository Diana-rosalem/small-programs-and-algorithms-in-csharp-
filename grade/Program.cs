using System;



class Program
{
    static void Main(string[] args)
    {


        Curso curso = new Curso("C#");

        curso.Notas.Add((decimal)5.0);
        curso.Notas.Add((decimal)6.0);
        curso.Notas.Add((decimal)10.0);
        curso.Notas.Add((decimal)9.0);
        curso.Notas.Add((decimal)8.0);
        curso.Notas.Add((decimal)2.0);




        int op = 0;
        while (op != 6)
        {

            Console.WriteLine("\n\n\t\t===== MENU =====");
            Console.WriteLine("\tDigite 1 para calcular a media, maior nota e a menor nota");
            Console.WriteLine("\tDigite 2 para calcular apenas a media");
            Console.WriteLine("\tDigite 3 para calcular apenas a maior nota");
            Console.WriteLine("\tDigite 4 para calcular apena a menor nota");
            Console.WriteLine("\tDigite 5 para mostrar quantos alunos foram aprovados e reprovados ");
            Console.WriteLine("\tDigite 6 para sair do programa");
            Console.WriteLine("\tDigite sua escolha:");
            op = Convert.ToInt32(Console.ReadLine());


            switch (op) {
                case 1:
                    Console.WriteLine($"\n\n\t=== {curso.Nome} ===");
                    Console.WriteLine($"\n\tMedia de {curso.Nome}= {curso.MediaNotas()}");
                    Console.WriteLine($"\n \tnota de {curso.Nome}= {curso.MaiorNota()}");
                    Console.WriteLine($"\n \tMenor nota de  {curso.Nome}= {curso.MenorNota()}");
                    break;

                case 2:
                    Console.WriteLine($"\n\n\t=== {curso.Nome} ===");
                    Console.WriteLine($"\n\tMedia de {curso.Nome}= {curso.MediaNotas()}");
                    break;

                case 3:
                    Console.WriteLine($"\n\n\t=== {curso.Nome} ===");
                    
                    Console.WriteLine($"\n \tnota de {curso.Nome}= {curso.MaiorNota()}");
                    break;

                case 4:
                    Console.WriteLine($"\n\n\t=== {curso.Nome} ===");
                    Console.WriteLine($"\n \tMenor nota de  {curso.Nome}= {curso.MenorNota()}");
                    break;
                case 5:
                    Console.WriteLine($"\n\n\t=== {curso.Nome} ===");
                    Console.WriteLine($"\n \t Quantidade de alunos aprovados no curso de {curso.Nome}= {curso.Aprovados()}");
                    Console.WriteLine($"\n \t Quantidade de alunos reprovados no curso de {curso.Nome}= {curso.Reprovados()}");
                    break;
            }
           
        }
    }
}


