List<String> x = File.ReadAllLines("finalpassword.txt").ToList();
 
List<Tuple<string, int>> list = new();
 
list = x.Select(x => new Tuple<string, int>(x.Substring(0,1), int.Parse(x.Substring(1)))).ToList();
 
int password = 0;
int counter = 50;
int password2 = 0;
int counter2 = 50;
foreach (var item in list) {
    if (item.Item1 == "L")
    {
        counter -= item.Item2;
        for (int i = 0; i < item.Item2; i++) { 
            counter2 -= 1;
            if (counter2 % 100 == 0) {
                password2++;
            }
        }
    }
    else { 
        counter += item.Item2;
        for (int i = 0; i < item.Item2; i++)
        {
            counter2 += 1;
            if (counter2 % 100 == 0)
            {
                password2++;
            }
        }
    }
    if (counter % 100 == 0) { 
        password++;
    }
}
 
 
Console.WriteLine(password);
Console.WriteLine(password2);
