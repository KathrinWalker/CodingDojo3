using CodingDojo3.Simulation;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace CodingDojo3.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private Simulator sim;
        private ObservableCollection<ItemVm> Data { get; set; }
        public MainViewModel()
        {

        }
    }
}