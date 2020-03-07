using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partialBlanco.Forms
{
    public class Reservation
    {
        public Reservation(ref Panel parent)
        {
            Label labelNombre = new Label
            {
                Location = new System.Drawing.Point(0, 30),
                Name = "labelName",
                Text = "Nombre"
            };

            TextBox txtName = new TextBox
            {
                Location = new System.Drawing.Point(labelNombre.ClientSize.Width 
                + 40, labelNombre.Location.Y),
                Name = "txtName"
            };

            Label labelCuenta = new Label
            {
                Location = new System.Drawing.Point(0, labelNombre.Location.Y + 30),
                Name = "labelCuenta",
                Text = "Numero de cuenta"
            };


            TextBox txtCuenta = new TextBox
            {
                Location = new System.Drawing.Point(labelNombre.ClientSize.Width
                + 40, labelCuenta.Location.Y),
                Name = "txtCuenta"
            };


            Button btn = new Button
            {
                Location = new System.Drawing.Point(labelNombre.ClientSize.Width
                + 40, labelCuenta.Location.Y + 30),
                Name = "btnAgregar",
                Text = "Agregar"
            };

            btn.Click += new EventHandler(Save);

            parent.Controls.Add(labelNombre);
            parent.Controls.Add(txtName);
            parent.Controls.Add(labelCuenta);
            parent.Controls.Add(txtCuenta);
            parent.Controls.Add(btn);
        }

        public void Save(object sender, EventArgs e)
        {

        }
      }
}
