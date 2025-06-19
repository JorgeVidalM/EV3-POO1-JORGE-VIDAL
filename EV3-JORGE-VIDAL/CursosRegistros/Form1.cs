using System;
using System.Linq;
using System.Windows.Forms;
using CursosRegistros.Data;
using CursosRegistros.Models;

namespace RegistroCursos
{
    public partial class Form1 : Form
    {
        AppDbContext db = new AppDbContext();
        int? idSeleccionado = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.Database.EnsureCreated();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = db.Estudiantes.ToList();


        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(tbxNOMBRES.Text) ||
                string.IsNullOrWhiteSpace(tbxAPELLIDOPAT.Text) ||
                string.IsNullOrWhiteSpace(tbxAPELLIDOMAT.Text) ||
                !long.TryParse(tbxRUT.Text, out _) ||
                !int.TryParse(tbxNMATRICULA.Text, out _) ||
                string.IsNullOrWhiteSpace(tbxCURSO.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios y deben tener un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var nuevo = new Estudiante
            {
                Nombres = tbxNOMBRES.Text,
                ApellidoPaterno = tbxAPELLIDOPAT.Text,
                ApellidoMaterno = tbxAPELLIDOMAT.Text,
                Rut = long.Parse(tbxRUT.Text),
                NumeroMatricula = int.Parse(tbxNMATRICULA.Text),
                Curso = tbxCURSO.Text
            };

            db.Estudiantes.Add(nuevo);
            db.SaveChanges();
            MessageBox.Show("Registro añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
            LimpiarCampos();
        }

        private void tbxBUSCAR_TextChanged(object sender, EventArgs e)
        {
            string filtro = tbxBUSCAR.Text.ToLower();
            var filtrados = db.Estudiantes
                              .Where(e => e.Nombres.ToLower().Contains(filtro))
                              .ToList();
            dataGridView1.DataSource = filtrados;
        }

        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            if (!idSeleccionado.HasValue)
            {
                MessageBox.Show("Debes seleccionar un estudiante para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            var estudiante = db.Estudiantes.Find(idSeleccionado.Value);
            if (estudiante != null)
            {
                estudiante.Nombres = tbxNOMBRES.Text;
                estudiante.ApellidoPaterno = tbxAPELLIDOPAT.Text;
                estudiante.ApellidoMaterno = tbxAPELLIDOMAT.Text;
                estudiante.Rut = long.Parse(tbxRUT.Text);
                estudiante.NumeroMatricula = int.Parse(tbxNMATRICULA.Text);
                estudiante.Curso = tbxCURSO.Text;

                db.SaveChanges();
                MessageBox.Show("Registro editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                LimpiarCampos();
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (!idSeleccionado.HasValue)
            {
                MessageBox.Show("Debes seleccionar un estudiante para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var estudiante = db.Estudiantes.Find(idSeleccionado.Value);
            if (estudiante != null)
            {
                db.Estudiantes.Remove(estudiante);
                db.SaveChanges();
                MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            tbxID.Clear();
            tbxNOMBRES.Clear();
            tbxAPELLIDOPAT.Clear();
            tbxAPELLIDOMAT.Clear();
            tbxRUT.Clear();
            tbxNMATRICULA.Clear();
            tbxCURSO.Clear();
            idSeleccionado = null;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                idSeleccionado = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var est = db.Estudiantes.Find(idSeleccionado);
                if (est != null)
                {
                    tbxNOMBRES.Text = est.Nombres;
                    tbxAPELLIDOPAT.Text = est.ApellidoPaterno;
                    tbxAPELLIDOMAT.Text = est.ApellidoMaterno;
                    tbxRUT.Text = est.Rut.ToString();
                    tbxNMATRICULA.Text = est.NumeroMatricula.ToString();
                    tbxCURSO.Text = est.Curso;
                }
            }





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
