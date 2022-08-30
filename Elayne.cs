using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaMedia
{

	class Program
    {
    	static void Main(string[] args)
    	{

          /*
          * MINE LEVANTAMENTO DE REQUISITOS
          * PRECISO SABER QUEM É´O ALUNO
          * PRECISO DAS 4 NOTAS DO ALUNO
          * CALCULA A MEDIA
          * MOSTRAR O CALCULO PARA O USUARIO
          */

          string nomeAluno;
          float nota1, nota2, nota3, nota4, media;
          //
          //solicita a entrada de dados pelo usuario
          Console.Write("Informe o nome do aluno: ");
          nomeAluno = Console.ReadLine();
          Console.Write("Informe a nota1: ");
          nota1 = Convert.ToSingle( Console.ReadLine());
          Console.Write("Informe a nota2: ");	
          nota2 = Convert.ToSingle( Console.ReadLine());
          Console.Write("Informe a nota3: ");
          nota3 = Convert.ToSingle( Console.ReadLine());
          Console.Write("Informe a nota4: ");
          nota4 = Convert.ToSingle( Console.ReadLine());
          //
          //Calcular a media
          media = (nota1+nota2+nota3+nota4) / 4;
          //
          //Mostra a media
          Console.WriteLine("A media do aluno {0} é {1}", nomeAluno, media);	

          if(media >= 7){
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Situaçao: Aprovado");
                        }
                        else{
                              Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Situaçao: Reprovado");
                        }	

          Console.ReadKey();



    	}
    }
}

