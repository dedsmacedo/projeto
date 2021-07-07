/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Aluno {
 public int codAluno;
 public string nome;
 public int cpf;
 public int telefone;
 public string email;
 public int anoEntrada;
 public string curso;

  static void Main() {
      Aluno novoAluno = new Aluno();
      novoAluno.codAluno = 4060539;
      novoAluno.nome = "Deise Macedo";
      novoAluno.cpf = 123456789-10;
      novoAluno.telefone = 3210-4567;
      novoAluno.anoEntrada = 2019;
      novoAluno.curso = "Análise e Desenvolvimento de Sistemas";
      
    Console.WriteLine("Codigo do Aluno:" + novoAluno.codAluno);
    Console.WriteLine("Nome do Aluno:" + novoAluno.nome);
    Console.WriteLine("CPF do Aluno:" + novoAluno.cpf);
    Console.WriteLine("Telefone do Aluno:" + novoAluno.telefone);
    Console.WriteLine("Ano de entrada do Aluno:" + novoAluno.anoEntrada);
    Console.WriteLine("Curso do Aluno:" + novoAluno.curso);
  }
}