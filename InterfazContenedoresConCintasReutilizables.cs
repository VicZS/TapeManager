using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapeManager
{
    public partial class InterfazContenedoresConCintasReutilizables : Form
    {
        public InterfazContenedoresConCintasReutilizables()
        {
            InitializeComponent();
        }

        private void btnRegresarInterfazContenedoresEnviados_Click(object sender, EventArgs e)
        {
            var principal = this.ParentForm as MenuPrincipal;
            if (principal != null)
            {
                principal.AbrirInterfaz(new InterfazContenedoresEnviados());
            }
        }
    }
}
