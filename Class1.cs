using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrusteeShipAOP.Core.Attribute;

namespace WindowsFormsApplication1
{
    [ClassAspect]
    public class Class1
    {
        public Class1(Control c)
        {
        }

        public int a1()
        {
            return default(int);
        }

        public Class1 a2()
        {
            return default(Class1);
        }

        public Point a3()
        {
            return default(Point);
        }
        
        static int s1 = 0;

        [DemoPropertyAspectAttribute]
        public int aabbc { get; set; } = 0;

        [DemoPropertyAspect]
        private int aabbc222 { get; set; } = 0;

        [DemoPropertyAspect]
        public int aabbd { get; set; } = 0;
        protected int ia = 0;
        int ic = 11;
        int ib = 22;
        [DemoPropertyAspect]
        [DemoMethodAspect]
        public void Add(int i1, int i2)
        {
            try
            {
                List<int> li = new List<int>();
                int iiiii = li[0];
                try
                {
                    AddA1();
                }
                catch (Exception ex)
                {
                }
                s1 = 2;
                ib = s1;
                aa(0, 0);
                aa2(0, 0);
            }
            catch
            {
            }
        }

        [DemoMethodAspect]
        public void AddA1()
        {
            aabbc222++;
        }
        [DemoMethodAspect]
        public void AddA12()
        {
        }
        private int aa(int i1, float f2)
        {
            return 123;
        }
        private int aadd(int i1, float f2)
        {
            throw new Exception();
        }

        public static int aa2(int i1, float f2)
        {
            return 123;
        }
    }
}
