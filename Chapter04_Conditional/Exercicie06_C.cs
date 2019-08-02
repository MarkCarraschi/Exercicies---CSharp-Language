using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_Conditional
{
    class Exercicie06_C
    {
        /*(Desafio)Dado o seguinte código:

                        int valor = 15;
                        string mensagem = "";
                        if(valor > 10)
                        {
                         mensagem = "Maior que dez";
                        }
                        else
                        {
                         mensagem = "Menor que dez;
                        }
                        MessageBox.Show(mensagem);
            Existe uma forma de fazer o if desse código uma linha só, 
            sem usar a palavra if e else. Pesquise sobre isso e tente fazer.*/

        static void Main(string[] args){

            int valor = 15;
            string message;

            message = (valor > 10) ? "Maior que dez" : "Menor que 10";
            Console.WriteLine(message);

            /*Original C0D&*/

            int valorOriginal = 15;
            string mensagemOriginal = "";
            if (valorOriginal > 10) mensagemOriginal = "Maior que dez";
                else mensagemOriginal = "Menor que dez";
                        
            Console.WriteLine(mensagemOriginal);

            Console.ReadKey();
        }
    }
}
