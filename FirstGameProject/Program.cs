using System;

namespace FirstGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************HOSGELDİNİZ****************");
            GamerManager gamerManager = new GamerManager();
            GameManager gameManager = new GameManager();
            DiscountManager discountManager = new DiscountManager();
            Gamer gamer = new Gamer();
            Game game = new Game();
            
                Console.WriteLine("Lütfen yapmak istediginiz islemi seciniz : " + "\n1)Oyuncu Kayıt" + "\n2)Oyuncu giris" + "\n3)Cikis icin 0 a basiniz. ");
            string choose = Console.ReadLine();

            
           
                if (choose == "1")
                {
                    Console.WriteLine("Oyuncu Kayit sistemine hosgeldiniz..Lutfen asagidaki bilgileri giriniz..");

                    Console.WriteLine("Kullanici Adi : ");
                    gamer.UserName = Console.ReadLine();
                    Console.WriteLine("Isim : ");
                    gamer.FirstName = Console.ReadLine();
                    Console.WriteLine("Soyadi : ");
                    gamer.LastName = Console.ReadLine();
                    //Console.WriteLine("Dogum Yiliniz : ");
                    //gamer.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Tc Kimlik no : ");
                    gamer.NationalityId = Console.ReadLine();

                    gamerManager.SignUp(gamer);

                Console.WriteLine("Yapmak istediginiz islemi seciniz." + "\n1)Oyun Seçenekleri" + "\n2)Kampanyalar" + "\n3)Cikis icin 0 a basiniz.");
                string choose2 = Console.ReadLine();
                
                
                    if (choose2 == "1")
                    {
                        Console.WriteLine("Islem yapmak istediginiz oyunun ismini yaziniz: ");
                        game.Name = Console.ReadLine();
                        Console.WriteLine("1)Satin al" + "\n2)Guncelle" + "\n3)Sil");
                        string choose3 = Console.ReadLine();
                        if (choose3 == "1")
                        {
                            gameManager.Buy(game);

                        }
                        else if (choose3 == "2")
                        {
                            gameManager.Update(game);

                        }
                        else if (choose3 == "3")
                        {
                            gameManager.Delete(game);

                        }

                    }else if(choose2 == "2")
                    {
                    Console.WriteLine("Islem yapmak istediginiz oyunun ismini yaziniz: ");
                    game.Name = Console.ReadLine();
                    Console.WriteLine("1)Ekle" + "\n2)Guncelle" + "\n3)Sil");
                    string choose4 = Console.ReadLine();
                        if (choose4 == "1")
                        {
                        discountManager.Add(game); 

                        }else if(choose4 == "2")
                        {
                        discountManager.Update(game);

                        }else if(choose4 == "3")
                        {
                        discountManager.Delete(game);
                        }

                    }else if(choose2 == "0")
                    {
                    Console.WriteLine("Cikis yapiliyor.. ");

                    }

              

                }
                else if (choose == "2")
                {
                    Console.WriteLine("Oyuncu Giris sistemine hosgeldiniz..");
                    Console.WriteLine("Kullanici adi : ");
                    gamer.UserName = Console.ReadLine();
                    gamerManager.SignIn(gamer);


                Console.WriteLine("Yapmak istediginiz islemi seciniz." + "\n1)Oyun Seçenekleri" + "\n2)Kampanyalar" + "\n3)Cikis icin 0 a basiniz.");
                string choose2 = Console.ReadLine();


                if (choose2 == "1")
                {
                    Console.WriteLine("Islem yapmak istediginiz oyunun ismini yaziniz: ");
                    game.Name = Console.ReadLine();
                    Console.WriteLine("1)Satin al" + "\n2)Guncelle" + "\n3)Sil");
                    string choose3 = Console.ReadLine();
                    if (choose3 == "1")
                    {
                        gameManager.Buy(game);

                    }
                    else if (choose3 == "2")
                    {
                        gameManager.Update(game);

                    }
                    else if (choose3 == "3")
                    {
                        gameManager.Delete(game);

                    }

                }
                else if (choose2 == "2")
                {
                    Console.WriteLine("Islem yapmak istediginiz oyunun ismini yaziniz: ");
                    game.Name = Console.ReadLine();
                    Console.WriteLine("1)Ekle" + "\n2)Guncelle" + "\n3)Sil");
                    string choose4 = Console.ReadLine();
                    if (choose4 == "1")
                    {
                        discountManager.Add(game);

                    }
                    else if (choose4 == "2")
                    {
                        discountManager.Update(game);

                    }
                    else if (choose4 == "3")
                    {
                        discountManager.Delete(game);
                    }

                }
                else if (choose2 == "0")
                {
                    Console.WriteLine("Cikis yapiliyor.. ");

                }
            }
                else if(choose == "0")
                {
                Console.WriteLine("Cikis yapiliyor...");
                }


            

            
        }
    }
}
