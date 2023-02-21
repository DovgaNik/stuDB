using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stuDB
{
    public class Item
    {
        Item(int Id, int Price, String Name, String Desctiption, int UnitsAvailable) {

            id = Id;
            price = Price;
            name = Name;
            description= Desctiption;
            unitsAvailable= UnitsAvailable;
        
        }

        private int id;
        private int price;
        public String? name;
        public String? description;
        public int unitsAvailable;

        int getId() {

            return id;
        
        }
        int getPrice() { 
        
            return  price;

        }
        void setPrice(int value) { 
        
            price = value;
        
        }

    }
}
