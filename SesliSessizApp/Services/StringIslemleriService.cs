namespace SesliSessizApp.Services
{
    class StringIslemleriService
    {
        string[] _sesliler = new string[8]
        {
            "a","e","ı","i","o","ö","u","ü"
        };

        public string SesliSessizHarfBul(string kelime, bool sesliMi)
        {
            string sonuc = "";

            if (sesliMi)
            {
                foreach (char kelimeHarf in kelime)
                {
                    foreach (string sesliHarf in _sesliler)
                    {
                        if(kelimeHarf.ToString().ToLower() == sesliHarf)
                        {
                            sonuc = sonuc + kelimeHarf;
                            break;
                        }
                    }
                }
            }

            return sonuc;

        }
    }
}
