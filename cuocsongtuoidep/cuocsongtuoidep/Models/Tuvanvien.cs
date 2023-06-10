using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace cuocsongtuoidep.Models
{
    public class Tuvanvien
    {
        [PrimaryKey, AutoIncrement]
        public int TuvanvienId { get; set; }
        public string TuvanvienName { get; set; }
        public DateTime TuvanvienDate { get; set; }
        public Boolean TuvanvienGender { get; set; }
        public string TuvanvienPhone { get; set; }
        public Boolean TuvanvienEnabled { get; set; }
    }
}
