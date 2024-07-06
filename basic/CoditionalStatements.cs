using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class CoditionalStatements
    {
        static void Main(string[] args){
        int myInt = 5;
        int mySecondInt = 10;

        if (myInt > mySecondInt)
        {
            myInt += 10;
        }

        Console.WriteLine(myInt);

        string myCow = "cow";
        string myCapitalizedCow = "Cow";
        
        if(myCow == myCapitalizedCow){
            Console.WriteLine("Equal");
        }else if(myCow == myCapitalizedCow.ToLower()){
            Console.WriteLine("equal without case sensitive");
        }else{
            Console.WriteLine("not Equal");
        }

        switch(myCow)
        {
            case "cow":
                Console.WriteLine("Lower Case");
                break;
            case "Cow":
                Console.WriteLine("Upper Case");
                break;
            default:
                Console.WriteLine("default ran");
                break;
        }
    }
}