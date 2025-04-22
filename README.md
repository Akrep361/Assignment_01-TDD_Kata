# Assignment_01-TDD_Kata

## Team  
Currently none – partner has changed degree program.

## Tools & Setup  
- Language: C# (.NET 8)  
- IDE: Visual Studio Code  
- Test framework: xUnit  
- Test runner: `dotnet watch test`  
- Repo: https://github.com/Akrep361/Assignment_01-TDD_Kata

---

## Approach

The project is divided into two parts: logic (`FizzBuzzLib`) and tests (`FizzBuzzTests`).  
Each step was done using the TDD cycle:
- Write a failing test (Red)  
- Write the minimal implementation (Green)  
- Refactor if needed

### Stage 1 – Basic Rules
- `1` → `"1"`  
- `3` → `"Fizz"`  
- `5` → `"Buzz"`  
- `15` → `"FizzBuzz"`  
- Refactoring: replaced nested `if` blocks with string concatenation

### Stage 2 – Contains 3/5
- `53` → `"FizzBuzz"`  
- `35` → `"FizzBuzzBuzz"`  
- Adjusted previous tests:
  - `3` → `"FizzFizz"`  
  - `5` → `"BuzzBuzz"`  
  - `15` → `"FizzBuzzBuzz"`  
- Additional tests:
  - `51` → `"FizzBuzz"`  
  - `33` → `"FizzFizz"`  
  - `7` → `"7"` (control case)  
Used the example numbers from the task as test cases, as they sufficiently cover all rules.

---

## Observations

- TDD provides structure and good error control  
- Refactoring is safe after green tests  
- `Contains('3')` and `Contains('5')` were simple and effective for digit checks  
- Tests clearly reflect the defined requirements  
- Baby Steps were not used, as TDD was new to me (no time constraint applied)