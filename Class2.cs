using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrusteeShipAOP.Core.Attribute;

namespace WindowsFormsApplication1
{

    class DemoMethodAspectAttribute : MPAspectAttribute
    {
        public override void OnEntry(object sender, AspectEventArgs args)
        {
            args.MethodName = "OnEntry " + args.MethodName + "  " + args.Params;
        }

        public override void OnExit(object sender, AspectEventArgs args)
        {
            args.MethodName = "OnExit " + args.MethodName + "  " + args.Params;
        }

        public override bool Validating(object sender, AspectEventArgs args)
        {
            return true;
        }
    }

    class DemoPropertyAspectAttribute : MPAspectAttribute
    {
        public override void OnEntry(object sender, AspectEventArgs args)
        {
            //args.MethodName = "OnEntry " + args.MethodName + "  " + args.Params;
        }

        public override void OnExit(object sender, AspectEventArgs args)
        {
            if (args.IsProperty && args.PropertyMethodType == PropertyMethodType.Set)
            {
                Form1.Instance.Text = args.Params[0].ToString();
                if ((int)args.Params[0] == 1)
                {
                    MessageBox.Show(args.Params[0].ToString());
                    MessageBox.Show(args.Params[0].ToString());
                    MessageBox.Show(args.Params[0].ToString());
                }
            }
            args.MethodName = "OnExit " + args.MethodName + "  " + args.Params;
        }

        static int aaa = 1;
        public override bool Validating(object sender, AspectEventArgs args)
        {
            //MethodInfo methodInfo = sender.GetType().GetMethod($"get_{args.MethodName.Substring(4)}", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            //object obj = methodInfo.Invoke(sender, null);
            //return (aaa++) % 2 == 0;
            return true;
        }
    }
}
