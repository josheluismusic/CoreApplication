﻿using System.ComponentModel.Composition;
using System.Windows.Controls;
using CoreApplication.Mocks.MockModule3.ViewModels.Sample5;

namespace CoreApplication.Mocks.MockModule3.Views.Sample5
{
    [Export]
    public partial class View1 : UserControl
    {
        [ImportingConstructor]
        public View1(View1ViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
