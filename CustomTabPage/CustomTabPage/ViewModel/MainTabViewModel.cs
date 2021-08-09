using CustomTabPage.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomTabPage.ViewModel {
    class MainTabViewModel:INotifyPropertyChanged {

        Page1 page1;
        Page2 page2;
        Page3 page3;
        Page4 page4;

        public Command PageCommand { get; set; }


        StackLayout _slTabbed;
        public MainTabViewModel (StackLayout sl) {

            PageCommand = new Command<object>(ClickPage);
            _slTabbed = sl;

            page1 = new Page1();
            page2 = new Page2();
            page3 = new Page3();
            page4 = new Page4();

            AddStack(page1);
            AddStack(page2);
            AddStack(page3);
            AddStack(page4);

            SetVisibleStack(page1);
        }

        public async void ClickPage(object id) {

            var pageId = (Page)Convert.ToInt32(id);

            switch(pageId) {

                case Page.Page1:

                    SetVisibleStack(this.page1);

                    break;
                case Page.Page2:

                    SetVisibleStack(this.page2);

                    break;
                case Page.Page3:

                    SetVisibleStack(this.page3);

                    break;
                case Page.Page4:

                    SetVisibleStack(this.page4);

                    break;

            }

        }

        public void SetVisibleStack (StackLayout page) {

            var indexPage = this._slTabbed.Children.IndexOf(page);

            Device.BeginInvokeOnMainThread(() => { 
                
                for(var x = 0; x < this._slTabbed.Children.Count;x++) {

                    if(indexPage == x) {
                        this._slTabbed.Children[x].IsVisible = true;
                    } else {
                        this._slTabbed.Children[x].IsVisible = false;
                    }

                }
                
            });  

        }
        public void AddStack (StackLayout page) {
  
            this._slTabbed.Children.Add(page);               

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    enum Page {
        Page1 = 1,
        Page2 = 2,
        Page3 = 3,
        Page4 = 4
    }
}
