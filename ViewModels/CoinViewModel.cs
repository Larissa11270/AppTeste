using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTeste.Models; 
using CommunityToolkit.Mvvm.ComponentModel; //import

namespace AppTeste.ViewModels
{
    // dois pontos (:) seria o extendes (herança)
    // coloca underline para referenciar que é uma variavel global,...
    // ... percente a classe como um todo
    public partial class CoinViewModel : ObservableObject
    {
        public string _ladoEscolhido = string.Empty;
        public string _imagem = string.Empty;
        public string _resultado = string.Empty;

        public void Flip()
        {
            Coin coin = new Coin();
            _resultado = coin.Jogar(_ladoEscolhido);
        }
    }
}
