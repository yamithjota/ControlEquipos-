using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlEquipos.Models;
using ControlEquipos.Views;

namespace ControlEquipos.Views
{
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }
        #region
        public void CargarDatos()
        {
            using (controlequiposEntities1 db = new controlequiposEntities1())
            {    //Selec * from marcas m;
                //Utilizar LINKQ para escribir consultas a la BD
                var Lstmarcas = from m in db.marcas
                                select new
                                { //Trae estos datos de la BD el id y la marca
                                    id_marca = m.id_marca,
                                    nom_marca = m.nom_marca
                                };
                this.grdDatos.DataSource = Lstmarcas.ToList();
            }
            
        }
        //Captura datos 
        public marcas getSelectedItem()
        {
            marcas m = new marcas();
            try
            {
                m.id_marca = int.Parse(grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[0].Value.ToString());
                return m;

            }
            catch
            {
                return null;
            }
        }

        #endregion

        private void Marcas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (controlequiposEntities1 db = new controlequiposEntities1())
            {
                //Consutar todas las marcas 
                var Lstmarcas = from m in db.marcas
                                select new
                                { //Trae estos datos de la BD el id y la marca
                                    id_marca = m.id_marca,
                                    nom_marca = m.nom_marca
                                };
                this.grdDatos.DataSource = Lstmarcas.ToList();
                //Aplicar filtros
                if(!string.IsNullOrEmpty(this.textNombre.Text))
                {
                    Lstmarcas = Lstmarcas.Where(m => m.nom_marca.Contains(this.textNombre.Text));
                }
                //Mapear la lista con los filtros al Datagrid
                this.grdDatos.DataSource = Lstmarcas.ToList(); 
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GestionMarcas gestionMarcas = new GestionMarcas(null);
            gestionMarcas.ShowDialog();
            //Actualizar el DataGrid
            this.CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //obtener los datos que se seleccionaron en el DataGrid
            marcas m = getSelectedItem();
            //¿Hubo seleccion?
            if(m != null)
            {
                //Inicializar formulario de edición
                GestionMarcas gestionMarcas = new GestionMarcas(m.id_marca);
                //Abrir formulario
                gestionMarcas.ShowDialog();
                this.CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Obtener el registro que se va a eliminar 
            marcas m = getSelectedItem();
            //¿Hubo seleccion?
            if (m != null)
            {
                //Solicitar confirmacion para eliminar 
                if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    using (controlequiposEntities1 db = new controlequiposEntities1())
                    {
                        marcas marcaEliminar = db.marcas.Find(m.id_marca);
                        db.marcas.Remove(marcaEliminar);
                        db.SaveChanges();
                    }
                }
                this.CargarDatos();
            }
        }
    }
}
