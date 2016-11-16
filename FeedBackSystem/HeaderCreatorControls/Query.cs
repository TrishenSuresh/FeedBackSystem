﻿using System;
using System.Windows.Forms;

namespace FeedBackSystem.HeaderCreatorControls
{
    public partial class Query : UserControl
    {
        public Query()
        {
            InitializeComponent();
        }

        public string GetValue()
        {
            string sqlStatement = "";
            switch (QueryList.Text)
            {
                case "Applicant - Email":
                    sqlStatement = "SELECT Email as title FROM applicant";
                    break;
                case "Application Status":
                    sqlStatement = "SELECT StatusTitle as title FROM applicationstatus";
                    break;
                default:
                    throw new Exception("You have to make a selection!");
            }
            return sqlStatement;
        }
    }
}
