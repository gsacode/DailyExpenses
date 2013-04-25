using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Windows.Storage;

namespace Tim.UI.Phone.Model
{
    public class Model
    {
        /// <summary>
        /// The database path.
        /// </summary>
        private string dbPath;

        /// <summary>
        /// The sqlite connection.
        /// </summary>
        private SQLiteConnection dbConn;

        public SQLiteConnection DbConn
        {
            get {
                if(dbConn == null)
                    dbConn = new SQLiteConnection(Path.Combine(ApplicationData.Current.LocalFolder.Path, "expense.sqlite"));
                return dbConn; 
            }
            set { dbConn = value; }
        }

        public Model()
        {
            dbConn = new SQLiteConnection(Path.Combine(ApplicationData.Current.LocalFolder.Path, "expense.sqlite"));
            CreateTables();
        }

        private void CreateTables()
        {
            if (dbConn.GetTableInfo("Expense") == null)
            {
                dbConn.CreateTable<Expense>();
            }
        }
    }
}
