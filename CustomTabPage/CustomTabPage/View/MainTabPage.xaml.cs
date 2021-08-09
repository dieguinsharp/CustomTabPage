using CustomTabPage.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomTabPage.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabPage:ContentPage {
        public MainTabPage () {
            InitializeComponent();

            BindingContext = new MainTabViewModel(StackTabbed);
        }
    }
}