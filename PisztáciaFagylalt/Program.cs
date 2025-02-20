using System;
using System.Collections.Generic;
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
            double jatekosHP = 30;

            double goblinTamadoEro = 3;
            double goblinHP = 20;
            double hatekonysag;
            double minotaurusHP = 150;
            double minotaurusTamadoEro = 5;
            double rabloHP = 15;
            double rabloTamadoEro = 2;
            String jatekosNev;
            String[] Inventory = new string[] { "1000 éves kard,Gyémántalma"};
            Random veletlen = new Random();

            //Fő program:

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
                        //goto ending; 
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
                                        Console.WriteLine("Győztél! és megkaptad A mintotaurus bárdját (25%-al több sebzés)");
                                        goto falu;
                                    }
                                    else
                                        Console.WriteLine("Vesztettél!");

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
                     falu:
                        Console.WriteLine("faluban találkozol egy idosnovel  (add neked egy thanos kart elfogadod? Igen/Nem)");
                        string dontes5 = Console.ReadLine();
                            if (dontes5.ToLower() == "Igen")
                            {
                                Console.WriteLine("Elfogadtad a kart(50% al több sebzés,10% max hp==110hp,15%-al több tűzz elleni védekezést)");
                                goto hegyvidek;
                            }
                            else if (dontes5.ToLower() == "Nem")
                            {
                                Console.WriteLine("megértette de adot neked egy gyürüt (50% max hp == 150hp)");
                                goto hegyvidek;
                            }
                            else
                            {
                                Console.WriteLine("Bro tanulj meg irni");
                                goto falu;
                            }
                        hegyvidek:
                            //holnap folyt kov
                    Console.ReadKey();

        }
    }
}
