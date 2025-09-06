using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTeste.Models
{
    public class Coin
    {
        public string Lado { get; set; } = string.Empty;

        // método - geralmente usa verbos
        public string Jogar()
        {
            // next - sorteia um numero entre 0 e o numero dentro do parametro
            // Random é um classe 
            int ladoSorteado = new Random().Next(2);
            //operador ternário
            // Ponto de interrogação é um if escondidinho 
            Lado = ladoSorteado == 0 ? "Cara" : "Coroa";
            return Lado;
        }

        //polimorfismo bem fofo
        public string Jogar(string ladoEscolhido)
        {
            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "Cara" : "Coroa";

            string resultado = (Lado == ladoEscolhido) ?
                $"Parabéns, você pediu {ladoEscolhido}  e deu {Lado}" :
                $"Que pena, você pediu {ladoEscolhido} e deu {Lado}";
            // ❤
            return resultado;
        }
    }
}
