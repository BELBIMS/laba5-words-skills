// Определение базового класса Animal
public class Animal
{
    public string food; // Питание животного
    public string location; // Местоположение животного
    public string name; // Имя животного

    // Виртуальный метод для издания звука
    public virtual void MakeNoise()
    {
        Console.WriteLine("Животное издает звук.");
    }

    // Виртуальный метод для кормления животного
    public virtual void Eat()
    {
        Console.WriteLine("Животное кушает.");
    }

    // Метод для сна животного
    public void Sleep()
    {
        Console.WriteLine("Животное спит.");
    }
}

// Класс Dog наследуется от Animal
public class Dog : Animal
{
    public string breed; // Порода собаки

    // Переопределенный метод для лаяния собаки
    public override void MakeNoise()
    {
        Console.WriteLine("Собака лает.");
    }

    // Переопределенный метод для кормления собаки костью
    public override void Eat()
    {
        Console.WriteLine("Собака ест кость.");
    }
}

// Класс Cat наследуется от Animal
public class Cat : Animal
{
    public string gender; // Пол кошки

    // Переопределенный метод для мяуканья кошки
    public override void MakeNoise()
    {
        Console.WriteLine("Кошка мяучит.");
    }

    // Переопределенный метод для кормления кошки рыбой
    public override void Eat()
    {
        Console.WriteLine("Кошка ест рыбу.");
    }
}

// Класс Horse наследуется от Animal
public class Horse : Animal
{
    public string color; // Цвет лошади

    // Переопределенный метод для ржания лошади
    public override void MakeNoise()
    {
        Console.WriteLine("Лошадь ржет.");
    }

    // Переопределенный метод для кормления лошади сеном
    public override void Eat()
    {
        Console.WriteLine("Лошадь ест сено.");
    }
}

// Класс для ветеринара
public class Veterinarian
{
    // Метод для лечения/обработки животного
    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine($"Корм: {animal.food}, Локация: {animal.location}");
    }
}

class Program
{
    static void Main()
    {
        // Создание объектов собаки, кошки и лошади
        Dog dog = new Dog();
        dog.food = "Кость";
        dog.location = "конура";
        dog.breed = "Такса";

        Cat cat = new Cat();
        cat.food = "Рыба";
        cat.location = "квартира";
        cat.gender = "кошка";

        Horse horse = new Horse();
        horse.food = "Сено";
        horse.location = "ферма";
        horse.color = "Белая";

        Veterinarian vet = new Veterinarian();

        // Вызов метода TreatAnimal для каждого животного
        vet.TreatAnimal(dog);
        vet.TreatAnimal(cat);
        vet.TreatAnimal(horse);
    }
}