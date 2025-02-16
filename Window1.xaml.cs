using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _7899
{
    
    public partial class Window1 : Window
    {
        public void ok(List<NhanVien> zz)
        {
            dt.ItemsSource = zz;
        }
        public Window1()
        {
            InitializeComponent();

        }
    }
}
