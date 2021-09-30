using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App3
{
    class PrimativeNode
    {
        //define a node
        private int Number;
        //deafult constructor
        public PrimativeNode() { }
        //set and get node attributes
        public bool setNumber(int i)
        {
            if (i > -1 )
            {
                Number = i;
            }
            return true;
        }
        public int getNumber()
        {
            return Number;
        }

      
    }
}
