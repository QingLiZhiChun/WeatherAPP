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
using Weather.net;
using System.IO;
using Weather.convert;
using Weather.task;
using Weather.jsonobj;
using Newtonsoft.Json;
using Weather.itemview;

namespace Weather
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Root root;
        public MainWindow()
        {
            InitializeComponent();
            notifiationTask.notificationEvent += NotifiationTask_notificationEvent;
            notifiationTask.SartMessageMonitor();
        }

        private void NotifiationTask_notificationEvent(MessageQueue msgQueue)
        {
            string val = msgQueue.DequeueMessage();
            JsonConvertTool cvtool = JsonConvertTool.CreateJsonRoot(val);
            if (cvtool.Validity())
            {
                root = cvtool.root;

                this.Dispatcher.Invoke(new Action(weatherViewInvoke));
                
            }
        }

        private void weatherViewInvoke()
        {
            if (root==null)
            {
                return;
            }
            weatherContentView.CityInfo = root.cityInfo;
            weatherContentView.DataInfo = root.data;
            f(root);
        }

        void f(Root root) {
        
            WeatherItemView itemView = new WeatherItemView();
            itemView.Yesterday = root.data.yesterday;
            stackpanel.Children.Add(itemView);


            foreach (var item in root.data.forecast) {
                WeatherItemView forecastitemView = new WeatherItemView();
                forecastitemView.Forecast = item;
                stackpanel.Children.Add(forecastitemView);
            }
        }

        WeatherTask wtsk = new WeatherTask();
        notification.NotifiationTask notifiationTask = new notification.NotifiationTask();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            wtsk.StartTask();
        }
    }
}
