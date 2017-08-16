using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Diagnostics.Trace.TraceInformation("My trace statement");
        System.Diagnostics.Trace.TraceWarning("My warning statement");
        System.Diagnostics.Trace.TraceError("My error statement");
    }
}