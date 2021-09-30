namespace Arrays
{
    class OrderStringArray
    {
        private Node[] arrayToOrder;
        private Node[] orderedArray;
        private int indexOfInsertIntoOrderedArray = 0;

        public OrderStringArray(Node[] theArray)
        {
            arrayToOrder = theArray;
            orderedArray = new Node[arrayToOrder.Length];

            orderArray();
        }

        private void orderArray()
        {
            int smallestLeft;
            bool moreElementsToMove;

            //for the number of elements in arrayToOrder
            for (int n = 0; n < orderedArray.Length; n++)
            {
                //find the element number of smallest element in arrayToOrder
                smallestLeft = locateIndexOfSmallestElementStillInArray();

                if (smallestLeft > -1)
                {
                    //place that element in the first available element of orderedArray
                    moreElementsToMove = putElementInorderedArrayInOrder(smallestLeft);

                    if (!moreElementsToMove)
                    {
                        arrayToOrder = orderedArray;

                        return;
                    }
                }
            }

            //point arrayToOrder to orderedArray
            arrayToOrder = orderedArray;
        }

        private bool putElementInorderedArrayInOrder(int smallestLeft)
        {
            orderedArray[indexOfInsertIntoOrderedArray] = arrayToOrder[smallestLeft];
            arrayToOrder[smallestLeft] = null;

            if (++indexOfInsertIntoOrderedArray >= orderedArray.Length)
                return false;
            else
                return true;
        }


        private int locateIndexOfSmallestElementStillInArray()
        {
            int elementSmallestNodeName = 0;

            //find the index of first element that is not null
            while (arrayToOrder[elementSmallestNodeName] == null)
            {
                elementSmallestNodeName++;

                //every element in the array is null
                if (elementSmallestNodeName >= arrayToOrder.Length)
                    return -1;
            }

            //at least one element in the array is not null
            for (int n = elementSmallestNodeName + 1; n < arrayToOrder.Length; n++)
            {
                if (arrayToOrder[n] != null && arrayToOrder[n].getFirstName().CompareTo(arrayToOrder[elementSmallestNodeName].getFirstName()) < 0)
                    elementSmallestNodeName = n;
            }

            return elementSmallestNodeName;
        }

        public Node[] getOrderedArray()
        {
            return orderedArray;
        }
    }
}
