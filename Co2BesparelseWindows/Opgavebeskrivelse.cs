using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co2BesparelseWindows
{
    internal class Opgavebeskrivelse
    {
    }
}
/*
 Hvor meget CO2 kan du spare?

I denne opgave skal du beregne din potentielle CO2-besparelse ved at arbejde hjemmefra (eller måske ved at tage et online-studie i stedet for et studie, der kræver fremmøde et sted).

Hvad skal programmet kunne?
Du skal lave et program, hvor brugeren kan indtaste to adresser og få vist, hvor meget CO2 der er at spare ved ikke at køre den tur.

Hvad skal du lave?
Jeg har lavet koden til selve beregningen af afstanden mellem to adresser.

Til gengæld skal du finde ud af at få kaldt min kode på den rigtige måde.

Hvad er formålet med opgaven?
Som programmør kommer man ofte ud for, at man skal bruge eller bygge videre på noget, som en anden har udviklet. 

Derfor er en del af opgaven, at du skal læse og forstå, hvordan min kode er opbygget. 

Du behøver ikke rette i min kode, og du skal kun bruge disse klasser

Afstandsberegner
Koordinatberegner
Koordinatset
Du er velkommen til at kigge på koden i AfstandService (som kalder den webservice, som rent faktisk beregner afstanden mellem adresserne), men det er et stykke uden for pensum på faget her.

Et par tips til at komme i gang
Hver af de to beregnere skal bruge en nøgle, som giver adgang til den bagvedliggende service. 

Det er disse to:

var koordinatNogle = "fMp5hPFGhG3uCJadnXblIqkE51gi4pildnQ/HYniTwjpssyVbOw0MA==";
var afstandNogle = "bEP239aWrJmPPUsOWnOgv567LCC4tXEi4LtXgj3nEfgmFpKPj/uTMw==";
Når du kalder metoder i de to beregnerklasser skal du skrive await foran. Det skyldes, at metoderne kalder services på nettet, og din kode skal vente på at få svaret tilbage.

Eksempelvis således:

var afstand = await minBeregner.BeregnAfstandIMeter(...)
Forskellige transportformers udledning
For at kunne beregne, hvor meget CO2 man kan spare, skal du naturligvis vide, hvor meget de forskellige transportformer udleder. Det kan du set et overslag over herunder. Du er naturligvis velkommen til at regne på præcis din egen transportform, hvis du har mere præcise tal for den.

Personbil (benzin): 174 gram CO2 per km

Personbil (diesel): 168 gram CO2 per km

Tog/bus: 36 gram CO2 per km

Kilde: https://www.statista.com/topics/6270/transport-emissions-in-the-uk/#dossierKeyfigures

Hvor finder du min kode?
Du kan finde min kode med en grafisk brugergrænseflade her https://github.com/SmartLearning-Org/Co2BesparelseWindowsProgrammering

Her skal du rette i filen MainWindow.xaml.cs. 

Variablerne benzinBil, dieselBil og Tog fortælle dig, hvilken transportform, brugeren har valgt.

Du kan også vælge en tekstbaseret udgave af min kode. Den kan du hente her: https://github.com/SmartLearning-Org/Co2BesparelseProgrammering/tree/Console

Så skal du rette i filen Program.cs og udskrive CO2 -besparelsen for hver af de tre transportformer.

Skal du aflevere opgaven?
Du skal ikke aflevere opgaven, men når du har lavet den, så prøv at taste dine egne oplysninger ind, og lad dit resultat indgå i vores samlede statistik ved at skrive det ind på siden Hvor meget CO2 sparede du?

Det kan også være, at du har lyst til at lade kolleger prøve programmet og se, hvor meget CO2  deres hjemmearbejdsdage sparer klimaet for.

Hvordan kommer du i gang?
Start med at hente min kode (du kan se, hvordan du gør det, på siden Sådan henter du min kode)

Lav så øvelsen På opdagelse i koden, hvor du kommer lidt rundt og ser forskellige dele af min kode.

God fornøjelse.



 */
