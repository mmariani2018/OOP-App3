using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App3
{
    class CreateArray
    {
        ViewArray view = new ViewArray();
        public CreateArray()
        {
            /*
            PrimativeNode[] thePrimativeArray = createThePrimativeArray();
            populateThePrimativeArray(thePrimativeArray);

            view.showArray(thePrimativeArray);
            */
            /*
            int numElements = determineNumberOfElementsInTheArray();
            StringNode[] theStringArray = createStringArray(numElements);
            populateTheStringArray(theStringArray);

            view.showStringArray(theStringArray);
            */
            
            int elements = determineNumberOfElementsInTheArray();
            AbstractNode[] theAbstarctArray = createAbstractArray(elements);
            populateTheAbstractArray(theAbstarctArray);

            view.showAbstractArray(theAbstarctArray);
            

            
        }
        private void showTheArray(PrimativeNode[] thePrimativeArray, StringNode[] theStringArray, AbstractNode[] theAbstarctArray)
        {
            ViewArray view = new ViewArray();
        }
       

        private void populateTheAbstractArray(AbstractNode[] theAbstarctArray)
        {
            AbstractNode temp;

            for (int n = 0; n < theAbstarctArray.Length; n++)
            {
                //create each element
                CreateAndPopulateNode cpn = new CreateAndPopulateNode();
                temp = cpn.getAbstractNode();

                //add each element to the array
                theAbstarctArray[n] = temp;
            }
        }
        private AbstractNode[] createAbstractArray(int elements)
        {
            //create array with proper number of elements
            return new AbstractNode[elements];
        }
        
        private void populateThePrimativeArray(PrimativeNode[] thePrimativeArray)
        {
            PrimativeNode temp;
            
          
            for(int n=0; n< thePrimativeArray.Length; n++)
            {
                CreateAndPopulateNode cpn = new CreateAndPopulateNode();
                temp =  cpn.getPrimativeNode();

                thePrimativeArray[n] = temp; 
            }

        }
            
        private PrimativeNode[] createThePrimativeArray()
        {
            //create array with proper number of elements
            return new PrimativeNode[3];
        }
        private void populateTheStringArray(StringNode[] theStringArray)
        {
            StringNode temp;

            for (int n = 0; n < theStringArray.Length; n++)
            {
                //create each element
                CreateAndPopulateNode cpn = new CreateAndPopulateNode();
                temp = cpn.getStringNode();

                //add each element to the array
                theStringArray[n] = temp;
            }
        }
        private StringNode[] createStringArray(int numElements)
        {
            //create array with proper number of elements
            return new StringNode[numElements];
        }


        private int determineNumberOfElementsInTheArray()
        {
            int tempNumber;

            //determine how many elements
            InputOutput IO = new InputOutput();
            do
            {
                String temp = IO.getSomething("how many elements will be in this array?");

                try
                {
                    tempNumber = Convert.ToInt32(temp);
                }
                catch
                {
                    tempNumber = -1;
                }
            } while (tempNumber < 1);

            return tempNumber;
        }
    }
}
