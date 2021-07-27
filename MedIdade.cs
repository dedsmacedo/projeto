using System;

namespace MedIdade

{
    class Program
    {
        static void Main(string[] args)
        {
            Double idade1, idade2, idade3, idade4, idade5, media = 0;

            Console.WriteLine("=========MEDIADOSALUNOS=========");
            Console.WriteLine("Digite a primeira idade: ");
            idade1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda idade: ");
            idade2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira idade: ");
            idade3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta idade: ");
            idade4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quinta idade: ");
            idade5 = Convert.ToDouble(Console.ReadLine());

            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
            Console.WriteLine("A idade média entre os alunos é: " + media);
            Console.ReadKey();
        }
    }
}
