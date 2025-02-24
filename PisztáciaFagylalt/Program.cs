using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PisztáciaFagylalt
{
    class Program
    {
        public static double jatekosTamadoEro;
        public static double jatekosVedekezes;
        public static double jatekosHP;
        public static String jatekosNev;
        public static double jatekosTuzVedekezes;
        public static double jatekosTuzTamadas;
        public static Boolean jatekosEl;

        public static Boolean gyemantAlma;

        static void Main(string[] args)
        {
            double goblinTamadoEro = 5;
            double goblinHP = 30;

            double minotaurusTamadoEro = 4;
            double minotauruszHp = 50;

            double banditaTamadoEro = 3;
            double banditaHP = 20;

            double sarkanyTamadoEro = 25;
            double sarkanyHP = 300;

            double budSpencerTamadoEro = 25;
            double budSpencerHP = 500;

            Boolean acelKard;

            ConsoleKey billentyu;
            //Fő program:
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                jatekosHP = 100;
                jatekosTamadoEro = 10;
                jatekosVedekezes = 0;
                jatekosTuzVedekezes = 10;
                jatekosTuzTamadas = 0;
                jatekosEl = true;
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

                Console.Write("\nAdd meg a neved: ");
                jatekosNev = Console.ReadLine();
                Console.WriteLine($"Üdvözöllek {jatekosNev}! Nyomj le egy billentyűt,ha készen állsz az izgalmas utazásra!");
                Console.ReadKey();

            intro:
                Console.Write("Át szeretnéd ugrani az introt? | Igen | Nem | : ");
                String valaszIntro = Console.ReadLine();

                if (valaszIntro.ToLower() == "nem")
                {
                    szovegKiir($"\nDaróczia mindig is híres volt különleges világáról.\n" +
                    $"Számtalan csodát élhet át az, aki kívülállóként lép be ebbe a csodálatos országba.\n" +
                    $"Habár Daróczia rengeteg szépséget rejt,sajnos hosszú ideje a gonoszság árnyékolja be vidékeit.\n" +
                    $"A koboldok és a mohóság uralta rabló emberek rendszeresen megtámadják és kifosztják Daróczia békés lakosait, akik képtelenek megvédeni magukat.\n" +
                    $"Várják, hogy egy nap eljön majd a hős,aki elhozza a békét.\n" +
                    $"Sokan úgy gondolják,hogy ez a hős a Harka erdőben él. Sokan látták már őt.\nEgy vakmerő,magas, izmos testfelépítésű ember,aki talán méltó ahhoz, hogy leszámoljon a sötétség erőivel.\n" +
                    $"Ezt az embert úgy hívták,hogy: {jatekosNev} \n"
                     );

                    Console.Write("\nNyomj ENTER billentyűt a folytatáshoz!");
                    Console.ReadKey();

                    szovegKiir($"\n\nA hős {jatekosNev}, mindig is érezte,hogy valami különleges dologért született.\nIgazán hőstípus volt és mindig mások érdekeit helyezte előtérbe.\n" +
                        $"A következő történet is az ő hősies, önfeláldozó személyiségéről szól.\nŐ mindenki számára példakép lehet.\n");

                    Console.Write("\nNyomj ENTER billentyűt a folytatáshoz!");
                    Console.ReadKey();

                    szovegKiir("\n\nEgy nap ez a hős kitűzött magának egy hihetetlenül magas rendű célt.\nTudomására jutott, hogy a Daróczi tengerpartra érkezett egy rémísztő alak egy fagylaltos kocsival.\n" +
                        "Előtört belőle a hősiesség és elhatározta, hogy el fog utazni ehhez az illetőhöz és vesz tőle egy fagylaltot, mert nagyon szereti azt.\nEzzel az elhatározással veszi kezdetét a hősies kaland.\n");

                    Console.Write("\nNyomj ENTER billentyűt a folytatáshoz!");
                    Console.ReadKey();
                } else if (valaszIntro.ToLower() == "igen")
                {
                    
                } else
                {
                    Console.WriteLine("\nNem megfelelő választ adtál meg!");
                    goto intro;
                }
                /*------------------------------------------------Játék-------------------------------------------------------*/

                Console.WriteLine($"\n\nKedves és hősies {jatekosNev}!\nEgy barátod veled szeretne menni erre a kalandra.\nFelajánlotta, hogy ha megvárod őt, akkor el tud téged vinni a tengerpartra a Daróczi mobillal.\nViszont neked most kell az a fagylalt. Mit választasz?");

            kunyho:
                Console.Write("\nMegvárod vagy elindulsz egyedül? | Maradok | Elindulok | : ");
                String valaszKunyho = Console.ReadLine();

                if (valaszKunyho.ToLower() == "elindulok")
                {
                    Console.WriteLine("\nElindulsz egyedül a kalandos útnak. Magaddal viszed a fegyveredet,az ezer éves kardot és a gyémántalmát,amit egyszer felhasználhatsz és akkor +75 életerőt kapsz.");
                    jatekosAdatKiir();
                    Console.WriteLine("Egy elágazáshoz érkezel. Két irányba mehetsz. Bal oldalon van a Sötét erdő, jobb oldalon pedig a Tölgy erdő.");
                elagazas:
                    Console.Write("Melyik utat választod ? | Bal | jobb | : ");
                    String valaszElagazas = Console.ReadLine();

                    if (valaszElagazas.ToLower() == "bal")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();

                        Console.WriteLine("Ahogy a sötét erdőben haladsz az ösvényen szembejön veled egy goblin. Megtámad téged és kénytelen vagy felvenni vele a harcot.");

                        if (csata("Goblin", goblinTamadoEro, goblinHP) == true)
                        {
                            Console.WriteLine("\nSikeresen legyőzted a goblint és megszerezted tőle Daróczi Gergő gyűrűjét,melynek segítségével 20%-al több az alap támadóerőd és 10%-al több a tűz elleni védekezésed.");
                            jatekosTamadoEro = Math.Round(jatekosTamadoEro * 1.2);
                            jatekosTuzVedekezes = Math.Round(jatekosTuzVedekezes * 1.1);
                            jatekosAdatKiir();

                            Console.Write("\nNyomj ENTER billentyűt a folytatáshoz!");
                            Console.ReadKey();

                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();

                            Console.WriteLine("Továbbmész. Megérkezel Gomba Land-be,ahol találkozol a Minótaurusszal,aki dühösen neked megy.");
                            if (csata("Minótaurusz", minotaurusTamadoEro, minotauruszHp))
                            {
                                Console.WriteLine("Sikeresen legyőzted a Minótauruszt!");
                            } 
                        }
                    }
                    else if (valaszElagazas.ToLower() == "jobb")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();

                        Console.WriteLine("\nA Tölgyerdőben haladsz tovább az ösvényen és találsz egy acélkardot.");
                    acelkard:
                        Console.Write("Felveszed az acélkardot? | igen | nem | : ");
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
                        Console.Write("Harcolsz vagy elmenekülsz? | Harcolok | Elmenekülök | : ");
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

                    if (jatekosEl)
                    {
                        Console.Write("\nNyomj ENTER billentyűt a folytatáshoz!");
                        Console.ReadKey();

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();

                        Console.WriteLine("Megérkezel egy faluba,ahol találkozol egy idős nővel. Felajánlja,hogy ad neked fegyvert,de csak az egyiket választhatod.");
                    falu:
                        Console.WriteLine("\nThanos kar:\n\t+50% támadóerő\n\t+10 HP\n\t+15% Tűz elleni védekezés\n ");
                        Console.WriteLine("Harka gyűrű:\n\t +50 HP\n");
                        Console.Write("Melyiket választod? | kar | gyűrű | : ");
                        String valaszFegyver = Console.ReadLine();

                        if (valaszFegyver.ToLower() == "kar")
                        {
                            Console.WriteLine("Elfogadtad a kart! (+50% támadóerő, +10 HP, +15% tűz elleni védekezés).");
                            jatekosTamadoEro = Math.Round(jatekosTamadoEro * 1.5);
                            jatekosHP += 10;
                            jatekosTuzVedekezes = Math.Round(jatekosTuzVedekezes * 1.15);
                            jatekosAdatKiir();
                        } else if (valaszFegyver.ToLower() == "gyűrű")
                        {
                            Console.WriteLine("Elfogadtad a gyűrűt! (+50 HP)");
                            jatekosHP += 50;
                            jatekosAdatKiir();
                        } else
                        {
                            Console.WriteLine("\nNem megfelelő választ adtál meg!");
                            goto falu;
                        }

                        Console.Write("\nNyomj ENTER billentyűt a folytatáshoz!");
                        Console.ReadKey();

                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();

                        Console.WriteLine("A falut elhagyva egy hegyvidékhez érkezel,ahol nem tudsz továbbhaladni,mert egy sárkány alszk elötted.");
                    hegyvidek:
                        Console.Write("Megküzdesz a sárkánnyal vagy megpróbálsz elosonni? | Harcolok | Elosonok | : ");
                        String valaszSarkany = Console.ReadLine();

                        if (valaszSarkany.ToLower() == "harcolok")
                        {
                            Console.WriteLine("A sárkány felébredt és észrevett.");
                            if (csata("Sárkány", sarkanyTamadoEro, sarkanyHP))
                            {
                                Console.WriteLine("Legyőzted a sárkányt és megszerezted a Káosz pengéjét (+60% támadóerő, +15p tűz sebzés)!");
                                jatekosTuzTamadas += 15;
                                jatekosTamadoEro = Math.Round(jatekosTamadoEro * 1.6);
                                jatekosAdatKiir();
                            }
                            
                        } else if (valaszSarkany.ToLower() == "elosonok") {
                            Console.WriteLine("Megpróbáltál elosonni,de a sárkány észrevett és megsebzett,de végül elmenekültél. Vesztettél 10 Hp-t.");
                            jatekosHP -= 10;
                            jatekosAdatKiir();

                        } else
                        {
                            Console.WriteLine("\nNem megfelelő választ adtál meg!");
                            goto hegyvidek;
                        }
                    }

                    if (jatekosEl)
                    {
                        Console.Write("\nNyomj ENTER billentyűt a folytatáshoz!");
                        Console.ReadKey();

                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();

                        Console.WriteLine("Sikeresen átjutottál a hegyvidéken. A távolban megpillantasz egy misztikus vonatot. Felszálsz rá. A vonaton találkozol egy banditával.");
                    vonat:
                        Console.Write("Megküzdesz a banditával vagy nem? | Igen | Nem | : ");
                        String valaszBandita = Console.ReadLine();

                        if (valaszBandita.ToLower() == "igen")
                        {
                            if (csata("Bandita", banditaTamadoEro, banditaHP)) {
                                Console.WriteLine("Győztél! Megkaptad az 'Elveszett lovag páncélja' nevezetű páncélt (+15 pont védekezés)!");
                                jatekosVedekezes += 15;
                                jatekosAdatKiir();
                            }

                        }
                        else if (valaszBandita.ToLower() == "nem")
                        {
                            Console.WriteLine("A bandita megsebez,de életben maradsz. (-10 HP)");
                            jatekosHP -= 10;
                            jatekosAdatKiir();
                        }
                        else
                        {
                            Console.WriteLine("\nNem megfelelő választ adtál meg!");
                            goto vonat;
                        }
                    }

                    if (jatekosEl)
                    {
                        Console.Write("\nNyomj ENTER billentyűt a folytatáshoz!");
                        Console.ReadKey();

                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();

                        Console.WriteLine("\nA misztikus vonattal megérkezel a tengerpartra,ahol végre találkozol a rejtélyes fagylaltárussal. Megkérdezi,hogy milyen fagylaltot kérsz? Van tutti frutti, karamell és vanília. Erre azt feleled,hogy pisztácia fagylaltot kérsz. Erre a fagylalt árus dühös lesz és azt feleli: A pisztácia kifogyott,majd megtámad téged és kénytelen vagy vele felvenni a harcot! Kiderül,hogy a rejtélyes fagylalt árus neve: Bud Spencer.");

                        if (csata("Bud Spencer", budSpencerTamadoEro, budSpencerHP))
                        {
                            Console.WriteLine("Sikeresen legyőzted Bud Spencert! Sajnos kiderült,hogy igazat mondott és valóban kifogyott a pisztácia,azonban Daróczia lakosai nagyon hálásak neked. Utazásod során több helyen is megfordultál és hatalmas erőd hírneve elijesztette Daróczia gonosztevőit,így elhoztad a békét és az emberek boldogan élhetnek tovább a varázslatos világban. Hősként ünnepelnek és még pisztácia fagylaltot is kaptál tőlük.Bud Spencer felajánlotta,hogy legyetek társak. Elfogadod és most együtt mentek hajóval megkeresni a titkos kincset.Végül Bud Spencer kinyitott egy konzerv chilis babot.\nVége!");
                        }
                    }

                }
                else if (valaszKunyho.ToLower() == "maradok")
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();

                    Console.WriteLine("\nA barátod megérkezik a Daróczi mobillal és elvisz téged a strandra,ahol találkoztok a rejtélyes fagylalt árussal. Megkérdezi,hogy milyen fagylaltot kérsz? Van tutti frutti, karamell és vanília . Erre azt feleled,hogy Pisztácia fagylaltot kérsz.Erre a válaszra az illető dühös lesz és azt feleli,hogy a pisztácia fagylalt kifogyott,majd lekever neked egyet. Utólag kiderült,hogy a rejtélyes alak neve: Bud Spencer.");

                }
                else
                {
                    Console.WriteLine("\nNem megfelelő választ adtál meg!");
                    goto kunyho;
                }

                Console.Write("\nSzeretnél új játékot kezdeni? Nyomj le egy billentyűt | ÚJ JÁTÉK (ENTER) | KILÉPÉS (ESC) |");
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

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            do
            {
                Console.WriteLine("----------------------------------------------------------");
                hatekonysag = veletlen.Next(1, 101);
                Console.WriteLine($"{jatekosNev} támadó hatékonysága: {hatekonysag} %");
                Console.WriteLine($"{jatekosNev} támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");

                if (jatekosTuzTamadas > 0)
                {
                    Console.WriteLine($"+{jatekosTuzTamadas} tűz sebzés!");
                    ellenfelHP -= Math.Round((jatekosTamadoEro * hatekonysag / 100) + jatekosTuzTamadas);
                }
                else ellenfelHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);


                if (ellenfelHP < 0) ellenfelHP = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{ellenfelNev} életereje: {ellenfelHP}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n----------------------------------------------------------");

                if (ellenfelHP > 0)
                {
                    hatekonysag = veletlen.Next(1, 101);
                    double ellenfelTamadas = Math.Round(ellenfelTamadoEro * hatekonysag / 100);
                    Console.WriteLine($"{ellenfelNev} támadó hatékonysága: {hatekonysag} %");

                    Console.WriteLine($"{ellenfelNev} támad {ellenfelTamadas} erővel");

                    if (ellenfelNev == "Sárkány")
                    {
                        double sarkanyTamadas = Math.Round(ellenfelTamadas - jatekosTuzVedekezes);
                        if (sarkanyTamadas < 0) sarkanyTamadas = 0;
                        Console.WriteLine($"A sárkány tűz erejét hárítod a tűz elleni védekezésed segítségével! A sárkány így csak {sarkanyTamadas} erővel támad.");

                        if (jatekosVedekezes > 0)
                        {
                            sarkanyTamadas -= jatekosVedekezes;
                            if (sarkanyTamadas < 0) sarkanyTamadas = 0;
                            Console.WriteLine($"A védekezésednek köszönhetően hárítod (a) {ellenfelNev} támadását. (A) {ellenfelNev} {sarkanyTamadas} erővel támad");
                        }

                        jatekosHP -= sarkanyTamadas;

                    }
                    else
                    {
                        if (jatekosVedekezes > 0)
                        {
                            ellenfelTamadas -= jatekosVedekezes;
                            if (ellenfelTamadas < 0) ellenfelTamadas = 0;
                            Console.WriteLine($"A védekezésednek köszönhetően hárítod (a) {ellenfelNev} támadását. (A) {ellenfelNev} {ellenfelTamadas} erővel támad");
                        }

                        jatekosHP -= ellenfelTamadas;
                    }

                }

                if (jatekosHP < 0) jatekosHP = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{jatekosNev} életereje: {jatekosHP}");
                Console.ForegroundColor = ConsoleColor.White;
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
                Console.WriteLine($"(A) {ellenfelNev} legyőzött téged, vége a játéknak.");
                jatekosEl = false;
            }

            jatekosAdatKiir();
            return gyozelem;
        }

        public static void jatekosAdatKiir()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine($"{jatekosNev} adatai: ");
            Console.WriteLine($"támadóerő: {jatekosTamadoEro}");
            Console.WriteLine($"védekezés: {jatekosVedekezes}");
            Console.WriteLine($"életerő: {jatekosHP}");
            Console.WriteLine($"tűz elleni védekezés: {jatekosTuzVedekezes}");
            Console.WriteLine($"tűz támadás: {jatekosTuzTamadas}");
            Console.WriteLine("----------------------------------------------------------");
        }

        public static void szovegKiir(String szoveg)
        {
            foreach (char c in szoveg)
            {
                Console.Write(c);
                Thread.Sleep(1);
            }

        }

    }
}
