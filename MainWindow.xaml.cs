using System.Reflection.Metadata;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _7899;

public record class NhanVien(string MaNV,string HoTen,string GioiTinh,DateTime NgaySinh,string PhongBan)
{
    public int tuoi => DateTime.Now.Year - NgaySinh.Year;
}
 
public partial class MainWindow : Window
{
    List<NhanVien> nv = new List<NhanVien>();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnNhap_Click(object sender, RoutedEventArgs e)
    {
        if (txtMaNhanVien.Text == ""||txtHoTen.Text==""||txtHeSoluong.Text=="")
        {
            MessageBox.Show("co loi");
            return;
        }
        

        var MaNV = txtMaNhanVien.Text;
        var HoTen = txtHoTen.Text;
        var GioiTinh = radNam.IsChecked.Value ? "Nam" : "Nữ";
        var PhongBan = cboPhongBan.SelectionBoxItem.ToString();
        var NgaySinh = dpNgaySinh.SelectedDate;
        if(!float.TryParse(txtHeSoluong.Text,out float HeSoLuong)||HeSoLuong<=0)
        {
            MessageBox.Show("he so luong >0");
            return;
        }
        NhanVien nvien = new NhanVien(MaNV,HoTen,GioiTinh,NgaySinh.Value,PhongBan);
        if (nvien.tuoi < 18)
        {
            MessageBox.Show("phai tu 18 tuoi");
            return;
        }
        if (nv.Find(nvv => nvien.MaNV == nvv.MaNV)!=null)
        {
            MessageBox.Show("trung ma nv");
            return;
        }
        nv.Add(nvien);

        dt.ItemsSource = null;
        dt.ItemsSource = nv;

    }

    private void btnWin1(object sender, RoutedEventArgs e)
    {
        var zz = nv.Where(nvi => nvi.tuoi == nv.Max(n => n.tuoi)).ToList();
        var c = new Window1();
        c.Show();
        c.ok(zz);
    }

}