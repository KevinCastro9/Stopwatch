// See https://aka.ms/new-console-template for more information
using Stopwatch;
using static System.Runtime.InteropServices.JavaScript.JSType;

try
{
    var start = new Start();
    
    while (true)
    {
        try
        {
            start.Menu();
        }
        catch (Exception Erro)
        {
            Console.WriteLine("Ocorreu o erro: " + Erro.ToString() + ". Durante a operação, por gentileza tente novamente!!!");
        }
    }
}
catch(Exception ex)
{

}







