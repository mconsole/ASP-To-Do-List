using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_To_Do_List.Models;

namespace ASP_To_Do_List
{
    public static class GlobalVariables
    {
        public static List<ListItem> ListItems { get; set; }
            = new List<ListItem>();
    }
}