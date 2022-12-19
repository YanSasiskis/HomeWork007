using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        Console.WriteLine("Hello");
        Console.WriteLine("Enter the year your account was opened");
        account.FirstYear = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the month your account was opened");
        account.FirstMonth = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the day your account was opened");
        account.FirstDay = Convert.ToInt32(Console.ReadLine());
        account.PrintAccountAge();

        Console.WriteLine("Enter your balance");
        account.Balance = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter annual interest");
        account.Procent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("After what period of time do you want to see your balance?(years)");
        account.IntervalOfYears = Convert.ToInt32(Console.ReadLine());
        account.PrintBalanceAfterTime();
        Console.ReadKey();              
    }
}
class BankAccount
{
    private int _procent;
    private int _sum;
    private int _balanceAfterTime;
    private int _balance;
    private int _firstYear;
    private int _firstMonth;
    private int _firstDay;
    private int _daysWithUs;
    private int _intervalOfYears;
    private int _temp;
    
    public int Procent
    {
        set
        {
            _procent = value;
        }
        get
        {
            return _sum;
        }
    }
    public int Sum
    {
        set
        {
            _sum = value;
        }
        get
        {
            return _sum;
        }
    }
    public int Balance
    {
        set
        {
            _balance = value;
        }
        get
        { 
            return _balance; 
        }
    }
    public int BalanceAfterTime
    {
        set
        {
            _balanceAfterTime = value;
        }
        get
        {
            return _balanceAfterTime;
        }
    }
    public int FirstYear
    {
        set
        {
            _firstYear = value;
        }
    }
    public int FirstMonth
    {
        set
        {
            _firstMonth = value;
        }
    }
    public int FirstDay
    {
        set
        {
            _firstDay = value;
        }
    }
    public int DaysWithUs
    {
        set
        {
            _daysWithUs = value;
        }
        get
        {
            return _daysWithUs;
        }
    }
    public int IntervalOfYears
    {
        set
        {
            _intervalOfYears = value;
        }
    }

    public int AccountAge()
    {
        DateTime first = new DateTime(_firstYear, _firstMonth, _firstDay);
        DateTime last = DateTime.Now; 

        TimeSpan daysWithUs = last.Subtract(first);
        _daysWithUs = daysWithUs.Days;  // зоч тут дейс писать после точки не понял....
        return _daysWithUs;
    }
    public void PrintAccountAge()
    {
        AccountAge();
        Console.WriteLine("Your account age is: {0}\n", _daysWithUs);
    }
    public int CalculateTheAmountInTime()   // Напомни как работают методы, а точнее как правильно было бы написать эту задачу.
                                            // (забыл как сделать передаваемый метод  через параметр)
    {
        for (int i = 0; i < _intervalOfYears; i++)   
        {
            _temp += _balance / 100 * _procent;  // считал вклад без учета капитализации.
        }
        _balanceAfterTime += _temp + _balance;  
        return _balanceAfterTime;
    }
    public void PrintBalanceAfterTime()
    {
        CalculateTheAmountInTime();
        Console.WriteLine("After {0} years you will get {1}",_intervalOfYears,_balanceAfterTime);
    }
}
/*
    Создайте программу в которой создайте класс «Банковский Счет».
    В теле класса создайте следующие поля: дата открытия счета, процентная ставка по счету, 
    сумма счета. В теле метода создайте следующие методы: Метод, который рассчитывает 
    количество дней, начиная с даты открытия счета; Метод который выводит информацию о 
    количестве рассчитанных дней; Метод который рассчитывает сумму, которая будет на счете 
    через определенное количество лет (количество лет – параметр метода); Метод который 
    выводит информацию о сумме. Также продумать над конструктором класса. В методе Main() 
    создайте экземпляр класса «Банковский Счет», присвойте всем полям значение через свойства 
    доступа, а также на экземпляр класса вызовите методы для отображения количества дней и 
    суммы.
*/