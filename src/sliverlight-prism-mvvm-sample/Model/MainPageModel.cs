using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using Microsoft.Practices.Prism.ViewModel;

namespace sliverlight_prism_mvvm_sample.Model
{
    public class MainPageModel : NotificationObject
    {
        private string _first;
        public string First
        {
            get { return this._first; }
            set
            {
                this._first = value;
                this.RaisePropertyChanged(() => this.First);
            }
        }

        private string _second;
        public string Second
        {
            get { return this._second; }
            set
            {
                this._second = value;
                this.RaisePropertyChanged(() => this.Second);
            }
        }

        private string _result;
        public string Result
        {
            get { return this._result; }
            set
            {
                this._result = value;
                this.RaisePropertyChanged(() => this.Result);
            }
        }
    }
}
