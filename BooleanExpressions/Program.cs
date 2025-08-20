string permission = "Admin|Manager";
int level = 55;

string message = "You do not have sufficient privileges.";

if (permission.Contains("Admin"))
{
    if (level > 55)
        message = "Welcome, Super Admin user.";
    else
        message = "Welcome, Admin user.";
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
        message = "Contact an Admin for access.";
    else
        message = "You do not have sufficient privileges.";
}

Console.WriteLine(message);