using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFNotepad
{
    public class ObservabltObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged<T>(ref T property, T value, [CallerMemberName] string propertyName = "") //CallerMemberName will pick up the type so you don't have to use a magic string
        {
            property = value;
            var handler = PropertyChanged;
            if(handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        
        }
    }
}
