using ERP.Api;
using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.ViewModels
{
    internal class TableViewModel : ViewModelBase
    {
        private string _title;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                NotifyPropertyChanged();
            }
        }

        private List<Frisbee> _frisbees;
        public List<Frisbee> Frisbees
        {
            get => _frisbees;
            set
            {
                _frisbees = value;
                NotifyPropertyChanged();
            }
        }

        private ERPApi _api = new ERPApi();

        public TableViewModel()
        {
            //GetAllFrisbees();
        }

        private async void GetAllFrisbees()
        {
            Frisbees = await _api.GetFrisbee();
        }
    }
}
