using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CsharpDDD1.WinForm.ViewModels
{
    /// <summary>
    /// ViewModelのBaseクラス
    /// INotifiPropertyChangedを実装
    /// </summary>
    public abstract class ViewModelBase :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual bool SetProperty<T>(ref T field, T value,[CallerMemberName] string propertyName =null)
        {
            if (Equals(field, value)){ return false; }
            {
                field = value;
                var h = this.PropertyChanged;
                if(h != null) { h(this, new PropertyChangedEventArgs(propertyName)); }
                return true;
            }
        }

    }
}
