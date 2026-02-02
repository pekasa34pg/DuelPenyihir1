wizard wizardA = new wizard("Furina", 20);
wizard WizardB = new wizard("Hu tao", 20);

Console.WriteLine("Permainan Dimulai...\n");
wizardA.Showstats();
WizardB.Showstats();


wizardA.attack(WizardB);
WizardB.attack(wizardA);
wizardA.attack(WizardB);

Console.WriteLine("Permainan Berakhir...\n");
wizardA.Showstats();
WizardB.Showstats();
public class wizard
{
    public string Name;
    public int Energy;
    public int Damage;

    // deklarasi constructor
     public wizard (string name,int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }
    

    public void Showstats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name},Energi: {Energy} \n");
    }



    public void attack(wizard Wizardlawanobj)
    {
        //mengurangi energi wizardlawanobj sebesar damage 
        Wizardlawanobj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {Wizardlawanobj.Name}");
        Console.WriteLine($"Sisa energi {Wizardlawanobj.Name} adalah {Wizardlawanobj.Energy}");
       }
 

}