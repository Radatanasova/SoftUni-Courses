using System;
public class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
       
        bool isBalanced = false;
        string prevParantesis = "";
        string firstParantesis = "";

        int countLeft = 0;
        int countRight = 0; 

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            
            switch (input)
            {
                case "(":
                    if (prevParantesis=="")
                    {
                        firstParantesis = "(";
                        isBalanced = true;
                        prevParantesis = "(";
                        countLeft++;
                        break;
                    }
                    if (firstParantesis == "(" && prevParantesis == ")")
                    {
                        isBalanced = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                    prevParantesis = "(";
                    countLeft++;
                    break;
                case ")":
                    if (prevParantesis == "")
                    {
                        firstParantesis = ")";
                        prevParantesis = ")";
                        isBalanced = false;
                        countRight++;
                        break;
                    }
                    if (firstParantesis == "(" && prevParantesis == "(")
                    {
                        isBalanced = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                    prevParantesis = ")";
                    countRight++;
                    break;
            }
        }
        if (isBalanced && firstParantesis=="(" && prevParantesis == ")" && countRight == countLeft)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}