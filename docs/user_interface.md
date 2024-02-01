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
Når rammen er over et felt, som stadig er ukendt, kan spilleren trykke på __enter-tasten__, for at "træde" der, eller markere med __backspace-tasten__ for at markere med flag.

## Virkemåde

Når et felt _ikke_ har en mine, og "trædes" på, bliver det ryddet, og de fire felter der støder op til ryddes efterfølgende. Disse __nabo-felter__'s naboer ryddes også hvis de er uden miner. Hvis et ryddet felt grænser op imod et felt med en mine, hvises et tal i feltet, for hvor mange miner det grænser op til.

Et felt kan maksimalt grænse op til 8 andre felter. Derfor kan der være fra 0 til 8 miner op til et felt.

I bunden af skærmen, eller i hvert fald under spillepladen, skal der udskrives nogle statusinformationer (InfoPanel), så spilleren løbenmde kan følge med i :
* hvor mange miner der er ialt, 
* hvormange miner som er markeret med flag (dog uden at afsløre om flagene er sat korrekt), 
* hvor mange minder der tilbage
* hvor stor en del at spille pladen der rydet i %

### Gameover
Når spillet afsluttes, enten fordi spilleren ryder et felt med en mine, eller fordi alle felter enten er markeret med flag, eller rydet.

Ved afslutningen skal statusinformationerne opdateres, og suppleres med info om:
* forkert placerede flag
* korrekt placerede flag

På spillepladen, skal symbolerne opdateres så man kan se : 
* hvilke flag der markeret korrekt (der er en mine), 
* hvilke flag er placeret forkert (der er _ikke_ mine)
* miner der ikke er markeret

## Implementation med Klasser

I dette projekt forventer jeg at oprette klasserne `GamePad`, `Minecell` og `InfoPanel`.

### GamePad

![GamePad](https://www.plantuml.com/plantuml/png/SoWkIImgAStDuU9ApaaiBbPmJynD3KXCKQZcKW22F9_ClDHY1Ik5pBmIY81pVavfBhA8ja9oQavEiO8lK2M85QqJomML09bLa9YY0JC5g4K7rGHDgChKiiISqiIIL90XnHgQN5orN5mEgNafG8S10000 "GamePad")


### Minecell

![Minecell](https://www.plantuml.com/plantuml/png/RP112i8m44NtFSNiMca5rmL14DpP2uYBQH9j84saauf5F8NW0Js9OvjQ4Ri9yt_V_vEio6FZszf4mY0HRBLLGXa3rmZuIw52UckGG-cSWIKSq93gpJbSMDRMXwdxcbAWhYuPo45Ks30NFn_tE7XMOLDsDUVImB2_22cQrePj9VzN7hIL1PQkRIWveSp7XNVPViR4Pzo7_uLhhI-cliGEy0JstBItUBSdiz0-NaRvZS5ZBv-Tba4UCv9BpW4PTCFnkrTqYrRAIdxb5m00 "Minecell")

## InfoPanel

![InfoPanel](https://www.plantuml.com/plantuml/png/NOwn2iCm44Ft-ueR4_e7dR9sA7Jf1rniEHWkvs0xK-c_zmY5b6hJGqAQMfVQzrM9AAYqndopL1vYq1UnQys6nbVErWzV8OwM-nzEAikl3mgfY4vYsMS5M-dW3JN04qVaSauDuvSyjoWTGyecwjsv51tfxUScMFIR7m00 "InfoPanel")
