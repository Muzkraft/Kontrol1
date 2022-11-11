string[] array = {"qwe", "12345", ":-)", "Rus", "Geek brains","Homework", "1234", "-5", "qwerty", "asd"};
Console.WriteLine(String.Join(", ", array));

string[] result = {};

for (int i = 0; i < array.Length; i++)
{
    result = Array.FindAll(array, i => i.Length <= 3).ToArray();       
}

Console.WriteLine(String.Join(", ", result));
