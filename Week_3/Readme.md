# Week 3 – Chapter 3: Making Decisions

A program becomes useful when it can **decide** what to do based on conditions.
This chapter covers how C# makes decisions, how to check user input safely,
and how to use common Windows Forms controls (RadioButton, CheckBox, ListBox).

## What this chapter covers

| Topic | Key idea |
|-------|----------|
| `if` statement | Runs a block only when a Boolean expression is `true` |
| Relational operators | `>`, `<`, `>=`, `<=`, `==`, `!=` compare two values |
| `if-else` | Chooses between two blocks of code |
| Nested decisions | An `if` inside another `if` to test several conditions |
| `if-else-if` | Tests many conditions in order (e.g. letter grades) |
| Logical operators | `&&` (AND), `||` (OR), `!` (NOT) combine conditions |
| `bool` variables / flags | A variable that signals whether a condition exists |
| Comparing strings | `==`, `!=`, and `String.Compare` |
| `TryParse` | Converts text to a number **without crashing** on bad input |
| Input validation | Checking the data is *reasonable*, not just numeric (e.g. score 0–100) |
| RadioButton / CheckBox | One choice vs. many choices; `Checked` property and `CheckedChanged` event |
| `switch` statement | Multiple-alternative decision based on one value |
| ListBox | `Items.Add`, `Items.Remove`, `Items.RemoveAt`, `Items.Clear`, `Items.Count`, `SelectedItem`, `SelectedIndex` |

## Demos

Each demo is a Windows Forms application. Code is in the [`code`](code) folder.

### 1. Loan Qualifier – nested `if`, `TryParse`, validation
Checks salary and years on the job. A user qualifies when salary ≥ 40,000 **and** years ≥ 2.
Bad input (letters, negative numbers) is rejected with a message instead of crashing.

| Control | Name |
|---------|------|
| TextBox | `salaryTextBox`, `yearsTextBox` |
| Button | `checkButton`, `clearButton` |
| Label | `resultLabel` |

Code: [`01_LoanQualifier.cs`](code/01_LoanQualifier.cs)

| Qualifies | Years too low | Invalid input |
|-----------|---------------|---------------|
| ![Qualifies](screenshots/01-loan-qualifies.png) | ![Years too low](screenshots/01-loan-years-low.png) | ![Invalid input](screenshots/01-loan-invalid.png) |

### 2. Grade Calculator – `if-else-if` and validation
Converts a score to A/B/C/D/F and rejects scores outside 0–100.

| Control | Name |
|---------|------|
| TextBox | `scoreTextBox` |
| Button | `calculateButton` |
| Label | `gradeLabel` |

Code: [`02_GradeCalculator.cs`](code/02_GradeCalculator.cs)

| Valid score | Out of range |
|-------------|--------------|
| ![Grade](screenshots/02-grade-result.png) | ![Out of range](screenshots/02-grade-invalid.png) |

### 3. Pizza Order – RadioButton, CheckBox, `bool` flag
Radio buttons pick **one** size; check boxes pick **any** toppings. A `bool` flag tracks
whether any topping was chosen, and the `CheckedChanged` event updates a live topping count.

| Control | Name |
|---------|------|
| RadioButton | `smallRadioButton`, `mediumRadioButton`, `largeRadioButton` |
| CheckBox | `cheeseCheckBox`, `pepperoniCheckBox`, `olivesCheckBox` |
| Button | `orderButton` |
| Label | `summaryLabel`, `toppingsCountLabel` |

Code: [`03_PizzaOrder_RadioCheckBox.cs`](code/03_PizzaOrder_RadioCheckBox.cs)

![Pizza order](screenshots/03-pizza-order.png)

### 4. Month Name – `switch` statement
Turns a number 1–12 into a month name; `default` handles anything else.

| Control | Name |
|---------|------|
| TextBox | `monthTextBox` |
| Button | `showMonthButton` |
| Label | `monthNameLabel` |

Code: [`04_MonthSwitch.cs`](code/04_MonthSwitch.cs)

| Valid month | Invalid month |
|-------------|---------------|
| ![Month](screenshots/04-month-valid.png) | ![Invalid](screenshots/04-month-invalid.png) |

### 5. ListBox Demo – adding, removing, selecting
Add and remove items, show the selected item and its index, and keep a live item count.
It checks `SelectedIndex != -1` before using `SelectedItem`, because reading `SelectedItem`
with nothing selected causes an error.

| Control | Name |
|---------|------|
| ListBox | `daysListBox` |
| TextBox | `newItemTextBox` |
| Button | `addButton`, `removeButton`, `clearButton` |
| Label | `selectedLabel`, `countLabel` |

Code: [`05_ListBoxDemo.cs`](code/05_ListBoxDemo.cs)

![ListBox demo](screenshots/05-listbox-demo.png)

## Key takeaways

- Use `TryParse` instead of `Parse` whenever the input comes from a user.
- `TryParse` checks the **type**; validation checks the **range/meaning**. You usually need both.
- Use `&&` / `||` to combine conditions instead of deep nesting when possible.
- `switch` is cleaner than a long `if-else-if` chain when testing one variable against fixed values.
- Always check `SelectedIndex != -1` before using `SelectedItem`.