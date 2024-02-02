# Implementation med Klasser

## Klassekandidater

I dette projekt forventer jeg at oprette klasserne `GamePad`, `Minecell` og `InfoPanel`, samt muligvis en `MineSweeperGame`.

### GamePad

Klassen `GamePad`, og den konkrete instans af klassen i et objekt, representerer selve spillepladen med alle cellerne hvor der _kan_ være miner.  
Der er vil normalt være højst en instans af klassen, men jeg tænker ikke bruge tid på at implementere _DesignPattern'et_ singleton.  
`GamePad`'en har ansvar for en to-dimensionel array med celler, som hver er af klassen `Minecell`.

GamePad'en skal kunne vise hele spillepladen på konsolen

#### Gameover 

Når spillet er slut skal spillepladen vises på en måde hvor det afsløres 
* hvor der _eventuelt_ er miner som ikke markeret med flag, 
* flag som markerer en celle _uden_ mine,
* miner der _ikke_ er markeret.

![GamePad](https://www.plantuml.com/plantuml/png/SoWkIImgAStDuU9ApaaiBbPmJynD3KXCKQZcKW22F9_ClDHY1Ik5pBmIY81pVavfBhA8ja9oQavEiO8lK2M85QqJomML09bLa9YY0JC5g4K7rGHDg4hNiiISqiIIL90XnHemqU2C_78K3iZ0_BBK8g0WLoqNbqDgNWhGwG00 "GamePad")

![Minecell_use-cases](https://www.plantuml.com/plantuml/png/ZLD1RiCW4BppYhqbaP937z0gKbMr9_SDs5viQWmLhAFcGSr7yh4kr4P4SQKYXF3ixZ3CucCWwMaQZH065G4vyBhh2LhjiI7jh12lSaGu79vWgwscdH3M4SvfJYqemFkdHqRg3nm8QGyC0GI6li1rS4wVWpGjA6tRIjPkyc4R2tbMrsyFqXY41ddrmDD5FcPAXShTnFS9p8oDconLA7rz7hN58D2s46MMwbcAChAxlq0EB8BJ6JP0E8-rCq3Qm4PjLaaRmwVUKyvm97mxwJ0pGYyzH85PVST4xeG-0UbcuQxWuJS0YXTCvHuqsEl5zzYYpLnH-Qpu4MnXnf8GUQKbQVuWUKddv_I-qA670PF_dhDZSvgqpRbnqFMomhnVxz1sTrERsslvNSnsb2DfYR53AMYnSpReFoANaHfKCAucHKTrU4uix2dv2Oj7SEGj_pa_ "Minecell_use-cases")


### Minecell

![Minecell](https://www.plantuml.com/plantuml/png/RP112i8m44NtFSNiMca5rmL14DpP2uYBQH9j84saauf5F8NW0Js9OvjQ4Ri9yt_V_vEio6FZszf4mY0HRBLLGXa3rmZuIw52UckGG-cSWIKSq93gpJbSMDRMXwdxcbAWhYuPo45Ks30NFn_tE7XMOLDsDUVImB2_22cQrePj9VzN7hIL1PQkRIWveSp7XNVPViR4Pzo7_uLhhI-cliGEy0JstBItUBSdiz0-NaRvZS5ZBv-Tba4UCv9BpW4PTCFnkrTqYrRAIdxb5m00 "Minecell")

#### Minecell use-cases
På klassen Minecell er der 3 use-cases:
* init, klassens contructor
* setflag, som udføres når brugeren taster `backspace`, for at markere en celle som en mine, uden at cleare den. For hvis der ern en mine, og hun clearer, så er hun `gameover`.
* clear, når brugeren taster `enter`, for hun mener der _ikke_ er en mine i celln.

Herunder ses use-casene, men pseudo-kode.

![Minecell_use-cases](https://www.plantuml.com/plantuml/png/ZLD1RiCW4BppYhqbaP937z0gKbMr9_SDs5viQWmLhAFcGSr7yh4kr4P4SQKYXF3ixZ3CucCWwMaQZH065G4vyBhh2LhjiI7jh12lSaGu79vWgwscdH3M4SvfJYqemFkdHqRg3nm8QGyC0GI6li1rS4wVWpGjA6tRIjPkyc4R2tbMrsyFqXY41ddrmDD5FcPAXShTnFS9p8oDconLA7rz7hN58D2s46MMwbcAChAxlq0EB8BJ6JP0E8-rCq3Qm4PjLaaRmwVUKyvm97mxwJ0pGYyzH85PVST4xeG-0UbcuQxWuJS0YXTCvHuqsEl5zzYYpLnH-Qpu4MnXnf8GUQKbQVuWUKddv_I-qA670PF_dhDZSvgqpRbnqFMomhnVxz1sTrERsslvNSnsb2DfYR53AMYnSpReFoANaHfKCAucHKTrU4uix2dv2Oj7SEGj_pa_ "Minecell_use-cases")

### InfoPanel

![InfoPanel](https://www.plantuml.com/plantuml/png/VP11gW8n38RtFKMMYdY10S6bBXwuSIrncjPY9fMcu-RnZkD9l9YTZkAWyB8epLV-_FcxremfznqRqpAg0cp5nHqAyQ-1KbqGKcWWIAvzeWw31F4_7m-EqK_x9JXafSCtpwd_nYqJ9hA5sDWVcQ3IUYpUEytcJxA_MCmqSq6GY-OO8y_Ddp4ICq4A_fGXkhUkQLxp1_s5Kal5byJ28FX7DlfKqyqrA8o6grKDCQutb9uBdUQDVXepUhtVeBTwJk5AEZ4swt8lt_y0 "InfoPanel")

InfoPanelet viser status oplysninger, fra opstart og opdateres hver gang spillren sætter flag, eller clearer. Endelig opdateres InfoPanelet, når spillet afsluttes, uanset om spilleren aktiverer en mine, eller har ryddet alle celler uden minder, vinder.

Her er to usecases relavente:
* init, contructor
* Uodate, hver gang spillren sætter flag, eller clearer, eller spillet afsluttes.

![InfoPanel_use-cases](https://www.plantuml.com/plantuml/png/PP9DQiGm38NtFeKOA6HASuKokz9LPzDrHutbr4IMWorJUliwFwMUcIoCUNgIdpvooef9Is1Zc9o2HaX-_5AmFj6WFeenBnW8UXk_fN-6pelNep4IbNPhTB281ket8LiOecHDPT2OuF8gBiuenDrOvvpH7Y-hqtcnmBMHf8H02OhOUkRPCzFCQAa-JTMpl7GRudssg7GNOvFNyM_hDIqJ5RNaEFDF5YyZ9I7miCGwBx5e2_u8A8eCmKljySZNicCSTs5pgETF70cwjgrltCVT_W3ehhQ2WGaJsNQxacd0J73ODbZW81y0CvHL-5W5W1iCRV4EHbjiaLm3gJoWop5K93lK9yWO_hQVOaeqATJeGwLfgINXOfeetHN_rphLQ_stVW40 "InfoPanel_use-cases")


