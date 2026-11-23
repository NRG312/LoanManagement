using LoanManagementApp.Models;
using System.Text.Json;

namespace LoanManagementApp.Managers
{
    internal class SaveData
    {
        private static readonly string pathSave = Path.Combine(AppContext.BaseDirectory, "Data");

        public static DateTime lastRun { get; private set; }
        public static List<Category> ?categories { get; private set; } = new List<Category>();
        public static void Save<Data>(string fileName,Data data)
        {
            Directory.CreateDirectory(pathSave);
            string json = JsonSerializer.Serialize(data);
            string filePath = Path.Combine(pathSave, fileName);
            File.WriteAllText(filePath, json);
        }
        private static T? Load<T>(string fileName)
        {
            string filePath = Path.Combine(pathSave, fileName);
            if (!File.Exists(filePath)) return default(T);
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(json);
        }

        public static void Load()
        {
            categories = Load<List<Category>>("Categories.json");
        }
    }


//    I w SaveData:

//private static readonly string dataPath =
//    Path.Combine(AppContext.BaseDirectory, "Data");

//    Przed zapisem:

//Directory.CreateDirectory(dataPath);

//i potem:

//string path = Path.Combine(dataPath, fileName);
//    File.WriteAllText(path, json);

//Wtedy:

//SaveData.Save("loans.json", loans);

//automatycznie trafi do:

//...\Data\loans.json






    //    Jeżeli zapisujesz zwykłe tekstowe dane:

    //internal static class SaveData
    //    {
    //        public static void Save(string fileName, string data)
    //        {
    //            File.WriteAllText(fileName, data);
    //        }

    //        public static string Load(string fileName)
    //        {
    //            return File.ReadAllText(fileName);
    //        }
    //    }

    //    Wtedy:

    //SaveData.Save("lastRun.txt", DateTime.Now.ToString());

    //a odczyt:

    //string data = SaveData.Load("lastRun.txt");

    //    Ale w Twoim programie z Loan poszedłbym krok dalej i użył JSON.

    //    Wtedy możesz zapisywać całe obiekty:


    //    SaveData.Save("loan.json", loan);

    //    i:

    //Loan loan = SaveData.Load<Loan>("loan.json");

    //    W środku SaveData używasz System.Text.Json:

    //internal static class SaveData
    //    {
    //        public static void Save<T>(string fileName, T data)
    //        {
    //            string json = JsonSerializer.Serialize(data);
    //            File.WriteAllText(fileName, json);
    //        }

    //        public static T Load<T>(string fileName)
    //        {
    //            string json = File.ReadAllText(fileName);
    //            return JsonSerializer.Deserialize<T>(json)!;
    //        }
    //}

    //To jest właśnie generyczność(T) — metoda nie musi wiedzieć, czy dostaje Loan, DateTime, List<Loan> itd.

    //Przykładowo:

    //SaveData.Save("lastRun.json", DateTime.Now);
    //SaveData.Save("loans.json", loans);
    //SaveData.Save("settings.json", settings);

    //A potem:

    //DateTime lastRun = SaveData.Load<DateTime>("lastRun.json");

    //    List<Loan> loans = SaveData.Load<List<Loan>>("loans.json");

    //    Settings settings = SaveData.Load<Settings>("settings.json");










}
