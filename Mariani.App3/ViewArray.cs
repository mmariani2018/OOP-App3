using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App3
{
    class ViewArray
    {
        public ViewArray()
        {
           
            

        }
        
        public void showArray(PrimativeNode[] thePrimativeArray)
        {
            InputOutput io = new InputOutput();
            String outputString = "";
           

            for (int n = 0; n < thePrimativeArray.Length; n++)
            {
                outputString += thePrimativeArray[n].getNumber() + "\n";
            }

            io.showMessage("\nthe elements in this array are:\n" + outputString);

            
        }
        public void showStringArray(StringNode[] theStringArray)
        {
            InputOutput io = new InputOutput();
            String outputString = "";


            for (int n = 0; n < theStringArray.Length; n++)
            {
                outputString += theStringArray[n].getName() + "\n";
            }

            io.showMessage("\nthe elements in this array are:\n" + outputString);


        }
        public void showAbstractArray(AbstractNode[] theAbstarctArray)
        {
            InputOutput io = new InputOutput();
            String outputString = "";


            for (int n = 0; n < theAbstarctArray.Length; n++)
            {
                outputString += theAbstarctArray[n].getFirstName() + "\n";
            }

            io.showMessage("\nthe elements in this array are:\n" + outputString);


        }

    }
}
