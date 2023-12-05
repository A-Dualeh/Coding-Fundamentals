using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annalyn_s_Infiltration;

public class Program
{
    static void Main(string[] args)
    {
        var knightIsAwake = false;
        var archerIsAwake = true;
        var prisonerIsAwake = false;
        var petDogIsPresent = false;


        Console.WriteLine($"{QuestLogic.CanFastAttack(knightIsAwake)}");
        Console.WriteLine($"{QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake)}");
        Console.WriteLine($"{QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake)}");
        Console.WriteLine($"{QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent)}");
    }
}