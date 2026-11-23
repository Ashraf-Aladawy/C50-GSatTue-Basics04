namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            /*Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
             the second price (index 1).*/

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);

            #endregion

            #region Question 2
            /*Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.*/

            //int[,] shelfCopies = { { 3, 5 },
            //                       { 1, 4 }  };

            //Console.WriteLine(shelfCopies[1,0]);

            #endregion

            #region Question 3
            /*Write a method called PrintWelcomeMessage that takes no parameters and prints
              "Welcome to the Library!". Call it from Main*/

            //PrintWelcomeMessage();
            #endregion

            #region Question 4
            /*Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            "Clean Code".*/

            //PrintBookTitle("Clean Code");
            #endregion

            #region Question 5
            /*Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            int pages = 400; and print pages afterward. What do you expect to see, and why?*/

            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            //// I expect to see 400 because variable pages (int) is value type so it passed it to method parameter as copy of value not refrence to original value
            #endregion

            #region Question 6
            /*Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
             with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
             see, and why?*/

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            //// I expect to see 20.5 because variable prices (double[]) is reference type so it passed it to method parameter as reference to original value so method access the original array and subtracts 5 from its first element

            #endregion

            #region Question 7
            /*Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            Call it and print pages afterward. How is the result different from question 5?
            */

            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            //// The result is different from question 5 is here passed variable pages as reference type,
            //// so method access the original variable and adds 50 to its value

            #endregion

            #region Question 8
            /*Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
           afterward.*/

            //double[] prices = { 10,20,30,40,50.5,60 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);

            #endregion

            #region Question 9
            /*Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it
            and print the price if found*/

            bool isFound = TryGetPrice("Clean Code", out double price);
            if (isFound)
            {
                Console.WriteLine(price);
            }
            #endregion
        }



        #region method of Question 3
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion

        #region method of Question 4
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        #endregion

        #region method of Question 5
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        #endregion

        #region method of Question 6
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        #endregion

        #region method of Question 7
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
        #endregion

        #region method of Question 8
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion

        #region method of Question 9
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;

            }
            else
            {
                price = 0;
                return false;
            }

        }
        #endregion
    }
}

