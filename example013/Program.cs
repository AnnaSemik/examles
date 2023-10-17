/*
Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить на большие "К", 
а большие "О" заменить на маленькие "о".
*/

string text = "Она несла в руках отвратительные, тревожные желтые цветы."
            + "Черт их знает, как их зовут, но они первые почему-то появляются в Москве."
            + "И эти цветы очень отчетливо выделялись на черном ее весеннем пальто."
            + "Она несла желтые цветы! Нехороший цвет. Она повернула с Тверской в переулок и тут обернулась.";

// string s = "qwerty"
//             0123
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase (text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replase (text, 'к', 'К');
System.Console.WriteLine(newText);System.Console.WriteLine();
newText = Replase (text, 'О', 'о');
System.Console.WriteLine(newText);