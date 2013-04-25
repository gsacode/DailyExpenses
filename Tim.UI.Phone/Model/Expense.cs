using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Tim.UI.Phone.Model
{
    public class Expense
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        public int Amount { get; set; }
    }
}
