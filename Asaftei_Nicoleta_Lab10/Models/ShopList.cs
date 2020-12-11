using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Asaftei_Nicoleta_Lab10.Models
{
     //salveaza fiecare lista de cumparaturi
   public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
