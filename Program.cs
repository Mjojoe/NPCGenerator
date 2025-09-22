// See https://aka.ms/new-console-template for more information

using NPCGenerator.npcs;

bool testing = false;
int NumOfInstances;
List<ICharacter> Instances = new();
string filename = "GeneratedNPCs.txt";

Console.WriteLine("NPC Generator");

if (testing) { NumOfInstances = 5; } 
else {
    NumOfInstances = 9;
}

for (int i = 0; i < NumOfInstances; i++)
{
    //Console.WriteLine("Generating random Instances ... ");
    Instances.Add(new Humanoid());
}

if (testing) {
    Console.WriteLine("These Instances have been generated:");

    foreach (ICharacter i in Instances)
    {
        Console.WriteLine("----------------------------------------");
        i.PrintCharacter();
    }
} else {
    string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, filename)))
    {
            outputFile.WriteLine(DateTime.Now.ToString());
    }
    foreach (ICharacter i in Instances)
    {
        string[] lines = i.WriteCharacterToFile();
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, filename), true))
        {
            foreach (string line in lines)
                outputFile.WriteLine(line);
        }
    }
    Console.WriteLine("Print Complete!");
}

Console.Read();

