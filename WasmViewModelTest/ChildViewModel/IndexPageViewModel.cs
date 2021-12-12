namespace WasmViewModelTest
{
    public class IndexPageViewModel : ViewModelBase
    {
        public CheckBoxViewModel CheckBoxViewModel { get; set; }

        public IndexPageViewModel()
        {
            CheckBoxViewModel = new CheckBoxViewModel();
            AddChildViewModel(CheckBoxViewModel);
        }

    }
}
