using static System.Console;
using projeto_dotnet.src.Entities;


Knight arus = new Knight("Arus", 23, "Knight");
WhiteWizard jennica = new WhiteWizard("Jennica", 23, "white wizard");
BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard");
Ninja wedge = new Ninja("Wedge", 43, "Ninja");

WriteLine($@"{arus.Attack()}
{jennica.Attack(1)}
{jennica.Attack(7)}
{topapa.Attack()}
{wedge.Attack()}");

