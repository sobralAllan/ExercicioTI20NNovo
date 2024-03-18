﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI20N
{
    class Control
    {
        Model modelo;
        public Control()
        {
            modelo = new Model();
        }//fim do construtor

        public void Menu()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n" +
                              "1. Exercício 01\n" +
                              "2. Exercício 02\n" +
                              "3. Exercício 03\n" +
                              "4. Exercício 04\n" +
                              "5. Exercício 05\n" +
                              "6. Exercício 06\n" +
                              "7. Exercício 07\n" +
                              "8. Exercício 08\n" +
                              "9. Exercício 09\n" +
                              "10. Exercício 10\n" +
                              "11. Exercício 11\n" +
                              "12. Exercício 12\n" +
                              "13. Exercício 13\n" +
                              "14. Exercício 14\n" +
                              "15. Exercício 15\n" +
                              "16. Exercício 16\n" +
                              "17. Exercício 17\n" +
                              "18. Exercício 18\n" + 
                              "19. Exercício 19\n" +
                              "20. Exercício 20");
        }//fim do menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                Menu();//Mostrando as opções
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(modelo.ExercicioUm());
                        break;
                    case 2:
                        Console.WriteLine(modelo.ExercicioDois());
                        break;
                    case 3:
                        Console.WriteLine("A soma dos números entre 1 e 100 é: " + modelo.ExercicioTres());
                        break;
                    case 4:
                        Console.WriteLine("Os múltiplos de 5 entre 1 e 50 são: " + modelo.ExercicioQuatro());
                        break;
                    case 5:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioCinco(num));
                        break;
                    case 6:
                        Console.WriteLine("Infome um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioSeis(num));
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioSete(num));
                        break;
                    case 8:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioOito(num));
                        break;
                    case 9:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioNove(num));
                        break;
                    case 10:
                        Console.WriteLine(modelo.ExercicioDez());
                        break;
                    case 11:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioOnze(num));
                        break;
                    case 12:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDoze(num));
                        break;
                    case 13:
                        Console.WriteLine(modelo.ExercicioTreze());
                        break;
                    case 14:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioCatorze(num));
                        break;
                    case 15:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioQuinze(num));
                        break;
                    case 16:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDezesseis(num));
                        break;
                    case 17:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("O dobro é: " + modelo.ExercicioDezessete(num));
                        break;
                    case 18:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("A média é: " + modelo.ExercicioDezoito(num, num2));
                        break;
                    case 19:
                        Console.WriteLine("Informe a temperatura em Celsius: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("A temperatura em Fahrenheit é: " + modelo.ExercicioDezenove(num));
                        break;
                    case 20:
                        Console.WriteLine("Informe o raio: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("O raio é: " + modelo.ExercicioVinte(num));
                        break;
                    case 21:
                        Console.WriteLine("Informe um número ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("O quadrado de " + num + " é: " + modelo.ExercicioVinteUm(num));
                        break;
                    case 22:
                        Console.WriteLine("Informe o primeiro número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteDois(num1, num2));
                        break;
                    case 23:
                        Console.WriteLine("Informe o primeiro número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteTres(num1, num2));
                        break;
                    case 24:
                        Console.WriteLine("Informe a sua idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteQuatro(idade));
                        break;
                    case 25:
                        Console.WriteLine("Informe o primeiro número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteCinco(num1, num2));
                        break;
                    case 26:
                        Console.WriteLine("Informe o seu peso: ");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a sua altura: ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteSeis(peso, altura));
                        break;
                    case 27:
                        Console.WriteLine("Informe quantos anos você tem: ");
                        int anos = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe quantos meses: : ");
                        int meses = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe quantos dias: ");
                        int dias = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteSete(anos, meses, dias));
                        break;
                    case 28:
                        Console.WriteLine("Informe o seu salário: ");
                        double salario = Convert.ToDouble(Console.ReadLine()); 
                        
                        Console.WriteLine("Informe suas vendas: ");
                        double vendas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("O salário final é: " + modelo.ExercicioVinteOito(salario, vendas));
                        break;
                    case 29:
                        modelo.ExercicioVinteNove();
                        break;
                    case 30:
                        modelo.ExercicioTrinta();
                        break;
                    default:
                        Console.WriteLine("Código digitado não é válido!");
                        break;
                }//fim do método
            } while (opcao != 0);
        }//fim do operacao
        

    }//fim da classe
}//fim do projeto
