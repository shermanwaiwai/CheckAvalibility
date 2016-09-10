using System;
using System.Collections.Generic;
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

using CheckAvability.Common;
using CheckAvability.Service;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using CheckAvability.Model;
using System.Collections;
using System.Data;
using System.Windows.Threading;
using CheckAvability.DAL;
namespace CheckAvability
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IConfiguration config { get; set; }
        //private IStoreService storeService { get; set; }
        private ICheckIphoneService checkIphoneService { get; set; }
        private IAuthService authService { get; set; }
        private IIphonePlus PlusDAL { get; set; }
        private DispatcherTimer dispatcherTimer { get; set; }
        private int DefaultSecond { get; set; } = 15;
        private bool isDBSave { get; set; } = false;
        public MainWindow()
        {
            this.config = new Configuration();
            //this.storeService = new StoreService(this.config);
            this.checkIphoneService = new CheckIphoneService(this.config);
            this.authService = new AuthService(this.config);
            this.PlusDAL = new IphonePlus();
            InitializeComponent();
        }
        
        private async void btn_Start_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    int second;
                    if (Int32.TryParse(textBox.Text, out second))
                    {
                        this.DefaultSecond = second;
                    }
                }
                this.dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                dispatcherTimer.Interval = new TimeSpan(0, 0, this.DefaultSecond);
                dispatcherTimer.Start();
                await CheckAvalibility();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            await CheckAvalibility();
        }

        public async Task CheckAvalibility()
        {
            dynamic result = await checkIphoneService.GetIphoneTaskAsyn();
            List<IphoneAvalibilityInStore> IphoneInStore = new List<IphoneAvalibilityInStore>();
            List<IphonePlusAvalibilityInStore> IphonePlusInStore = new List<IphonePlusAvalibilityInStore>();
            var jObj = (JObject)result;

            foreach (JToken token in jObj.Children())
            {
                if (token is JProperty)
                {
                    var prop = token as JProperty;

                    if (prop.Name == "R409" || prop.Name == "R428" || prop.Name == "R485" || prop.Name == "R499" || prop.Name == "R610")
                    {
                        IphoneAvalibilityInStore get_iphone_return = Mapper.IphoneMapping(prop.Name, prop.Value.ToString());
                        IphonePlusAvalibilityInStore get_iphone_plus_return = Mapper.IphonePlusMapping(prop.Name, prop.Value.ToString());
                        IphoneInStore.Add(get_iphone_return);
                        IphonePlusInStore.Add(get_iphone_plus_return);
                    }
                }
            }
            IphonedataGrid.ItemsSource = IphoneInStore;
            IphonePlusdataGrid.ItemsSource = IphonePlusInStore;
            IphonedataGrid.Items.Refresh();
            IphonePlusdataGrid.Items.Refresh();

            
            if (isDBSave)
            {
                var plus_mapper_return = Common.IphonePlusMapper.IphonePlusMapToDbEntities(IphonePlusInStore).ToList();
                if (plus_mapper_return.Count() > 0)
                {
                    await PlusDAL.Create(plus_mapper_return);
                }
            }
        }

        private async void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            await this.authService.GetLoginUrlTask();
        }


        //public void UpdateColor(DataGrid input)
        //{
        //    var r= GetDataGridRows(input);

        //    foreach (DataGridColumn column in IphonedataGrid.Columns)
        //    {
        //        if (column.GetCellContent(r) is TextBlock)
        //        {
        //            TextBlock cellContent = column.GetCellContent(r) as TextBlock;
        //            if (cellContent.Text == "ALL")
        //            {
        //                cellContent.Background = Brushes.Pink;
        //            }
        //        }
        //    }
        //}

        //public IEnumerable<DataGridRow> GetDataGridRows(DataGrid grid)
        //{
        //    var itemsSource = grid.ItemsSource as IEnumerable;
        //    if (null == itemsSource) yield return null;
        //    foreach (var item in itemsSource)
        //    {
        //        var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
        //        if (null != row) yield return row;
        //    }
        //}
    }

}
