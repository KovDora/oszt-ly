﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace osztály
{

    class Program
    {
        /*
         * 1;Avon Mór;alfa;4. Kis;német;F;4;1
           2;Bakt Ernő;alfa;4. Kis;spanyol;F;4;1
           3;Bal Margó;alfa;4. Kis;spanyol;L;2;0
           4;Bekre Pál;alfa;4. Kis;spanyol;F;4;1
           5;Citad Ella;beta;1. Sió;spanyol;L;3;0
           6;Daj Kálmán;alfa;2. Bán;német;F;3;0
           7;Dári Dóra;beta;1. Sió;spanyol;L;2;0
           8;Emanci Pál;beta;3. Joó;spanyol;F;5;2
           9;Feles Elek;alfa;2. Bán;német;F;3;0
           10;Git Áron;beta;3. Joó;német;F;5;2
           11;Halo Lajos;alfa;4. Kis;német;F;5;2
           12;Hát Izsák;beta;3. Joó;német;F;4;1
           13;Heu Réka;beta;1. Sió;német;L;3;0
           14;Hot Elek;alfa;4. Kis;spanyol;F;5;2
           15;Illemta Nóra;alfa;4. Kis;spanyol;L;3;0
           16;Ka Pál;alfa;4. Kis;spanyol;F;5;2
           17;Kor Mihály;alfa;2. Bán;spanyol;F;3;0
           18;Lapos Elemér;alfa;4. Kis;spanyol;F;4;1
           19;Major Anna;alfa;4. Kis;német;L;2;0
           20;Malt Ernő;beta;1. Sió;spanyol;F;4;1
           21;Mángor Olga;beta;3. Joó;német;L;4;1
           22;Meg Győző;beta;3. Joó;spanyol;F;5;2
           23;Mérta Nóra;beta;1. Sió;spanyol;L;3;1
           24;Ne Pál;beta;1. Sió;német;F;3;1
           25;Ordy Bálint;alfa;2. Bán;német;F;4;1
           26;Öröm Melitta;beta;3. Joó;német;L;4;1
           27;Parady Csoma;alfa;4. Kis;spanyol;F;4;1
           28;Patkóm Ágnes;alfa;2. Bán;német;L;6;3
           29;Patta Nóra;alfa;4. Kis;spanyol;L;5;1
           30;Rö Vid;beta;1. Sió;német;F;4;1
           31;Szikla Szilárd;alfa;4. Kis;német;F;3;0
           32;Szüre Tibor;beta;3. Joó;német;F;4;1
           33;Teo Dóra;beta;3. Joó;spanyol;L;4;1
           34;Vagd Alma;beta;3. Joó;német;L;4;1
           35;Veg Eta;beta;1. Sió;spanyol;L;3;0
           36;Zúz Mara;beta;3. Joó;német;L;5;2
        */

        class Tanuló
        {
            public string kod;
            public string nev;
            public int matcsop;
            public int angolcsop;
            public bool vantestver;
            public int nem;
            public double tanulmányi_átlag;

        }
        static void Main(string[] args)
        {
            List<Tanuló> tanulók = new List<Tanuló>();
            string[] sorok = File.ReadAllLines("input");
            for (int i = 0; i < sorok.Length; i++)
            {
                string[] sortömb = sorok[i].Split(';');
                Tanuló t = new Tanuló();
                t.kod = sortömb[0];
                //Növelni kell
                //Add hozzá a listához
            }



        }
    }
}
