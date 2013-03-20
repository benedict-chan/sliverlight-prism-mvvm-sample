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

using sliverlight_prism_mvvm_sample.Interfaces;

namespace sliverlight_prism_mvvm_sample.Implementations
{
    public class ClickService : IClickService
    {

        public string GetResult(string first, string second)
        {
            return string.Format("{0} joined {1} in {2}", first, second, this.GetType().Name);
        }

    }
}
