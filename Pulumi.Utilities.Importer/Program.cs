// See https://aka.ms/new-console-template for more information

using CliWrap;

try
{
    string workingDir = "";
    string filePath = Path.Combine(workingDir, "import.json");
    File.WriteAllText(filePath, args[0]);

    var result = await Cli.Wrap("pulumi")
        .WithArguments(["import", $"-f {filePath}"])

        .WithWorkingDirectory("work/dir/path")
        .ExecuteAsync();

}

catch
{

}