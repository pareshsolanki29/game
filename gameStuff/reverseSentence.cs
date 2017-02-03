            int temp;
            Console.WriteLine("Enter Your Sentence:")
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            int k = a.Length - 1;
            temp = k;
           for (int i = k; temp >= 0; k--)
            {
                Console.Write(a[temp] + "" + ' ');
                --temp;
            }
            Console.ReadKey();



for (int x = 2; x < 100; x++)
    {
        int isPrime = 0;
        for (int y = 1; y < x; y++)
        {
            if (x % y == 0)
                isPrime++;

            if(isPrime == 2) break;
        }
        if(isPrime != 2)
           Console.WriteLine(x);

        isPrime = 0;
    }
    Console.ReadKey();