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

using sliverlight_prism_mvvm_sample.Model;

using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;

namespace sliverlight_prism_mvvm_sample.ViewModel
{
    public class MainPageViewModel : NotificationObject
    {
        private MainPageModel _model;

        public MainPageViewModel()
        {
            this._model = new MainPageModel()
                {
                    First = "first",
                    Second = "second"
                };
        }

        public string First
        {
            get
            {
                return this._model.First;
            }
            set
            {
                this._model.First = value;
                this.RaisePropertyChanged("First");
            }
        }

        public string Second
        {
            get
            {
                return this._model.Second;
            }
            set
            {
                this._model.Second = value;
                this.RaisePropertyChanged("Second");
            }
        }

        public string Result
        {
            get
            {
                return this._model.Result;
            }
            set
            {
                this._model.Result = value;
                this.RaisePropertyChanged("Result");
            }
        }

        public ICommand ClickCommand
        {
            get{
                return new DelegateCommand(ExecuteClick);
                }
        }

        public void ExecuteClick()
        {
            this.Result = string.Format("{0}-{1}", this.First, this.Second);
        }

    }
}
