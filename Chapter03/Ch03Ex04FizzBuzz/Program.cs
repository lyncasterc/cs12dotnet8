
for (int i = 1; i <= 100; i++)
{
   bool isDivisibleBy3 = i % 3 == 0;
   bool isDivisibleBy5 = i % 5 == 0;
   string message = "";

   if (isDivisibleBy3 && isDivisibleBy5)
   {
      message = "fizzbuzz";
   }
   else if (isDivisibleBy3)
   {
      message = "fizz";
   } else if (isDivisibleBy5)
   {
      message = "buzz";
   }
   else
   {
      message = i.ToString();
   }


   message += (i < 100 ? ", " : "");
   
   Console.Write(message);
}