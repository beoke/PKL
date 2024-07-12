using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih11_KonekDbDapper
{
    public class NIlaiDal
    {
        private const string _consString = "Data Source=DESKTOP-B10RQSP;Initial Catalog=LatihanDatabase;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public IEnumerable<NilaiModel> Listdata()
        {
            const string sql = @"
                SELECT
                    MahasiswaName, MatakuliahName, aa.NIlai
                 FROM
                    Nilai aa 
                    INNER JOIN Matakuliah bb ON aa.MatakuliahId = bb.MatakuliahId
                    INNER JOIN Mahasiswa cc ON aa.MahasiswaId = cc.MahasiswaId";

            using var conn = new SqlConnection(_consString);
            var ListNilai = conn.Query<NilaiModel>(sql);
            return ListNilai;
        }
    }
}
