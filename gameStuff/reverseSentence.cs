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



            