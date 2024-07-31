using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Latih12_MdiForm
{
    public class DbDal
    {
        private const string _connstring = "Data Source=DESKTOP-B10RQSP;Initial Catalog=LatihanDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public (IEnumerable<MahasiswaModel> MahasiswaList, IEnumerable<matakuliahModel> MatakuliahList) GetData()
        {
            const string sql = @"
                SELECT * FROM Mahasiswa;
                SELECT * FROM Matakuliah;
            ";

            using var conn = new SqlConnection(_connstring);
            try
            {
                conn.Open();
                using var multi = conn.QueryMultiple(sql);
                var mahasiswaList = multi.Read<MahasiswaModel>().ToList();
                var matakuliahList = multi.Read<matakuliahModel>().ToList();

                return (mahasiswaList, matakuliahList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching data: {ex.Message}");
                return (Enumerable.Empty<MahasiswaModel>(), Enumerable.Empty<matakuliahModel>());
            }
        }
    }
}

