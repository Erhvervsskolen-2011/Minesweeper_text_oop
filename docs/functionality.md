
# Virkemåde

Når et felt _ikke_ har en mine, og "trædes" på, bliver det ryddet, og de otte felter der støder op til ryddes efterfølgende. Disse __nabo-felter__'s naboer ryddes også hvis de er uden miner. Hvis et ryddet felt grænser op imod et felt med en mine, hvises et tal i feltet, for hvor mange miner det grænser op til.

## Om at finde nabo-felter

Et felt kan maksimalt grænse op til 8 andre felter. Derfor kan der være fra 0 til 8 miner op til et felt.

||||
|:-:|:-:|:-:|
|↖|↑|↗|
|←|aktivt felt|→|
|↙|↓|↘|

Nabofelterne kan vi give navne ud fra verdenshjørnerne, så nabofeltet til højre er der ligger mod øst, felt ovenfor mod nord, skråt ovenfor til højre er nordøst osv.

||-1|0|+1|
|-:|:-:|:-:|:-:|
|-1|NW|N|NE|
|0|W|aktivt felt|E|
|+1|SW|S|SE|

Hvis vi kigger på koordinater kan man se at alle felterne ovenfor ligger en linjer hvis tal er 1 mindre end det aktuele felt.  
Felterne neden for på en linje der er den aktuelle linje +1.  
Lige sådan er alle nabofelterne til venstre er en mindre end den aktulle kolonne. til højre er den aktuelle kolonne +1

||||
|:-:|:-:|:-:|
|(-1,-1)|(0,-1)|(+1,-1)|
|(-1,0)|aktivt felt|(+1,0)|
|(-1,+1)|(0,+1)|(+1,+1)|

Her er hver parentes et talpar man trækker fra eller lægger til x, y koordinattet, altså linien og kolonnen hvor det aktuelle felt er.

### Alternativ

Som et alternativ til ovenstående kan man benytte en strategi hvor spillepalden udvides eller fores med en ekstra række eller kollene øverst, neders, til venstre og til højre, altså hele vejen rundt.
Det ekstra felter vises ikke, på spillepladen, og kan ikke rydes, men tjener kun til at man kan tælle miner hele vejen rundt, uden undtagelse.

## Afslutning af spillet

Spillet afsluttes, enten 
* fordi spilleren ryder et felt med en mine, eller 
* fordi alle felter, uden miner, enten 
  * er markeret med flag, eller 
  * rydet, eller
* spilleren taster _ESC_.

I det første tilfælde har spilleren tabt, i andet tilfælde har spilleren vundet, tredje er uafgjort.

## Statusinformationer

I bunden af skærmen, eller i hvert fald under spillepladen, skal der udskrives nogle statusinformationer (InfoPanel), så spilleren løbenmde kan følge med i :
* hvor mange miner der er ialt, 
* hvormange miner som er markeret med flag (dog uden at afsløre om flagene er sat korrekt), 
* hvor mange miner der tilbage
* hvor stor en del at spille pladen der rydet i %

### Gameover

Ved afslutningen skal statusinformationerne opdateres, og suppleres med info om:
* forkert placerede flag
* korrekt placerede flag

På spillepladen, skal symbolerne opdateres så man kan se : 
* hvilke flag der markeret korrekt (der er en mine), 
* hvilke flag er placeret forkert (der er _ikke_ mine)
* miner der ikke er markeret

