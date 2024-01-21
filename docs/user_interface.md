# Spildesign

## Spillets formål


Et eksempel på en 20*10 spilleplade:
```text
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
```
Legend:

| symbol | |
|-:|:-|
| ▓ | Ukendt |
| ░ | Renset |
| 1-8 | antal miner omkring felt |
| ⚑ | Spilleren har markeret med flag fordi hun/han mistænker at der er en mine |
| 💣 | vises først når spillet er slut. |

Kilde til flag: <https://www.compart.com/en/unicode/U+2691>  
(Alternativt kan man brige "det hvide flag" <https://www.compart.com/en/unicode/U+2690>)  
Mine: <https://www.compart.com/en/unicode/U+1F4A3>

ramme tegn:
```text
┏━┓ ╔═╗
┃ ┃ ║ ║
┗━┛ ╚═╝ 
```
kilde: <https://en.wikipedia.org/wiki/Box-drawing_character>

Et felt hvor det ikke vides om der er en mine eller ikke vises med tegnet `░`.
Et tomt felt vises med mellemrum ` `.
Et flag (hvor spilleren "tror" der er en mine) vises med `f`.
En mine med `b`
Hvis man "træder" på en mine vises den med rød baggrund.

## Navigation

Spilleren kan bevæge den tykke ramme rundt på spille pladen med piletasterne. Der skal være check og begrænsinger på, så den ikke kan gå ud over pladens kanter.
Når rammen er over et felt, som stadig er ukendt, kan spilleren trykke på __enter-tasten__, for at "træde" der, eller markere med __mellemrums-tasten__ for at markere med flag.

## Virkemåde

Når et felt _ikke_ har en mine, og "trædes" på, bliver det ryddet, og de fire felter der støder op til ryddes efterfølgende. Disse __nabo-felter__'s naboer ryddes også hvis de er uden miner. Hvis et ryddet felt grænser op imod et felt med en mine, hvises et tal i feltet, for hvor mange miner det grænser op til.

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
