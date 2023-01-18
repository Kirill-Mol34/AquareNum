System.Console.WriteLine("Введите первое число: ");
string writenum1=Console.ReadLine();
int num1=Convert.ToInt32(writenum1);
System.Console.WriteLine("Введите второе число: ");
string writenum2=Console.ReadLine();
int num2=Convert.ToInt32(writenum2);
string txtResult= $"Число {num1} не является квадратом числа {num2}";
if (num1==num2*num2)
{
    txtResult=txtResult.Replace("не"," ");
}
System.Console.WriteLine(txtResult);
System.Console.WriteLine();