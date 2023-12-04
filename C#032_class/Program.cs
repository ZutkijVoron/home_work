// Исходный массив
char[] chars = { 'a', 'b', 'c', 'd' };

// Первый способ:
// string str = new string(chars);

// Второй способ: 
// string str = string.Join("", chars);

// Третий способ:
string str = string.Concat<char>(chars);

//Четвертый способ:
// string str = "";
// for (var i = 0; i < chars.Length; i++)
// {
//     str += chars[i];
// }

System.Console.WriteLine(str);