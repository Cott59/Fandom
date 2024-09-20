using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Fandom
{
    internal class DataProcesing
    {
        static private string dbname = "Fandom.db";
        static private string path = $"Data Source={dbname};";
        static private string show_Persons_data = "SELECT * FROM Persons;";
        static private string dbName = "Fandom";
        static private string tblPersonName = "Persons";
        static private string tblInfoName = "Info";
        static private string tblImagesName = "Images";
        //static private Binding binding;
       
        public static DataSet AddData()
        {
            DataSet fandom = new DataSet(dbName);
            DataTable persons = new DataTable(tblPersonName);
            // person = id (integer, primary key, autoincrement) + name (varchar)
            // integer
            DataColumn idColumn = new DataColumn("id", Type.GetType("System.Int32"));
            // уникальность - PRIMARY KEY
            idColumn.Unique = true;
            // true - может быть незаполненным - PRIMARY KEY
            idColumn.AllowDBNull = false;
            // autoincrement
            idColumn.AutoIncrement = true;
            // начало диапазона
            idColumn.AutoIncrementSeed = 100;
            // шаг
            idColumn.AutoIncrementStep = 1;
            // name
            DataColumn nameColumn = new DataColumn("name", Type.GetType("System.String"));
            // Добавляем колонки в экземпляр DataTable
            persons.Columns.Add(idColumn);
            persons.Columns.Add(nameColumn);

            // Добавления DataTable в DataSet
            fandom.Tables.Add(persons);

            // Определяем поле Primary Key
            persons.PrimaryKey = new DataColumn[] { persons.Columns["id"] };
            
            // 1-ый вариант
            DataRow person = persons.NewRow();
            person.ItemArray = new object[] { null, "Doctor David Livesey" };
            persons.Rows.Add(person);
            // 2-вариант
            persons.Rows.Add(new object[] { null, "John Silver" });
            persons.Rows.Add(new object[] { null, "William \"Billy\" Bones" });
            // 3-ий вариант
            //object[,] personsArray = { { 104, "Andrew \"Black Dog\"" }, { 105, "Blind David Pew" }, { 106, "James Hawkins" } };
            //foreach (var pers in personsArray) persons.Rows.Add(pers);
            // save fandom DataSet 
            using (SQLiteConnection conn = new SQLiteConnection(path))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(show_Persons_data, conn);
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
                adapter.Update(fandom.Tables[0]);
                //binding = new Binding("bnd", fandom, );
            }
            return fandom;
        }
        public static DataSet GetDBData()
        {
            DataSet result = new DataSet();
            using (SQLiteConnection conn = new SQLiteConnection(path))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(show_Persons_data, conn);
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
                adapter.Fill(result);
            }
            return result;
        }
        public static void SaveData2DB(DataTable dt)
        {
            using (SQLiteConnection conn = new SQLiteConnection(path))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(show_Persons_data, conn);
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
                adapter.Update(dt);
            }
        }
    }
     
}
