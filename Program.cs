Console.WriteLine("1. Gülləni tək tək at");
Console.WriteLine("2. Güllənin hamısını birdən at");
Console.WriteLine("3. Mərmini yenidən doldur");
Console.WriteLine("4. Oyundan çıx");
Console.WriteLine("5. Mərmi sayını gösdər");
int bullet = 30;

while (true)
{
    string number = Console.ReadLine();

    while (number == "")
    {
        Console.WriteLine("Duzgun reqem daxil edin");
        string NewNumber = Console.ReadLine();
        number = NewNumber;
    }

    int num = int.Parse(number);

    CheckNum(num);
    

    if (num == 1)
    {
        
        if (bullet > 0)
        {   bullet--;
            Console.WriteLine("Gulle atildi");
        }
        else 
        {
            Console.WriteLine("3 bassaraq gulle doldur");
        }
        

    }
    else if(num == 2)
    {
        if (bullet > 0)
        {
            bullet = 0;
            Console.WriteLine("Gulle hamisi atildi");
        }
        else
        {
            Console.WriteLine("3 bassaraq gulle doldur");
        }
    }
    else if (num == 3)
    {
        bullet = 30;
        Console.WriteLine("Gulle dolduruldu");
    }
    else if (num == 4)
    {
        Console.WriteLine("Oyundan cixildi");
        return;
    }
    else if (num == 5)
    {
        Console.WriteLine(bullet + " gulleniz var");
    }   
}

    
    static void CheckNum(int check)
    {

        while (check < 1 || check > 5)
        {
            Console.WriteLine("Duzgun reqem daxil edin");
            int NewNum = int.Parse(Console.ReadLine());
            check = NewNum;
        };
    }   
    
    
    
    
    
    
    