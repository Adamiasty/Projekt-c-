var number = 95452324584521;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;


foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}
    Console.WriteLine("Podana wartość to: " + number);
    Console.WriteLine("ilość 0 w podanej wartości to => " + counter0);
    Console.WriteLine("ilość 1 w podanej wartości to => " + counter1);
    Console.WriteLine("ilość 2 w podanej wartości to => " + counter2);
    Console.WriteLine("ilość 3 w podanej wartości to => " + counter3);
    Console.WriteLine("ilość 4 w podanej wartości to => " + counter4);
    Console.WriteLine("ilość 5 w podanej wartości to => " + counter5);
    Console.WriteLine("ilość 6 w podanej wartości to => " + counter6);
    Console.WriteLine("ilość 7 w podanej wartości to => " + counter7);
    Console.WriteLine("ilość 8 w podanej wartości to => " + counter8);
    Console.WriteLine("ilość 9 w podanej wartości to => " + counter9);

// kod się buduje ale średnio z tego rozwiązania jestem zadowolony