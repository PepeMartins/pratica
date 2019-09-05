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
        public int Volume
        {
            get { return GetValue<int>(nameof(Volume)); }
            set { SetValue(value, nameof(Volume)); }
        }
    }
}
