﻿using CoreApplication.Mocks.MockModule1.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoreApplication.Mocks.MockModule1.Views
{
    /// <summary>
    /// Interaction logic for View2.xaml
    /// </summary>
    [Export("MockModule1.View2")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class View2 : UserControl
    {
        [ImportingConstructor]
        public View2(View2ViewModel vm)
        {
            InitializeComponent();

            this.DataContext = vm;
        }
    }
}
