//int number = 4;

//if(number % 2 == 0)
//{
//    Console.WriteLine("cut ededdir");
//}
//else
//{
//    Console.WriteLine("tek ededdir");
//}

//ternary
//string result = number % 2 == 0 ? "cut ededdir" : "tek ededdir";
//Console.WriteLine(result);
//Console.WriteLine("Bir ad daxil edin:");
//string name = Console.ReadLine();
//Console.WriteLine("Daxil etdiyiniz ad: " + name);
//Console.WriteLine("Ay daxil edin:");
//int month = int.Parse(Console.ReadLine());

//string result = String.Empty;
//switch (month)
//{
//    case 1:
//        result = "Yanvar";
//        break;
//    case 2:
//        result = "Fevral";
//        break;
//    case 3:
//        result = "Mart";
//        break;
//    default:
//        result = "Bashqa bir ay...";
//        break;
//}

//string result = month switch
//{
//    1 => "Yanvar",
//    2 => "Fevral",
//    3 => "Mart",
//    _ => "Bashqa bir ay..."
//};

//Console.WriteLine(result);

//int number = 3;

//string result = number switch
//{
//    > 0 => "Musbetdi",
//    < 0 => "Menfidir",
//    _ => "sifirdir"
//};

//Console.WriteLine(result);

//if (month == 1)
//{
//    Console.WriteLine("Yanvar");
//}
//else if (month == 2)
//{
//    Console.WriteLine("Fevral");
//}
//else if (month == 3)
//{
//    Console.WriteLine("Mart");
//}
//else
//{
//    Console.WriteLine("Bashqa bir ay...");
//}




//for (int i = 0; i < 10; i++)
//{
//    if (i % 2 != 0)
//        continue;

//   Console.WriteLine(i);
//}

//int i = 20;

//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 10);

//while (i < 10)
//{
//    Console.WriteLine(i);
//    i++;
//}

//while (true)
//{
//    Console.WriteLine("Bir eded daxil edin:");
//    int number = int.Parse(Console.ReadLine());
//    if (number % 2 == 0)
//    {
//        Console.WriteLine("cut ededdir");
//        break;
//    }

//    Console.WriteLine("tek ededdir");
//}

//int[] numbers = new int[3];

//numbers[0] = 5;
//numbers[1] = 6;
//numbers[2] = 3;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//string[] names = new string[4];

//names[0] = "Mehemmed Ali";
//names[1] = "Kenan";
//names[2] = "Xedice";

//for (int i = 0; i < names.Length; i++)
//{
//    //if (names[i] is null)
//    //    names[i] = "Nezrin";
//    //names[i] = names[i] ?? "Nezrin";
//    //names[i] ??= "Nezrin";

//    Console.WriteLine(names[i]);
//}

//foreach (var name in names)
//{
//    if(name == null)
//        Console.WriteLine("nulldir");
//}