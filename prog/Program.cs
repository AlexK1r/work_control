Console.Clear();

//Функция перебора элементов массива с проверкой на условие
void FillArray(string[] InitialArray, string[] NewArray, int LengthElement)  
{
    int index = 0;
    for (int i = 0; i < InitialArray.Length; i++)
        {
            if (InitialArray[i].Length < LengthElement)
                {
                    NewArray[index] = InitialArray[i];
                    index++;
                }
        }
}

//Функция вывода на экран 
void PrintArray(string[] InitialArray)
{
    for (int i = 0; i < InitialArray.Length; i++)
    {
        Console.Write(InitialArray[i] + " ");
    }
}

int LengthElement = 5;                                              //  размер искомых элементов (меньше указанного значения) 
string[] InitialArray = {"hello", "2", "world", ";-)", "week"};     //  начальный массив
string[] NewArray = new string[InitialArray.Length];                //  массив куда будем складывать результат

FillArray(InitialArray, NewArray, LengthElement);
PrintArray(NewArray);