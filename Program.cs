string[] ArrayOfStringsInput = new string[] {"Saturday", ":)", "sun", "abcdefg", "qwerty", "o"};//задали массив в начале алгоритма
string[] NewArray = new string [6]; //создали новый массив под подходящие под условие элементы
int len = 6;
int newindex=0;
for (int index = 0; index<len; index++)
{
        int length = ArrayOfStringsInput[index].Length; //определяем длину строки
        if (length<=3)//условие из задачи
        {
            NewArray[newindex] = ArrayOfStringsInput[index];
            newindex++;
        }
}
int count = NewArray.Length; //выводим массив
int position = 0;
while (position < count)
{
    Console.WriteLine(NewArray[position]);
    position++;
}