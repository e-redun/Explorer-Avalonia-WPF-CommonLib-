using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestLib.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
		private string _mainDiskName;

		public string MainDiskName
        {
			get { return _mainDiskName; }
			set
			{ 
				_mainDiskName = value; 
				OnPropertyChanged();
			}
		}

		public MainViewModel()
		{
			MainDiskName = "4444444444444";
		}

		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
