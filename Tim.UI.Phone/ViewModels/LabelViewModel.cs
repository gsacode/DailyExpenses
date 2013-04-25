using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Tim.UI.Phone.ViewModels
{
    public class LabelViewModel : INotifyPropertyChanged
    {
        private int _labelId;
        /// <summary>
        /// Label Identifier
        /// </summary>
        /// <returns></returns>
        public int LabelId
        {
            get
            {
                return _labelId;
            }
            set
            {
                if (value != _labelId)
                {
                    _labelId = value;
                    NotifyPropertyChanged("LabelId");
                }
            }
        }

        private string _name;
        /// <summary>
        /// Name of the Label
        /// </summary>
        /// <returns></returns>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        private SolidColorBrush _labelColor;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public SolidColorBrush LabelColor
        {
            get
            {
                return _labelColor;
            }
            set
            {
                if (value != _labelColor)
                {
                    _labelColor = value;
                    NotifyPropertyChanged("LabelColor");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}