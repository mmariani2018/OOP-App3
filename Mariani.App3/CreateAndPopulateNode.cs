using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App3
{
    class CreateAndPopulateNode
    {  
        PrimativeNode temp = new PrimativeNode();
        StringNode otherTemp = new StringNode();
        AbstractNode thirdTemp = new AbstractNode();
        
        public CreateAndPopulateNode()
        {
            //This can only be ran one line at a time
            //populatePrimativeNode(temp);
            //populateStringNode(otherTemp);
            //populateAbstractNode(thirdTemp);
           
        }
        private void populateAbstractNode(AbstractNode thirdTemp)
        {
            String tempName;
            bool flag = false;
            InputOutput IO = new InputOutput();

            //populate node attributes
            do
            {
                tempName = IO.getSomething("please input the name for this node");

                flag = thirdTemp.setFirstName(tempName);
            } while (!flag);
        }

        public AbstractNode getAbstractNode()
        {
            return thirdTemp;
        }
        private void populateStringNode(StringNode otherTemp)
        {
            String tempName;
            bool flag = false;
            InputOutput IO = new InputOutput();

            //populate node attributes
            do
            {
                tempName = IO.getSomething("please input any string");

                flag = otherTemp.setName(tempName);
            } while (!flag);
        }
        public StringNode getStringNode()
        {
            return otherTemp;
        }

        private void populatePrimativeNode(PrimativeNode number)
        { 
            String tempNumber;
            bool success;
        
            InputOutput IO = new InputOutput();

            do
            {
                tempNumber = IO.getSomething("Enter a number");

                success  =int.TryParse(tempNumber, out int validNumber);
                temp.setNumber(validNumber);
              
            } while (success == false);           

           
           
        }
        public PrimativeNode getPrimativeNode()
        {
            return temp;
        }

    }
}
