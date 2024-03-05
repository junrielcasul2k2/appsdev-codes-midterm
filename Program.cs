 

double homePrice = InputValues("Price of the Home    >>    ");

double interestRate = InputValues("Interest Rate        >>    ");

double downPaymentPercentage = InputValues("Percentage as Down Payment   >>    ");


double downPayment = DownPayment(homePrice, downPaymentPercentage);

double financedAmount = FinancedAmount(homePrice, downPayment);

double monthlyPayment = monthlyPayment1(interestRate, financedAmount);

double totalInterest = TotalInterest(monthlyPayment, homePrice);



Display(downPayment, totalInterest, monthlyPayment, financedAmount);

 
static double InputValues(string prompt)
{
    Console.Write(prompt);
    return Convert.ToDouble(Console.ReadLine());
}

static double DownPayment(double homePrice, double downPaymentPercentage)
{
    return homePrice * (downPaymentPercentage / 100);
}

static double monthlyPayment1(double InterestRate, double FinanceAmount)
{
    double month = 30 * 12;
    double rate = (InterestRate / 100) / 12;

    return (( rate + rate / (( Math.Pow((1 + rate), month)) - 1)) * FinanceAmount );
}
static double FinancedAmount(double homePrice, double downPayment)
{
    return homePrice - downPayment;
}

static double TotalInterest(double monthlyPayment, double homePrice)
{
    double month = 30 * 12;
    
    return (monthlyPayment * month) - homePrice;

}

static void Display(double downPayment, double totalInterest, double monthlyPayment, double financeAmount)
{
    Console.WriteLine($"Down Payment       :       ${downPayment:F2}");
    Console.WriteLine($"Amount Financed    :       ${financeAmount:F2}");
    Console.WriteLine($"Monthly Payment    :       ${monthlyPayment:F2}");
    Console.WriteLine($"Total Interest     :       ${totalInterest:F2}");

}
 

