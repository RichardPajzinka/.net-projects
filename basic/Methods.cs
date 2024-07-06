using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Methods
    {
         static void Main(string[] args){
        int[] intsToCompress = new int[] {10,15,20,25,30,35,12};

        DateTime startTime = DateTime.Now;

        int totalValue = 0;
        startTime = DateTime.Now;
        for(int i = 0; i < intsToCompress.Length; i++){
           totalValue += intsToCompress[i];
        }
        Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
        Console.WriteLine(totalValue);

        //sam si najde čo to je a prida to ako novu premennu
        foreach(int intFroCompression in intsToCompress){
            totalValue += intFroCompression;
        }

        //Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
        Console.WriteLine(totalValue);


        int index = 0;
        while(index < intsToCompress.Length){
            index++;
            totalValue += intsToCompress[index];
            
        }
        Console.WriteLine(totalValue);

        do{
            totalValue += intsToCompress[index];
            index++;
        }while(index < intsToCompress.Length);
        Console.WriteLine(totalValue);

    } 

    static private int GetSum(int[] intsToCompress){

        int totalValue = 0;
        //int[] intsToCompress = new int[] {10,15,20,25,30,35,12};

        foreach(int intFroCompression in intsToCompress){
            totalValue += intFroCompression;
        }
            return totalValue;
        
    }
    }
}