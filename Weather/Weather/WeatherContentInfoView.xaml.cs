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

namespace Weather
{
    /// <summary>
    /// WeatherContentInfoView.xaml 的交互逻辑
    /// </summary>
    public partial class WeatherContentInfoView : UserControl
    {
        /// <summary>
        /// 城市信息依赖属性
        /// </summary>
        public static DependencyProperty CityInfoProperty = null;
        private static PropertyMetadata CityInfoPropertyMetadata = null;
        /// <summary>
        /// data属性
        /// </summary>
        public static DependencyProperty DataProperty = null;
        /// <summary>
        /// Data元数据
        /// </summary>
        public static PropertyMetadata DataPropertyMetadata = null;
        static WeatherContentInfoView()
        {
            CityInfoPropertyMetadata = new PropertyMetadata(null, new PropertyChangedCallback(CityInfoPropertyChangedCallback), new CoerceValueCallback(CityInfoCoerceValueCallback));//注册城市信息依赖属性
            CityInfoProperty = DependencyProperty.Register("CityInfo", typeof(CityInfo), typeof(WeatherContentInfoView), CityInfoPropertyMetadata);

            DataPropertyMetadata = new PropertyMetadata(null, new PropertyChangedCallback(DataPropertyChangedCallback), new CoerceValueCallback(DataCoerceValueCallback));//注册天气数据元数据
            DataProperty = DependencyProperty.Register("Data", typeof(Data), typeof(WeatherContentInfoView), DataPropertyMetadata);//注册天气数据依赖属性
        }

        private static object DataCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return baseValue;
        }

        private static void DataPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WeatherContentInfoView weatherContentInfoView = d as WeatherContentInfoView;
            if (e.NewValue==null)
            {
                return;
            }
            Data data = e.NewValue as Data;
            weatherContentInfoView.TxtBlkShiDu.Text = data.shidu;
            weatherContentInfoView.TxtBlkPm25.Text = data.pm25;
            weatherContentInfoView.TxtBlkPm10.Text = data.pm10;
            weatherContentInfoView.TxtBlkKongQiZhiLiang.Text = data.quality;
            weatherContentInfoView.TxtBlkWenDu.Text = data.wendu;
            weatherContentInfoView.TxtBlkJianKangTiXing.Text = data.ganmao;
        }

        /// <summary>
        /// 城市信息强制回调
        /// </summary>
        /// <param name="d"></param>
        /// <param name="baseValue"></param>
        /// <returns></returns>
        private static object CityInfoCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return baseValue;
        }
        /// <summary>
        /// 城市信息属性变化时处理城市信息显示
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void CityInfoPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WeatherContentInfoView weatherContentInfoView = d as WeatherContentInfoView;
            CityInfo cityInfo = e.NewValue as CityInfo;
            weatherContentInfoView.txtBlkProvince.Text = cityInfo.parent;//获取省信息
            weatherContentInfoView.txtBlkRegion.Text = cityInfo.city;//获取城市信息
            weatherContentInfoView.TxtBlkUpdateTime.Text = cityInfo.updateTime;
        }
        /// <summary>
        /// 城市信息
        /// </summary>
        public CityInfo CityInfo
        {
            get
            {
                return (CityInfo)GetValue(CityInfoProperty);
            }
            set
            {
                SetValue(CityInfoProperty, value);
            }
        }
        /// <summary>
        /// 天气数据
        /// </summary>
        public Data DataInfo
        {
            get
            {
                return (Data)GetValue(DataProperty);
            }
            set
            {
                SetValue(DataProperty, value);
            }
        }
        public WeatherContentInfoView()
        {
            InitializeComponent();
        }
    }
}
