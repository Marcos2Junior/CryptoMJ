using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMJ
{
    public class ListBase64Factory
    {
        public int Lenght { get; private set; }
        public int Interval { get; private set; }
        public ListBase64Factory(int lenght, int interval)
        {
            Lenght = lenght;
            Interval = interval;
        }

        public List<string> Create()
        {
            string caracteresbase64 = "E2oy5sxb1agn+TMqi4Lplc8tB76YmGRWFwDzjZrXK9AhQd=UJ/CI3VNOuHfP0evSk";
            List<string> list = new List<string>();
            for (int i = 0; i < Lenght; i++)
            {
            }

            return list;
        }
    }
}
