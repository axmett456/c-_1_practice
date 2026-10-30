## The three screenshots below show the most important ideas from the chapter.

---

## Screenshot 1 – The `if` statement (Test Score Average)

![if statement – Test Score Average code](screenshots/01-if-statement-test-score-code.png)

**What the code does**

1. `const double HIGH_SCORE = 95.0;` defines a constant, the score considered "high".
2. The three scores are read from the text boxes with `double.Parse` and the average is calculated:
   `average = (test1 + test2 + test3) / 3.0;`
3. The average is shown in a label rounded to one decimal place with `ToString("n1")`.
4. **The decision:** `if (average > HIGH_SCORE)` uses the relational operator `>`. Only when the
   expression is `true` does the program show *"Congratulations! Great job!"*. If it is `false`, the
   block is skipped.
5. The whole code is inside `try { }` / `catch (Exception ex) { }`, so if the user types something
   that is not a number, the program shows an error message instead of crashing.

**Key point:** an `if` statement runs its block only when its Boolean expression is `true`.
(A safer alternative to `Parse` inside `try/catch` is `double.TryParse`, covered later in the chapter.)

---

## Screenshot 2 – Logical operators with CheckBoxes

![Logical operators with CheckBox code](screenshots/02-logical-operators-checkbox-code.png)

**What the code does**

1. `string Subjects = "";` starts with an empty result string.
2. Each CheckBox has a `Checked` property that is `true` when the box is ticked.
3. **Case 1:** `if (chkjava.Checked && chkReact.Checked && chlPHP.Checked)`
   The AND operator `&&` is `true` only when **all three** boxes are ticked. The code then adds
   `"Java\n" + "React\n" + "PHP"` to `Subjects` and shows it in a message box.
4. The comments show the next cases (any two selected, only one selected, none selected), written as an
   `else if` chain. The final `else` handles the case where nothing is selected.

**Key points**

- `&&` (AND): both sides must be `true`. `||` (OR): at least one side must be `true`. `!` (NOT): reverses the value.
- In an `if-else-if` chain, only the **first** condition that is `true` runs, so the most specific
  condition (all three) is checked first.
- Names in code (`chkjava`, `chkReact`, …) must exactly match the `Name` property of the controls.

---

## Screenshot 3 – Safe selection in a ListBox

![Safe ListBox selection](screenshots/03-listbox-safe-selection.png)

**What the code does**

1. In a ListBox, items are numbered from `0`. `SelectedIndex` is **`-1`** when no item is selected.
2. `if (listBox1.SelectedIndex != -1)` checks that the user really selected something.
3. If so, `listBox1.SelectedItem.ToString()` gets the selected item and shows *"You selected: …"*.
4. Otherwise the `else` branch tells the user *"No item selected. Please select one."*

**Why it matters:** reading `SelectedItem` when nothing is selected causes an exception (the
"unsafe" version in the slides). Checking `SelectedIndex != -1` first is a simple input-validation
decision that prevents the crash.

---

## Key takeaways

- Decisions are built from Boolean expressions: relational operators compare, logical operators combine.
- Always validate user input (`TryParse` / `try-catch`, range checks, `SelectedIndex != -1`) before using it.
- `if` for one condition, `if-else-if` for several ordered conditions, `switch` for one variable with fixed values.
