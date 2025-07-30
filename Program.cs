// See https://aka.ms/new-console-template for more information

using static NPCGenerator.npcs;

bool testing = true;
int NumOfInstances = 0;
List<Humanoid> instances = new();

Console.WriteLine("NPC Generator");

if (testing == true) { NumOfInstances = 1; } 
else {
    Console.WriteLine("How many doors to generate?");
    int NumofInstances = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < NumOfInstances; i++)
{
    int Count = i + 1;
    Console.WriteLine("Generating random Instance ... ");
    Instances.Add(new Humanoid());
}
Console.WriteLine("These Instances have been generated:");
foreach (ICharacter i in Instances)
{
    Console.WriteLine("----------------------------------------");
    i.PrintCharacter();
}
Console.Read();

