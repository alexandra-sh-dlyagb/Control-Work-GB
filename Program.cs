string[] ArrayOfStringsInput = new string[] {"Saturday", ":)", "sun", "abcdefg", "qwerty", "o"};//задали массив в начале алгоритма
string[] NewArray = new string [6]; //создали массив под подходящие под условие элементы
int newindex=0;
for (int index = 0; index<6; index++)
{
        int length = ArrayOfStringsInput[index].Length;
        if (length<=3)
        {
            NewArray[newindex] = ArrayOfStringsInput[index];
            newindex++;
        }
}
int count = NewArray.Length;
int position = 0;
while (position < count)
{
    Console.WriteLine(NewArray[position]);
    position++;
}








//int length = ArrayOfStringsInput[index].Length;
  //  while (newindex<3)
    //{
      //  if (length<=3)//смотрим, удовлетворяет ли элемент условию
        //{
          //  NewArray[newindex] = ArrayOfStringsInput[index];//переносим элемент в новый массив
            //newindex = newindex+1;
        //}
    //}