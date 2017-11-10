using CodingDojo3.Simulation;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using Shared.Interfaces;

namespace CodingDojo3.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private Simulator sim;
        private List<ItemVm> Data { get; set; }

        public ObservableCollection<ItemVm> SensorList {get; set; }

        public ObservableCollection<ItemVm> ActorList { get; set; }

        public MainViewModel()
        {
            Data = new List<ItemVm>();
            SensorList = new ObservableCollection<ItemVm>();
            ActorList = new ObservableCollection<ItemVm>();
            GetData();
        }

        private void GetData()
        {
            Simulator sim = new Simulator(Data);
            foreach (var item in sim.Items)
            {
                if (item.ItemType.Equals(typeof(ISensor))){
                    SensorList.Add(item);
                }else if (item.ItemType.Equals(typeof(IActuator))){
                    ActorList.Add(item);
                }
            }
        }
    }
}