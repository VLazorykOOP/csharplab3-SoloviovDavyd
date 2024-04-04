using System;

class Money
{
    // Поля
    protected int nominal; // номінал купюри
    protected int num;     // кількість купюр

    // Конструктор
    public Money(int nominal, int num)
    {
        this.nominal = nominal;
        this.num = num;
    }

    // Методи
    // Вивести номінал і кількість купюр
    public void Print()
    {
        Console.WriteLine($"Номінал: {nominal}, Кількість: {num}");
    }

    // Визначити, чи вистачить коштів на купівлю товару на суму N гривень
    public bool CanBuy(int amount)
    {
        return amount <= (nominal * num);
    }

    // Визначити, скільки шт товару вартості N гривень можна придбати на наявні грошові кошти
    public int CalculateQuantity(int amount)
    {
        return amount / nominal;
    }

    // Властивості
    // Дозволяє отримати-встановити значення полів
    public int Nominal
    {
        get { return nominal; }
        set { nominal = value; }
    }

    public int Num
    {
        get { return num; }
        set { num = value; }
    }

    // Дозволяє розрахувати суму грошей
    public int TotalAmount
    {
        get { return nominal * num; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання
        Money wallet = new Money(100, 5); // Створюємо гаманець з 5 купюрами номіналом 100 гривень

        // Виводимо інформацію про гаманець
        Console.WriteLine("Інформація про гаманець:");
        wallet.Print();

        // Перевіряємо, чи можемо купити товар на 700 гривень
        int amountToBuy = 700;
        Console.WriteLine($"\nЧи можна купити товар на {amountToBuy} гривень? {wallet.CanBuy(amountToBuy)}");

        // Розраховуємо кількість товару, яку можна купити на 700 гривень
        Console.WriteLine($"Кількість товару, яку можна купити за {amountToBuy} гривень: {wallet.CalculateQuantity(amountToBuy)}");

        // Змінюємо значення купюр у гаманці
        wallet.Num = 10;

        // Виводимо інформацію про гаманець після зміни кількості купюр
        Console.WriteLine("\nІнформація про гаманець після зміни кількості купюр:");
        wallet.Print();

        // Виводимо загальну суму грошей у гаманці
        Console.WriteLine($"\nЗагальна сума грошей у гаманці: {wallet.TotalAmount} гривень");
    }
}
