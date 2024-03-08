namespace Kiosk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Items();
            Console.ReadLine();
        }

        static void Items()
        {
            //variables
            double itemsPrice = 0;
            double total = 0;
            int count = 1;
            string input = "y";
            string checkout = "";
            bool continuedInput = true;


            itemsPrice = InputDouble($"Item {count}: $ ");
            total = total + itemsPrice;
            count++;
            checkout = Console.ReadKey(true).KeyChar.ToString().ToLower();
            if (checkout == "n" || checkout == "\r")
            {
                continuedInput = false;
            }
            //contiues the ring up process. ends when n is hit instead.
            while (continuedInput == true)
            {
                itemsPrice = InputDouble($"Item {count}: $ ");
                total = total + itemsPrice;
                count++;
                checkout = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (checkout == input)
                {
                    continuedInput = true;
                }
                else
                {
                    continuedInput = false;

                }//end if 
            }//end while


            if (total > 200.00)
            {
                Console.WriteLine("Low Change, would you like to pay another way?");
            }
            else
            {
                Payment(total);
            }



        }
        static void Payment(double total)
        {
            #region Variables
            double change = 0;
            double notes = 0;
            double remaining = 0;
            double remaingDue = 0;
            string pay = "y";
            string readyToPay = "";
            bool paymentReady = false;
            double oneCent = 0.01;
            double fiveCent = 0.05;
            double tenCent = 0.10;
            double twentyFiveCent = 0.25;
            double dollar = 1.00;
            double five = 5.00;
            double ten = 10.00;
            double twenty = 20.00;
            double hundred = 100.00;
            #endregion

            Console.WriteLine("Are you ready to enter payment: y/n;");
            readyToPay = Console.ReadKey(true).KeyChar.ToString().ToLower();

            if (readyToPay == pay)
            {
                paymentReady = true;
                Console.WriteLine($"Total is {total}");
            }//end 
            remaining = total;
            while (paymentReady == true && remaining > 0.00)
            {
                notes = InputDouble("Please enter payment: $ ");
                if (notes >= hundred)
                {
                    remaining = remaining - notes;
                    remaingDue = remaining;
                    if (remaingDue >= 0.01)
                    {
                        Console.WriteLine($"You have ${remaingDue} balence due.");
                    }
                }
                else if (notes >= twenty)
                {
                    remaining = remaining - notes;
                    remaingDue = remaining;
                    if (remaingDue >= 0.01)
                    {
                        Console.WriteLine($"You have ${remaingDue} balence due.");
                    }

                }
                else if (notes >= ten)
                {
                    remaining = remaining - notes;
                    remaingDue = remaining;
                    if (remaingDue >= 0.01)
                    {
                        Console.WriteLine($"You have ${remaingDue} balence due.");
                    }
                }
                else if (notes >= five)
                {
                    remaining = remaining - notes;
                    remaingDue = remaining;
                    if (remaingDue >= 0.01)
                    {
                        Console.WriteLine($"You have ${remaingDue} balence due.");
                    }
                }
                else if (notes >= dollar)
                {
                    remaining = remaining - notes;
                    remaingDue = remaining;
                    if (remaingDue >= 0.01)
                    {
                        Console.WriteLine($"You have ${remaingDue} balence due.");
                    }
                }
                else if (notes >= twentyFiveCent)
                {
                    remaining = remaining - notes;
                    remaingDue = remaining;
                    if (remaingDue >= 0.01)
                    {
                        Console.WriteLine($"You have ${remaingDue} balence due.");
                    }
                }
                else if (notes >= tenCent)
                {
                    remaining = remaining - notes;
                    remaingDue = remaining;
                    if (remaingDue >= 0.01)
                    {
                        Console.WriteLine($"You have ${remaingDue} balence due.");
                    }
                }
                else if (notes >= fiveCent)
                {
                    remaining += remaining - notes;
                    remaingDue = remaining;
                    if (remaingDue >= 0.01)
                    {
                        Console.WriteLine($"You have ${remaingDue} balence due.");
                    }
                }
                else if (notes >= oneCent)
                {
                    remaining = remaining - notes;
                    remaingDue = remaining;
                    if (remaingDue >= 0.01)
                    {
                        Console.WriteLine($"You have ${remaingDue} balence due.");
                    }
                }//end if;
            }//end while

            if (notes > remaining)
            {
                if (remaining < 0)
                {
                    remaining *= -1;
                }
                change = notes - remaining;
            }//end if

            if (change >= 0.01)
            {
                Console.WriteLine($"Change: ${change}");
                RetainedCash(change);
            }//end if 


        }//end function

        static void RetainedCash(double change)
        {
            //Variables
            bool hasChange = change > 0.01;
            double moneyGiven = 0;
            #region Money types
            const double _oneCent = 0.01;
            const double _fiveCent = 0.05;
            const double _tenCent = 0.10;
            const double _twentyFiveCent = 0.25;
            const double _one = 1.00;
            const double _twos = 2.00;
            const double _five = 5.00;
            const double _ten = 10.00;
            const double _twenty = 20.00;
            const double _fifty = 50.00;
            const double _hundred = 100.00;
            #endregion
            //Finds the amount of change ex: if change is 200
            //it finds to give 2 $100 bills
            double hundreds = (double)(change / _hundred);
            double fiftis = (double)((change % _hundred) / _fifty);
            double twenty = (double)(((change % _hundred) % _fifty) / _twenty);
            double ten = (double)((((change % _hundred) % _fifty) % _twenty) / _ten);
            double five = (double)(((((change % _hundred) % _fifty) % _twenty) % _ten) / _five);
            double two = (double)((((((change % _hundred) % _fifty) % _twenty) % _ten) % _five) / _twos);
            double one = (double)(((((((change % _hundred) % _fifty) % _twenty) % _ten) % _five) % _twos) / _one);



            while (hasChange)
            {
                if (change >= 100)
                {
                    Console.WriteLine("Dispensed $100");
                    change = change - 100;
                }
                if (change >= 50)
                {
                    Console.WriteLine("Dispensed $50");
                    change -= 50;
                }
                if (change >= 20)
                {
                    Console.WriteLine("Dispensed $20");
                    change -= 20;
                }
                if (change >= 10)
                {
                    Console.WriteLine($"Dispensed $10");
                    change -= 10;
                }
                if (change >= 5)
                {
                    Console.WriteLine($"Dispensed $5");
                    change -= 5;
                }
                if (change >= 2)
                {
                    Console.WriteLine($"Dispensed $2");
                    change -= 2;
                }
                if (change >= 1)
                {
                    Console.WriteLine($"Dispensed $1");
                    change -= 1;
                }
                if (change == 0.00)
                {
                    hasChange = false;
                }
            }
        }

        #region HELPER FUNCTIONS
        static string Input(string message)
        {
            System.Console.Write(message);
            return Console.ReadLine();
        }//end function

        static double InputDouble(string message)
        {
            string value = Input(message);
            return double.Parse(value);
        }//end function
        #endregion
    }
}