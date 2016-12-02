using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_To_Do_List.Models;

namespace ASP_To_Do_List.Models
{
    public class ListItem
    {
        public string Item;
        public string Date;

        public static void Create(string TaskName, string DueDate)
        {
            var ListItem = new ListItem();
            ListItem.Item = TaskName;
            ListItem.Date = DueDate;

            GlobalVariables.ListItems.Add(ListItem);
        }

        public static List<ListItem> GetAll()
        {
            return GlobalVariables.ListItems;
        }
    }
}