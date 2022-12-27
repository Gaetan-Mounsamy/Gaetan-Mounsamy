using System.Data;
using System.Data.OleDb;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\gaeta\Desktop\Fun\rage.xlsx";
            string worksheet = "Feuil1$";

            var dataSet = Initialisation.GetDataSetFromExcelFile(file);
            Fonction.InsertData(file, worksheet);

        }
        
    }
}