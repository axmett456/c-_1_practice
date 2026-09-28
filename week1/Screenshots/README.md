# Week 1 Screenshots

This folder is for the two Week 1 screenshots and their explanations. Add the screenshot image files here when they are ready.

## Screenshot 1: String Variable in a TextBox

This Windows Forms event handler runs when Button 1 is clicked. It stores `Jamhuuriya University` in a string variable and displays it in `textBox2`.

```csharp
private void button1_Click(object sender, EventArgs e)
{
	string productDescription = "Jamhuuriya University";
	textBox2.Text = productDescription;
}
```

### How It Works

- `button1_Click` is the event handler called when the button is clicked.
- `string productDescription` declares a string variable.
- The text in quotation marks is the value assigned to the variable.
- `textBox2.Text` sets the text displayed in the TextBox.
- `sender` identifies the control that raised the event; `e` contains event data.

### Result

After Button 1 is clicked, `textBox2` displays:

```text
Jamhuuriya University
```

This example displays text in a TextBox, not in a MessageBox.

## Screenshot 2: C# String Concatenation

String concatenation joins text values. This example combines two strings and displays the result in a pop-up MessageBox.

```csharp
string message = "Jamhuuriya" + " University";
MessageBox.Show(message);
```

### How It Works

- `string message` declares a string variable.
- The `+` operator joins the two strings.
- The leading space in `" University"` separates the words.
- `MessageBox.Show(message)` displays the combined text.

### Output

```text
Jamhuuriya University
```
