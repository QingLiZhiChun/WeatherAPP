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
using Weather.jsonobj;

namespace Weather.itemview
{
    /// <summary>
    /// WeatherItemView.xaml 的交互逻辑
    /// </summary>
    public partial class WeatherItemView : UserControl
    {
        private static DependencyProperty ForecastProperty;
        static PropertyMetadata ForecastPropertyMetadata;

        private static DependencyProperty YesterdayProperty;
        static PropertyMetadata YesterdayPropertyMetadata;
        static WeatherItemView()
        {
            ForecastPropertyMetadata = new PropertyMetadata(null, new PropertyChangedCallback(ForecastPropertyChangedCallback), new CoerceValueCallback(ForecastCoerceValueCallback));
            ForecastProperty = DependencyProperty.Register("Forecast", typeof(Forecast), typeof(WeatherItemView), ForecastPropertyMetadata);


            YesterdayPropertyMetadata = new PropertyMetadata(null, new PropertyChangedCallback(YesterdayPropertyChangedCallback), new CoerceValueCallback(YesterdayCoerceValueCallback));
            YesterdayProperty = DependencyProperty.Register("Yesterday", typeof(Yesterday), typeof(WeatherItemView), YesterdayPropertyMetadata);
        }

        public Yesterday Yesterday
        {
            get
            {
                return (Yesterday)GetValue(YesterdayProperty);
            }
            set
            {
                SetValue(YesterdayProperty,value);
            }
        }
        public Forecast Forecast
        {
            get
            {
                return (Forecast)GetValue(ForecastProperty);
            }
            set
            {
                SetValue(ForecastProperty, value);
            }
        }

        private static object YesterdayCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return baseValue; 
        }

        private static void YesterdayPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WeatherItemView weatherItemView = d as WeatherItemView;
            Yesterday Yesterday = e.NewValue as Yesterday;
            if (Yesterday == null)
            {
                return;
            }
            weatherItemView.txtBlkDate.Text = Yesterday.ymd;
            weatherItemView.txtBlkweek.Text = Yesterday.week;
            weatherItemView.LabRiChu.Content = Yesterday.sunrise;
            weatherItemView.LabRiLuo.Content = Yesterday.sunset;
            weatherItemView.txtBlkWeatherType.Text = Yesterday.type;
            weatherItemView.labZuiGao.Content = Yesterday.high;
            weatherItemView.labZuiDi.Content = Yesterday.low;
            weatherItemView.LabFengXiang.Content = Yesterday.fx;
            weatherItemView.LabFengLi.Content = Yesterday.fl;
            ChangeImage(weatherItemView, Yesterday.type);
        }

        private static object ForecastCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return baseValue;
        }

        private static void ForecastPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WeatherItemView weatherItemView = d as WeatherItemView;
            Forecast f = e.NewValue as Forecast;
            weatherItemView.txtBlkDate.Text = f.ymd;
            weatherItemView.txtBlkweek.Text = f.week;
            weatherItemView.LabRiChu.Content = f.sunrise;
            weatherItemView.LabRiLuo.Content = f.sunset;
            weatherItemView.txtBlkWeatherType.Text = f.type;
            weatherItemView.labZuiGao.Content = f.high;
            weatherItemView.labZuiDi.Content = f.low;
            weatherItemView.LabFengXiang.Content = f.fx;
            weatherItemView.LabFengLi.Content = f.fl;
            ChangeImage(weatherItemView, f.type);
        }


      static  void ChangeImage(WeatherItemView weatherItemView,string weather) {
            switch (weather) {
                case "晴":
                    weatherItemView.weatherImg.Source = new BitmapImage(new Uri("pack://application:,,,/img/sun.png"));
                    break;
                case "多云":
                    weatherItemView.weatherImg.Source = new BitmapImage(new Uri("pack://application:,,,/img/duoyun.png"));
                    break;
                default:
                    break;
            }
        }

        public WeatherItemView()
        {
            InitializeComponent();
        }
    }
}
