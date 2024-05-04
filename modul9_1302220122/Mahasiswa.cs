namespace modul9_1302220122
{
    public class Mahasiswa
    {

        public Mahasiswa(string nama, string NIM, int Year)
        {
            this.nama = nama;
            this.NIM = NIM;
            this.Year = Year;
        }

        public String nama { get; set; }

        public string NIM { get; set; }

        public int Year { get; set; }

        public List<string> course { get; set; } = new List<string>();

    public Mahasiswa (string nama, string NIM, List<string> course ,int Year) 
        {
            this.nama = nama;
            this.NIM = NIM;
            this.Year = Year;

        }
    }
}
