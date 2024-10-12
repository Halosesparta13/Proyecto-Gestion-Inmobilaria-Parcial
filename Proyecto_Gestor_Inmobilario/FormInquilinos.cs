using Proyecto_Gestor_Inmobilario.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gestor_Inmobilario
{
    public partial class FormInquilinos : Form
    {
        public FormInquilinos()
        {
            InitializeComponent();
        }

        private void MostrarInquilinos(List<Inquilino> inquilinos)
        {
            dgInquilinos.DataSource = null;
            if(inquilinos.Count == 0)
            {
                return;
            }
            else
            {
                dgInquilinos.DataSource = inquilinos;
            }
        }
    }
}
