using ImagePanZoomRotateFilter.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImagePanZoomRotateFilter.ViewModels
{
    public class MedicalImageViewModel : INotifyPropertyChanged
    {

        private IImageLoader imageLoader;

        private List<int> rotations = new List<int>() { 0, 90, 180, 270 };
        public List<int> Rotations
        {
            get { return rotations; }
        }

       
        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        private double zoom = 1.0d;
        public double Zoom 
        { 
            get { return zoom; } 
            private set { SetProperty(ref zoom, value); } 
        }

        private double rotate = 90.0d;
        public double Rotate 
        { 
            get { return rotate; }  
            set { SetProperty(ref rotate, value); } 
        }

        double pan = 0.0d;
        public double Pan 
        { 
            get { return pan; } 
            private set { SetProperty(ref pan, value); } 
        }
        public ICommand LoadImageCommand { get; private set; }
        public ICommand MouseLeftButtonDownCommand { get; private set; }
        public ICommand MouseLeftButtonUpCommand { get; private set; }
        public ICommand MouseEnterCommand { get; private set; }
        public ICommand MouseLeaveCommand { get; private set; }
        public ICommand MouseMoveCommand { get; private set; }
        public ICommand MouseWheelCommand { get; private set; }
        public MedicalImageViewModel()
        {
            LoadImageCommand    = new RelayCommand<string>(async (p) => await ExecuteLoadItemsCommand(p));
            MouseLeftButtonDownCommand = new RelayCommand<MouseEventArgs>((mea) => ExecuteMouseLeftButtonDown(mea));
            MouseLeftButtonUpCommand = new RelayCommand<MouseEventArgs>((mea) => ExecuteMouseLeftButtonUp(mea));
            MouseEnterCommand = new RelayCommand<MouseEventArgs>((mea) => ExecuteMouseEnter(mea));
            MouseLeaveCommand = new RelayCommand<MouseEventArgs>((mea) => ExecuteMouseLeave(mea));
            MouseMoveCommand = new RelayCommand<MouseEventArgs>((mea) => ExecuteMouseMove(mea));
            MouseWheelCommand = new RelayCommand<MouseEventArgs>((mea) => ExecuteMouseWheel(mea));
        }

        private void ExecuteMouseWheel(MouseEventArgs mea)
        {
            
        }

        private void ExecuteMouseMove(MouseEventArgs mea)
        {
            throw new NotImplementedException();
        }

        private void ExecuteMouseLeave(MouseEventArgs mea)
        {
            
        }

        private void ExecuteMouseEnter(MouseEventArgs mea)
        {
            
        }

        private void ExecuteMouseLeftButtonUp(MouseEventArgs mea)
        {
            
        }

        private void ExecuteMouseLeftButtonDown(MouseEventArgs mea)
        {
            
        }

        async Task<int> ExecuteLoadItemsCommand(string p)
        {
            var r = Resources.Resources.ResourceManager.GetStream("Knee");
            return await imageLoader.Load(r);
        }
        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
