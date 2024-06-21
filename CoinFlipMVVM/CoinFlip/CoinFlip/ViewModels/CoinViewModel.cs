using CoinFlip.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoinFlip.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {

        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        public string imagem;

        [ObservableProperty]
        public string escolha;

        public ICommand JogarCommand { get; }

        public CoinViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        public void Jogar()
        {
            //Instanciando uma moeda
            //Passo por parâmetro a escolha do jogador
            //Comparo a o lado sorteado com a escolha do jogador
            //Exibo o resultado
            Coin coin = new Coin();
            coin.Jogar();
            //Resultado = Escolha == coin.LadoSorteado ? "boa" : "perdeu lixo horroroso otario bobao";
            if (Escolha == coin.LadoSorteado)
            {
                Resultado = "GANHOU";
            }
            else
            {
                Resultado = "perdeu noob";
            }
        }
    }
}
