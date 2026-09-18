# 🎮 Tic-Tac-Toe Game

A simple and interactive **Tic-Tac-Toe game** built with **C# and Windows Forms**.

This project was created as a practical C# project to practice **Windows Forms, event handling, controls, game logic, and object-oriented programming concepts**.

---

## 🎯 About the Game

Tic-Tac-Toe is a classic **two-player game** played on a 3×3 grid.

* ❌ **Player 1** plays with `X`
* ⭕ **Player 2** plays with `O`
* 🔄 Players take turns selecting an empty cell.
* 🏆 The first player to get three matching symbols in a row wins.
* 🤝 If all nine cells are filled without a winner, the game ends in a draw.

---

## ✨ Features

* 👥 Two-player local gameplay
* ❌ `X` and `O` player system
* 🔄 Automatic turn switching
* 🏆 Winner detection
* 🤝 Draw detection
* 💡 Highlights the winning combination
* 🚫 Prevents selecting an already-used cell
* 🔁 Restart game functionality
* 📢 Game result notifications
* 🖥️ Simple and clean Windows Forms interface

---

## 🧠 Winning Conditions

The game checks all possible winning combinations.

### ➡️ Rows

```text
X | X | X
---------
O | O | -
---------
- | - | -
```

### ⬇️ Columns

```text
X | O | -
---------
X | O | -
---------
X | - | -
```

### ↘️ Diagonals

```text
X | O | -
---------
O | X | -
---------
- | - | X
```

---

## 🛠️ Technologies

* 💻 **C#**
* 🪟 **Windows Forms**
* ⚙️ **.NET**
* 🧰 **Visual Studio**

---

## ⚙️ How It Works

Each cell of the game board is represented by a `PictureBox`.

The current player's symbol is stored using the `Tag` property:

```csharp
pictureBox.Tag = "X";
```

or:

```csharp
pictureBox.Tag = "O";
```

After each move, the game checks the possible winning combinations across:

* ➡️ Rows
* ⬇️ Columns
* ↘️ Diagonals

The game also keeps track of the number of played moves. If all nine cells are filled without a winner, the game declares a draw.

---

## 🎮 Game Controls

| Control           | Purpose                             |
| ----------------- | ----------------------------------- |
| 🖼️ `PictureBox`  | Represents a cell on the game board |
| 👤 Player Label   | Displays the current player         |
| 🏆 Winner Label   | Displays the game result            |
| 🔄 Restart Button | Restarts the game                   |

---

## 🚀 Getting Started

### 1️⃣ Clone the repository

```bash
git clone https://github.com/ahmedhicazi/Tic-Tac-Toe_Game.git
```

### 2️⃣ Open the project

Open the solution in **Visual Studio**.

### 3️⃣ Build the project

Build the solution using Visual Studio.

### 4️⃣ Run the application

Press:

```text
F5
```

and start playing! 🎮

---

## 📚 What I Practiced

Through this project, I practiced several C# and Windows Forms concepts:

* 🧩 Windows Forms
* 🖱️ Event handling
* 🎛️ Working with controls
* 🏷️ Using the `Tag` property
* 🔀 Conditional statements
* 🔧 Methods
* 🧠 Game logic
* 🔄 Managing application state
* 🏗️ Basic Object-Oriented Programming

---

## 🔮 Future Improvements

Some ideas for future versions:

* 🤖 Add a single-player mode against the computer
* 🧠 Add AI with different difficulty levels
* 🏆 Add a score system
* 👤 Allow players to enter their names
* 🔊 Add sound effects
* ✨ Add animations
* 🎨 Improve the user interface
* 🧹 Refactor the game logic into separate classes

---

## 👨‍💻 About Me

**Ahmed Hicazi**

💻 **Full Stack Desktop Developer**

I'm a programmer interested in **software development, .NET, C#, desktop applications, and artificial intelligence**.

🌐 **Personal Website:**
https://ahmedhicazi.github.io

🐙 **GitHub:**
https://github.com/ahmedhicazi

---

## ⭐ Support

If you like this project, consider giving the repository a ⭐ on GitHub!

---

### 📄 License

This project is open source and available for learning and educational purposes.
