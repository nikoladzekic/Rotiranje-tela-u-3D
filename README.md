////////////////////
3D ROTACIJA TELA
////////////////////
Nikola Džekić
////////////////////
C# Console App
///////////////////

/////////NAPOMENA///////

Rotacija se vrti u smeru suprotnom od smera kazaljke na satu

////////////////////////

-Prvo uneti veličinu matrice, odnosno broj vrsta, jer je broj kolona uvek fiksan, odnosno 3.
-Zatim uneti ugao rotacije u stepenima.
-Zatim uneti koordinatu svake tačke, potrebno je prethodno nacrtati na papiru
 kako bi telo izgledalo radi lakšeg unosa koordinata.
-Nakon unosa zadnje koordinate program će ispisati koja je matrica rotacija koriscena,
u ovom slučaju uneo sam samo matricu Rx, odnosno matricu koja rotira po x osi. 
- Ispod matrice Rx ispisaće novodobijenu matricu B, koja predstavlja koordinate tela
 rotiranog za proizvoljno unesen ugao od strane korisnika.
-Provera se može izvršiti ponovnim ispisivanjem koordinata na papiru, i spajanjem 
koordinata dobija se novodobijeno telo rotirano za proizvoljan ugao.

//////////////////////
Mana ispisa na ovaj način je što program ne može da ispiše iznos pri korišćenju metode
Cos(),ukoliko je iznos 0, pa će ispisati približnu vrednost odnosno 0.0003(naprimer).
///////////////////