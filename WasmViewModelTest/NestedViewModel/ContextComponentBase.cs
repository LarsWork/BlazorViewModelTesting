using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace WasmViewModelTest
{

    /// <summary>
    /// ComponentBase with DataContext
    /// </summary>
    public class ContextComponentBase : ComponentBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Parameter]
        public ViewModelBase DataContext { get; set; }

        /// <inheritdoc />
        protected override async Task OnInitializedAsync()
        {
            if (DataContext == null) return;

            if (!DataContext.Initialized) // do once
            {
                await DataContext.InitializeAsync();
                DataContext.PropertyChanged += (s, e) =>
                {
                    Console.WriteLine($"Statehaschanged: {s}");
                    StateHasChanged();
                };
            }

            await base.OnInitializedAsync();
        }
    }
}