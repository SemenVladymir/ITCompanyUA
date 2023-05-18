﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCompanyUA
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1 (ITCompanies company) : this()
        {
            this.Name.Text = company.Name;
            this.Employees.Text = company.Employees.ToString();
            this.Cities.Text = company.Cities;
            this.Lider.Text = company.Lider;
        }
    }
}
