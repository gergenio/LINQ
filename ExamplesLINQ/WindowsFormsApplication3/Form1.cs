using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        List<Persona> lPersona = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lPersona.Add(new Persona("Pepe",15));
            lPersona.Add(new Persona("Maria",20));
            lPersona.Add(new Persona("Juan", 30));
            lPersona.Add(new Persona("Jose", 18));
            lPersona.Add(new Persona("Pedro", 40));
            lPersona.Add(new Persona("Mario", 30));

            foreach (Persona p in lPersona)
            {
                textBox1.Text += p.Nombre + " " + p.Edad + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Lista = lPersona.OrderBy(c => c.Edad);
            string mensaje="";
            foreach (Persona p in Lista)
            { 
                mensaje += p.Nombre + " " + p.Edad + "\n";
            }
            MessageBox.Show(mensaje, "Orden ascendente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Lista = lPersona.OrderByDescending(c => c.Edad);
            string mensaje = "";
            foreach (Persona p in Lista)
            {
                mensaje += p.Nombre + " " + p.Edad + "\n";
            }
            MessageBox.Show(mensaje, "Orden descendente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Lista = lPersona.Where(c => c.Edad >20);
            string mensaje = "";
            foreach (Persona p in Lista)
            {
                mensaje += p.Nombre + " " + p.Edad + "\n";
            }
            MessageBox.Show(mensaje, "Mayores de 20");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var Lista = from persona in lPersona
            //            where persona.Nombre.Length > 4
            //            select persona;
            string mensaje = "";

            var Lista = lPersona.Where(c => c.Nombre.Length > 4 & c.Edad > 20).OrderBy(c => c.Edad);
            foreach (Persona p in Lista)
            {
                mensaje += p.Nombre + " " + p.Edad + "\n";
            }
            MessageBox.Show(mensaje, "Mayores de 20");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lPersona.Where(c => c.Nombre.Length > 4 & c.Edad > 20).OrderBy(c => c.Edad);
            MessageBox.Show(lPersona.Sum(c=> c.Edad).ToString(), "Mayores de 20");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lPersona.Max(c => c.Edad).ToString());
        }
    }
}
