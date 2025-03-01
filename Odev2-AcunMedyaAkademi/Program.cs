
        // 1. Ödevb
        Console.Write("sayı girin: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int x = number; x > 0; x /= 10)
        {
            sum += x % 10;
        }
        Console.WriteLine("sayıların toplamı: " + sum);

        // 2. Ödev
        int userInput;
        do
        {
            Console.Write("10 ile 100 arasında bir sayı gir: ");
            userInput = int.Parse(Console.ReadLine());
        } while (userInput < 10 || userInput > 100);
        Console.WriteLine("sayı: " + userInput);

        // 3. Ödev
        int[] ages = { 5, 15, 25, 70 };
        foreach (int age in ages)
        {
            if (age <= 12) Console.WriteLine(age + " : Çocuk");
            else if (age <= 19) Console.WriteLine(age + " : Genç");
            else if (age <= 64) Console.WriteLine(age + " : Yetişkin");
            else Console.WriteLine(age + " : Yaşlı");
        }

        // 4. ödve
        int[] numbers = { 1, 2, 3, 2, 4, 5, 1 };
        var duplicates = numbers.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine("Tekrar eden sayılar: " + string.Join(", ", duplicates));

        // 5. ödev
        string[] words = { "elma", "armut", "çilek", "karpuz" };
        string shortest = words.OrderBy(w => w.Length).First();
        string longest = words.OrderByDescending(w => w.Length).First();
        Console.WriteLine($"En kısa kelime: {shortest}, En uzun kelime: {longest}");

        // 6. ödev
        Console.Write("Bir cümle gir: ");
        string sentence = Console.ReadLine();
        string[] sentenceWords = sentence.Split(' ').OrderBy(w => w).ToArray();
        Console.WriteLine("Sıralı kelimeler: " + string.Join(", ", sentenceWords));

        // 7. ÖDev
        List<string> dynamicList = new List<string> { "a", "b" };
        dynamicList.Add("c");
        Console.WriteLine("Genişletilmiş dizi: " + string.Join(", ", dynamicList));

        // 8. ödev
        List<string> userWords = new List<string>();
        Console.Write("Bir kelime gir: ");
        userWords.Add(Console.ReadLine());
        userWords.Reverse();
        Console.WriteLine("Tersten yazdırma: " + string.Join(", ", userWords));

        // 9. Ödev
        List<int> randomNumbers = new List<int>();
        Console.Write("Kaç sayı gireceksiniz: ");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.Write("Sayı girin: ");
            randomNumbers.Add(int.Parse(Console.ReadLine()));
        }
        randomNumbers.Sort();
        Console.WriteLine("Sıralı sayılar: " + string.Join(", ", randomNumbers));

        // 10. Ödev
        randomNumbers.RemoveAll(n => n < 10);
        Console.WriteLine("10dan küçükler silindi: " + string.Join(", ", randomNumbers));

        // 11. ödev
        List<int> grades = new List<int> { 40, 55, 30, 80, 45 };
        grades = grades.Select(g => g < 50 ? 50 : g).ToList();
        Console.WriteLine("Güncellenmiş notlar: " + string.Join(", ", grades));
