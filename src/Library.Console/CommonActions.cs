namespace Library.Console;

[Flags]
public enum CommonActions
{
    Repeat = 0,
    Select = 1,
    Quit = 2,
    SearchBooks = 4,
    SearchPatrons = 8,
    RenewPatronMembership = 16,
    ReturnLoanedBook = 32,
    ExtendLoanedBook = 64
}

