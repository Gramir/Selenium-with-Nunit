# Selenium with C# and NUnit

A comprehensive test automation project using Selenium WebDriver with C# and NUnit framework to test the [Sauce Demo](https://www.saucedemo.com/) e-commerce application.

## 📋 Table of Contents

- [Overview](#overview)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Running Tests](#running-tests)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [Test Scenarios](#test-scenarios)
- [Page Object Model](#page-object-model)
- [Contributing](#contributing)

## 🎯 Overview

This project demonstrates automated testing of a web application using the Page Object Model (POM) pattern. It includes comprehensive tests for user authentication, inventory management, and shopping cart functionality on the Sauce Demo website.

## 🔧 Prerequisites

Before running this project, ensure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or higher
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or [Visual Studio Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/downloads)
- Google Chrome browser (latest version)

## 📦 Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Gramir/Selenium-with-Nunit.git
   cd Selenium-with-Nunit
   ```

2. **Restore NuGet packages:**
   ```bash
   dotnet restore
   ```

3. **Build the project:**
   ```bash
   dotnet build
   ```

## 🚀 Running Tests

### Run all tests
```bash
dotnet test
```

### Run tests with detailed output
```bash
dotnet test --logger "console;verbosity=detailed"
```

### Run specific test class
```bash
dotnet test --filter "ClassName=LoginTests"
dotnet test --filter "ClassName=InventoryTests"
```

### Run specific test method
```bash
dotnet test --filter "MethodName=LogInSuccefully"
```

## 📁 Project Structure

```
SeleniumTest/
├── Pages/                          # Page Object Model classes
│   ├── LoginPage.cs               # Login page interactions
│   └── Inventory.cs               # Inventory page interactions
├── Tests/                         # Test classes
│   ├── LoginTests.cs             # Authentication tests
│   └── InventoryTests.cs         # Inventory and cart tests
├── GlobalUsings.cs               # Global using statements
├── SeleniumTest.csproj           # Project configuration
└── README.md                     # This file
```

## 🛠️ Technologies Used

- **Framework:** .NET 8.0
- **Testing Framework:** NUnit 3.13.3
- **Web Automation:** Selenium WebDriver 4.16.2
- **Browser Driver:** Chrome Driver 120.0.6099.10900
- **Design Pattern:** Page Object Model (POM)
- **Additional Libraries:**
  - Selenium.Support
  - SeleniumExtras.WaitHelpers
  - NUnit3TestAdapter
  - Microsoft.NET.Test.Sdk

## 🧪 Test Scenarios

### Login Tests (`LoginTests.cs`)
- ✅ **LogInSuccefully:** Validates successful login with valid credentials
- ✅ **LogInWithWrongPassword:** Verifies error handling for invalid credentials
- ✅ **LogOutSuccefully:** Tests complete logout functionality

### Inventory Tests (`InventoryTests.cs`)
- ✅ **AddAndRemoveItemToCart:** Tests adding and removing items from shopping cart
- ✅ **OrganizeItemsByA_Z:** Validates sorting functionality (A-Z)
- ✅ **OrganizeItemsByZ_A:** Validates sorting functionality (Z-A)

## 🏛️ Page Object Model

The project follows the Page Object Model design pattern for better maintainability:

### LoginPage.cs
- Handles all login page interactions
- Methods: `GoToPage()`, `Login()`
- Elements: Username field, password field, login button, error messages

### Inventory.cs
- Manages inventory and cart operations
- Methods: `AddBackPackItemCart()`, `RemoveBackpackItemCart()`, `FilterByA_Z()`, `FilterByZ_A()`, `Logout()`
- Elements: Product buttons, cart elements, filter dropdown, menu items

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📋 Test Execution Notes

- Tests use Chrome browser in normal mode (not headless)
- Each test class uses `OneTimeSetUp` and `OneTimeTearDown` for browser lifecycle
- The application under test: https://www.saucedemo.com/
- Default test credentials: 
  - Username: `standard_user`
  - Password: `secret_sauce`

## 🐛 Known Issues

- The project has some nullable reference warnings that don't affect functionality
- Tests require an active internet connection to reach the Sauce Demo website
- Chrome browser must be installed and accessible

## 📄 License

This project is for educational and demonstration purposes.
