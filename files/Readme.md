# File Handling Assignment – C# Windows Forms

## 1. Project Overview

This project is a simple File Handling application developed using C# and Windows Forms.

The application demonstrates how to add items to a text file, read file contents, display saved items, and delete specific items.

The project focuses on the use of C# file handling methods, especially reading and deleting data from files.

## 2. Technologies Used

- C#
- Windows Forms
- .NET
- Visual Studio
- Text File (`items.txt`)

## 3. Application Buttons and Functions

### Button 1: Add Item

This button saves a new item entered in the TextBox to the `items.txt` file.

**Method used:** `File.AppendAllText()`

The application checks whether the TextBox is empty before saving the item. After saving, the ListBox is updated to display the items.

### Button 2: Delete Item

This button deletes a specified item from the `items.txt` file.

**Methods used:**
- `File.ReadAllLines()`
- `File.WriteAllLines()`

The application reads all items, searches for the specified item, removes it, and saves the remaining items back to the file.

### Button 3: Read All Text

This button reads the complete contents of `items.txt` and displays the result in a MessageBox.

**Method used:** `File.ReadAllText()`

### Button 4: Read All Lines

This button reads all lines from `items.txt` and displays them in the ListBox.

**Methods used:**
- `File.ReadAllLines()`
- `listBox1.Items.AddRange()`

Each line from the file appears as a separate item in the ListBox.

## 4. How the Application Works

1. The user enters an item in the TextBox.
2. The Add Item button saves the item to `items.txt`.
3. The application loads the saved items into the ListBox.
4. The Read All Text button displays the complete file contents in a MessageBox.
5. The Read All Lines button displays all file lines in the ListBox.
6. The Delete Item button removes the selected text entered by the user from the file and updates the ListBox.

## 5. File Storage

The application uses the following code to define the file path:

`Path.Combine(Application.StartupPath, "items.txt")`

This stores `items.txt` in the application's startup directory.

## 6. File Handling Methods

| Method | Description |
|---|---|
| `File.AppendAllText()` | Adds text to the end of a file. |
| `File.ReadAllText()` | Reads the entire file as a string. |
| `File.ReadAllLines()` | Reads all lines into a string array. |
| `File.WriteAllLines()` | Writes lines to a file, replacing its existing contents. |
| `File.Exists()` | Checks whether a file exists. |

## 7. Error Handling

The application checks whether the file exists before reading or deleting items. It also validates empty input and displays messages when an item is not found.

## 8. Conclusion

This project demonstrates basic file handling operations in C# Windows Forms. It provides practical experience in adding items, reading text files, displaying information, and deleting items.

The application fulfills the main objectives of the assignment by demonstrating file reading functions and deleting items from a file.
