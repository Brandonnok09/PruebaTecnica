using PersonaCurp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CurpValidator;

namespace PersonaCurp
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            getPersonas();                      
            
        }

        public void getPersonas()
        {
            using (ContextPersona db = new ContextPersona())
            {
                var lst = from p in db.Persona select p;
                data_Personas.DataSource = lst.ToList();
                
            }
        }

        private void btn_Nueva_Click(object sender, EventArgs e)
        {            
            FormNuevaPersona form = new FormNuevaPersona();
            form.ShowDialog();
            getPersonas();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt16(data_Personas.Rows[data_Personas.CurrentRow.Index].Cells[0].Value.ToString());

            if (id != null)
            {
                FormNuevaPersona form = new FormNuevaPersona(id);
                form.ShowDialog();
                getPersonas();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt16(data_Personas.Rows[data_Personas.CurrentRow.Index].Cells[0].Value.ToString());

            if (id != null)
            {
                using (ContextPersona db = new ContextPersona())
                {
                    Persona p = db.Persona.Find(id);
                    db.Persona.Remove(p);
                    db.SaveChanges();
                }
                getPersonas();
            }
        }
    }
}
