using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU_DR_CSHRP
{
    class Vehicle
    {
        private int makeKey;
        private string makeName;
        private int modelKey;
        private string modelName;
        public int vehicleYear { get; set; }

        public Vehicle()
        {
            makeKey = 0;
            makeName = "";
            modelKey = 0;
            modelName = "";
        }

        public int getMakeKey()
        {
            return makeKey;
        }
            
        public void setMakeKey(int mKey)
        {
            this.makeKey = mKey;
        }

        public string getMakeName()
        {
            return makeName;
        }

        public void setMakeName(string name)
        {
            this.makeName = name;
        }

        public int getModelKey()
        {
            return modelKey;
        }

        public void setModelKey(int mKey)
        {
            this.modelKey = mKey;
        }

        public string getModelName()
        {
            return modelName;
        }

        public void setModelName(string name)
        {
            this.modelName = name;
        }


    }
}
