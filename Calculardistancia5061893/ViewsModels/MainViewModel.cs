
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculardistancia5061893.ViewsModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _Varx1;
        [ObservableProperty]
        private double _Vary1;
        [ObservableProperty]
        private double _Varx2;
        [ObservableProperty]
        private double _Vary2;
        [ObservableProperty]
        private string? _distancia;


        [RelayCommand]

        private void CalcularDistancia()
        {
            var distancia = Math.Sqrt(
                Math.Pow(Varx2 - Varx1, 2) +
                Math.Pow(Vary2 - Vary1, 2)
            );
            Distancia = distancia.ToString("F2");


        }


    }
}

