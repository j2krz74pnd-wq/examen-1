//task1
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int rakam = 1;
// int max = 1;
// for (int i = 1; i < n; i++)
// {
//     if (arr[i] == arr[i - 1])
//     {
//         rakam++;
//     }
//     else
//     {
//         rakam = 1;
//     }

//     if (rakam > max)
//     {
//         max = rakam;
//     }
// }
// Console.WriteLine(max);


//task2
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i]= Convert.ToInt32(Console.ReadLine());
// }
// bool IsPalindrome = true;
// for (int i = 0; i < n / 2; i++)
// {
//     if (arr[i] != arr[n - 1 - i])
//     {
//         IsPalindrome=false;
//     }
// }
// if (IsPalindrome)
// {
//     System.Console.WriteLine("True");
// }
// else
// {
//     System.Console.WriteLine("False");
// }


//task3
// string text = Console.ReadLine();

// int vowels = 0;
// int consonants = 0;

// for (int i = 0; i < text.Length; i++)
// {
//     char c = text[i];
//     if (char.IsLetter(c))
//     {
//         char lower = char.ToLower(c);
//         if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
//         {
//             vowels++;
//         }
//         else
//         {
//             consonants++;
//         }
//     }
// }

// Console.WriteLine("Vowels: " + vowels);
// Console.WriteLine("Consonants: " + consonants);


//task4
string text = Console.ReadLine();



//task5
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int max = arr[0];
// for (int i = 1; i < n; i++)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
// }
// Console.WriteLine(max);


//task 6
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DigitRecurs(n));

// int SumDigit(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     return n % 10 + SumDigit(n/10);
// }
// int DigitRecurs(int n)
// {
//     if (n < 10)
//     {
//         return n;
//     }
//     return DigitRecurs(SumDigit(n));
// }


//task7
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// Multiply(ref a, ref b);

// void Multiply(ref int a, ref int b)
// {
//     a = a * 2;
//     b = b * 2;
// }
// Console.WriteLine("a = " + a);
// Console.WriteLine("b = " + b);


//task8
// int n = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[n];
// for (int i = 0; i < n; i++)
// {
//     a[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine(CountEvenNumbers(a));

// int CountEvenNumbers(int[] arr)
// {
//     int cnt = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             cnt++;
//         }
//     }
//     return cnt;
// }


//task9
// int n = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[n];
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//     a[i] = Convert.ToInt32(Console.ReadLine());
//     sum = sum + a[i];
// }
// double average = sum/n;
// int cnt = 0;
// for (int i = 0; i < n; i++)
// {
//     if (a[i] > average)
//     {
//         cnt++;
//     }
// }
// Console.WriteLine(cnt);


//task10
// int n = Convert.ToInt32(Console.ReadLine());
// IsRecurs(n);

// void IsRecurs(int n)
// {
//     if (n < 1)
//     {
//         return;
//     }
//     Console.Write(n + " ");
//     IsRecurs(n - 1);
// }
