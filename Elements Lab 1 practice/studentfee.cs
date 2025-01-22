using System;

class studentfee
{
    static void Main()
    {
        Console.Write("Enter the student fee: ");
        double fee = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());
        
        double discount = (fee * discountPercent) / 100;
        double finalFee = fee - discount;

        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
    }
}
