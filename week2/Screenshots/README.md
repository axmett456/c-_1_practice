# Week 2 Screenshots

This folder is for the three Week 2 screenshots and their explanations. Add the screenshot image files here when they are ready.

## Screenshot 3: Explicit Conversion

An explicit conversion (cast) changes a value from one type to another. Here, an `int` value is converted to `double`.

```csharp
int number1 = 10;
double number2 = (double)number1;
```

### How It Works

- `int number1 = 10;` declares an integer variable.
- `(double)` explicitly converts the integer value to a `double`.
- `number2` stores the converted numeric value.

### Result

```text
number1 = 10
number2 = 10
```

`number2` is a `double` whose numeric value is 10 (equivalent to 10.0). Its default text display may show `10`, without a decimal place.

## Screenshot 4: C# Integer Division

When both operands are integers, C# performs integer division and discards the fractional part.

```csharp
int x = 7;
int y = 3;
MessageBox.Show((x / y).ToString());
```

### How It Works

- `x` and `y` are both `int` values.
- `7 / 3` evaluates to `2` in integer division; the remainder is discarded.
- `.ToString()` converts the result to text for `MessageBox.Show()`.

### Output

```text
2
```

## Screenshot 5: C# Try-Catch Example

This example attempts to convert the text entered in a TextBox to an integer. The `catch` blocks handle text that is not an integer and values outside the `int` range.

```csharp
try
{
	int number = int.Parse(txtshow.Text);
	MessageBox.Show(number.ToString());
}
catch (FormatException)
{
	MessageBox.Show("Please enter a valid whole number.");
}
catch (OverflowException)
{
	MessageBox.Show("The number is too large or too small.");
}
```

### How It Works

- `try` runs the conversion code that may fail.
- `txtshow.Text` reads the text entered in the TextBox.
- `int.Parse()` converts valid integer text to an `int`.
- `MessageBox.Show()` displays the converted number.
- `FormatException` handles text that is not a valid integer.
- `OverflowException` handles a number outside the range supported by `int`.

### Examples

- Input `25` displays `25`.
- Input `abc` displays `Please enter a valid whole number.`
- An integer outside the supported range displays `The number is too large or too small.`
