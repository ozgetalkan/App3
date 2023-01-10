namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Yazici> yazicilar = new List<Yazici>();
            yazicilar.Add(new RenkliYazici());
            yazicilar.Add(new SiyahBeyazYazici());
            yazicilar.Add(new RenkliYazici());
            foreach (var y in yazicilar)
            {
                //((RenkliYazici)y).Yaz();
                y.Yaz(5);
            }
            Console.WriteLine(Yazici.YazilanAdet);
            File.WriteAllText("c:\\Data\\dosya.txt", Yazici.YazilanAdet.ToString());
            //İlgili uzantıda Dosya isminde bir txt dosyası oluşturur ve toplam alınan çıktı sayısını bu txt dosyasına yazar.
        }
    }
    class DemirBas
    {

    }
    public abstract class Yazici
    {
        public static int YazilanAdet;
        public abstract void Yaz(int SayfaSayisi);
        public int DolulukOranı { get; set; }
    }
    class RenkliYazici : Yazici
    {
        public override void Yaz(int i)
        {
            YazilanAdet = YazilanAdet + i;
            Console.WriteLine("Renkli Yaz");
        }
    }
    class SiyahBeyazYazici : Yazici
    {
        public override void Yaz(int j)
        {
            YazilanAdet = YazilanAdet + j;
            Console.WriteLine("Yaz");
        }
    }
    public class LimitException : Exception
    {
        public LimitException(string message) : base(message) { }
        public LimitException(string message, Exception inner) : base(message, inner) { }
    }
}