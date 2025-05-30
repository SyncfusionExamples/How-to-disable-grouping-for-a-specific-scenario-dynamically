using SfDataGridSample.Helper;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            viewModel.InstalledModels.CollectionChanged += InstalledModels_CollectionChanged;
        }

        private void InstalledModels_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                if (datagrid.View?.Groups?.Count() == 1)
                {
                    datagrid.GroupColumnDescriptions.Clear();
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            viewModel.InstalledModels.Add(new InstalledModel()
            {
                Architecture = "x64",
                ParameterSize = 12345,
                Publisher = "DEF Corp",
                FullModel = "Model B",
                Quantization = "Int16",
                HumanReadableSize = "13.5 MB",
                ModifiedAt = DateTime.Now,
                Location = "Data Center A"
            });

        }
    }

    public class InstalledModel
    {
        public string Architecture { get; set; }
        public int ParameterSize { get; set; }
        public string Publisher { get; set; }
        public string FullModel { get; set; }
        public string Quantization { get; set; }
        public string HumanReadableSize { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string Location { get; set; } // Grouping column
    }

    public class InstalledModelsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<InstalledModel> _installedModels;

        public ObservableCollection<InstalledModel> InstalledModels
        {
            get => _installedModels;
            set
            {
                if (_installedModels != value)
                {
                    _installedModels = value;
                    OnPropertyChanged(nameof(InstalledModels));
                }
            }
        }

        public ICommand AddMoreCommand { get; }

        public InstalledModelsViewModel()
        {
            InstalledModels = new ObservableCollection<InstalledModel>();


            var model = new InstalledModel()
            {
                Architecture = "x64",
                ParameterSize = 12345,
                Publisher = "ABC Corp",
                FullModel = "Model A",
                Quantization = "Int8",
                HumanReadableSize = "12.3 MB",
                ModifiedAt = DateTime.Now,
                Location = "Data Center A"
            };
            InstalledModels.Add(model);
            var model1 = new InstalledModel
            {
                Architecture = "ARM",
                ParameterSize = 6789,
                Publisher = "XYZ Inc",
                FullModel = "Model B",
                Quantization = "FP16",
                HumanReadableSize = "8.9 MB",
                ModifiedAt = DateTime.Now.AddDays(-1),
                Location = "Data Center A"
            };
            InstalledModels.Add(model1);


        }

        private void AddMore()
        {
            InstalledModels.Add(new InstalledModel
            {
                Architecture = "RISC-V",
                ParameterSize = 4567,
                Publisher = "RISC Publisher",
                FullModel = "Model C",
                Quantization = "FP32",
                HumanReadableSize = "14.7 MB",
                ModifiedAt = DateTime.Now.AddDays(-2),
                Location = "Data Center C"
            });

            // Add more items or different logic here if needed
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
