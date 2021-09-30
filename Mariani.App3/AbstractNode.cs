using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App3
{
    class AbstractNode
    {
        //define a node
        private String firstName;
        //deafult constructor
        public AbstractNode() { }
        //set and get node attributes
        public bool setFirstName(String s)
        {
            if (s != null && s.Length > 0)
            {
                firstName = s;
                return true;
            }

            return false;
        }

        public String getFirstName()
        {
            return firstName;
        }
    }
}
