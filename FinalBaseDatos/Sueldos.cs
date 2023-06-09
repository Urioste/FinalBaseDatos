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
    public partial class Sueldos : Form
    {
        private Finanzas fin;
        

        public Sueldos()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            fin = new Finanzas();
            fin.Show();
            this.Close();
        }

        private void busca_Click(object sender, EventArgs e)
        {
            Conexion db = new Conexion();
            SqlConnection conexion = db.ConexionDb();
            SqlCommand comm = new SqlCommand("ReporteSueldos", conexion);
            int numeroMes;
            int actual = DateTime.Now.Year;
            if (cmbMes.Text != "" && cmbEncargados.Text != "" && año.Text != ""  && int.Parse(año.Text) >= 2023 && int.Parse(año.Text) < actual+1)
            {
                try
                {
                    //cambiendo de char a int
                    switch (cmbMes.Text.ToLower())
                    {
                        case "enero":
                            numeroMes = 1;
                            break;
                        case "febrero":
                            numeroMes = 2;
                            break;
                        case "marzo":
                            numeroMes = 3;
                            break;
                        case "abril":
                            numeroMes = 4;
                            break;
                        case "mayo":
                            numeroMes = 5;
                            break;
                        case "junio":
                            numeroMes = 6;
                            break;
                        case "julio":
                            numeroMes = 7;
                            break;
                        case "agosto":
                            numeroMes = 8;
                            break;
                        case "septiembre":
                            numeroMes = 9;
                            break;
                        case "octubre":
                            numeroMes = 10;
                            break;
                        case "noviembre":
                            numeroMes = 11;
                            break;
                        case "diciembre":
                            numeroMes = 12;
                            break;
                        default:
                            numeroMes = -1;
                            break;
                    }
                    //Mostrando la tabla

                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@insertarmes", numeroMes);
                    comm.Parameters.AddWithValue("@insertarencargado", cmbEncargados.Text);
                    comm.Parameters.AddWithValue("@insertaraño", año.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Datos.DataSource = dt;
                    comm.Dispose();
                    comm.Parameters.Clear();

                    //Mostrando el Total
                    comm.CommandText = "SUELDOMES";
                    SqlParameter resultado = new SqlParameter("@resultadoSueldo", System.Data.SqlDbType.Money);
                    resultado.Direction = System.Data.ParameterDirection.Output;


                    comm.Parameters.Add(resultado);
                    comm.Parameters.AddWithValue("@insertarmes", numeroMes);
                    comm.Parameters.AddWithValue("@insertarencargado", cmbEncargados.Text);
                    comm.Parameters.AddWithValue("@insertaraño", año.Text);
                    comm.ExecuteNonQuery();

                    Total.Text = $"El total a pagar al encargado {cmbEncargados.Text} es: ";
                    monto.Text = $"{resultado.Value}";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correspondientes por favor...");
            }
            
            conexion.Close();
            comm.Dispose();
        }

        private void encargado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 