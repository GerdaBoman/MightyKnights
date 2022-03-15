# MightyKnights
Prague Parking 2.0 – OOP-version 

Kundens nya krav på systemet
• Data skall sparas så att det inte försvinner när programmet stängs av.
• Det skall gå att hantera P-platser av olika storlek så att även stora fordon som bussar och små fordon som cyklar.
• En karta över P-huset visas, så att man enkelt kan se beläggningen. 
• Du kan stå en bit från skärmen och får en överskådlig blick över parkeringsgaraget. 
• Det skall finnas en textfil med konfigurationsdata för systemet. Filformatet är fritt, men vi valde att använda oss av JSON.

• I konfigurationsfilen skall man kunna konfigurera
- Antal P-platser i garaget
- Fordonstyper (Bil och MC, men det kan komma fler)
- Antal P-platser i garaget
- Fordonstyper (Bil och MC, men det kan komma fler)
- Antal fordon per P-plats för respektive fordonstyp

•Prisstruktur

• Bil: 20 CZK per påbörjad timme
• MC: 10 CZK per påbörjad timme
• De första tio minuterna är gratis.


• Applikationen är i Winforms.  

Alla fordon skall hanteras som objekt. Det skall finnas minst fem klasser:
1. Fordon
2. Bil, som ärver från Fordon
3. MC, som ärver från Fordon
4. ParkeringsPlats
5. ParkeringsHus

Lösningen på projektet innehåller tre delar. 
Core,DataAccess samt UI.
