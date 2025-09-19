Console.WriteLine("Hello, World!");

Console.Write("Username: ");
string username = Console.ReadLine() ?? "";

Console.Write("Password: ");
string password = Console.ReadLine() ?? "";

Console.Write("UserId (heltal): ");
uint userId = uint.TryParse(Console.ReadLine(), out var u) ? u : 0;


bool userIsAdmin   = userId > 65536;
bool usernameValid = username.Length >= 3;
bool passwordValid =
    (password.Contains("$") || password.Contains("|") || password.Contains("@")) &&
    ((userIsAdmin && password.Length >= 20) || (!userIsAdmin && password.Length >= 16));


Console.WriteLine();
Console.WriteLine($"userIsAdmin:   {userIsAdmin}");
Console.WriteLine($"usernameValid: {usernameValid}");
Console.WriteLine($"passwordValid: {passwordValid}");



