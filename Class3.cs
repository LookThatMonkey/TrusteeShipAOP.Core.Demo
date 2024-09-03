using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class Class3
    {
        public int a1 = 0;

        public void SetA1(int a1)
        {
            this.a1 = a1;
            if (this.a1 == 1)
            {
                MessageBox.Show("觸發了");
            }
        }
        public int GetA1()
        {
            return a1;
        }







        private int _a2 = 0;
        public int a2
        {
            get
            {
                return _a2;
            }
            set
            {
                _a2 = value;
                if (this._a2 == 1)
                {
                    MessageBox.Show("觸發了");
                    //log
                    //STATUS
                    //check
                }
            }
        }



        public int a { get; set; } = 0;

        public void aaaa()
        {
            a2 = 1;
            a2 = 2;
            a1 = 3;
        }
    }
}
