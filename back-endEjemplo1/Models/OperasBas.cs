using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_endEjemplo1.Models
{
    public class OperasBas
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int res { get; set; }

        public void Suma()
        {
            this.res = this.num1 + this.num2;
        }

        public void Resta()
        {
            this.res = this.num1 - this.num2;
        }
    }
}