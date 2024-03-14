//Starting point number
int startPoint = 100000000;

// dividers of n
int[] dividers = [3, 5, 7, 9];

// lowest number superior than the startPoint with the dividers provided
int n = FindNumber(dividers);

// Storing the returned lists using collection expression introduced in C# 12 instead of explicitly declaring the whole thing (= new ...)
List<int> l = ReturnList(n);
List<string> lPrime = [..Encode(l)];

// Output the results to the console
Console.WriteLine("N = " + n);
//string.joins prints the list with values separated by a comma
Console.WriteLine("L = " + string.Join(", ", l));
Console.WriteLine("L' = " + string.Join(", ", lPrime));

// Divide numbers from the startPoint with the dividers array, will return numbers only if is a multiple
int FindNumber(int[] dividersArray)
{
    int currentNum = startPoint;
    while (true)
    {
        bool isMultiple = true;
        foreach (int divider in dividersArray)
        {
            if (currentNum % divider != 0)
            {
                isMultiple = false;
                break;
            }
        }
        if (isMultiple)
        {
            return currentNum;
        }
        currentNum++;
    }
}

//Return the provided number into a list that contain each digits separately
List<int> ReturnList(int number)
{
    List<int> list = [];
    string nString = number.ToString();
    for (int i = 0; i < nString.Length; i++)
    {
        list.Add(Convert.ToInt32(char.GetNumericValue(nString[i])));
    }
    // or using a Linq expression :
    // list.AddRange(nString.Select(t => Convert.ToInt32(char.GetNumericValue(t))));
    return list;
}

//Return a list that contains the digits associated with a key "E" when first encountered or "R" when repeated while pointing to the initial point
List<string> Encode(List<int> lPrimeList)
{
    List<string> letters = [];
    List<int> existsCheck = [];

    foreach (int value in lPrimeList)
    {
        string key = "E";
        if (existsCheck.Contains(value))
        {
            key = "R";
            letters.Add(key + (existsCheck.IndexOf(value) + 1));
        }else
        {
            letters.Add(key + value.ToString());
        }
        existsCheck.Add(value);
    }
    return letters;
}