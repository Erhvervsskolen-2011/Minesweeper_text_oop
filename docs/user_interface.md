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
Når rammen er over et felt, som stadig er ukendt, kan spilleren trykke på __enter-tasten__, for at "træde" der, eller markere med __backspace-tasten__ for at markere med flag.

