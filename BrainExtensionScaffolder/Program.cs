using System.Diagnostics;

Console.WriteLine("Hi, Sam, hope things are going OK.");
Console.WriteLine("Here on business?");
var workNote = Console.ReadLine().ToLower() is ("y" or "yes" or "1") ? true : false;
Console.WriteLine("Sure, let me get that put together for you.");
var basePath = $"C:\\Vaults\\Brain Extension";
var filePath = $"{(workNote ? "External" : "Internal")} Records\\{DateTime.Now.Year}\\{DateTime.Now.Month}\\{DateTime.Now.Day} {DateTime.Now.DayOfWeek}.md";
// Ensure the directory exists
Directory.CreateDirectory(Path.GetDirectoryName(basePath+"\\"+filePath));
//try make file
if (!File.Exists(basePath + "\\" + filePath))
{
    File.CreateText(basePath + "\\" + filePath).Close();
}
Console.WriteLine("I scaffolded it in Obsidian for you.");
Console.WriteLine("Attempting to open file...");
try
{
    var uri = $"obsidian://open?vault=Brain%20Extension&file={Uri.EscapeDataString(filePath)}";
    var processStartInfo = new ProcessStartInfo
    {
        FileName = uri,
        UseShellExecute = true
    };
    Process.Start(processStartInfo);
    Console.WriteLine("File should be open in Obsidian now!");
}
catch (Exception ex)
{
    Console.WriteLine($"Failed to open file in Obsidian: {ex.Message}");
}


var SKY = @"          o                                              ~~+                              
                       '.                  *        \                         .   .       
                                                 .   \                                    
                  '  .._                              * +                                 
                   .' .-'`                  .                                             
                  /  /                                  .         '                  .    
   o .            |  |                                                             +   .  
                  \  \        +                                             *             
                   '._'-._                                                                
              '       ```    .                                    |                       
                             .               .     +'            -o-       *              
      +     .  *   o  |  .         .                   |  .       |               +       
              '     --o--        .  |                - o -       |                        
                      |          *--o--      '         |        -o-                       
                '                   |                      *     |                        
                 ~~+                            '                                         
         ':.                                                                              
         + '::._                                     + '                                  
             '._)                               .  +            *  '.                     
                                         '                                                
                           '                         o     +                  .           
                            '':.                             +                      .     
   .                           '::._ +                        o                '          
     .                           '._)                                                     
  .    |                                                 o                         o      
     --o--                                                   .             '              
       |                          '                  +                                    
                                              .              o                   +        
 '                  . .                                        *            .          o  
                                 .                              .                         ";