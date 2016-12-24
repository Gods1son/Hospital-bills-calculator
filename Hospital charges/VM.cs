using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_charges
{
    class VM : INotifyPropertyChanged
    {
        public const decimal daily_charge = 350m;
        public decimal Days
        {
            get { return _days; }
            set { _days = value; OnPropertyChanged(); }
        }
        private decimal _days;
        public decimal Medication
        {
            get { return _medication; }
            set { _medication = value; OnPropertyChanged(); }
        }
        private decimal _medication;
        public decimal Surgical
        {
            get { return _surgical; }
            set { _surgical = value; OnPropertyChanged(); }
        }
        private decimal _surgical;
        public decimal Lab
        {
            get { return _lab; }
            set { _lab = value; OnPropertyChanged(); }
        }
        private decimal _lab;
        public decimal Rehab
        {
            get { return _rehab; }
            set { _rehab = value; OnPropertyChanged(); }
        }
        private decimal _rehab;
        public decimal Total
        {
            get { return _total; }
            set { _total = value; OnPropertyChanged(); }
        }
        private decimal _total;
        public decimal CalcStayCharges()
        {
            decimal stay = 0m;
            stay = Days * daily_charge;
            return stay;
        }
        public decimal CalcMiscCharges()
        {
            decimal misc = 0m;
            misc = Medication + Surgical + Rehab + Lab;
            return misc;
        }
        public void docalc()
        {
            Total = CalcStayCharges() + CalcMiscCharges();
        }
        public void clear()
        {
            Days = 0;
            Medication = 0;
            Surgical = 0;
            Lab = 0;
            Rehab = 0;
            Total = 0;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
