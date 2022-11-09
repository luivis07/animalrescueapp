using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace animalrescue.mainmodule.services.dtos
{
    public abstract class BaseDto : INotifyPropertyChanged
    {
        protected ICollection<string> _changedProperties { get; } = new HashSet<string>();
        public event PropertyChangedEventHandler? PropertyChanged
        {
            add { }
            remove { }
        }
        protected void OnPropertyChanged(string propertyName, object before, object after)
        {
            _changedProperties.Add(propertyName);
        }

        public IReadOnlyCollection<string> ChangedProperties => _changedProperties.ToList();
    }
}