﻿namespace SesliSessizApp.Services
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

            bool sesliHarfMi;
            if (sesliMi)
            {
                foreach (char kelimeHarf in kelime)
                {
                    foreach (string sesliHarf in _sesliler)
                    {
                        if(kelimeHarf.ToString().ToLower() == sesliHarf)
                        {
                            if (!sonuc.Contains(kelimeHarf.ToString()))
                            sonuc = sonuc + kelimeHarf;
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < kelime.Length; i++)
                {
                    sesliHarfMi = false;
                    for (int j = 0; j < _sesliler.Length; j++)
                    {
                        if (kelime[i].ToString().ToLower() == _sesliler[j])
                        {
                            sesliHarfMi = true;
                            break;
                        }
                    }

                    if (!sesliHarfMi)
                    {
                        if (!sonuc.Contains(kelime[i].ToString())) sonuc += kelime[i];
                    }
                }
            }

            return sonuc;

        }

        public string IlkHarfleriBuyult(string cumle)
        {
            string sonuc = "";

            if (string.IsNullOrWhiteSpace(cumle))
            {
                return "Lütfen minimum bir kelime içeren bir cümle giriniz";
            }
            else
            {
                string[] kelimeler = cumle.Split(' ');

                foreach (string kelime in kelimeler)
                {
                    sonuc += kelime.Substring(0, 1).ToUpper();
                    sonuc += kelime.Substring(1).ToLower();
                    sonuc += " ";
                }

            }

            return sonuc.Trim();
        }
    }
}
