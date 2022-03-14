using System;
public class Program{
    
    public static string searchValue(int value,Dictionary<string,int> dict){
       
        foreach(KeyValuePair<string,int> item in dict){
            if(item.Value == value){
                return item.Key;
            }
        }

        return "Item not Find" ;

    }
    public static void Main(string[] args){
        var dict = new Dictionary<string,int>();

        dict["Atal Bihari Vajpayee"] = 1998;
        dict["Narendra Modi"] = 2014;
        dict["Manmohan Singh"] = 2004;
        Console.WriteLine("PM of {0} was : {1}",2004,searchValue(2004,dict));
        dict["Narendra Modi"] = 2019;
        Console.WriteLine("before Sorting");
        foreach (var kvp in dict){
            Console.WriteLine("{0}, {1}", kvp.Key, kvp.Value);
        }
        Console.WriteLine("after Sorting");
        dict = dict.OrderBy(x=>x.Value).ToDictionary(x=>x.Key, x=>x.Value);
        foreach (var kvp in dict){
            Console.WriteLine("{0}, {1}", kvp.Key, kvp.Value);
        }

    }
}