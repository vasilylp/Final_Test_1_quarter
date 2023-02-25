// Задача. Написать программу которая создает новый массив строк в который входят те элементы 
//из заданного массива строк, длинна которых меньше либо равна 3 символам;
//==========================================================================================

//------------1. Создаем новый массив из элементов, длинна которых < = 3 символам----------

string[] FillArrayMinLanght(string[] arr)
{
              int shortWord = 3;

              var list = new List<string>(); // Так как длинна нового массива не известна, сначала создаем список
              int j = 0;

              for (int i = 0; i < arr.Length; i++)
              {

                            if (arr[i].Length <= shortWord)
                            {
                                          list.Add(arr[i]); // добавляем элементы в список
                                          j++;
                            }
              }
              var arrShortWord = list.ToArray(); // создаем новый массив из полученного списка
              return arrShortWord;
}
// ------------2. Выводим новый массив на печать ------------------------------
void PrintArray(string[] arr)
{
              System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

//-----------------------------------------------------------------------------

string[] arrWord = { "Hello", "2", "world", ":-)" };
string[] array = FillArrayMinLanght(arrWord);
PrintArray(array);

string[] arrWord2 = { "1234", "1567", "-2", "computer science" };
string[] array2 = FillArrayMinLanght(arrWord2);
PrintArray(array2);

string[] arrWord3 = { "Russia", "Denmark", "Kazakstan"};
string[] array3 = FillArrayMinLanght(arrWord3);
PrintArray(array3);