using System.CommandLine;

class Program
{
    static async Task Main(string[] args)
    {
        var host = new Option<string>
            (name: "--host",
             description: "(Option)host");
        host.AddAlias("-h");
        var book = new Option<FileInfo>
            (name: "--book",
             description: "book")
        { IsRequired = true };
        book.AddAlias("-b");
        var sheet = new Option<string>
            (name: "--sheet",
             description: "sheet")
        { IsRequired = true };
        sheet.AddAlias("-s");
        var username = new Option<string>
            (name: "--username",
             description: "(Option)username");
        username.AddAlias("-u");
        var password = new Option<string>
            (name: "--password",
             description: "(Option)password");
        password.AddAlias("-p");

        var rootCommand = new RootCommand();
        rootCommand.Add(host);
        rootCommand.Add(book);
        rootCommand.Add(sheet);
        rootCommand.Add(username);
        rootCommand.Add(password);

        rootCommand.SetHandler((host, book, sheet, username, password) =>
        {
            Console.WriteLine($"-- = {host}");
        },
            host, book, sheet, username, password);

        await rootCommand.InvokeAsync(args);
    }
}