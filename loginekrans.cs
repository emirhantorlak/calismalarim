using System;

namespace loginekran
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hoşgeldiniz Kayıt olmak için 1'i giriş yapmak için 0'ı tuşlayınız.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
            { 
            
                Console.WriteLine("Güvenlik sorusunu cevaplayın.(İlk evcil hayvanınızın adı nedir?)");
                string guvenlik = Console.ReadLine();
                Console.WriteLine("Kullanıcı adınızı girin.");
                string gkadi = Console.ReadLine();
                sifreekran:
                Console.WriteLine("Şifrenizi girin.");
                string gsifre = Console.ReadLine();
                Console.WriteLine("Şifreyi doğrulayın.(2.kez girin)");
                string gsifre2 = Console.ReadLine();
                if (gsifre != gsifre2)
                {
                    Console.WriteLine("Şifreler uyuşmuyor.Lütfen daha dikkatli tuşlama yapınız. Kayıt ekranına yönlendiriliyorsunuz...");
                    goto sifreekran;
                }
                else
                
                {
                    Console.WriteLine("Kayıt başarılı giriş ekranına yönlendiriliyorsunuz...");
                    girisekran:
                
                
                    Console.WriteLine("Kullanıcı adınızı giriniz.");
                    string kadi = Console.ReadLine();
                    if (gkadi == kadi)
                    {
                        Console.WriteLine("Şifrenizi giriniz");
                        string sifre = Console.ReadLine();
                        if (sifre == gsifre)
                        {
                            Console.WriteLine("Giriş Başarılı siteye yönlendiriliyorsunuz.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Hatalı şifre girdiniz.Şifrenizi yenilemek için 1'i tekrar girmek için 0'ı tuşlayın");
                            int y = Convert.ToInt32(Console.ReadLine());
                        sifreyenile:
                            
                            
                            if (y == 1)
                            {
                                Console.WriteLine("Güvenlik sorusunun cevabını girin.(İlk evcil hayvanınızın adı nedir?)");
                                string gguvenlik = Console.ReadLine();
                                if (guvenlik == gguvenlik)
                                {
                                    Console.WriteLine("Yeni şifreyi girin.");
                                    gsifre = Console.ReadLine();
                                    Console.WriteLine("Yeni şifreyi tekrar girin");
                                    gsifre2 = Console.ReadLine();
                                    if (gsifre == gsifre2)
                                    {
                                        Console.WriteLine("Şifre değiştirme başarılı giriş ekranına yönlendiriliyorsunuz...");
                                        goto girisekran;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Şifreler uyuşmuyor.Tekrar deneyin.");
                                        goto sifreyenile;
                                    }

                                }
                                else
                                {
                                    goto girisekran;
                                }
                            }

                            
                            else
                            {
                                goto girisekran;

                            }

                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı bulunamadı.Giriş ekranına yönlendiriliyorsunuz.");
                        goto girisekran;

                    }
                    if (x == 0)
                    {
                        goto girisekran;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen sadece 0'ı veya 1'i tuşlayınız.");
                        Console.ReadKey();
                    }

                }

                
                
                   

                
                
                
                
                {
                    
                }
                
            }
            
                
             
            
                
            
            
        }
    }
}
