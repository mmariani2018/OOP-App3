using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App3
{
    class StringNode
    {
        //define a node
        private String name;
        //deafult constructor
        public StringNode() { }
        //set and get node attributes
        public bool setName(String s)
        {
            if(s != null  && s.Length > 0)
            {
                name = s;
                return true;
            }
            return false;
        }

        public String getName()
        {
            return name;
        }
            
            }
}
