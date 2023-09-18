using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Data_Access_Layer
{
    class Sale
    {
        public int SalesNo { get; set; }
        public string Date { get; set; }
        public string MedicineName { get; set; }
        public double Price { get; set; }
    }
}
