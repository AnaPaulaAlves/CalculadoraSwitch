using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            // perguntar a operaçaõ
            Console.WriteLine("Qual a operação deseja realizar? \nSoma, Subtração, Multiplicação, Divisão");
            string operacao = Console.ReadLine().ToLower();

           // pedir o 1 número
           Console.WriteLine("Digite o 1 numero:");
           float num1 = float.Parse(    Console.ReadLine() );

          // pedir o 2 número
          Console.WriteLine("Digite o 2 numero:");
           float num2 = float.Parse(    Console.ReadLine() );

          // Fazer o calculo
          float resultado = 0 ;

        //   if(operacao == "Soma")
        //   {
            //   resultado = num1 + num2;
        //   }
        //   else if(operacao == "Subtracao" || operacao == "subtracao")
        //   {
            //   resultado = num1 - num2;
        //   }
        //  else if(operacao == "Multiplicacao")
        //   {
            //   resultado = num1 * num2;
        //   }
        //  else if(operacao == "Divisao")
        //   {
            //   resultado = num1 / num2;
        //   }
        //   else
        //   {
            //   Console.WriteLine("Operação inválida");
        //   }

        switch(operacao){

        case "Soma" :   
            resultado = num1 + num2;
            break;

        case "subtracao" :
        resultado = num1 - num2;
        break;

        case "multiplicacao" :
        resultado = num1 * num2;
        break;

        case "divisao" :
        resultado = num1 / num2;
        break;

        default:
          Console.WriteLine("Operação invalida! :( ");
          break;

        }

         // mostrar o resultado 
        // Concatenação
        // Console.WriteLine("Calculo : num1 +" com "+ num2 +" = " + resultado);

        // Interpolação
        Console.WriteLine($"Calculo : {num1} com {num2} = {resultado}" ); 
        }
}
}