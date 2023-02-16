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

namespace KingConAPIClient2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KingConAPI.SendCacheOrder(txtMsg.Text.Trim());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtMsg.Text = "<MdjOrdersFile CompactMode=\"1\">\r\n\t<Orders>\r\n\t\t<Order Vol=\"3000\" VolMatch=\"0\" VolCancel=\"0\" ActionFlag=\"0\" OrderStatus=\"0\" DP=\"0\" SettleCurrency=\"0\" ETT=\"-1\" Price=\"10.100000\" BS=\"B\" Cond=\"R\" DealType=\"0\" TT=\"0\" OT=\"0\" PT=\"0\" Offset=\"6\" OFT=\"16\" DealTime=\"-1\" OrderDateTime=\"-1\" ConfirmDateTime=\"-1\" ID=\"6016.TW\" ID2=\"\" Name=\"康和證\" TSID=\"CSC\" EmergeBroker=\"\" EmergeBrokerName=\"\" CreatorAcc=\"\" DealAcc=\"0-9899999\" DealAccUI=\"證-總公司-9899999-*測試*許*千\" SSID=\"F123456789\" ChkUI=\"-1\"/>\r\n\t\t<Order Vol=\"3000\" VolMatch=\"0\" VolCancel=\"0\" ActionFlag=\"0\" OrderStatus=\"0\" DP=\"0\" SettleCurrency=\"0\" ETT=\"-1\" Price=\"0.000000\" BS=\"S\" Cond=\"I\" DealType=\"0\" TT=\"0\" OT=\"0\" PT=\"4\" Offset=\"6\" OFT=\"16\" DealTime=\"-1\" OrderDateTime=\"-1\" ConfirmDateTime=\"-1\" ID=\"2887.TW\" ID2=\"\" Name=\"台新金\" TSID=\"CSC\" EmergeBroker=\"\" EmergeBrokerName=\"\" CreatorAcc=\"\" DealAcc=\"0-9899999\" DealAccUI=\"證-總公司-9899999-*測試*許*千\" SSID=\"F123456789\" ChkUI=\"-1\"/>\r\n\t</Orders>\r\n</MdjOrdersFile>\n";
        }
    }
}
