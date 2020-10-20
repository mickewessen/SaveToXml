using System;
using System.Collections.Generic;
using System.Text;

namespace SaveToXml.Models
{
    public class information
    {
        private string txtdata1;
        private string txtdata2;
        private int txtdata3;
        private string txtdata4;


        public string FirstName
        {
            get { return txtdata1; }
            set { txtdata1 = value; }
        }
        public string LastName
        {
            get { return txtdata2; }
            set { txtdata2 = value; }
        }
        public int Age
        {
            get { return txtdata3; }
            set { txtdata3 = value; }
        }
        public string City
        {
            get { return txtdata4; }
            set { txtdata4 = value; }
        }
    }
}
