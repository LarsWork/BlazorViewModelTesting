namespace WasmViewModelTest
{
    public class CheckBoxViewModel : ViewModelBase
    {
        private bool _checkbox;

        public bool CheckBoxState
        {
            get => _checkbox;
            set { 
                _checkbox = value;
                OnPropertyChanged(nameof(CheckBoxState));
            }
        }
    }
}
