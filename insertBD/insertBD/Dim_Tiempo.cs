﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertBD
{
    public partial class Dim_Tiempo : Form
    {
        public Dim_Tiempo()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            ConexionDW a=new ConexionDW();
            a.Abrir();
            if(a.registrosTiempo()<1){                           
                btn_generar.Visible = false;
                button1.Visible = false;
                label2.Visible = true;
                progreso.Visible = true;
                tiempo_DW tiempoDW = new tiempo_DW();
                progreso.Value = 0;
                tiempoDW.GenerarFecha(progreso);
                MessageBox.Show("Dim Tiempo Generada Correctamente", "Fechas");
                label2.Text = "Dim Tiempo Generada correctamente";
                progreso.Visible = false;
                button1.Visible = true;
             }else{
                MessageBox.Show("La Dimencion Tiempo debe estar vacia para poder Insertar");
            }
            a.Cerrar();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu a = new menu();
            this.Hide();
            a.Show();
        }
    }
}
