﻿using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace CoreApplication.Mocks.MockModule3.Views.Default
{
    [Export]
    public partial class PacienteInfo : UserControl
    {
        public PacienteInfo()
        {
            InitializeComponent();
        }
    }
}
