<b>3-4 Laboratorinis darbas</b>
===============================

<b>Release v0.1</b>
-------------------

Kas buvo padaryta:

-   Studento klasės sūkurimas
-   Studento įvėdimo funkcija
-   Studentų atvaizdavimo funkcija (lentelės pavidalu)

<b>Release v0.2</b>
-------------------

Kas buvo padaryta:

-   Sukurta funkcija nuskaityti studentus iš <i>student.txt</i> failo
-   Studentai atvaizduoji pagal jų pavardes \#\# <b>Release v0.3</b>

Kas buvo padaryta:

-   Studento klasė yra pakeičiama į <i>struct</i>
-   Skaitant informaciją iš failų yra pridedama <i>exeption</i>

<b>Release v0.4</b>
-------------------

Kas buvo padaryta:

-   Pridėta funkcija sugeneruoti studentus ir juos įkelti į failą
-   Pridėta funkcija, kuri išskaido studentus į <i>passed</i> ir
    <i>failed</i> kategorijas
-   Pridėta funkcija išsaugoti studentų kategorijas į skirtingus failus
-   Matuojamas funkcijų greitis

<b>Testavimo rezultatai:</b>

students10000 iskaidymas RunTime 00:00:23.3595869 irasymas RunTime
00:00:23.3796274 students100000 iskaidymas RunTime 00:40:10.2571267
irasymas RunTime 00:40:10.3976088

<i>P.S. toliau neišėjo atlikti testavimų, nes kompiuteris nėra pats
galingiausias :) </i>

<b>Release v0.5</b>
-------------------

Kas buvo padaryta:

-   sukurta funkcija, kuri išmatuoja `List`, `LinkedList`, `Queue`
    greičius

<b>Testavimo rezultatai:</b>

List TEST<br/> iskaidymas LIST RunTime 00:00:00.0086783<br/> Linked
TEST<br/> iskaidymas LIST RunTime 00:00:00.0071031<br/> Que TEST<br/>
iskaidymas Que RunTime 00:00:00.0052875<br/>

-   `List` buvo lėčiausias iš visų kolekcijų
-   `LinkedList` buvo antras pagal greitį, tačiau `List` atsiliko tik
    0.001s
-   `Queue` buvo greičiausias tarp kolekcijų

<b>Release v1.0</b>
-------------------

Kas buvo padaryta:

-   sukurta nauja funkcija, kuri išskaido studentus į <i>failed</i>
    kategorija ir iš studento masyvo yra ištrinama <i>failed</i>
    kategorija

<b>Testavimo rezultatai:</b>

List TEST two<br/> iskaidymas LIST RunTime 00:00:00.0048516<br/> Linked
TEST TWO<br/> iskaidymas LIST RunTime 00:00:00.0061429<br/> Que TEST
TWO<br/> iskaidymas Que TWO RunTime 00:00:00.0181249<br/>

-   `List` lyginant su praeitu algoritmų, tai šis pagerino laiką
    dvigubai
-   `LinkedList` lyginant su praeitu algoritmu, tai yra greitesnis,
    tačiau tik labai mažai
-   `Queue` lyginant su praeitu alogoritmu, tai siulyčiau pasilikti su
    pirmu, nes šis alogritmas buvo trigubai lėtesnis

