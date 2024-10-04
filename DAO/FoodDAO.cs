using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DAO
{
    //internal class FoodDAO
    //{
    //}
    public class FoodDAO
    {
        private static FoodDAO _instance;

        public static FoodDAO Instance 
        {
               get { if (_instance == null) _instance = new FoodDAO(); return FoodDAO._instance; }
                private set { FoodDAO._instance = value; }
        }

        public List<FoodDTO> GetListFood()
        {
            List<FoodDTO> list = new List<FoodDTO>();

            string query = "Select * from Food";

            DataTable date = DataProvider.Instance.ExecuteSPDataTable(query);

            foreach (DataRow item  in   data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                list.Add(food);
            }


            return list;
        }
    }


}
