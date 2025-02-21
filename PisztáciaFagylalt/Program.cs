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
        public static double jatekosTamadoEro ;
        public static double jatekosHP = 30;
        public static String jatekosNev;
        public static double hatekonysag;
        static void Main(string[] args)
        {
            double goblinHP = 50; 
            double goblinTamadoEro = 3;
            double minotaurusHP = 50; 
            double minotaurusTamadoEro = 4;
            double banditaHP = 20;
            double banditaTamadoEro = 3;
            double sarkanyHP = 300;
            double sarkanyTamadoEro = 5;
            double budspencerHP = 500;
            double budspencerTamadoEro = 25;
            double jatekosHP = 100;
            
            

            String jatekosNev;
            String[] Inventory = new string[] { "1000 éves kard,Gyémántalma" };

            Random veletlen = new Random();


            
            do
            {
                Console.WriteLine();
                Console.WriteLine("csodalatos pisztacia fagylat kalandja");


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
                Console.Write("Egy elágazáshoz érkezel. Két irányba mehetsz. Bal oldalon van a Sötét erdő, jobb oldalon pedig a Tölgy erdő. Melyik utat választod? | Bal | jobb | : ");
                String valaszElagazas = Console.ReadLine();

                if (valaszElagazas.ToLower() == "bal")
                {
                    Console.WriteLine("Ahogy a sötét erdőben haladsz az ösvényen szembejön veled egy kobold. Megtámad téged és kénytelen vagy felvenni vele a harcot.");

                    if (csata("Goblin", goblinTamadoEro, goblinHP) == true)
                    {
                        Console.WriteLine("Működik és győztél.");
                        goto gombaland;
                    }
                    else
                    {
                        Console.WriteLine("Működik és vesztettél");
                    }

                }
                else if (valaszElagazas.ToLower() == "jobb")
                {
                    Console.WriteLine("jobb");
                    goto tolgyerdo;
                }
                else
                {
                    Console.WriteLine("\nNem megfelelő választ adtál meg!");
                    goto elagazas;
                }
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
                if (csata("Minotaurus", minotaurusTamadoEro, minotaurusHP) == true)
                {
                    Console.WriteLine("Működik és győztél.");
                    goto gombaland;
                }
                
                if (jatekosHP < 30)
                    goto gyemantalma;
                else
                    goto falu;
                tisztas:
                Console.WriteLine("találkozol egy banditával kiakar rabolni harcolsz vele Igen|Nem");
                string dontes4 = Console.ReadLine();
                if (dontes4.ToLower() == "igen")
                {
                    if (csata("Goblin", banditaTamadoEro, banditaHP) == true)
                    {
                        Console.WriteLine("Működik és győztél.");
                        goto gombaland;
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
                    if (csata("Sárkány", sarkanyTamadoEro, sarkanyHP) == true)
                    {
                        Console.WriteLine("Működik és győztél.és megkaptad A Káosz Pengéjét(60%-több sebzés és 15%-al több tűz sebzés");
                        goto gombaland;
                    }
                    else
                    {
                        Console.WriteLine("Működik és vesztettél");
                    }
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
                if (csata("bandita", banditaTamadoEro, banditaHP) == true)
                    {
                      Console.WriteLine("Győztél! megkapdat egy'az elveszet lovag péncélja' neveztű páncélt(25%-al több védekezés)");
                      goto tengerpart;
                    }
                        
                

                

                else if (dontes7.ToLower() == "Nem")
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
                if (dontes8.ToLower() == "Igen")
                {
                    if (csata("Bud Spencer", budspencerTamadoEro, budspencerHP) == true)
                    {
                        Console.WriteLine("Működik és győztél.");
                    }
                    else
                    {
                        Console.WriteLine("Működik és vesztettél");
                    }
                }
                else if (dontes8.ToLower() == "Nem")
                {
                    Console.WriteLine("Bro a végén vagy és te nemet mondasz (Instant Halál) Játkokat kilépéshez nyomd med az (esc) gombot vagy (entert) a újrajátszáshoz");
                }


                if (jatekosHP > 0)
                {
                    Console.WriteLine("Győztél! Vége a Játéknak kilépéshez nyomd meg az (esc) gombot vagy (entert) a újrajátszáshoz");
                }
                else
                {
                    Console.WriteLine("Vesztettél! Vége a Játéknak kilépéshez nyomd meg az (esc) gombot vagy (entert) a újrajátszáshoz");
                }


            }while (true);
        }
        public static Boolean csata(String ellenfelNev, double ellenfelTamadoEro, double ellenfelHP)
        {
            Random veletlen = new Random();
            Boolean gyozelem = false;
            double hatekonysag;
            do
            {
                Console.WriteLine("------------------------------------------------------");
                hatekonysag = veletlen.Next(1, 101);
                Console.WriteLine($"{jatekosNev} támadó hatékonysága: {hatekonysag} %");

                Console.WriteLine($"{jatekosNev} támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");
                ellenfelHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);

                if (ellenfelHP < 0)
                    ellenfelHP = 0;
                Console.WriteLine($"{ellenfelNev} életereje: {ellenfelHP}");
                Console.WriteLine("\n------------------------------------------------------");

                if (ellenfelHP > 0)
                {
                    hatekonysag = veletlen.Next(1, 101);
                    Console.WriteLine($"{ellenfelNev} támadó hatékonysága: {hatekonysag} %");

                    Console.WriteLine($"{ellenfelNev} támad {Math.Round(ellenfelTamadoEro * hatekonysag / 100)} erővel");
                    jatekosHP -= Math.Round(ellenfelTamadoEro * hatekonysag / 100);
                }

                if (jatekosHP < 0)
                    jatekosHP = 0;

                Console.WriteLine($"játékos életereje: {jatekosHP}");
                Console.WriteLine("\nNyomj ENTER-t a folytatáshoz");
                Console.ReadKey();

            } while (jatekosHP != 0 && ellenfelHP != 0);

            if (jatekosHP > 0)
            {
                Console.WriteLine("Győztél!");
                gyozelem = true;
            }
            else
                Console.WriteLine("Vesztettél!");

            return gyozelem;
        }


            

        
    }
}
