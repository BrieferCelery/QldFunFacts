using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace QldFunFacts
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        // Implementation of INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string name = null) => PropertyChanged?
            .Invoke(this, new PropertyChangedEventArgs(name));
    }
}
