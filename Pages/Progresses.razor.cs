﻿using Microsoft.AspNetCore.Components;
using Xakpc.BlazorBits.Bootstrap.ViewModels;

namespace Xakpc.BlazorBits.Bootstrap.Pages
{
    public partial class Progresses
    {
        [Inject]
        protected new ProgressViewModel DataContext
        {
            get => base.DataContext as ProgressViewModel;
            set => base.DataContext = value;
        }
    }
}
