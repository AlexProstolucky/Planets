
internal class Program
{
    public enum Маса : ulong
    {
        Меркурій = 32868,
        Венера = 481068,
        Земля = 597600,
        Марс = 63345,
        Юпітер = 187664328,
        Сатурн = 56180376,
        Уран = 8605440,
        Нептун = 10159200,
    }
    private static bool CorrectNamePlanet(string name_planet)
    {
        bool correct = true;
        switch (name_planet)
        {
            case "Солце":
            case "Меркурій":
            case "Венера":
            case "Земля":
            case "Марс":
            case "Юпітер":
            case "Сатурн":
            case "Уран":
            case "Нептун":
                break;
            default:
                correct = false;
                break;
        }
        return correct;
    }

    private static ulong GetPlanetMass(string name_planet)
    {
        ulong mass = 0;
        switch (name_planet)
        {
            case "Меркурій":
                mass = (ulong)Маса.Меркурій;
                break;
            case "Венера":
                mass = (ulong)Маса.Венера;
                break;
            case "Земля":
                mass = (ulong)Маса.Земля;
                break;
            case "Марс":
                mass = (ulong)Маса.Марс;
                break;
            case "Юпітер":
                mass = (ulong)Маса.Юпітер;
                break;
            case "Сатурн":
                mass = (ulong)Маса.Сатурн;
                break;
            case "Уран":
                mass = (ulong)Маса.Уран;
                break;
            case "Нептун":
                mass = (ulong)Маса.Нептун;
                break;
            default:
                Console.WriteLine("Хибна назва планети!");
                break;
        }
        return mass;
    }
    private static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Для обрахунку спільної маси планет оберіть самі планети:");
        Console.WriteLine("Перелік планет:\nМеркурій\nВенера\nЗемля\nМарс\nЮпітер\nСатурн\nУран\nНептун\n");
        Console.WriteLine("Для обрання планети напишіть її у рядок, для завершення вводу напишіть 1:");
        string name;
        List<string> names = new List<string>();
        do 
        {
            name = Console.ReadLine();
            if (name == "1") break;
            if (!CorrectNamePlanet(name)) continue;
            else 
            {
                names.Add(name);
            }
        }while (true);
        ulong result = 0;
        foreach (string i in names) 
        {
            result += GetPlanetMass(i);
        }

        Console.WriteLine($"Сума планет = {result}");
    }
}