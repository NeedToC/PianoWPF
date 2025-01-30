using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PianoWPF.Core
{
    public class ObservableObject : INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;


        protected virtual void OnPropertyChanging([CallerMemberName] string p_PropertyName = null)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(p_PropertyName));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string p_PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p_PropertyName));
        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
            {
                return false;
            }
            OnPropertyChanging(propertyName);
            field = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// For improved performance, the best practice is to use callback method TModel parameter in scope, not the field, ... E.g. (user, name) => user.Name = name;
        /// </summary>
        protected bool SetProperty<TModel, T>(T oldValue, T newValue, TModel model, Action<TModel, T> callback, [CallerMemberName] string propertyName = null)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            if (callback == null)
                throw new ArgumentNullException(nameof(callback));
            if (EqualityComparer<T>.Default.Equals(oldValue, newValue))
            {
                return false;
            }
            OnPropertyChanging(propertyName);
            callback(model, newValue);
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
