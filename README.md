# Assignment_01-TDD_Kata

## Team  
Momentan keins - Partner hat Studiengang gewechselt.

## Tools & Setup  
- Sprache: C# (.NET 8)  
- IDE: Visual Studio Code  
- Testframework: xUnit  
- Testlauf: `dotnet watch test`  
- Repo: https://github.com/Akrep361/Assignment_01-TDD_Kata

---

## Vorgehen (TDD)

- Projekt in zwei Teile aufgeteilt: Logik (`FizzBuzzLib`) und Tests (`FizzBuzzTests`)  
- Jeder Schritt nach TDD:
  - Test geschrieben (Red)  
  - Minimaler Code (Green)  
  - Refactor wenn nötig

### Stage 1 – klassische Regeln
- `1` → `"1"`  
- `3` → `"Fizz"`  
- `5` → `"Buzz"`  
- `15` → `"FizzBuzz"`  
- Refactor: string-Verkettung statt verschachtelter ifs

### Stage 2 – enthält 3/5
- `53` → `"FizzBuzz"`  
- `35` → `"FizzBuzzBuzz"`  
- Alte Tests angepasst:
  - `3` → `"FizzFizz"`  
  - `5` → `"BuzzBuzz"`  
  - `15` → `"FizzBuzzBuzz"`  
- Weitere Tests:
  - `51` → `"FizzBuzz"`  
  - `33` → `"FizzFizz"`  
  - `7` → `"7"` (Kontrollfall)

---

## Erkenntnisse

- TDD gibt Struktur und gute Fehlerkontrolle  
- Refactor wird durch grüne Tests abgesichert  
- `Contains('3')` und `Contains('5')` als einfache Lösung zur Ziffernerkennung  
- Tests spiegeln Anforderungen direkt wider  
- Baby Steps wurden nicht angewendet