using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainExtensionScaffolder;
public static class FileScaffolder
{
    //this shouldn't be a method this should just be main, and i delete what's in main right now. i'll fix that when i get back to it i guess
    public static bool DetermineFileLocation(out string? fileName, out string? clientName)
    {
        fileName = null;
        clientName = null;
        var basePath = $"C:\\Vaults\\Brain Extension";

        bool isClientNote;
    GetGeneralOrClient:
        Console.WriteLine("Please Select: \n0: Brain Extension Configuration\n1: Daily Note\n2: Client Note");
        switch (Console.ReadLine())
        {
            case "0":
                return false;
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

    }
}