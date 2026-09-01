 The bank account supports this behavior:

    It has a 10-digit number that uniquely identifies the bank account.
    It has a string that stores the name or names of the owners.
    The balance can be retrieved.
    It accepts deposits.
    It accepts withdrawals.
    The initial balance must be positive.
    Withdrawals can't result in a negative balance.


Different types of accounts

- An interest earning account that accrues interest at the end of each month.
- A line of credit that can have a negative balance, but when there's a balance, there's an interest charge each month.
- A prepaid gift card account that starts with a single deposit, and only can be paid off. It can be refilled once at the start of each month.

Requirements

An interest earning account:

    Gets a credit of 2% of the month-ending-balance.

A line of credit:

    Can have a negative balance, but not be greater in absolute value than the credit limit.
    Incurs an interest charge each month where the end of month balance isn't 0.
    Incurs a fee on each withdrawal that goes over the credit limit.

A gift card account:

    Can be refilled with a specified amount once each month, on the last day of the month.

