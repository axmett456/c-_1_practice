# Week 4 – Chapter 4: Loops, Files, and Random Numbers

Loops let a program repeat work, files let it keep data after it closes, and the
`Random` class lets it produce unpredictable values. This chapter covers all three.

## What this chapter covers

| Topic | Key idea |
|-------|----------|
| `while` loop | **Pretest** loop – checks the condition *before* each iteration; may run 0 times |
| Counter variables | Track how many times a loop has run; must be updated or the loop never ends |
| Infinite loops | Happen when nothing ever makes the condition `false` |
| `++` and `--` | Increment / decrement by 1; **postfix** (`x = count++`) uses the old value, **prefix** (`x = ++count`) changes first |
| `for` loop | Initialization; test; update – ideal when you know the count |
| `do-while` loop | **Posttest** loop – always runs at least once |
| Files | Always: **open → process (read/write) → close** |
| `StreamWriter` | Writes text files: `File.CreateText` (erases) / `File.AppendText` (keeps) with `Write` / `WriteLine` |
| `StreamReader` | Reads text files: `File.OpenText` with `ReadLine`, `Read`, `ReadToEnd`; loop with `EndOfStream` |
| OpenFileDialog / SaveFileDialog | Standard Windows dialogs; `ShowDialog()` returns a `DialogResult`; chosen path is in `FileName` |
| `Random` class | `Next()`, `Next(max)`, `NextDouble()` |
| Load event | Code that runs automatically when the form opens |

## Demos

Each demo is a Windows Forms application. Code is in the [`code`](code) folder.

### 1. Ending Balance – `while` loop
Calculates the balance of an account that earns 0.5% interest per month, listing every month.
Example: starting balance 1000 for 8 months → **$1,040.71**.

| Control | Name |
|---------|------|
| TextBox | `startingBalTextBox`, `monthsTextBox` |
| ListBox | `detailListBox` |
| Label | `endingBalanceLabel` |
| Button | `calculateButton`, `clearButton`, `exitButton` |

Code: [`01_EndingBalance.cs`](code/01_EndingBalance.cs)

| Before | After clicking Calculate |
|--------|--------------------------|
| ![Before](screenshots/01-balance-empty.png) | ![After](screenshots/01-balance-result.png) |

### 2. Squares – `for` loop
Lists the squares of 1–10, then counts by 10, then counts backward from 10 to 0.

| Control | Name |
|---------|------|
| Button | `goButton` |
| ListBox | `outputListBox` |

Code: [`02_Squares.cs`](code/02_Squares.cs)

![Squares](screenshots/02-squares.png)

### 3. Increment/Decrement and `do-while`
Shows the difference between postfix and prefix, and proves that `do-while` runs once
while a `while` with the same false condition runs zero times.

| Control | Name |
|---------|------|
| Button | `runButton` |
| ListBox | `outputListBox` |

Code: [`03_IncrementAndDoWhile.cs`](code/03_IncrementAndDoWhile.cs)

![Increment and do-while](screenshots/03-increment-dowhile.png)

### 4. Names File – `StreamWriter`, `StreamReader`, file dialogs
Add names to a list, **save** them to a text file (SaveFileDialog + `File.CreateText`),
**append** to an existing file (`File.AppendText`), and **open** a file back into the
list (OpenFileDialog + `File.OpenText` + `EndOfStream` loop). Errors are handled with `try/catch`.

| Control | Name |
|---------|------|
| TextBox | `nameTextBox` |
| ListBox | `namesListBox` |
| Button | `addButton`, `saveButton`, `appendButton`, `openButton` |
| Dialogs | `openFileDialog1`, `saveFileDialog1` (Filter: `Text files (*.txt)\|*.txt`) |

Code: [`04_FileNotepad.cs`](code/04_FileNotepad.cs)

| Save As dialog | Saved file in Notepad | Names loaded back |
|----------------|-----------------------|-------------------|
| ![Save dialog](screenshots/04-save-dialog.png) | ![Notepad](screenshots/04-notepad-file.png) | ![Loaded](screenshots/04-open-loaded.png) |

### 5. Dice Roller – `Random` and the Load event
Rolls two dice (`rand.Next(6) + 1` gives 1–6). The Load event sets up the form as soon as it opens.

| Control | Name |
|---------|------|
| Button | `rollButton` |
| Label | `resultLabel` |
| ListBox | `historyListBox` |

Code: [`05_DiceAndLoadEvent.cs`](code/05_DiceAndLoadEvent.cs)

![Dice roller](screenshots/05-dice-roller.png)

## Check your understanding (from the slides)

| Question | Answer |
|----------|--------|
| What messages does `number = 5; number++; show; number--; show;` display? | `6`, then `5` |
| How many times does `count = 0; while (count < 4) { ...; count++; }` iterate? | 4 times (displays 0, 1, 2, 3) |
| What is a posttest loop? | A loop that runs its body **before** testing the condition (`do-while`) |
| `while` vs `do-while`? | `while` tests first (may run 0 times); `do-while` tests last (runs at least once) |
| How many times does the `do-while` with `count < 0` iterate? | Once (displays 0, then `count` becomes 1 and the test fails) |

## Key takeaways

- Choose the loop by need: **`for`** when the count is known, **`while`** when it depends on a condition, **`do-while`** when the body must run at least once.
- Every loop needs something that eventually makes its condition `false`.
- Always **close** files; and wrap file code in `try/catch` because files and paths can fail.
- `CreateText` **erases** an existing file; use `AppendText` to keep the old content.
- `Random.Next(n)` returns `0` to `n-1`; create one `Random` object and reuse it.