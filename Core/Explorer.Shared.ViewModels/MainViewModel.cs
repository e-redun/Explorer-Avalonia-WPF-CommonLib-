using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Explorer.Shared.ViewModels
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

		public object TestVM { get; set; } = new TestViewModel();

		public MainViewModel()
		{
			MainDiskName = Environment.SystemDirectory;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
