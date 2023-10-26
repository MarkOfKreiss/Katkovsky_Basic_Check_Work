using System.Reflection.Metadata.Ecma335;

string[] Unsorted = new string[7] {"hdy%", "^5", ":):", "yyytttrre", "r", "", "09876567576"};
//string[] Unsorted = new string[1] {"hdyuu"};
string[] Sorted;

Filter(Unsorted, out Sorted);
ShowArr(Sorted);

void Filter (string[] NotFiltered, out string[] Filtered) {
    int len = NotFiltered.Length;
    int n = 0;
    string[] tempArray = new string[len];

    for(int i = 0; i < len; i++) {
        if (NotFiltered[i].Length <= 3) {
            tempArray[n] = NotFiltered[i];
            n++;
        }
    }

    if (n == 0) {
        Filtered = new string[1];
    } else {
        Filtered = tempArray[0..n];
    }
}

void ShowArr (string[] Array) {
    int len = Array.Length;
    Console.WriteLine();
    Console.Write("[");
    if(Array[0] != null) {
        Console.Write("\"" + Array[0] + "\"");
    }
    for(int i = 1; i < len; i++) {
        Console.Write(", \"" + Array[i] + "\"");
    }
    Console.Write("]");
}
