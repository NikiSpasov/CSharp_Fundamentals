
public class Cat
{

    //какви характеристики да има обекта:
    public int Age { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public bool isAsleep { get; set; }

    //какво поведение да има обекта (с методи):

    public string SayMiau()
    {
        return $"Hi, I am {Name} and i'm {Age} years old! And, of course, Miaaauu";
    }
    public void GoToSleep()
    {
        isAsleep = true;
    }
    public void Awake()
    {
        isAsleep = false;
    }
}
