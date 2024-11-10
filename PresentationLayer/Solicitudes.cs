using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Solicitudes : Form
    {
        BL_Solicitud solicitud = new BL_Solicitud();
        public Solicitudes(string estado)
        {
            InitializeComponent();
            CargarSolicitudes(estado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (solicitudesDataGridView.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                // Obtiene los datos de la fila seleccionada
                DataGridViewRow selectedRow = solicitudesDataGridView.SelectedRows[0];
                string idSolicitud = selectedRow.Cells["ID_Solicitud"].Value.ToString();

                bool changeSolicitud = solicitud.cambiarEstadoSolicitud(idSolicitud, "2");

                if (changeSolicitud)
                {
                    solicitudesDataGridView.Refresh();
                    Solicitudes solicitudes = new Solicitudes("2");
                    Home.EmbedFormInPanel(solicitudes);

                } else
                {
                    MessageBox.Show("Error al revisar la solicitud.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud para revisar.");
            }
        }

        // Evento para cancelar solicitud
        private void button2_Click(object sender, EventArgs e)
        {
            if (solicitudesDataGridView.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                // Obtiene los datos de la fila seleccionada
                DataGridViewRow selectedRow = solicitudesDataGridView.SelectedRows[0];
                string idSolicitud = selectedRow.Cells["ID_Solicitud"].Value.ToString();

                // Aquí procesarías la lógica para cancelar la solicitud.
                MessageBox.Show("Solicitud " + idSolicitud + " cancelada.");
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud antes de cancelar.");
            }
        }

        public void CargarSolicitudes(string estado)
        {
            // Limpiar las columnas del DataGridView antes de agregar nuevas
            solicitudesDataGridView.Columns.Clear();

            // Obtener las solicitudes
            List<SolicitudDTO> solicitudes = solicitud.GetSolicitudes(estado);

            // Asignar la lista como el origen de datos
            solicitudesDataGridView.DataSource = solicitudes;

            // El índice de las columnas puede variar según el orden en que se asignan los datos
            solicitudesDataGridView.Columns["ID_Solicitud"].Width = 150;
            solicitudesDataGridView.Columns["Fecha_Solicitud"].Width = 150;
            solicitudesDataGridView.Columns["Monto_Solicitado"].Width = 150;
            solicitudesDataGridView.Columns["Periodo"].Width = 150;
            solicitudesDataGridView.Columns["Estado_Solicitud"].Width = 150;
            solicitudesDataGridView.Columns["Empleado"].Width = 150;
        }


    }
}
