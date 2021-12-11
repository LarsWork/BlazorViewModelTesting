namespace WasmViewModelTest
{
    public class SimpleViewModel : ViewModelBase
    {
        private bool _checkbox;

        public bool CheckBoxState
        {
            get => _checkbox;
            set { _checkbox = value; OnPropertyChanged(nameof(CheckBoxState)); }
        }
    }
}
