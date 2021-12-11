using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Xakpc.BlazorBits.Bootstrap.ViewModels
{
public class LarsProgressViewModel : ViewModelBase
{
    private int _progress;

    public LarsProgressViewModel()
    {
        Add = new Command<int>(i => Progress += 1, i => Progress < 100);
        Subtract = new Command<int>(i => Progress -= 1, i => Progress > 0);
    }

    public int Progress
    {
        get => _progress;
        set { _progress = value; OnPropertyChanged(nameof(Progress)); }
    }

    public override Task InitializeAsync()
    {
        Progress = 66;
        return base.InitializeAsync();
    }

    public ICommand Add { get; set; }
    public ICommand Subtract { get; set; }
}
}