using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static double jatekosTamadoEro = 10;
        public static double jatekosHP = 30;
        public static String jatekosNev;
        static void Main(string[] args)
        {
            double goblinTamadoEro = 3;
            double goblinHP = 20;

            ConsoleKey billentyu;
            //Fő program:
            do
            {
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
                        Console.WriteLine("Ahogy a sötét erdőben haladsz az ösvényen szembejön veled egy kobold. Megtámad téged és kénytelen vagy felvenni vele a harcot.");

                        if (csata("Goblin", goblinTamadoEro, goblinHP) == true)
                        {
                            Console.WriteLine("Működik és győztél.");
                        }
                        else
                        {
                            Console.WriteLine("Működik és vesztettél");
                        }

                    }
                    else if (valaszElagazas.ToLower() == "jobb")
                    {
                        Console.WriteLine("jobb");
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
            do
            {
                Console.WriteLine("------------------------------------------------------");
                hatekonysag = veletlen.Next(1, 101);
                Console.WriteLine($"{jatekosNev} támadó hatékonysága: {hatekonysag} %");

                Console.WriteLine($"{jatekosNev} támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");
                ellenfelHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);

                if (ellenfelHP < 0) ellenfelHP = 0;
                Console.WriteLine($"{ellenfelNev} életereje: {ellenfelHP}");
                Console.WriteLine("\n------------------------------------------------------");

                if (ellenfelHP > 0)
                {
                    hatekonysag = veletlen.Next(1, 101);
                    Console.WriteLine($"{ellenfelNev} támadó hatékonysága: {hatekonysag} %");


                    Console.WriteLine($"{ellenfelNev} támad {Math.Round(ellenfelTamadoEro * hatekonysag / 100)} erővel");
                    jatekosHP -= Math.Round(ellenfelTamadoEro * hatekonysag / 100);

                }

                if (jatekosHP < 0) jatekosHP = 0;

                Console.WriteLine($"játékos életereje: {jatekosHP}");
                Console.WriteLine("\nNyomj ENTER-t a folytatáshoz");
                Console.ReadKey();

            } while (jatekosHP != 0 && ellenfelHP != 0);

            if (jatekosHP > 0) {
                Console.WriteLine("Győztél!");
                gyozelem = true;
            }
            else Console.WriteLine("Vesztettél!");

            return gyozelem;
        }
    }
}
