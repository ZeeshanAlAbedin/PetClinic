using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTest1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Global Declaration
        static int item_count;
        String a;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void add_item(object sender, EventArgs e) {
            ++item_count;
            /*Converting Integer to String Error Here*/
            a = item_count.ToString();
            _ItemCount.Text = a;
        }
    }
}