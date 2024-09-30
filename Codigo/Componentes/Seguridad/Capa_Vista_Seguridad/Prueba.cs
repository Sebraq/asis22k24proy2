using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Seguridad
{
    public partial class Prueba : Form
    {
        public Prueba(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "codigo", "nombre", "linea", "marca", "existencia", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("50");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("producto");
            navegador1.AsignarComboConTabla("linea", "codigo_linea", "nombre_linea", 1);
            navegador1.AsignarComboConTabla("marca", "codigo_marca", "nombre_marca", 1);
            navegador1.AsignarForaneas("linea", "nombre_linea", "codigo_linea", "codigo_linea");
            navegador1.AsignarForaneas("marca", "nombre_marca", "codigo_marca", "codigo_marca");
            navegador1.AsignarNombreForm("PERROS");
        }
    }
}
