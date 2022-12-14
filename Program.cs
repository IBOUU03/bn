string test = Console.ReadLine();
string newtest ="";
for (int i = test.Length-1; i >= 0; i--)
{
    newtest += test[i].ToString();

}

string[] test1;
test1 = newtest.Split(' ');

for (int i = test1.Length-1; i >= 0; i--)
{
    Console.Write(test1[i]+" ");
}
