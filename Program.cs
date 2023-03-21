Console.WriteLine("Введите количество элементов массива");
string value = Console.ReadLine();
int size = Convert.ToInt32(value);

int count = 0;
string [] array = new string [size];

string AddMessageToUser(string messageToUser){
    Console.WriteLine(messageToUser);
    string answer = Console.ReadLine();
    if(answer.Length <= 3) count ++;
    return answer;
}

for(int i = 0; i < size; i++){
    string message = AddMessageToUser("Введите " + (i + 1) + " элемент массива");
    array [i] = message;
}

string [] result = new string [count];
Console.Write($"Ваш массив строк [{string.Join("; ", array)}]->");

count = 0;

for(int i = 0; i < size; i++){
    if(array[i].Length <= 3){
        result[count++] = array[i];
    }
}

Console.Write($" Ваш массив строк [{string.Join(", ", result)}]");