using mvvm_part2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvm_part2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RoomsView : ContentPage
	{        
        public RoomsView ( )
		{
            InitializeComponent();
            BindingContext = new RoomsViewModel();
        }
	}
}