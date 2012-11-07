using System.ComponentModel;
using System.Windows.Media;

namespace PivotViewerDemo
{
    public class Price : INotifyPropertyChanged
    {
        private string underlying;
        public string Underlying
        {
            get { return underlying; }
            set { underlying = value; NotifyProperty("Underlying"); }
        }

        private string maturity;
        public string Maturity
        {
            get { return maturity; }
            set { maturity = value; NotifyProperty("Maturity"); }
        }

        public SolidColorBrush MaturityColour
        {
            get
            {
                switch (Maturity)
                {
                    case "3M":
                        return new SolidColorBrush(Color.FromArgb(220, 249, 169, 56));

                    case "6M":
                        return new SolidColorBrush(Color.FromArgb(220, 89, 171, 195));

                    case "12M":
                        return new SolidColorBrush(Color.FromArgb(220, 81, 163, 81));

                    default:
                        return new SolidColorBrush(Colors.White);
                }
            }
        }


        private int barrier;
        public int Barrier
        {
            get { return barrier; }
            set { barrier = value; NotifyProperty("Barrier"); }
        }


        private string sector;
        public string Sector
        {
            get { return sector; }
            set { sector = value; NotifyProperty("Sector"); }
        }

        private string currency;
        public string Currency
        {
            get { return currency; }
            set { currency = value; NotifyProperty("Currency"); }
        }

        private decimal couponToday;
        public decimal CouponToday
        {
            get { return couponToday; }
            set { couponToday = value; NotifyProperty("CouponToday"); }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyProperty(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        #endregion
    }
}
