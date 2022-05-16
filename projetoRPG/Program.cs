
using projetoRPG.Entities;

Knight hero = new Knight("Arus", 23, "Knight");
Wizard wizard = new Wizard("Jenica", 23, "White Wizard");
Ninja ninja = new Ninja("Zung", 24, "Ninja");
BlackWizard blackwizard = new BlackWizard("Zebue", 32, "BlackWizard");



Console.WriteLine(wizard.Attack(8));

Console.WriteLine(hero.Attack());

Console.WriteLine(ninja.Attack(9));

Console.WriteLine(blackwizard.Attack());