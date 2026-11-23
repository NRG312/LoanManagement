using LoanManagementApp.Models;
namespace LoanManagementApp.Managers
{
    internal class LoanManager
    {
        private List<Category> categories = new List<Category>();

        public void AddNewCategory(Category category)
        {
            categories.Add(category);
        }
        public List<Category> GetCategories()
        {
            List<Category> getCategories = categories;
            return getCategories;
        }
        public void RemoveCategory(Category category)
        {
            categories.Remove(category);
        }


        //Form1 glowna strona
        //NewLeanForm strona po kliknieciu dodaj nowa rate
        //LoanControl prefab ktory jest dodawany jako kafelek do layoutu ze wszystkimi ratami

        //stworzenie raty
        //Form1 event guzika -> otwiera sie okno newleanform uzupelnia sie pola -> towrzy sie nowy loancontrol i przekazywany jest loan tam ktory sie inicjuje -> loanmanager dostaje loan do listy
    }
}
