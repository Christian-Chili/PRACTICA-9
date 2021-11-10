using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica_9___Ejercicios.Ejercicio_3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var query = from m in XElement.Load(MapPath("Productos.xml")).Element("Producto") 
                        select m
                        {
                            Codigo = (string)m.Element("Codigo"),
                            Nombre = (string)m.Element("Nombre"),
                            Precio = (string)m.Element("Precio")
                        }

            var querys = from m in XElement.Load(MapPath("Ventas.xml")).Element("Venta") 
                        select m
                        {
                            Codigo = (string)m.Element("Codigo"),
                            Cantidad = (string)m.Element("Cantidad"),
                            
                        }

            this.GridView1.DataSource = query;
            this.GridView1.DataBind();

            this.GridView2.DataSource = querys;
            this.GridView2.DataBind();
        }

           public class Producto
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


    }
}