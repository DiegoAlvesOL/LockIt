# LockIt

**LockIt** is an academic project created to help me learn software development concepts using C#.  
The goal is to build a simple, modular password generator that allows the user to choose the length of the password and produces a random combination of letters, numbers, and special characters.

---

## ✨ Current Features
- Generate random passwords of user-defined length
- User interaction through the terminal (CLI)
- Modular structure (LockItCore, LockItUi, LockItData folders)
- Encapsulation and Object-Oriented Programming principles applied

---

## 🔮 Planned Features (Roadmap)
- Save generated passwords in a database (e.g., MySQL)
- Add user authentication and login screen
- Implement a GUI for easier interaction
- Allow favorite passwords or frequently used combinations
- Include advanced options for password strength rules
- Add automated tests

---

## 📁 Project Structure
```
LockIt/
├── Dependencies/           # External libraries or helpers
├── LockItCore/             # Business logic (password generation)
│   ├── CharacterSets.cs
│   ├── PasswordGenerator.cs
├── LockItData/             # Data persistence (future database integration)
├── LockItUi/               # User interface (CLI)
│   ├── ConsoleUi.cs
├── Program.cs              # Entry point
├── README.md               # Project documentation
├── .gitignore              # Git configuration
```
---

## 🛠️ Technologies and Practices
- C# 11 / .NET 8
- Object-Oriented Programming (OOP)
- Modular structure
- Good versioning practices (git)
- Semantic commits (feat, chore, fix, etc.)

---

## 🚀 How to Run
1. Clone the repository
2. Open the solution in an IDE (such as Rider or Visual Studio)
3. Run the project and interact with the terminal:

```bash
Program.cs
```


## 📌 Notes
This project is for academic purposes and will evolve as I continue learning C# and OOP concepts.  
It focuses on clean architecture, modularity, and separating responsibilities across classes and folders.
