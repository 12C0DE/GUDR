using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU_DR_CSHRP
{
    class Category
    {
        private int category_key;
        private string category_name;
        private static int catRowCount;

        public Category()
        {
            category_key = 0;
            category_name = "New Category";
        }

        public int getCatKey()
        {
            return category_key;
        }

        public void setCatKey(int catkey)
        {
            this.category_key = catkey;
        }

        public string getCatName()
        {
            return category_name;
        }

        public void setCatName(string catname)
        {
            string newName;

            newName = catname.Replace("'", "");

            category_name = newName;
        }
        public static int getCatRowCount()
        {
            return catRowCount;
        }

        public static void increaseCatRowCount()
        {
            catRowCount++;
        }

        public static void resetCatRowCount()
        {
            catRowCount = 0;
        }
    }

    class SubCategory : Category
    {
        private int subCategory_key;
        private string subCategory_Name;

        public SubCategory()
        {
            subCategory_key = 0;
            subCategory_Name = "New Subcategory";
        }

        public int getSubCatKey()
        {
            return subCategory_key;
        }
        public void setSubCatKey(int subkey)
        {
            subCategory_key = subkey;
        }

        public string getSubCatName()
        {
            return subCategory_Name;
        }
        public void setSubCatName(string subName)
        {
            string newName;

            newName = subName.Replace("'", "");
            subCategory_Name = newName;
        }
    }
}
