using System;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using iText.Kernel.Exceptions;

namespace PresentationLayer
{
    public partial class ReportsAndQueries : Form
    {
        public ReportsAndQueries()
        {
            InitializeComponent();
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                string reportContent = "Este es un informe de ejemplo\n";
                reportContent += "Datos de consulta:\n";
                reportContent += queryResultsTextBox.Text;

                GeneratePdfReport(reportContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneratePdfReport(string content)
        {
            string fileName = $"Reporte_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string relativePath = @"..\..\..\resources\Reportes";
            string filePath = Path.Combine(relativePath, fileName);

            try
            {
                // Asegurarse de que el directorio existe
                Directory.CreateDirectory(relativePath);

                using (var writer = new PdfWriter(filePath))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        using (var document = new Document(pdf))
                        {
                            document.Add(new Paragraph(content));
                        }
                    }
                }

                MessageBox.Show($"Reporte generado con éxito: {filePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (PdfException pdfEx)
            {
                MessageBox.Show($"Error de iText al generar el PDF: {pdfEx.Message}\nDetalles: {pdfEx.StackTrace}", "Error de PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"Error de E/S al generar el reporte: {ioEx.Message}\nDetalles: {ioEx.StackTrace}", "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                MessageBox.Show($"Error de acceso al generar el reporte: {uaEx.Message}\nDetalles: {uaEx.StackTrace}", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al generar el reporte: {ex.Message}\nDetalles: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}