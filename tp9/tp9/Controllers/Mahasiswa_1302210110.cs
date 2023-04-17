using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tp9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa_1302210110 : ControllerBase
    {
        private string[] Mahasiswa = new[]
        {
            "Reyhan", "ui", "kutur", "luru"
        };

        private int[] nim = new[]
        {
            1302210110, 1302210198, 1302219187, 1302209876
        };
        
        public IEnumerable<string> GetStrings()
        {
            return Mahasiswa;
        }
        public IEnumerable<int> GetInts() { return nim;}

        [HttpGet(Name = "Mahasiswa")]
        public string getmahasiswa(int i, int j) 
        {  
            while (i < Mahasiswa.Length)
            {
                while(j < nim.Length)
                {
                    return Mahasiswa[j];
                }
            }
            return null;
        }
    }
}
