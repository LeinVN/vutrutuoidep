using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using cuocsongtuoidep.Models;
using SQLite;
using Xamarin.Essentials;

namespace cuocsongtuoidep.Data
{
    public class TuvanDb //Khai báo tạo ra một csdl, tạo ra một bảng dữ liệu.
    {
        private SQLiteAsyncConnection csdl;
        public TuvanDb(string duongdan)
        {
            csdl = new SQLiteAsyncConnection(duongdan); //truyền đường dẫn vào sau bằng biến duongdan
            csdl.CreateTableAsync<Tuvanvien>().Wait(); //tạo bảng và chờ cho tới khi thành công
        }
        //Thêm sửa xóa danh sách.
        public Task<List<Tuvanvien>> TuvanList()
        {
            return csdl.Table<Tuvanvien>().ToListAsync();//gọi danh sách tư vấn viên
        }
        // Tìm Tư vấn viên theo ID
        public Task<Tuvanvien> TuvanvienGet(int Id) //phương thức TuvanvienGet trả về một tư vấn viên.
        {
            return csdl.Table<Tuvanvien>().Where(t => t.TuvanvienId == Id).FirstOrDefaultAsync(); //t là biến, => là điều kiện, firtOderDefault là tìm bản ghi đầu tiên.
        }
        // Cập nhật Tư vấn viên
        public Task<int> TuvanvienSave(Tuvanvien tvv)
        {
            if (tvv.TuvanvienId == 0)
                return csdl.InsertAsync(tvv);
            else
                return csdl.UpdateAsync(tvv);
        }
        //xóa Tư vấn viên
        public Task<int> TuvanvienDelete(Tuvanvien tvv)
        {
            return csdl.DeleteAsync(tvv);
        }
    }
}
