﻿using FinalBaseDatos.Models;
using System;
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
    public partial class ConsumoMenu : Form
    {
        private Consumos consumos;
        private Tablainfantes tablainfantes;

        public ConsumoMenu()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consumos = new Consumos();
            consumos.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlCommand comm = new SqlCommand("InsertarConsumoMenu", conexion);
            if(NroMatricula.Text != "" && cmbMenu.Text != "")
            {
                try
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@NroMatricula", NroMatricula.Text);
                    comm.Parameters.AddWithValue("@NroMenu", cmbMenu.Text);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Se ha ingresado el consumo con exito...");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos por favor....");
            }

            comm.Dispose();
            conexion.Close();
            consumos = new Consumos();
            consumos.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ver_Click(object sender, EventArgs e)
        {
            tablainfantes = new Tablainfantes();
            tablainfantes.Show();

        }
    }
}
