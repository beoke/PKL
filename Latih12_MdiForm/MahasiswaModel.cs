using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Latih12_MdiForm
{
    public class MahasiswaModel
    {
        public int MahasiswaId { get; set; }
        public string MahasiswaName { get; set; }
        public int Umur { get; set; }
        public string Jurusan { get; set; }
    }
}
