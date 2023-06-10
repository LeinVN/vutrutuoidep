using cuocsongtuoidep.Services;
using cuocsongtuoidep.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using cuocsongtuoidep.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace cuocsongtuoidep
{
    public partial class App : Application
    {
        private static TuvanDb _db; //Private Static dùng chung cho ứng dụng, không mất đi khi chuyển các giao diện, _db biến phụ của db
        public static TuvanDb db{ //Kiểu trả về cũng là TuvanDb
            get //không cần set
            {
                if (_db == null) //lần đầu tiên mới chạy ứng dụng _db= null
                    _db = new TuvanDb(Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData), "cstd.db3"));
                        // Path lấy ra trong đường dẫn của điện thoại, Combine: nối,
                        // GetFolderPath: Phương thức lấy đường dẫn thiết bị.
                        // Nối path với  tên file cstd.db3 là tên file dữ liệu.
                return _db; //nếu không null, có rồi thì trả về _db
            }
        }
        public App()
        {
            InitializeComponent();
            //DependencyService.Register<MockDataStore>();
            //MainPage = AppShell();
            //Mainpage là trang quản lý
            //MainPage = new NavigationPage(new MainPage()); //NavigationPage thanh điều hướng mở các trang dữ liệu khác
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}
