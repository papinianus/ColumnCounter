using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;

public class Program
{
    private static int Main(string[] args)
    {
        var rootCommand = new RootCommand
        {
            new Option<string>(
                "host"
                ),
            new Option<FileInfo>(
                "book"
                ),
            new Option<string>(
                "sheet"
                ),
            new Option<string>(
                "username"
                ),
            new Option<string>(
                "password"
                )

        };

        rootCommand.Description = "ColumnCounter";
    }
}