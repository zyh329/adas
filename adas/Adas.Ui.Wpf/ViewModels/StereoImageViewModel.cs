﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Adas.Core.Camera;
using Adas.Ui.Wpf.Annotations;
using Emgu.CV.Structure;

namespace Adas.Ui.Wpf.ViewModels
{
    public class StereoImageViewModel: INotifyPropertyChanged
    {
        private StereoImage<Bgr, byte> _image;
        
        private bool _showLeft;
        private bool _showRight;

        public StereoImageViewModel()
        {
            _showLeft = true;
            _showRight = true;
        }

        public StereoImage<Bgr, byte> Image
        {
            get { return _image; }
            set
            {
                if (Equals(value, _image)) return;
                _image = value;
                OnPropertyChanged();
            }
        }

        public bool ShowLeft {
            get { return _showLeft; }
            set
            {
                if (_showLeft == value) return;
                _showLeft = value;
                OnPropertyChanged();
            }
        }
        public bool ShowRight
        {
            get { return _showRight; }
            set
            {
                if (_showRight == value) return;
                _showRight = value;
                OnPropertyChanged();
            }
        }

        public bool ShowCustomize { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
