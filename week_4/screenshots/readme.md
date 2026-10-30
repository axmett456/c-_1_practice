 ##  The three screenshots below show the most important ideas from the chapter.

---

## Screenshot 1 – The `while` loop (Ending Balance)

![while loop – Ending Balance](screenshots/01-while-loop-ending-balance.png)

**What the program does**

The user enters a starting balance (1000) and a number of months (8). The program adds monthly
interest and lists the balance for every month in a ListBox. The final balance is **$1,040.71**.

**The key line**

```csharp
balance = balance + (INTEREST_RATE * balance);   // INTEREST_RATE = 0.005m (0.5% per month)
detailListBox.Items.Add("The ending balance for month " + count +
                        " is " + balance.ToString("c"));
```

- A `while` loop repeats these lines **as long as** its condition is `true`.
- A **counter variable** (`count`) tracks the current month. It must start at a value that lets the
  loop run, and it must be increased inside the loop (`count++`), otherwise the loop becomes an
  **infinite loop**.
- Month 1: 1000 × 1.005 = 1005.00; month 2: 1010.03; … month 8: 1040.71.
- `ToString("c")` formats the number as currency.

**Key point:** `while` is a *pretest* loop. The condition is checked **before** each iteration,
so it can run zero times.

---

## Screenshot 2 – Reading a file with a loop

![Reading a file with a loop and try/catch](screenshots/02-read-file-loop-try-catch.png)

**What the code does**

1. `StreamReader reader;` declares the object used to read a text file.
2. `File.OpenText("...path...")` opens the file (step 1: **open**).
3. `while (reader.EndOfStream == false)` repeats until the end of the file is reached.
4. Inside the loop, `reader.ReadLine()` reads one line (step 2: **process**) and
   `listBox1.Items.Add(line)` shows it in the ListBox.
5. `reader.Close()` disconnects the file (step 3: **close**).
6. `try { } catch (Exception ex) { MessageBox.Show(ex.Message); }` handles errors such as a missing
   file or a wrong path, so the program does not crash.

**Key points**

- Every file operation follows three steps: **open → process → close**.
- `EndOfStream` becomes `true` when there is nothing left to read, which makes it ideal for a `while` loop.
- A file path with backslashes needs `\\` in a normal string, or the `@` prefix: `@"C:\Data\Names.txt"`.
- To write instead of read, use `StreamWriter` with `File.CreateText` (erases old content) or `File.AppendText` (keeps it).

---

## Screenshot 3 – Random numbers

![Random.Next syntax](screenshots/03-random-next.png)

**What the code does**

```csharp
Random rand = new Random();      // create a Random object
int number = rand.Next(100);     // random whole number from 0 to 99
```

- `Random.Next()` returns a random whole number from `0` up to the largest `int` value.
- `Random.Next(max + 1)` returns a number from `0` to `max`. To get `0`–`99`, call `rand.Next(100)`.
- `Random.NextDouble()` returns a decimal number from `0.0` up to (but not including) `1.0`.

**Useful tip:** to get a dice roll from 1 to 6, use `rand.Next(6) + 1`. Create the `Random` object **once**
and reuse it instead of creating a new one every time.

---

## Key takeaways

- Use `for` when you know how many times to repeat, `while` when it depends on a condition, and `do-while` when the body must run at least once.
- Every loop needs something that eventually makes its condition `false`.
- Files: **open → process → close**, and wrap file code in `try/catch`.
- `Random.Next(n)` gives `0` to `n-1`.
