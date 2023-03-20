string IsMessageToUser(string messageToUser){
    Console.WriteLine(messageToUser);
    string answer = Console.ReadLine();
    return answer;
}

 int  IsCharacters(string arr){
    int  array = arr.Length;
    int charact = 0;
    for (int i = 0; i < array; i++){
                if ((arr[i] != ' ') && (arr[i] != '.') && (arr[i] != ',')){
                    charact++;
                }
            }
    return array;
}


string array1 = IsMessageToUser("Введите первую часть массива");
string array2 = IsMessageToUser("Введите вторую часть массива");
string array3 = IsMessageToUser("Введите третью часть массива");

Console.Write($"Ваш массив строк [{string.Join("; ", array1, array2, array3)}]->");

int arr1 = IsCharacters(array1);
int arr2 = IsCharacters(array2);
int arr3 = IsCharacters(array3);
if(arr1 <= 3) Console.Write($" [{string.Join("; ", array1)}]");
if(arr2 <= 3) Console.Write($" [{string.Join("; ", array2)}]");
if(arr3 <= 3) Console.Write($" [{string.Join("; ", array3)}]");
else Console.Write($"[]");

Console.ReadLine();