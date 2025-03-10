using System.Diagnostics;
using System.Text;
var SKY = new List<string>()
{
"          o                                              ~~+                              ",
"                       '.                  *        \\                         .   .       ",
"                                                 .   \\                                    ",
"                  '  .._                              * +                                 ",
"                   .' .-'`                  .                                             ",
"                  /  /           Brain Extension        .         '                  .    ",
"   o .            |  |           Obsidian Wrapper                                  +   .  ",
"                  \\  \\        +                                             *             ",
"                   '._'-._       By Medi                                                ",
"              '       ```    .                                    |                       ",
"                             .               .     +'            -o-       *              ",
"      +     .  *   o  |  .         .                   |  .       |               +       ",
"              '     --o--        .  |                - o -       |                        ",
"                      |          *--o--      '         |        -o-                       ",
"                '                   |                      *     |                        ",
"                 ~~+                            '                                         ",
"         ':.                                                                              ",
"         + '::._                                     + '                                  ",
"             '._)                               .  +            *  '.                     ",
"                                         '                                                ",
"                           '                         o     +                  .           ",
"                            '':.                             +                      .     ",
"   .                           '::._ +                        o                '          ",
"     .                           '._)                                                     ",
};
foreach (var line in SKY)
{
    Console.WriteLine(line);
    //wait 150ms
    Thread.Sleep(50);
}
Thread.Sleep(3000);
for(var i = 0; i < 50; i++)
{
    Console.WriteLine();
    //wait 150ms
    Thread.Sleep(15);
}
Console.ReadLine();
/*

var fileName = null;
var clientName = null;
var basePath = $"C:\\Vaults\\Brain Extension";

if (true) //(if the config file is null or invalid)
{
    goto ModifyConfig;
}

bool isClientNote;
GetGeneralOrClient:
Console.WriteLine("Please Select: \n0: Options\n1: Daily Note\n2: Client Note");
switch (Console.ReadLine())
{
    case "0":
        goto ModifyConfig;
    case "1":
        isClientNote = false; break;
    case "2":
        isClientNote = true; break;
    default:
        Console.WriteLine("Invalid selection, please try again.");
        goto GetGeneralOrClient;
}
if (!isClientNote)
{
    Console.WriteLine("Generating Daily Note...");
    fileName = $"External Records\\Daily Notes\\{DateTime.Now.Year}\\{DateTime.Now.Month}\\{DateTime.Now.Day} {DateTime.Now.DayOfWeek}.md";
    goto GenerateTheFile;
}

GetClientName:
//get all subfolders of External Records\Client Notes
var clientFolders = Directory.GetDirectories(basePath + "\\External Records\\Client Notes");
StringBuilder clientOptions = new StringBuilder();
clientOptions.AppendLine("Please select a client:");
clientOptions.AppendLine($"0: New Client");
for (int i = 1; i <= clientFolders.Length; i++)
{
    clientOptions.AppendLine($"{i}: {clientFolders[i].Split('\\').Last()}");
}

Console.WriteLine(clientOptions.ToString());
var clientSelection = Console.ReadLine();
if (clientSelection == "0")
{
    Console.WriteLine("Please enter the client's name:");
    string clientChoice = Console.ReadLine();
    if (string.IsNullOrEmpty(clientChoice))
    {
        Console.WriteLine("Invalid client name, please try again.");
        goto GetClientName;
    }
    else
    {
        clientName = clientChoice;
    }
}
else if (int.TryParse(clientSelection, out int clientIndex) && clientIndex > 0 && clientIndex <= clientFolders.Length)
{
    clientName = clientFolders[clientIndex - 1].Split('\\').Last();
}
else
{
    Console.WriteLine("Invalid selection, please try again.");
    goto GetClientName;
}

DetermineNoteType:
Console.WriteLine("Please Select: \n0: No Template\n1: Bug\n2: Feature\n3: Meeting");

GenerateTheFile:
*/