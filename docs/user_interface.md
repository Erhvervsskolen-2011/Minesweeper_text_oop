# Spildesign

## Spillets formål

Her er et 10*10 eksempel

```text
╔═════════════════════╗
║                     ║
║ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ║
║  ┏━┓                ║
║ ░┃░┃░ ░ ░ ░ ░ ░ ░ ░ ║
║  ┗━┛                ║
║ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ║
║                     ║
║ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ║
║                     ║
║ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ║
║                     ║
║ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ║
║                     ║
║ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ║
║                     ║
║ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ║
║                     ║
║ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ║
║                     ║
║ ░ ░ ░ ░ ░ ░ ░ ░ ░ ░ ║
║                     ║
╚═════════════════════╝

```

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