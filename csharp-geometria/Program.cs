/*
 * [x] Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.
 *  Aggiungere due metodi: calcolaArea e calcolaPerimetro checalcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
 * 
 * [x] Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console,
 *  i valori di base e di altezza con cui istanziare un nuovoRettangolo. Dopo averlo istanziato,
 *  occupatevi di configurare le sue proprietà di base e altezza (come abbiamo fatto con le nostre auto questa mattina nelprogramma principale)
 *  e stampate a video il perimetro e l’area.
 * 
 * [x] Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi
 *  (baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà adesempio con un metodo
 *  StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:
 *      —— Rettangolo1 ——
 *      base: 20 cm
 *      altezza: 10 cm
 *      Perimetro: 60 cm
 *      Area: 200 cm2
 */

using Utilities;
using csharp_geometria;


int width = Input.InputInteger("Inserisci la base del rettangolo: "),
    height = Input.InputInteger("Inserisci l'altezza del rettangolo: ");

Rectangle rettangolo = new Rectangle(width, height);
Console.WriteLine($"L'area del tuo rettangolo è {rettangolo.Area()}, mentre il perimetro è {rettangolo.Perimeter()}");
rettangolo.PrintRectangle();
