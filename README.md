1. Olvassa be a kep.txt állomány tartalmát, és tárolja el a 640×360 képpont színét!
2. Kérje be a felhasználótól a kép egy pontjának sor- és oszlopszámát (a számozás mindkét
esetben 1-től indul), és írja a képernyőre az adott képpont RGB színösszetevőit a minta
szerint!
3. Világosnak tekintjük az olyan képpontot, amely RGB-értékeinek összege 600-nál nagyobb.
Számolja meg és írja ki, hogy a teljes képen hány világos képpont van!
4. A kép legsötétebb pontjainak azokat a pontokat tekintjük, amelyek RGB-értékeinek összege
a legkisebb. Adja meg, hogy mennyi a legkisebb összeg, illetve keresse meg az ilyen RGB
összegű pixeleket, és írja ki mindegyik színét RGB(r,g,b) formában a mintának
megfelelően!
5. A képen a kék ég látható közepén egy felhővel. Az ég és a felhő színe között jelentős
különbség van, így az ég-felhő határvonal programmal is felismerhető. Ennek
megtalálásához készítsen függvényt hatar néven, amely megadja, hogy egy adott sorban
van-e olyan hely a képen, ahol az egymás melletti képpontok kék színösszetevőinek eltérése
meghalad egy adott értéket! A függvény kapja meg paraméterként a sor számát, illetve
az eltérés értékét, melyek egészek! A függvény visszatérési értéke egy logikai érték legyen,
amely megadja, hogy az adott sorban volt-e az eltérést meghaladó különbség az egymás
melletti képpontok kék színében!
6. Keresse meg a képen a felhő első és utolsó sorát az előzőleg elkészített függvény
segítségével úgy, hogy eltérésként 10-et ad meg a függvénynek bemenetként! Adja meg
az első és az 
