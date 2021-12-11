﻿using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Xakpc.BlazorBits.Bootstrap.ViewModels
{
    public class ProgressViewModel : ViewModelBase
    {
        private int _progress;
        private LarsProgressViewModel _larsViewModel;

        public ProgressViewModel()
        {
            Add = new Command<int>(i => Progress += 1, i => Progress < 100);
            Subtract = new Command<int>(i => Progress -= 1, i => Progress > 0);
            LarsProgressViewModel = new LarsProgressViewModel();
        }

        public int Progress
        {
            get => _progress;
            set { _progress = value; OnPropertyChanged(nameof(Progress)); }
        }
        public LarsProgressViewModel LarsProgressViewModel
        {
            get => _larsViewModel;
            set { _larsViewModel = value; OnPropertyChanged(nameof(LarsProgressViewModel)); }
        }

        public override Task InitializeAsync()
        {
            Progress = 22;
            return base.InitializeAsync();
        }

        public ICommand Add { get; set; }
        public ICommand Subtract { get; set; }
    }
}