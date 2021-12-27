using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lan12._2
{
    class PromotionEvent
    {
        public string message;
        public int n;
        public PromotionEvent(string s, int c)
        {
            message = s;
            n = c;
        }
        public PromotionEvent(string s)
        {
            message = s;
        }
        public override string ToString()
        {
            return $"{message}";
        }
    }
}
