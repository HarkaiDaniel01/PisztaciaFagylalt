using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PisztáciaFagylalt
{
    class Program
    {
        static void Main(string[] args)
        {
            double jatekosTamadoEro = 10;
            double jatekosHP = 100;

            double goblinTamadoEro = 3;
            double goblinHP = 20;

            double hatekonysag;

            double minotaurusHP = 150;
            double minotaurusTamadoEro = 4;

            double rabloHP = 15;
            double rabloTamadoEro = 2;

            double sarkanyHP = 300;
            double sarkanyTamadoEro = 5;

            double budspencerHP = 500;
            double budspencerTamadoEro = 15;

            String jatekosNev;
            String[] Inventory = new string[] { "1000 éves kard,Gyémántalma" };
            ConsoleKey Billi;
            Random veletlen = new Random();
            do
            {
                Console.WriteLine();
                Console.WriteLine("                                                  __    \r\n(\\,----------------------------------------------'()'--o\r\n (_    _A csodalatos pisztacia fagylat kalandja_    /~\" \r\n  (_)_)                                        (_)_)    ");


                Console.Write("Add meg a neved: ");
     
                jatekosNev = Console.ReadLine();
                /*történet*/
                Console.WriteLine($"Üdvözöllek {jatekosNev}! Nyomj le egy billentyűt,ha készen állsz az izgalmas utazásra!");

                Console.WriteLine($"Daróczia mindig is híres volt különleges világáról.\n" +
                    $"Számtalan csodát élhet át az,ki kvülállóként lép be ebbe a csodálatos országba.\n" +
                    $"Habár Daróczia rengeteg szépséget rejt,sajnos hosszú idők óta a gonoszság árnyékolja be vidékeit.\n" +
                    $"A koboldok és a mohóság uralta rabló emberek rendszeresen megtámadják és kifosztják Daróczia békés lakosait,akik képtelenek megvédeni magukat.\n" +
                    $"Várják,hogy egy nap eljön majd a hős,aki elhozza a békét.\n" +
                    $"Sokan úgy gondolják,hogy ez a hős a Harka erdőben él. Sokan látták már őt.\nEgy vakmerő,magas, izmos testfelépítésű ember,aki talán méltó ahhoz,hogy leszámoljon a sötétség erőivel.\n" +
                    $"Ezt az embert úgy hvták,hogy: {jatekosNev} \n"
                    );

                Console.WriteLine($"A hős {jatekosNev}, mindig is érezte,hogy valami különleges dolog miatt született meg.\nIgazán hős típus volt és mindig mások érdekeit helyezte előtérbe.\n" +
                    $"A következő történet is az ő hősies,önfeláldozó személyiségéről szól.\nŐ mindenki számára példakép lehet.\n");

                Console.WriteLine("Egy nap ez a hős kitűzött magának egy hihetetlenül magas rendű célt.\nTudomására jutott,hogy a Daróczi tengerpartra érkezett egy rémísztő alak egy fagylaltos kocsival.\n" +
                    "Előtört belőle a hős és elhatározta,hogy el fog utazni ehhez az illetőhöz és vesz tőle egy fagylaltot,mert nagyon szereti azt.\nEzzel az elhatározással veszi kezdetét a hősies kaland.\n");

                Console.WriteLine($"\nKedves és hősies {jatekosNev}!\nEgy barátod veled szeretne menni erre a kalandra.\nFelajánlotta,hogy ha megvárod őt,akkor el tud téged vinni a tengerpartra a Daróczi mobillal.\n" +
                    $"Viszont neked most kell az a fagylalt. Mit választasz? Elindulsz egyedül vagy megvárod? ");

            kunyho:
                Console.WriteLine("Mit teszel? ( maradsz | elmész)");
                Console.Write("Játékos: ");
                string dontes1 = Console.ReadLine();
                if (dontes1.ToLower() == "elmész")
                {
                    Console.WriteLine("Sikeresen Elindultál a kalandodra");
                    goto elagazas;
                }
                else if (dontes1.ToLower() == "maradsz")
                {
                    Console.WriteLine("Megvártad a barátodat és elvittéged a daróczi mobilra de semilyen cuccal neki vágni a bossnak egy kicsit meredek (Dark souls ending)");

                }
                else
                {
                    Console.WriteLine("Nincs ilyen lehetőség!");
                    goto kunyho;
                }
            elagazas:
                Console.WriteLine("Elágazáshoz érkezel döntés az hogy jobbra vagy balra ( jobb | bal)");

                string dontes2 = Console.ReadLine();
                if (dontes2.ToLower() == "jobb")
                {
                    Console.WriteLine("Sikeresen Elérkeztél a tölgyerőbe");
                    goto tolgyerdo;
                }
                else if (dontes2.ToLower() == "bal")
                {
                    Console.WriteLine("Sikeresen Elérkeztél a sötét erőbe");
                    goto soteterdo;
                }
                else
                {
                    Console.WriteLine("Nincs ilyen lehetőség!");
                    goto elagazas;
                }
            soteterdo:
                Console.WriteLine("Be érkeztél a sötéterőbe találkozol egy goblinnal de a goblin nem barátságos neked ment");
                do
                {
                    Console.WriteLine("------------------------------------------------------");
                    hatekonysag = veletlen.Next(1, 101);
                    Console.WriteLine($"Játékos támadó hatékonysága: {hatekonysag} %");

                    Console.WriteLine($"Játékos támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");
                    goblinHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);

                    if (goblinHP < 0)
                        goblinHP = 0;
                    Console.WriteLine($"goblin életereje: {goblinHP}");
                    Console.WriteLine("\n------------------------------------------------------");

                    if (goblinHP > 0)
                    {
                        hatekonysag = veletlen.Next(1, 101);
                        Console.WriteLine($"goblin támadó hatékonysága: {hatekonysag} %");


                        Console.WriteLine($"goblin támad {Math.Round(goblinTamadoEro * hatekonysag / 100)} erővel");
                        jatekosHP -= Math.Round(goblinTamadoEro * hatekonysag / 100);

                    }

                    if (jatekosHP < 0)
                        jatekosHP = 0;

                    Console.WriteLine($"játékos életereje: {jatekosHP}");
                    Console.WriteLine("\nNyomj ENTER-t a folytatáshoz");
                    Console.ReadKey();

                } while (jatekosHP != 0 && goblinHP != 0);

                if (jatekosHP > 0)
                {
                    Console.WriteLine("Győztél! és megkaptad Daróczi Gergő gyürűjét (20%-al több sebzés,5%-al több Tűzz eleni védekelzés)");
                    goto gombaland;
                }
                else
                    Console.WriteLine("Vesztettél!");
                tolgyerdo:
                Console.WriteLine("elkérztél a tölgyerdőbe de találtál egy acél kardot felveszed? Igen|Nem");
                string dontes3 = Console.ReadLine();
                if (dontes3.ToLower() == "igen")
                {
                    Console.WriteLine("Sikeresen felvetted az acél kardot");
                    goto tisztas;
                }
                else if (dontes3.ToLower() == "nem")
                {
                    Console.WriteLine("Nem vetted fel és tovább haladtál de ám egy hangot hallotál és visszapillantva elünt a kard");
                    goto tisztas;
                }
                else
                {
                    Console.WriteLine("Bro tanulj meg irni");
                    goto tolgyerdo;
                }
            gombaland:
                Console.WriteLine("Gombaland találkozol egy minotaurusal de ő mérgesen neked megy");
                do
                {
                    Console.WriteLine("------------------------------------------------------");
                    hatekonysag = veletlen.Next(1, 101);
                    Console.WriteLine($"Játékos támadó hatékonysága: {hatekonysag} %");

                    Console.WriteLine($"Játékos támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");
                    minotaurusHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);

                    if (minotaurusHP < 0)
                        minotaurusHP = 0;
                    Console.WriteLine($"minotaurus életereje: {minotaurusHP}");
                    Console.WriteLine("\n------------------------------------------------------");

                    if (minotaurusHP > 0)
                    {
                        hatekonysag = veletlen.Next(1, 101);
                        Console.WriteLine($"minotaurus támadó hatékonysága: {hatekonysag} %");


                        Console.WriteLine($"minotaurus támad {Math.Round(minotaurusTamadoEro * hatekonysag / 100)} erővel");
                        jatekosHP -= Math.Round(minotaurusTamadoEro * hatekonysag / 100);

                    }

                    if (jatekosHP < 0)
                        jatekosHP = 0;

                    Console.WriteLine($"játékos életereje: {jatekosHP}");
                    Console.WriteLine("\nNyomj ENTER-t a folytatáshoz");
                    Console.ReadKey();

                } while (jatekosHP != 0 && minotaurusHP != 0);

                if (jatekosHP > 0)
                {
                    Console.WriteLine("Győztél! és megkaptad A mintotaurus bárdját (25%-al több sebzés)");
                    goto falu;
                }
                else
                    Console.WriteLine("Vesztettél!");
                if (jatekosHP < 30)
                    goto gyemantalma;
                else
                    goto falu;
                tisztas:
                Console.WriteLine("találkozol egy banditával kiakar rabolni harcolsz vele Igen|Nem");
                string dontes4 = Console.ReadLine();
                if (dontes4.ToLower() == "igen")
                {
                    do
                    {
                        Console.WriteLine("------------------------------------------------------");
                        hatekonysag = veletlen.Next(1, 101);
                        Console.WriteLine($"Játékos támadó hatékonysága: {hatekonysag} %");

                        Console.WriteLine($"Játékos támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");
                        rabloHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);

                        if (rabloHP < 0)
                            rabloHP = 0;
                        Console.WriteLine($"rabló életereje: {rabloHP}");
                        Console.WriteLine("\n------------------------------------------------------");

                        if (rabloHP > 0)
                        {
                            hatekonysag = veletlen.Next(1, 101);
                            Console.WriteLine($"rabló támadó hatékonysága: {hatekonysag} %");


                            Console.WriteLine($"rabló támad {Math.Round(rabloTamadoEro * hatekonysag / 100)} erővel");
                            jatekosHP -= Math.Round(rabloTamadoEro * hatekonysag / 100);

                        }

                        if (jatekosHP < 0)
                            jatekosHP = 0;

                        Console.WriteLine($"játékos életereje: {jatekosHP}");
                        Console.WriteLine("\nNyomj ENTER-t a folytatáshoz");
                        Console.ReadKey();

                    } while (jatekosHP != 0 && rabloHP != 0);

                    if (jatekosHP > 0)
                    {
                        Console.WriteLine("Győztél! nem kaptál semmit de nem veszitettél semmit)");
                        goto falu;

                    }
                    else
                        Console.WriteLine("Vesztettél!");
                    if (jatekosHP >= 30)
                    {
                        goto gyemantalma;
                    }
                    else
                    {
                        goto falu;
                    }
                }
                else if (dontes4.ToLower() == "nem")
                {
                    Console.WriteLine("Nem voltál elég gyors és elkapott (elvesztetted az 1000 éves kardot)");
                    goto falu;
                }
                else
                {
                    Console.WriteLine("Bro tanulj meg irni");
                    goto tisztas;
                }
            gyemantalma:
                Console.WriteLine("Megszeretnéd enni a gyémánt almát? Igen|Nem");
                string gyalma = Console.ReadLine();
                if (gyalma.ToLower() == "Igen")
                {
                    Console.WriteLine($"Megetted");
                    jatekosHP += 75;
                    goto falu;
                }
                else if (gyalma.ToLower() == "Nem")
                {
                    Console.WriteLine("Nem etted meg");
                    goto falu;
                }
                else
                {
                    Console.WriteLine("Nincs ilyen lehetőség!");
                    goto gyemantalma;
                }
            falu:
                Console.WriteLine("Felérkeztél egy faluba, és találkozol egy idős nővel. (Add neked egy Thanos kart? Elfogadod? I/N)");
                string dontes5 = Console.ReadLine();

                if (dontes5.ToLower() == "i")
                {
                    Console.WriteLine($"Elfogadtad a kart! (50% több sebzés, 10%-kal több max hp == 110hp, 15%-kal több tűz elleni védekezés)");
                    jatekosHP += 10;
                    goto hegyvidek;
                }
                else if (dontes5.ToLower() == "n")
                {
                    Console.WriteLine($"Megértette, de adott neked egy gyűrűt! (50%-kal több max hp == 150hp)");
                    jatekosHP += 50;
                    goto hegyvidek;
                }
                else
                {
                    Console.WriteLine("Hibás válasz! Kérlek, írj 'Igen' vagy 'Nem'.");
                    goto falu;
                }
            hegyvidek:
                Console.WriteLine("A falut elhagyva egy hegyvidékrészhez érkezve egy sárkány állja el az utad aki éppen alszik elosonsz|megküzdesz vele?");
                string dontes6 = Console.ReadLine();
                if (dontes6.ToLower() == "megküzdesz")
                {
                    Console.WriteLine("A sárkány felébredt és észre vett");
                    do
                    {
                        Console.WriteLine("------------------------------------------------------");
                        hatekonysag = veletlen.Next(1, 101);
                        Console.WriteLine($"Játékos támadó hatékonysága: {hatekonysag} %");

                        Console.WriteLine($"Játékos támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");
                        sarkanyHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);

                        if (sarkanyHP < 0)
                            sarkanyHP = 0;
                        Console.WriteLine($"sárkány életereje: {sarkanyHP}");
                        Console.WriteLine("\n------------------------------------------------------");

                        if (sarkanyHP > 0)
                        {
                            hatekonysag = veletlen.Next(1, 101);
                            Console.WriteLine($"sárkány támadó hatékonysága: {hatekonysag} %");


                            Console.WriteLine($"sárkány támad {Math.Round(sarkanyTamadoEro * hatekonysag / 100)} erővel");
                            jatekosHP -= Math.Round(sarkanyTamadoEro * hatekonysag / 100);

                        }

                        if (jatekosHP < 0)
                            jatekosHP = 0;

                        Console.WriteLine($"játékos életereje: {jatekosHP}");
                        Console.WriteLine("\nNyomj ENTER-t a folytatáshoz");
                        Console.ReadKey();

                    } while (jatekosHP != 0 && sarkanyHP != 0);

                    if (jatekosHP > 0)
                    {
                        Console.WriteLine("Győztél! és megkaptad A Káosz Pengéjét(60%-több sebzés és 15%-al több tűz sebzés)");
                        goto mav;
                    }
                    else
                        Console.WriteLine("Vesztettél!");

                }
                else if (dontes6.ToLower() == "elosonsz")
                {
                    Console.WriteLine($"Gyáva vagy ezért a sárkány észre vett de ép elmenekültél -10hp{jatekosHP - 10}");
                }
                else
                {
                    Console.WriteLine("Nem értem mit akarsz");
                    goto hegyvidek;
                }

            mav:
                Console.WriteLine("Sikeresen kiérve a hegyvidékről megláttod hogy egy misztikusvonat jelenik meg a távolban felszálsz és a fedélzeten egy banditával találkozol megharcolsz vele vagy sem Igen|Nem");
                string dontes7 = Console.ReadLine();
                if (dontes7.ToLower() == "megküzdesz")
                    do
                    {
                        Console.WriteLine("------------------------------------------------------");
                        hatekonysag = veletlen.Next(1, 101);
                        Console.WriteLine($"Játékos támadó hatékonysága: {hatekonysag} %");

                        Console.WriteLine($"Játékos támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");
                        rabloHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);

                        if (rabloHP < 0)
                            rabloHP = 0;
                        Console.WriteLine($"rabló életereje: {rabloHP}");
                        Console.WriteLine("\n------------------------------------------------------");

                        if (rabloHP > 0)
                        {
                            hatekonysag = veletlen.Next(1, 101);
                            Console.WriteLine($"rabló támadó hatékonysága: {hatekonysag} %");


                            Console.WriteLine($"rabló támad {Math.Round(rabloTamadoEro * hatekonysag / 100)} erővel");
                            jatekosHP -= Math.Round(rabloTamadoEro * hatekonysag / 100);

                        }

                        if (jatekosHP < 0)
                            jatekosHP = 0;

                        Console.WriteLine($"játékos életereje: {jatekosHP}");
                        Console.WriteLine("\nNyomj ENTER-t a folytatáshoz");
                        Console.ReadKey();

                    } while (jatekosHP != 0 && rabloHP != 0);

                if (jatekosHP > 0)
                {
                    Console.WriteLine("Győztél! megkapdat egy'az elveszet lovag péncélja' neveztű páncélt(25%-al több védekezés)");
                    goto tengerpart;
                }

                else if (dontes6.ToLower() == "Nem")
                {
                    Console.WriteLine($"A bandita megsebez de életben maradsz -10hp {jatekosHP - 10}");
                    goto tengerpart;
                }
                else
                {
                    Console.WriteLine("Még mindig nem tudom hogy mit irsz");
                    goto mav;
                }
            tengerpart:
                Console.WriteLine("kiérsz  a tengerpartra de meg találod a final boss Bud Spencer Fagylat árust kihiv téged egy harcra Igen|Nem");
                string dontes8 = Console.ReadLine();
                if (dontes6.ToLower() == "megküzdesz")
                {
                    Console.WriteLine("A sárkány felébredt és észre vett");
                    do
                    {
                        Console.WriteLine("------------------------------------------------------");
                        hatekonysag = veletlen.Next(1, 101);
                        Console.WriteLine($"Játékos támadó hatékonysága: {hatekonysag} %");

                        Console.WriteLine($"Játékos támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");
                        budspencerHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);

                        if (budspencerHP < 0)
                            budspencerHP = 0;
                        Console.WriteLine($"Bud Spencer életereje: {budspencerHP}");
                        Console.WriteLine("\n------------------------------------------------------");

                        if (sarkanyHP > 0)
                        {
                            hatekonysag = veletlen.Next(1, 101);
                            Console.WriteLine($"Bud Spencer támadó hatékonysága: {hatekonysag} %");


                            Console.WriteLine($"Bud Spencer támad {Math.Round(budspencerTamadoEro * hatekonysag / 100)} erővel");
                            jatekosHP -= Math.Round(budspencerTamadoEro * hatekonysag / 100);

                        }

                        if (jatekosHP < 0)
                            jatekosHP = 0;

                        Console.WriteLine($"játékos életereje: {jatekosHP}");
                        Console.WriteLine("\nNyomj ENTER-t a folytatáshoz");


                    } while (jatekosHP != 0 && budspencerHP != 0);
                    {


                        if (jatekosHP > 0)
                        {
                            Console.WriteLine("Győztél! Vége a Játéknak kilépéshez nyomd med az (esc) gombot vagy (entert) a újrajátszáshoz");
                        }
                        else
                        {
                            Console.WriteLine("Vesztettél! Vége a ");
                        }
                    }
                }
                else if (dontes8.ToLower() == "Nem")
                {
                    Console.WriteLine("Bro a végén vagy és te nemet mondasz (Instant Halál) Játkokat kilépéshez nyomd med az (esc) gombot vagy (entert) a újrajátszáshoz");
                }
                Billi = Console.ReadKey(true).Key;
            } while (Billi != ConsoleKey.Escape);




            Console.ReadKey();


        }
    }
}
