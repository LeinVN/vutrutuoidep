using cuocsongtuoidep.Models;
using cuocsongtuoidep.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cuocsongtuoidep
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuanLyTuVanVien : ContentPage
    {
        public QuanLyTuVanVien()
        {
            InitializeComponent();
        }

        async protected override void OnAppearing()
        {
            lstTuvanvien.ItemsSource = await App.db.TuvanList(); // load lại list dữ liệu
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Themtuvanvien());
        }
        private void btnSua_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button; //button để sửa
            Grid grid = (Grid)button.Parent; //khai báo biến grid kiểu Grid, Parent: nơi 
            Label id = grid.FindByName<Label>("lblId");
            Label hoten = grid.FindByName<Label>("lblHoTen");
            Label ngaysinh = grid.FindByName<Label>("lblNgaySinh");
            Label gioitinh = grid.FindByName<Label>("lblGioiTinh");
            Label dienthoai = grid.FindByName<Label>("lblDienThoai");
            Label tinhtrang = grid.FindByName<Label>("lblTinhTrang");
            Tuvanvien tvv = new Tuvanvien();
            tvv.TuvanvienId = Convert.ToInt32(id.Text);
            tvv.TuvanvienName = hoten.Text;
            tvv.TuvanvienDate = Convert.ToDateTime(ngaysinh.Text);
            tvv.TuvanvienGender = (gioitinh.Text== "True")? true: false ;
            tvv.TuvanvienPhone = dienthoai.Text;
            tvv.TuvanvienEnabled = (tinhtrang.Text=="True")? true: false;
            Navigation.PushAsync(new Themtuvanvien(tvv));
            
        }

        async private void btnXoa_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Grid grid = (Grid)button.Parent;
            Label id = grid.FindByName<Label>("lblId");
            Tuvanvien tvv = await App.db.TuvanvienGet(Convert.ToInt32(id.Text));
            int xoaID = await App.db.TuvanvienDelete(tvv);
            lstTuvanvien.ItemsSource =await App.db.TuvanList(); //load lại list dữ liệu
        }
    }
}