using cuocsongtuoidep.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cuocsongtuoidep
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Themtuvanvien : ContentPage
	{
		int id = 0;
		public Themtuvanvien (Tuvanvien tvv=null)
		{
			InitializeComponent ();
			if (tvv != null)
			{
				id = tvv.TuvanvienId;
				txtHoten.Text = tvv.TuvanvienName;
				txtNgaysinh.Date = tvv.TuvanvienDate;
				pkGioitinh.SelectedIndex = (tvv.TuvanvienGender == true) ? 0 : 1;
				txtDienthoai.Text = tvv.TuvanvienPhone;
				pkTrangthai.SelectedIndex =(tvv.TuvanvienEnabled== true) ? 0 : 1;
			}
            else
                id = 0;
        }

        private void btnThem_Clicked(object sender, EventArgs e)
        {
			Tuvanvien tvv= new Tuvanvien();
			tvv.TuvanvienId = id;
			tvv.TuvanvienName = txtHoten.Text;
			tvv.TuvanvienDate = txtNgaysinh.Date;
			tvv.TuvanvienGender = (pkGioitinh.SelectedItem.ToString() == "Nam") ? true : false;
			tvv.TuvanvienPhone = txtDienthoai.Text;
			tvv.TuvanvienEnabled = (pkTrangthai.SelectedItem.ToString()=="Hoạt động")? true : false;
			App.db.TuvanvienSave(tvv); //Lưu dữ liệu ào DB
			Navigation.PopAsync(); //quan về trang trước
        }
    }
}