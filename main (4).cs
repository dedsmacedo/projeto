
using System;
class Aluno {
    public string nome;
    
 static void Main() {
     Aluno novoAluno = new Aluno();
      novoAluno.nome = "Deise Macedo";
      double priNota,segNota;
      double media;
      
      
    Console.WriteLine("digite a primeira nota:");
    
    priNota = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("digite a segunda nota:");
    
    segNota = Convert.ToDouble(Console.ReadLine());
    
    
    media = (priNota+segNota)/2;
    
    Console.WriteLine("nome do aluno:" + novoAluno.nome);
    
    Console.WriteLine("A média do Aluno foi:" + media);
 }
}