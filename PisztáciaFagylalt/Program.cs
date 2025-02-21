using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PisztáciaFagylalt
{
    class Program
    {
        public static double jatekosTamadoEro;
        public static double jatekosHP;
        public static String jatekosNev;
        public static double jatekosTuzVedekezes;
        public static Boolean JatekosEl;

        public static Boolean gyemantAlma;

        static void Main(string[] args)
        {
            double goblinTamadoEro = 5;
            double goblinHP = 30;

            double minotaurusTamadoEro = 4;
            double minotauruszHp = 50;

            double banditaTamadoEro = 3;
            double banditaHP = 20;

            Boolean acelKard;

            ConsoleKey billentyu;
            //Fő program:
            do
            {
                jatekosHP = 100;
                jatekosTamadoEro = 10;
                jatekosTuzVedekezes = 10;
                JatekosEl = true;
                gyemantAlma = true;
                acelKard = false;

                String szoveg = ("A csodálatos pisztácia fagylalt kalandja");

                int konzolSzelesseg = Console.WindowWidth;  // A konzol szélessége
                int szovegHosszusag = szoveg.Length;  // A szöveg hossza
                int hely = (konzolSzelesseg - szovegHosszusag) / 2;  // Kiszámoljuk a szükséges szóközök számát

                // A szöveg kiírása középre
                Console.SetCursorPosition(hely, Console.CursorTop);
                Console.WriteLine(szoveg);

                /*-------------------------------------------------Intro----------------------------------------------------*/

                Console.Write("Add meg a neved: ");
                jatekosNev = Console.ReadLine();
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


                /*------------------------------------------------Játék-------------------------------------------------------*/
                Console.WriteLine($"\n\n\nKedves és hősies {jatekosNev}!\nEgy barátod veled szeretne menni erre a kalandra.\nFelajánlotta,hogy ha megvárod őt,akkor el tud téged vinni a tengerpartra a Daróczi mobillal.\nViszont neked most kell az a fagylalt. Mit választasz?");

            kunyho:
                Console.Write("\nMegvárod vagy elindulsz egyedül? | Maradok | Elindulok | : ");
                String valaszKunyho = Console.ReadLine();

                if (valaszKunyho.ToLower() == "elindulok")
                {
                    Console.WriteLine("\nElindulsz egyedül a kalandos utnak. Magaddal viszed a fegyveredet,az ezer éves kardot és a gyémántalmát,amit ha egyszer felhasználhatsz és akkor +75 életerőt ad.");
                elagazas:
                    Console.Write("Egy elágazáshoz érkezel. Két irányba mehetsz. Bal oldalon van a Sötét erdő, jobb oldalon pedig a Tölgy erdő. Melyik utat választod? | Bal | jobb | : ");
                    String valaszElagazas = Console.ReadLine();

                    if (valaszElagazas.ToLower() == "bal")
                    {
                        Console.WriteLine("Ahogy a sötét erdőben haladsz az ösvényen szembejön veled egy goblin. Megtámad téged és kénytelen vagy felvenni vele a harcot.");

                        if (csata("Goblin", goblinTamadoEro, goblinHP) == true)
                        {
                            Console.WriteLine("\nSikeresen legyőzted a goblint és megszerezted tőle Daróczi Gergő gyűrűjét,melynek segítségével 20%-al több az alap támadóerőd és 5%-al több a tűz elleni védekezésed.");
                            jatekosTamadoEro = Math.Round(jatekosTamadoEro * 1.2);
                            jatekosTuzVedekezes = Math.Round(jatekosTuzVedekezes * 1.05);
                            jatekosAdatKiir();

                            Console.WriteLine("Továbbmész. Megérkezel Gomba Land-be,ahol találkozol a Minótaurusszal,aki dühösen neked megy.");
                            if (csata("Minótaurusz", minotaurusTamadoEro, minotauruszHp))
                            {
                                
                            } 
                        }
                    }
                    else if (valaszElagazas.ToLower() == "jobb")
                    {
                        Console.WriteLine("\nA Tölgyerdőben haladsz tovább az ösvényen és találsz egy acélkardot.");
                    acelkard:
                        Console.WriteLine("Felveszed az acélkardot? | igen | nem | ");
                        String valaszKard = Console.ReadLine();
                        
                        if (valaszKard.ToLower() == "igen")
                        {
                            Console.WriteLine("Sikeresen felvetted az acélkardot,ami a támadóerődet megnöveli + 40%-al");
                            acelKard = true;
                            jatekosTamadoEro = Math.Round(jatekosTamadoEro * 1.4);
                            jatekosAdatKiir();
                        } else if (valaszKard.ToLower() == "nem")
                        {
                            Console.WriteLine("Nem vetted fel az acél kardot és tovább haladtál,azonban egy furcsa hangra lettél figyelmes. Visszapillantva azt vetted észre,hogy az acél kard rejélyes módon eltűnt.");
                        } else
                        {
                            Console.WriteLine("\nNem megfelelő választ adtál meg!");
                            goto acelkard;
                        }

                        Console.WriteLine("Megérkezel egy tisztásra. Találkozol egy banditával,aki ki akar rabolni.");
                    bandita:
                        Console.WriteLine("Harcolsz vagy elmenekülsz? | Harcolok | Elmenekülök |");
                        String valaszBandita = Console.ReadLine();

                        if (valaszBandita.ToLower() == "harcolok")
                        {
                            if (csata("Bandita", banditaTamadoEro, banditaHP))
                            {
                                Console.WriteLine("Siker");
                            }

                        } else if (valaszBandita.ToLower() == "elmenekülök")
                        {
                            Console.WriteLine("Megpróbáltál elmenekülni,de nem voltál elég gyors és a bandita elkapott.");
                            if (acelKard == true)
                            {
                                Console.WriteLine("Elrabolta tőled az acél kardot, így 40%-al csökkent a támadó erőd.");
                                jatekosTamadoEro = Math.Round(jatekosTamadoEro / 1.4);
                                jatekosAdatKiir();
                            } else
                            {
                                Console.WriteLine("Elrabolta tőled az ezer éves kardot, így vesztettél a támadó erődből 1 pontot.");
                                jatekosTamadoEro -= 1;
                                jatekosAdatKiir();
                            }
                            
                        } else
                        {
                            Console.WriteLine("\nNem megfelelő választ adtál meg!");
                            goto bandita;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNem megfelelő választ adtál meg!");
                        goto elagazas;
                    }

                }
                else if (valaszKunyho.ToLower() == "maradok")
                {

                    Console.WriteLine("\nA barátod megérkezik a Daróczi mobillal és elvisz téged a strandra,ahol találkoztok a rejtéjes fagylalt árussal. Megkérdezi,hogy milyen fagylaltot kérsz? Van csokoládé és vanillia. Erre azt feleled,hogy Pisztácia fagylaltot kérsz.Erre a válaszra az illető dühös lesz és azt feleli,hogy a pisztácia fagylalt kifogyott,majd megöl téged.Utólag kiderült,hogy a rejtélyes alak neve: Bud Spencer.");

                }
                else
                {
                    Console.WriteLine("\nNem megfelelő választ adtál meg!");
                    goto kunyho;
                }

                Console.Write("Szeretnél új játékot kezdeni? Nyomj le egy billentyűt | ÚJ JÁTÉK (ENTER) | KILÉPÉS (ESC) |");
                billentyu = Console.ReadKey(true).Key;

            } while (billentyu != ConsoleKey.Escape);
        }

        /*-----------------------------------------------Harc jelenet-------------------------------------------------*/
        public static Boolean csata(String ellenfelNev, double ellenfelTamadoEro, double ellenfelHP)
        {
            Random veletlen = new Random();
            Boolean gyozelem = false;
            double hatekonysag;
            jatekosAdatKiir();

            Console.WriteLine($"{ellenfelNev} adatai: ");
            Console.WriteLine($"támadóerő: {ellenfelTamadoEro}");
            Console.WriteLine($"életerő: {ellenfelHP}");

            Console.WriteLine("Nyomj ENTER billentyűt, ha készen állsz a harcra!");
            Console.ReadKey();
            do
            {
                Console.WriteLine("----------------------------------------------------------");
                hatekonysag = veletlen.Next(1, 101);
                Console.WriteLine($"{jatekosNev} támadó hatékonysága: {hatekonysag} %");

                Console.WriteLine($"{jatekosNev} támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");
                ellenfelHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);

                if (ellenfelHP < 0) ellenfelHP = 0;
                Console.WriteLine($"{ellenfelNev} életereje: {ellenfelHP}");
                Console.WriteLine("\n----------------------------------------------------------");

                if (ellenfelHP > 0)
                {
                    hatekonysag = veletlen.Next(1, 101);
                    Console.WriteLine($"{ellenfelNev} támadó hatékonysága: {hatekonysag} %");


                    Console.WriteLine($"{ellenfelNev} támad {Math.Round(ellenfelTamadoEro * hatekonysag / 100)} erővel");
                    jatekosHP -= Math.Round(ellenfelTamadoEro * hatekonysag / 100);

                }

                if (jatekosHP < 0) jatekosHP = 0;

                Console.WriteLine($"játékos életereje: {jatekosHP}");
                Console.WriteLine("\nNyomj ENTER billentyűt a folytatáshoz\n");
                Console.ReadKey();

                if (gyemantAlma == true && jatekosHP <= 35 && jatekosHP > 0)
                {
                    Console.WriteLine("Az életerőd nagyon alacsony lett. Fel szeretnéd használni a gyémántalmát,hogy kapj +75 Hp-t?");
                alma:
                    Console.Write("Megeszed az almát? | igen | nem | : ");
                    String valaszAlma = Console.ReadLine();

                    if (valaszAlma.ToLower() == "igen")
                    {
                        jatekosHP += 75;
                        gyemantAlma = false;
                        Console.WriteLine($"Az életerőd most már: {jatekosHP}");
                    }
                    else if (valaszAlma.ToLower() == "nem")
                    {
                        Console.WriteLine($"Az életerőd továbbra is: {jatekosHP}");
                    } else
                    {
                        Console.WriteLine("\nNem megfelelő választ adtál meg!");
                        goto alma;
                    }
                }

            } while (jatekosHP != 0 && ellenfelHP != 0);

            if (jatekosHP > 0)
            {
                Console.WriteLine("Győztél!");
                gyozelem = true;
            }
            else
            {
                Console.WriteLine($"A {ellenfelNev} megölt téged, vége a játéknak.");
                JatekosEl = false;
            }

            return gyozelem;
        }

        public static void jatekosAdatKiir()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine($"{jatekosNev} adatai: ");
            Console.WriteLine($"támadóerő: {jatekosTamadoEro}");
            Console.WriteLine($"életerő: {jatekosHP}");
            Console.WriteLine($"tűz elleni védekezés: {jatekosTuzVedekezes}");
            Console.WriteLine("----------------------------------------------------------");
        }

    }
}
