using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace tutorial_mvc.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public int Volume1
        {
            get { return GetValue<int>(nameof(Volume1)); }
            set { SetValue(value, nameof(Volume1)); }
        }

        public string Source1
        {
            get { return GetValue<string>(nameof(Source1)); }
            set { SetValue(value, nameof(Source1)); }
        }

        public int Volume2
        {
            get { return GetValue<int>(nameof(Volume2)); }
            set { SetValue(value, nameof(Volume2)); }
        }
        public int Volume3
        {
            get { return GetValue<int>(nameof(Volume3)); }
            set { SetValue(value, nameof(Volume3)); }
        }
        public int Volume4
        {
            get { return GetValue<int>(nameof(Volume4)); }
            set { SetValue(value, nameof(Volume4)); }
        }

        public MainWindowViewModel()
        {
            Volume1 = 50;
            Source1 = @"C:\Pp\Internet Money\nick mira\Nick Mira Bodega Drum Kit\Snares & Claps\NM - Blocc (Clap).wav";
        }

    }
}
