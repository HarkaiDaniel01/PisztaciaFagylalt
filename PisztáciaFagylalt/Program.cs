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

            double csontvazTamadoEro = 5;
            double csontvazHP = 20;

            double hatekonysag;
            String jatekosNev;

            Random veletlen = new Random();

            //Fő program:

            Console.WriteLine("A pisztácia fagylalt kaland");
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

            Console.WriteLine($"\nKedves és hősies {jatekosNev}!\nEgy barátod veled szeretne menni erre a kalandra.\nFelajánlotta,hogy ha megvárod őt,akkor el tud téged vinni a tengerpartra a Daróczi mobillal.\n" +
                $"Viszont neked most kell az a fagylalt. Mit választasz? Elindulsz egyedül vagy megvárod? ");
            do
            {
                Console.WriteLine("------------------------------------------------------");
                hatekonysag = veletlen.Next(1, 101);
                Console.WriteLine($"Játékos támadó hatékonysága: {hatekonysag} %");

                Console.WriteLine($"Játékos támad {Math.Round(jatekosTamadoEro * hatekonysag / 100)} erővel");
                csontvazHP -= Math.Round(jatekosTamadoEro * hatekonysag / 100);

                if (csontvazHP < 0) csontvazHP = 0;
                Console.WriteLine($"csontváz életereje: {csontvazHP}");
                Console.WriteLine("\n------------------------------------------------------");

                if (csontvazHP > 0)
                {
                    hatekonysag = veletlen.Next(1, 101);
                    Console.WriteLine($"Csontváz támadó hatékonysága: {hatekonysag} %");


                    Console.WriteLine($"Csontváz támad {Math.Round(csontvazTamadoEro * hatekonysag / 100)} erővel");
                    jatekosHP -= Math.Round(csontvazTamadoEro * hatekonysag / 100);

                }

                if (jatekosHP < 0) jatekosHP = 0;

                Console.WriteLine($"játékos életereje: {jatekosHP}");
                Console.WriteLine("\nNyomj ENTER-t a folytatáshoz");
                Console.ReadKey();

            } while (jatekosHP != 0 && csontvazHP != 0);

            if (jatekosHP > 0) Console.WriteLine("Győztél!");
            else Console.WriteLine("Vesztettél!");

            Console.ReadKey();

        }
    }
}
