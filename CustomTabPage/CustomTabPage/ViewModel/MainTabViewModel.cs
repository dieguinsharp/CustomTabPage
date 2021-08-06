using CustomTabPage.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CustomTabPage.ViewModel {
    class MainTabViewModel:INotifyPropertyChanged {

        public Command PageCommand { get; set; }


        StackLayout _sl;
        public MainTabViewModel (StackLayout sl) {

            PageCommand = new Command<object>(ClickPage);
            _sl = sl;
        }

        public void ClickPage(object id) {

            StackLayout page = null;

            var pageId = (Page)Convert.ToInt32(id);

            switch(pageId) {

                case Page.Page1:

                    page = new Page1();

                    break;
                case Page.Page2:

                    page = new Page2();

                    break;
                case Page.Page3:

                    page = new Page3();

                    break;
                case Page.Page4:

                    page = new Page4();

                    break;

            }

            _sl.Children.Clear();
            _sl.Children.Add(page);

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
