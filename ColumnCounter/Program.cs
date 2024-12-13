using System.CommandLine;

class Program
{
    static async Task Main(string[] args)
    {
        var hostOption = new Option<string>
            (aliases: ["--host", "-h"],
             description: "共有フォルダのホスト名または IP アドレス");
        var bookOption = new Option<FileInfo>
            (aliases: ["--book", "-b"],
             description: "Excel ファイルのフルパス")
        { IsRequired = true };
        var sheetOption = new Option<string>
            (aliases: ["--sheet", "-s"],
             description: "シート名")
        { IsRequired = true };
        var usernameOption = new Option<string>
            (aliases: ["--username", "-u"],
             description: "共有フォルダもしくはデータベースにアクセスする場合のユーザー名");
        var passwordOption = new Option<string>
            (aliases: ["--password", "-p"],
             description: "共有フォルダもしくはデータベースにアクセスする場合のパスワード");

        var rootCommand = new RootCommand
        {
            hostOption,
            bookOption,
            sheetOption,
            usernameOption,
            passwordOption
        };

        rootCommand.SetHandler((host, book, sheet, username, password) =>
        {
            Console.WriteLine($"-- = {host}");
        },
            hostOption, bookOption, sheetOption, usernameOption, passwordOption);

        await rootCommand.InvokeAsync(args);
    }
}