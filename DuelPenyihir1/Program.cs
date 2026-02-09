Wizard wizardA = new Wizard("Furina", 20);
Wizard wizardB = new Wizard("Hu tao", 24);


Console.WriteLine("Permainan Dimulai...\n");
wizardA.ShowStats();
wizardB.ShowStats();

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardB.Heal();
//wizardA.Attack(wizardB);

string pilihan;

while (wizardA.Energi > 0 && wizardB.Energi > 0)
{
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.WriteLine("\nMasukkan pilihan anda (1/2/3/4): ");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        wizardA.Attack(wizardB);
    }
    else if (pilihan == "2")
    {
        wizardB.Attack(wizardA);
    }
    else if (pilihan == "3")
    {
        wizardA.Heal();
    }
    else if (pilihan == "4")
    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("Pilihan anda ngawur");
    }
}

Console.WriteLine("Permainan berakhir\n");
wizardA.ShowStats();
wizardB.ShowStats();

if (wizardA.Energi < wizardB.Energi)
{
    Console.WriteLine($"{wizardA.Name} memenangkan duel");
}
else
{
    Console.WriteLine($"{wizardB.Name} memenangkan duel");
}

public class Wizard
{
    //deklarasi field
    public string Name;
    public int Energi;
    public int Damage;

    //deklarasi constructor
    public Wizard(string nama, int damage)
    {
        Name = nama;
        Energi = 50;
        Damage = damage;

    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energi} \n");
    }

    public void Attack(Wizard wizardLawanOBJ)
    {
        //mengurangi energi wizarLawanOBJ sebesar damage
        wizardLawanOBJ.Energi -= Damage;
        Console.WriteLine($"{Name} menyerang {wizardLawanOBJ.Name}");
        Console.WriteLine($"sisa energi {wizardLawanOBJ.Name} adalah {wizardLawanOBJ.Energi}");
    }

    public void Heal()
    {
        Energi += 5;

        //menambah energi
        if (Energi <= 100)
        {

            Console.WriteLine($"{Name} melakukan heal! Energi meningkat menjadi {Energi}");
        }
        else
        {
            Energi = 100;
            Console.WriteLine("Sudah mencapai energi maksimum!");
        }

    }
}