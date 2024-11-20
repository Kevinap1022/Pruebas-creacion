using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int puntajeAlice = 0;
        int puntajeBob = 0;
        
        if(a[0] > b[0]){
            puntajeAlice += 1;
        }
        else{
           puntajeBob += 1;
        }
        
        if(a[1] == b[1]){
           puntajeBob += 0;
           puntajeAlice += 0;
           
           
        }else{
        if(a[1] < b[1]){
            puntajeBob += 1;
        }
        else{
            puntajeAlice += 1; 
        }
        }



        if(a[2] < b[2]){
            puntajeBob += 1;
        }
        else{
            puntajeAlice += 1; 
        }

        
        List<int> ListaPuntaje = new List<int>();
        ListaPuntaje.Add(puntajeAlice);
        ListaPuntaje.Add(puntajeBob);
        
        return ListaPuntaje;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
