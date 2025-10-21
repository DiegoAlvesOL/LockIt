# LockIt

Select the README version:

* [🇺🇸 English](#english-version)
* [🇧🇷 Portuguese - BR](#versão-em-português)

---
## English Version

**LockIt** is an academic project created to help me learn software development concepts using C#.
The goal is to build a **modular password generator** that allows the user to choose the password length and produces random combinations of letters, numbers, and special characters.
The project now includes **automated tests** and is structured to support both console and GUI interfaces in the future.

### Current Features

* Generate random passwords of user-defined length
* User interaction through the terminal (CLI)
* Modular structure (LockItCore, LockItInfra, LockItUi, LockItData folders)
* Object-Oriented Programming (OOP) principles applied
* Automated integration tests to ensure reliability

### Planned Features (Roadmap)

* Save generated passwords in a database (e.g., MySQL)
* Add user authentication and login screen
* Implement a **GUI using WinForms**
* Allow favorite passwords or frequently used combinations
* Include advanced options for password strength rules

### 📁 Project Structure
```
LockIt/
├─ LockIt.sln
├─ README.md
├─ LockIt/                  # Projeto principal
│   ├─ LockIt.csproj
│   ├─ Program.cs
│   ├─ LockItCore/
│   │   ├─ CharacterSets.cs
│   │   ├─ Credential.cs
│   │   └─ PasswordGenerator.cs
│   ├─ LockItInfra/
│   │   ├─ AppPaths.cs
│   │   ├─ JsonLoader.cs
│   │   └─ JsonStorage.cs
│   ├─ LockItUi/
│   │   └─ ConsoleUi.cs
│   ├─ LockItData/
│   │   └─ credentials.json
│   └─ LockItDocs/
├─ LockIt.IntegrationTests/
│   ├─ LockIt.IntegrationTests.csproj
│   └─ Tests/
│       └─ EnsureDataDirectoryTests.cs
├─ LockIt.TestHelpers/
│   ├─ LockIt.TestHelpers.csproj
│   └─ Helpers/
│       └─ TestEnvironmentHelper.cs
```

### Technologies and Practices

* C# (.NET 9)
* Object-Oriented Programming (OOP)
* Modular structure with separation of responsibilities
* Automated tests with xUnit
* Clean architecture principles
* Git version control with semantic commits (feat, chore, fix, etc.)

### How to Run

1. Clone the repository

```bash

git clone https://github.com/DiegoAlvesOL/LockIt.git
```

2. Open the solution in an IDE (Rider or Visual Studio)
3. Run the console app:

    * Set `LockIt` as the startup project
    * Execute `Program.cs`
4. Run automated tests (optional):

    * Set `LockIt.IntegrationTests` as the startup project
    * Execute the tests to verify functionality

### Notes

This project is for academic purposes and will continue evolving.
The focus is on **clean architecture, modularity, and separation of responsibilities**, making it easy to extend with new interfaces and features.


---

## Versão em Português

**LockIt** é um projeto acadêmico criado para me ajudar a aprender conceitos de desenvolvimento de software usando C#.
O objetivo é construir um **gerador de senhas modular** que permita ao usuário escolher o tamanho da senha e produza combinações aleatórias de letras, números e caracteres especiais.
O projeto agora inclui **testes automatizados** e está estruturado para suportar tanto interfaces de console quanto GUI no futuro.

### Funcionalidades atuais

* Geração de senhas aleatórias com tamanho definido pelo usuário
* Interação através do terminal (CLI)
* Estrutura modular (LockItCore, LockItInfra, LockItUi, LockItData folders)
* Princípios de Programação Orientada a Objetos (OOP) aplicados
* Testes automatizados para garantir confiabilidade

### Funcionalidades planejadas (Roadmap)

* Salvar senhas geradas em um banco de dados (ex.: MySQL)
* Adicionar autenticação de usuários e tela de login
* Implementar **GUI usando WinForms**
* Permitir senhas favoritas ou combinações usadas frequentemente
* Incluir opções avançadas de regras de força de senha

### 📁 Estrutura do projeto

```
LockIt/
├─ LockIt.sln
├─ README.md
├─ LockIt/                  # Projeto principal
│   ├─ LockIt.csproj
│   ├─ Program.cs
│   ├─ LockItCore/
│   │   ├─ CharacterSets.cs
│   │   ├─ Credential.cs
│   │   └─ PasswordGenerator.cs
│   ├─ LockItInfra/
│   │   ├─ AppPaths.cs
│   │   ├─ JsonLoader.cs
│   │   └─ JsonStorage.cs
│   ├─ LockItUi/
│   │   └─ ConsoleUi.cs
│   ├─ LockItData/
│   │   └─ credentials.json
│   └─ LockItDocs/
├─ LockIt.IntegrationTests/
│   ├─ LockIt.IntegrationTests.csproj
│   └─ Tests/
│       └─ EnsureDataDirectoryTests.cs
├─ LockIt.TestHelpers/
│   ├─ LockIt.TestHelpers.csproj
│   └─ Helpers/
│       └─ TestEnvironmentHelper.cs
```

### Tecnologias e práticas

* C# (.NET 9)
* Programação Orientada a Objetos (OOP)
* Estrutura modular com separação de responsabilidades
* Testes automatizados com xUnit
* Princípios de arquitetura limpa
* Controle de versão com Git e commits semânticos (feat, chore, fix, etc.)

### Como executar

1. Clone o repositório

```bash

git clone https://github.com/DiegoAlvesOL/LockIt.git
```

2. Abra a solução em um IDE (Rider ou Visual Studio)
3. Execute o app console:

    * Defina `LockIt` como projeto de inicialização
    * Execute `Program.cs`
4. Execute os testes automatizados (opcional):

    * Defina `LockIt.IntegrationTests` como projeto de inicialização
    * Execute os testes para verificar funcionalidades

### 📌 Observações

O projeto é para fins acadêmicos e continuará evoluindo.
O foco está em **arquitetura limpa, modularidade e separação de responsabilidades**, facilitando a adição de novas interfaces e funcionalidades.

