﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBaseDatos
{
    public partial class Factura : Form
    {
        public Factura(SqlParameter valor)
        {
            InitializeComponent();
            Total.Text = $"El total pagado es de: {valor.Value}";
        }

    }
}