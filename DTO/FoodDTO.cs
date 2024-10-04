using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    public class FoodDTO
    {

        public FoodDTO(int FoodID, string FoodName, int IdCategory, float Price)
        {
            this.FoodID1 = FoodID;
            this.FoodName1 = FoodName;
            this.IdCategory1 = IdCategory;
            this.Price1 = Price; 
        }

        public FoodDTO(DataRow row)
        {
            this.FoodID1 = (int)row["FoodID"];
            this.FoodName1 = row["FoodName"].ToString();
            this.IdCategory1 = (int)row["IdCategory"];
            this.Price1 = (float)Convert.ToDouble(row["Price"].ToString());
        }


        private string FoodName;

        private int FoodID;

        private int IdCategory;

        private float Price;

        public int FoodID1 { get => FoodID; set => FoodID = value; }
        public string FoodName1 { get => FoodName; set => FoodName = value; }
        public int IdCategory1 { get => IdCategory; set => IdCategory = value; }
        public float Price1 { get => Price; set => Price = value; }
    }


}


  
}
