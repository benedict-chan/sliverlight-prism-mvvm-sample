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

namespace sliverlight_prism_mvvm_sample.Interfaces
{
    public interface IClickService
    {
        string GetResult(string first, string second);
    }
}
