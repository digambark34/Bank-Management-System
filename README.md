
# Simple Bank Account Management System

This project is a simple console-based Bank Account Management System built in C#. It allows users to create bank accounts, deposit and withdraw money, and check account balances.

## Features

- **Create Account**: Register a new account with an account number and an owner name.
- **Deposit Money**: Add funds to an existing account.
- **Withdraw Money**: Withdraw funds from an existing account.
- **Check Balance**: View the current balance of an existing account.
- **Exit**: Close the application.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or later)

## Usage

When you run the application, you'll see the following menu options:

```
1. Create Account
2. Deposit Money
3. Withdraw Money
4. Check Balance
5. Exit
Choose an Option
```

### Example Workflow

1. **Create Account**  
   Select option `1` to create an account.
   - Enter a unique account number and an owner name to create the account.

2. **Deposit Money**  
   Select option `2` to deposit money.
   - Enter the account number and amount to deposit.

3. **Withdraw Money**  
   Select option `3` to withdraw money.
   - Enter the account number and amount to withdraw. Ensure sufficient balance is available.

4. **Check Balance**  
   Select option `4` to check the balance of an account.
   - Enter the account number to view the current balance.

5. **Exit**  
   Select option `5` to exit the application.

### Sample Code

The application consists of three main classes:

- **Account**: Manages individual account details and operations.
- **Bank**: Manages all accounts using a dictionary for quick access.
- **Program**: The main application loop for user interaction.

## Code Structure

- `Account`: Contains methods for deposit, withdraw, and balance inquiry.
- `Bank`: Contains methods for creating an account and retrieving account details.
- `Program`: Implements the main menu and handles user inputs.

## Contribution

Feel free to submit pull requests or open issues to improve this project!
