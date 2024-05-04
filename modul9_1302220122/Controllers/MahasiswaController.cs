using Microsoft.AspNetCore.Mvc;

namespace modul9_1302220122.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMasiswa = new List<Mahasiswa>
        {
           new Mahasiswa("salman", "1302220122",["KPL", "Basdat"], 2024),
           new Mahasiswa("Afzaal", "1302220104",["KPL", "Basdat"], 2024),
           new Mahasiswa("Rizky", "1302220128",["KPL", "Basdat"],2024),
           new Mahasiswa("Ahta", "1302223125",["KPL", "Basdat"],2024)
        };

        [HttpGet]
        
        public IEnumerable<Mahasiswa> Get()
        {
            return listMasiswa;
        }
        [HttpGet("{id}")]

        public Mahasiswa Get(int id) { 
            return listMasiswa [id];
        }
        [HttpPost]

        public void post([FromBody] Mahasiswa mahasiswa)
        {
            listMasiswa.Add (mahasiswa);
        }
        [HttpDelete( "{id]}")]

        public void delete(int id)
        {
            listMasiswa.RemoveAt(id);
        }

        }
    } 
