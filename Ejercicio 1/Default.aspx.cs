using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica_9___Ejercicios.Ejercicio_1
{
    public partial class Ejercicio6 : System.Web.UI.Page
    {
        protected void Page_Load(string value)
        {
            var ven = GetVenta();
            var query = new List<Venta>(); foreach (var m in ven)

            {
                if (m.Codigo == value) query.Add(m);
            }

            this.GridView1.DataSource = query;
            this.GridView1.DataBind();

        }

        public List<Productos> GetProductos()
        {
            return new List<Productos>
            {
                new Productos { Codigo = "01" ,  Nombre = "TV" , Precio = 1500},
                new Productos { Codigo = "02" ,  Nombre = "PC" , Precio = 3500},
            };
        }

        public List<Venta> GetVenta()
        {
            return new List<Venta>
            {
                new Venta { Codigo = "01" ,  Cantidad = 12 },
                new Venta { Codigo = "02" ,  Cantidad = 2},
            };
        }

        public class Productos
        {
            public String Codigo { get; set; }
            public String Nombre { get; set; }
            public int Precio { get; set; }

        }

        public class Venta
        {
            public String Codigo { get; set; }
            public int Cantidad { get; set; }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string valor = TextBox1.Text;
            Page_Load(valor);
        }
    }
}