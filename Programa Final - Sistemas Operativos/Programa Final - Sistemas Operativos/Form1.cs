using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

// Sistemas Operativos - Grupo 06 (Galindo_Huaccho_Lazo_Rojas)

namespace Programa_Final___Sistemas_Operativos
{
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += FrmPantallaPrincipal_KeyDown;
            this.AcceptButton = btnAgregar;
        }

        private void FrmPantallaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl == txtPeticion)
                {
                    btnAgregar.PerformClick();
                }
            }
        }

        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            lblConclusion.Visible = false;
            lblCopy.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTamaño.Clear();
            txtPosicion.Clear();
            txtPeticion.Clear();
            txtFIFO.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            dataGridView6.Rows.Clear();
            dataGridView7.Rows.Clear();
            txtFIFO.Clear();
            txtSSTF.Clear();
            txtSCAN.Clear();
            txtCSCAN.Clear();
            txtLOOK.Clear();
            txtCLOOK.Clear();
            lblResultado.Text = "";
            lblConclusion.Visible = false;
            txtTamaño.Enabled = true;
            txtPosicion.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtPosicion.Text, out int Posicion) &&
            int.TryParse(txtPeticion.Text, out int Peticion) &&
            int.TryParse(txtTamaño.Text, out int Tamaño))
            {
                if (Posicion > Tamaño && Peticion > Tamaño)
                {
                    DialogResult result = MessageBox.Show("La posición inicial del cabezal y la petición de pista no debe ser mayor al tamaño total de pistas del disco duro", "Servicio TI - Grupo 06", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        txtPosicion.Clear();
                        txtPeticion.Clear();
                    }
                }
                else if (Posicion > Tamaño)
                {
                    DialogResult result = MessageBox.Show("La posición inicial del cabezal no debe ser mayor al tamaño total de pistas del disco duro", "Servicio TI - Grupo 06", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        txtPosicion.Clear();
                        txtPeticion.Clear();
                    }
                }
                else if (Peticion > Tamaño)
                {
                    if (Tamaño > Posicion)
                    {
                        txtTamaño.Enabled = false;
                        txtPosicion.Enabled = false;
                    }

                    DialogResult result = MessageBox.Show("La petición de pista no debe ser mayor al tamaño total de pistas del disco duro", "Servicio TI - Grupo 06", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        txtPeticion.Clear();
                    }
                }
                else
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = (rowIndex + 1).ToString();
                    dataGridView1.Rows[rowIndex].Cells[1].Value = txtPeticion.Text;

                    txtPeticion.Clear();
                    txtTamaño.Enabled = false;
                    txtPosicion.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Servicio TI - Grupo 06", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPeticion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FIFO()
        {
            int tamañoDisco = Convert.ToInt32(txtTamaño.Text);
            int posicionActual = Convert.ToInt32(txtPosicion.Text);

            List<int> solicitudes = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["coPista"].Value != null && int.TryParse(row.Cells["coPista"].Value.ToString(), out int pista))
                {
                    solicitudes.Add(pista);
                }
            }

            List<int> pistasAccedidasFIFO = new List<int>();
            List<int> pistasAtravesadasFIFO = new List<int>();

            foreach (int solicitud in solicitudes)
            {
                pistasAccedidasFIFO.Add(solicitud);
                pistasAtravesadasFIFO.Add(Math.Abs(posicionActual - solicitud));
                posicionActual = solicitud;
            }

            int sumaPistasAtravesadasFIFO = pistasAtravesadasFIFO.Sum();
            double longitudMediaFIFO = (double)sumaPistasAtravesadasFIFO / solicitudes.Count;
            dataGridView2.Rows.Clear();

            for (int i = 0; i < pistasAccedidasFIFO.Count; i++)
            {
                dataGridView2.Rows.Add(pistasAccedidasFIFO[i], pistasAtravesadasFIFO[i]);
            }

            txtFIFO.Text = longitudMediaFIFO.ToString("F4");
        }

        private void SSTF()
        {
            int posicionActual = Convert.ToInt32(txtPosicion.Text);

            var pistas = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Select(row => Convert.ToInt32(row.Cells["coPista"].Value))
                .Where(p => p != 0)
                .ToList();

            List<int> pistasAtravesadasSSTF = new List<int>();
            int pistasRecorridas = 0;

            while (pistas.Any())
            {
                int pistaMasCercana = pistas.OrderBy(p => Math.Abs(posicionActual - p)).First();
                int pistasAtravesadas = Math.Abs(posicionActual - pistaMasCercana);

                pistasAtravesadasSSTF.Add(pistasAtravesadas);
                dataGridView7.Rows.Add(pistaMasCercana, pistasAtravesadas);

                pistasRecorridas += pistasAtravesadas;
                posicionActual = pistaMasCercana;

                pistas.Remove(pistaMasCercana);
            }

            double longitudMediaSSTF = (double)pistasRecorridas / ((dataGridView1.Rows.Count) - 1);

            txtSSTF.Text = longitudMediaSSTF.ToString("F4");
        }

        private void SCAN()
        {
            int tamañoDisco = Convert.ToInt32(txtTamaño.Text);
            int posiciónActual = Convert.ToInt32(txtPosicion.Text);

            var pistas = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Select(row => Convert.ToInt32(row.Cells["coPista"].Value))
                .OrderBy(p => p)
                .ToList();

            List<int> pistasAtravesadasSCAN = new List<int>();
            int pistaAnterior = posiciónActual;
            int proximaPista = 0;

            foreach (int pista in pistas.Where(p => p >= posiciónActual))
            {
                proximaPista = pista;
                int pistaAtravesada = Math.Abs(pistaAnterior - pista);
                pistasAtravesadasSCAN.Add(pistaAtravesada);
                dataGridView6.Rows.Add(proximaPista, pistaAtravesada);
                pistaAnterior = pista;
            }

            pistasAtravesadasSCAN.Add(Math.Abs(proximaPista - tamañoDisco));
            dataGridView6.Rows.Add(tamañoDisco, Math.Abs(proximaPista - tamañoDisco));

            pistas.Reverse();
            pistaAnterior = tamañoDisco;
            foreach (int pista in pistas.Where(p => p < posiciónActual))
            {
                proximaPista = pista;
                int pistaAtravesada = Math.Abs(pistaAnterior - pista);
                pistasAtravesadasSCAN.Add(pistaAtravesada);
                dataGridView6.Rows.Add(proximaPista, pistaAtravesada);
                pistaAnterior = pista;
            }

            int sumaPistasAtravesadasSCAN = pistasAtravesadasSCAN.Sum();
            double longitudMediaSCAN = (double)sumaPistasAtravesadasSCAN / ((pistas.Count) + 1);

            txtSCAN.Text = longitudMediaSCAN.ToString("F4");
        }

        private void CSCAN()
        {
            int tamañoDisco = Convert.ToInt32(txtTamaño.Text);
            int posiciónActual = Convert.ToInt32(txtPosicion.Text);
            var pistas = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Select(row => Convert.ToInt32(row.Cells["coPista"].Value))
                .OrderBy(p => p)
                .ToList();

            List<int> pistasAtravesadasCSCAN = new List<int>();
            int pistaAnterior = posiciónActual;
            int proximaPista = 0;

            foreach (int pista in pistas.Where(p => p >= posiciónActual))
            {
                proximaPista = pista;
                int pistaAtravesada = Math.Abs(pistaAnterior - pista);
                pistasAtravesadasCSCAN.Add(pistaAtravesada);
                dataGridView5.Rows.Add(proximaPista, pistaAtravesada);
                pistaAnterior = pista;
            }

            pistasAtravesadasCSCAN.Add(Math.Abs(proximaPista - tamañoDisco));
            dataGridView5.Rows.Add(tamañoDisco, Math.Abs(proximaPista - tamañoDisco));

            pistaAnterior = 0;
            pistaAnterior = tamañoDisco;
            foreach (int pista in pistas.Where(p => p < posiciónActual))
            {
                proximaPista = pista;
                int pistaAtravesada = Math.Abs(pistaAnterior - pista);
                pistasAtravesadasCSCAN.Add(pistaAtravesada);
                dataGridView5.Rows.Add(proximaPista, pistaAtravesada);
                pistaAnterior = pista;
            }

            int sumaPistasAtravesadasCSCAN = pistasAtravesadasCSCAN.Sum();
            double longitudMediaCSCAN = (double)sumaPistasAtravesadasCSCAN / ((pistas.Count) + 1);

            txtCSCAN.Text = longitudMediaCSCAN.ToString("F4");
        }

        private void LOOK()
        {
            int tamañoDisco = Convert.ToInt32(txtTamaño.Text);
            int posiciónActual = Convert.ToInt32(txtPosicion.Text);
            var pistas = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Select(row => Convert.ToInt32(row.Cells["coPista"].Value))
                .OrderBy(p => p)
                .ToList();

            List<int> pistasAtravesadasSCAN = new List<int>();
            int pistaAnterior = posiciónActual;
            int proximaPista = 0;

            foreach (int pista in pistas.Where(p => p >= posiciónActual))
            {
                proximaPista = pista;
                int pistaAtravesada = Math.Abs(pistaAnterior - pista);
                pistasAtravesadasSCAN.Add(pistaAtravesada);
                dataGridView4.Rows.Add(proximaPista, pistaAtravesada);
                pistaAnterior = pista;
            }

            pistas.Reverse();
            foreach (int pista in pistas.Where(p => p < posiciónActual && p != 0))
            {
                proximaPista = pista;
                int pistaAtravesada = Math.Abs(pistaAnterior - pista);
                pistasAtravesadasSCAN.Add(pistaAtravesada);
                dataGridView4.Rows.Add(proximaPista, pistaAtravesada);
                pistaAnterior = pista;
            }

            int sumaPistasAtravesadasSCAN = pistasAtravesadasSCAN.Sum();
            double longitudMediaSCAN = (double)sumaPistasAtravesadasSCAN / ((pistas.Count) - 1);

            txtLOOK.Text = longitudMediaSCAN.ToString("F4");
        }

        private void CLOOK()
        {
            int tamañoDisco = Convert.ToInt32(txtTamaño.Text);
            int posicionActual = Convert.ToInt32(txtPosicion.Text);
            var pistas = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Select(row => Convert.ToInt32(row.Cells["coPista"].Value))
                .OrderBy(p => p)
                .ToList();

            List<int> pistasAtravesadasCSCAN = new List<int>();
            int pistaAnterior = posicionActual;
            int proximaPista = 0;

            foreach (int pista in pistas.Where(p => p >= posicionActual && p <= tamañoDisco))
            {
                proximaPista = pista;
                int pistaAtravesada = Math.Abs(pistaAnterior - pista);
                pistasAtravesadasCSCAN.Add(pistaAtravesada);
                dataGridView3.Rows.Add(proximaPista, pistaAtravesada);
                pistaAnterior = pista;
            }

            foreach (int pista in pistas.Where(p => p < posicionActual && p > 0))
            {
                proximaPista = pista;
                int pistaAtravesada = Math.Abs(pistaAnterior - pista);
                pistasAtravesadasCSCAN.Add(pistaAtravesada);
                dataGridView3.Rows.Add(proximaPista, pistaAtravesada);
                pistaAnterior = pista;
            }

            int sumaPistasAtravesadasCSCAN = pistasAtravesadasCSCAN.Sum();
            double longitudMediaCSCAN = (double)sumaPistasAtravesadasCSCAN / ((pistas.Count) - 1);

            txtCLOOK.Text = longitudMediaCSCAN.ToString("F4");
        }

        private void btnDesarrollar_Click(object sender, EventArgs e)
        {
            lblConclusion.Visible = true;

            FIFO();
            SSTF();
            SCAN();
            CSCAN();
            LOOK();
            CLOOK();

            Dictionary<string, System.Windows.Forms.TextBox> textBoxes = new Dictionary<string, System.Windows.Forms.TextBox>
            {
                {"FIFO", txtFIFO},
                {"SSTF", txtSSTF},
                {"SCAN", txtSCAN},
                {"CSCAN", txtCSCAN},
                {"LOOK", txtLOOK},
                {"CLOOK", txtCLOOK}
            };

            double valorMinimo = double.MaxValue;
            List<string> algoritmosEficientes = new List<string>();

            foreach (var textBox in textBoxes)
            {
                double valorTextBox = double.Parse(textBox.Value.Text);

                if (valorTextBox < valorMinimo)
                {
                    valorMinimo = valorTextBox;
                    algoritmosEficientes.Clear();
                    algoritmosEficientes.Add(textBox.Key);
                }
                else if (valorTextBox == valorMinimo)
                {
                    algoritmosEficientes.Add(textBox.Key);
                }
            }

            string descripcion = "";
            if (algoritmosEficientes.Count == 1)
            {
                descripcion = $"Para este caso, el algoritmo más eficiente es {algoritmosEficientes[0]} porque proporciona una longitud media de búsqueda de {valorMinimo}.";
            }
            else if (algoritmosEficientes.Count > 1)
            {
                string algoritmos = string.Join(", ", algoritmosEficientes);
                descripcion = $"Para este caso, los algoritmos más eficientes son {algoritmos}, porque proporcionan una longitud media de búsqueda de {valorMinimo}.";
            }

            lblResultado.Text = descripcion;
        }

        private void GraficoFIFO(List<int> solicitudes)
        {
            Chart grafico = new Chart();
            grafico.Size = new System.Drawing.Size(600, 400);

            ChartArea area = new ChartArea();
            grafico.ChartAreas.Add(area);

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Line;

            grafico.Series.Add(serie);

            for (int i = 0; i < solicitudes.Count - 1; i++)
            {
                DataPoint puntoInicio = new DataPoint(solicitudes[i], i + 1);
                puntoInicio.MarkerStyle = MarkerStyle.Circle;
                puntoInicio.MarkerSize = 8;
                puntoInicio.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoInicio);
                serie.Points.AddXY(solicitudes[i], i + 1);
                serie.Points.AddXY(solicitudes[i + 1], i + 2);
                DataPoint puntoFin = new DataPoint(solicitudes[i + 1], i + 2);
                puntoFin.MarkerStyle = MarkerStyle.Circle;
                puntoFin.MarkerSize = 8;
                puntoFin.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoFin);
            }

            grafico.ChartAreas[0].AxisY.Title = "Número de solicitud";
            grafico.ChartAreas[0].AxisX.Title = "Pista accedida";
            grafico.Titles.Add("Gráfico del algoritmo de planificación FIFO");
            grafico.ChartAreas[0].AxisY.Interval = 1;

            foreach (int solicitud in solicitudes)
            {
                CustomLabel etiqueta = new CustomLabel();
                etiqueta.FromPosition = solicitud - 0.5;
                etiqueta.ToPosition = solicitud + 0.5;
                etiqueta.Text = solicitud.ToString();
                grafico.ChartAreas[0].AxisX.CustomLabels.Add(etiqueta);
            }

            Form formularioGrafico = new Form();
            formularioGrafico.Text = "Gráfico FIFO";
            formularioGrafico.ClientSize = new System.Drawing.Size(grafico.Width, grafico.Height);
            formularioGrafico.Controls.Add(grafico);
            grafico.Dock = DockStyle.Fill;
            formularioGrafico.Show();
        }

        private void GraficoSSTF(List<int> solicitudes)
        {
            Chart grafico = new Chart();
            grafico.Size = new System.Drawing.Size(600, 400);

            ChartArea area = new ChartArea();
            grafico.ChartAreas.Add(area);

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Line;

            grafico.Series.Add(serie);

            for (int i = 0; i < solicitudes.Count - 1; i++)
            {
                DataPoint puntoInicio = new DataPoint(solicitudes[i], i + 1);
                puntoInicio.MarkerStyle = MarkerStyle.Circle;
                puntoInicio.MarkerSize = 8;
                puntoInicio.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoInicio);
                serie.Points.AddXY(solicitudes[i], i + 1);
                serie.Points.AddXY(solicitudes[i + 1], i + 2);
                DataPoint puntoFin = new DataPoint(solicitudes[i + 1], i + 2);
                puntoFin.MarkerStyle = MarkerStyle.Circle;
                puntoFin.MarkerSize = 8;
                puntoFin.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoFin);
            }

            grafico.ChartAreas[0].AxisY.Title = "Número de solicitud";
            grafico.ChartAreas[0].AxisX.Title = "Pista accedida";
            grafico.Titles.Add("Gráfico del algoritmo de planificación SSTF");
            grafico.ChartAreas[0].AxisY.Interval = 1;

            foreach (int solicitud in solicitudes)
            {
                CustomLabel etiqueta = new CustomLabel();
                etiqueta.FromPosition = solicitud - 0.5;
                etiqueta.ToPosition = solicitud + 0.5;
                etiqueta.Text = solicitud.ToString();
                grafico.ChartAreas[0].AxisX.CustomLabels.Add(etiqueta);
            }

            Form formularioGrafico = new Form();
            formularioGrafico.Text = "Gráfico SSTF";
            formularioGrafico.ClientSize = new System.Drawing.Size(grafico.Width, grafico.Height);
            formularioGrafico.Controls.Add(grafico);
            grafico.Dock = DockStyle.Fill;
            formularioGrafico.Show();
        }

        private void GraficoSCAN(List<int> solicitudes)
        {
            Chart grafico = new Chart();
            grafico.Size = new System.Drawing.Size(600, 400);

            ChartArea area = new ChartArea();
            grafico.ChartAreas.Add(area);

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Line;

            grafico.Series.Add(serie);

            for (int i = 0; i < solicitudes.Count - 1; i++)
            {
                DataPoint puntoInicio = new DataPoint(solicitudes[i], i + 1);
                puntoInicio.MarkerStyle = MarkerStyle.Circle;
                puntoInicio.MarkerSize = 8;
                puntoInicio.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoInicio);
                serie.Points.AddXY(solicitudes[i], i + 1);
                serie.Points.AddXY(solicitudes[i + 1], i + 2);
                DataPoint puntoFin = new DataPoint(solicitudes[i + 1], i + 2);
                puntoFin.MarkerStyle = MarkerStyle.Circle;
                puntoFin.MarkerSize = 8;
                puntoFin.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoFin);
            }

            grafico.ChartAreas[0].AxisY.Title = "Número de solicitud";
            grafico.ChartAreas[0].AxisX.Title = "Pista accedida";
            grafico.Titles.Add("Gráfico del algoritmo de planificación SCAN");
            grafico.ChartAreas[0].AxisY.Interval = 1;

            foreach (int solicitud in solicitudes)
            {
                CustomLabel etiqueta = new CustomLabel();
                etiqueta.FromPosition = solicitud - 0.5;
                etiqueta.ToPosition = solicitud + 0.5;
                etiqueta.Text = solicitud.ToString();
                grafico.ChartAreas[0].AxisX.CustomLabels.Add(etiqueta);
            }

            Form formularioGrafico = new Form();
            formularioGrafico.Text = "Gráfico SCAN";
            formularioGrafico.ClientSize = new System.Drawing.Size(grafico.Width, grafico.Height);
            formularioGrafico.Controls.Add(grafico);
            grafico.Dock = DockStyle.Fill;
            formularioGrafico.Show();
        }

        private void GraficoCSCAN(List<int> solicitudes)
        {
            Chart grafico = new Chart();
            grafico.Size = new System.Drawing.Size(600, 400);

            ChartArea area = new ChartArea();
            grafico.ChartAreas.Add(area);

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Line;

            grafico.Series.Add(serie);

            for (int i = 0; i < solicitudes.Count - 1; i++)
            {
                DataPoint puntoInicio = new DataPoint(solicitudes[i], i + 1);
                puntoInicio.MarkerStyle = MarkerStyle.Circle;
                puntoInicio.MarkerSize = 8;
                puntoInicio.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoInicio);
                serie.Points.AddXY(solicitudes[i], i + 1);
                serie.Points.AddXY(solicitudes[i + 1], i + 2);
                DataPoint puntoFin = new DataPoint(solicitudes[i + 1], i + 2);
                puntoFin.MarkerStyle = MarkerStyle.Circle;
                puntoFin.MarkerSize = 8;
                puntoFin.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoFin);
            }

            grafico.ChartAreas[0].AxisY.Title = "Número de solicitud";
            grafico.ChartAreas[0].AxisX.Title = "Pista accedida";
            grafico.Titles.Add("Gráfico del algoritmo de planificación CSCAN");
            grafico.ChartAreas[0].AxisY.Interval = 1;

            foreach (int solicitud in solicitudes)
            {
                CustomLabel etiqueta = new CustomLabel();
                etiqueta.FromPosition = solicitud - 0.5;
                etiqueta.ToPosition = solicitud + 0.5;
                etiqueta.Text = solicitud.ToString();
                grafico.ChartAreas[0].AxisX.CustomLabels.Add(etiqueta);
            }

            Form formularioGrafico = new Form();
            formularioGrafico.Text = "Gráfico CSCAN";
            formularioGrafico.ClientSize = new System.Drawing.Size(grafico.Width, grafico.Height);
            formularioGrafico.Controls.Add(grafico);
            grafico.Dock = DockStyle.Fill;
            formularioGrafico.Show();
        }

        private void GraficoLOOK(List<int> solicitudes)
        {
            Chart grafico = new Chart();
            grafico.Size = new System.Drawing.Size(600, 400);

            ChartArea area = new ChartArea();
            grafico.ChartAreas.Add(area);

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Line;

            grafico.Series.Add(serie);

            for (int i = 0; i < solicitudes.Count - 1; i++)
            {
                DataPoint puntoInicio = new DataPoint(solicitudes[i], i + 1);
                puntoInicio.MarkerStyle = MarkerStyle.Circle;
                puntoInicio.MarkerSize = 8;
                puntoInicio.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoInicio);
                serie.Points.AddXY(solicitudes[i], i + 1);
                serie.Points.AddXY(solicitudes[i + 1], i + 2);
                DataPoint puntoFin = new DataPoint(solicitudes[i + 1], i + 2);
                puntoFin.MarkerStyle = MarkerStyle.Circle;
                puntoFin.MarkerSize = 8;
                puntoFin.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoFin);
            }

            grafico.ChartAreas[0].AxisY.Title = "Número de solicitud"; 
            grafico.ChartAreas[0].AxisX.Title = "Pista accedida";
            grafico.Titles.Add("Gráfico del algoritmo de planificación LOOK");
            grafico.ChartAreas[0].AxisY.Interval = 1;

            foreach (int solicitud in solicitudes)
            {
                CustomLabel etiqueta = new CustomLabel();
                etiqueta.FromPosition = solicitud - 0.5;
                etiqueta.ToPosition = solicitud + 0.5;
                etiqueta.Text = solicitud.ToString();
                grafico.ChartAreas[0].AxisX.CustomLabels.Add(etiqueta);
            }

            Form formularioGrafico = new Form();
            formularioGrafico.Text = "Gráfico LOOK";
            formularioGrafico.ClientSize = new System.Drawing.Size(grafico.Width, grafico.Height);
            formularioGrafico.Controls.Add(grafico);
            grafico.Dock = DockStyle.Fill;
            formularioGrafico.Show();
        }

        private void GraficoCLOOK(List<int> solicitudes)
        {
            Chart grafico = new Chart();
            grafico.Size = new System.Drawing.Size(600, 400);

            ChartArea area = new ChartArea();
            grafico.ChartAreas.Add(area);

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Line;

            grafico.Series.Add(serie);

            for (int i = 0; i < solicitudes.Count - 1; i++)
            {
                DataPoint puntoInicio = new DataPoint(solicitudes[i], i + 1);
                puntoInicio.MarkerStyle = MarkerStyle.Circle;
                puntoInicio.MarkerSize = 8;
                puntoInicio.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoInicio);
                serie.Points.AddXY(solicitudes[i], i + 1);
                serie.Points.AddXY(solicitudes[i + 1], i + 2);
                DataPoint puntoFin = new DataPoint(solicitudes[i + 1], i + 2);
                puntoFin.MarkerStyle = MarkerStyle.Circle;
                puntoFin.MarkerSize = 8;
                puntoFin.MarkerColor = System.Drawing.Color.Blue;
                serie.Points.Add(puntoFin);
            }

            grafico.ChartAreas[0].AxisY.Title = "Número de solicitud";
            grafico.ChartAreas[0].AxisX.Title = "Pista accedida";
            grafico.Titles.Add("Gráfico del algoritmo de planificación CLOOK");
            grafico.ChartAreas[0].AxisY.Interval = 1;

            foreach (int solicitud in solicitudes)
            {
                CustomLabel etiqueta = new CustomLabel();
                etiqueta.FromPosition = solicitud - 0.5;
                etiqueta.ToPosition = solicitud + 0.5;
                etiqueta.Text = solicitud.ToString();
                grafico.ChartAreas[0].AxisX.CustomLabels.Add(etiqueta);
            }

            Form formularioGrafico = new Form();
            formularioGrafico.Text = "Gráfico CLOOK";
            formularioGrafico.ClientSize = new System.Drawing.Size(grafico.Width, grafico.Height);
            formularioGrafico.Controls.Add(grafico);
            grafico.Dock = DockStyle.Fill;
            formularioGrafico.Show();
        }

        private void btnFIFO_Click(object sender, EventArgs e)
        {
            List<int> solicitudesFIFO = new List<int>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["coFIFOAC"].Value != null && int.TryParse(row.Cells["coFIFOAC"].Value.ToString(), out int pista))
                {
                    solicitudesFIFO.Add(pista);
                }
            }
            GraficoFIFO(solicitudesFIFO);
        }

        private void btnSSTF_Click(object sender, EventArgs e)
        {
            List<int> solicitudesSSTF = new List<int>();

            foreach (DataGridViewRow row in dataGridView7.Rows)
            {
                if (row.Cells["coSSTFAC"].Value != null && int.TryParse(row.Cells["coSSTFAC"].Value.ToString(), out int pista))
                {
                    solicitudesSSTF.Add(pista);
                }
            }
            GraficoSSTF(solicitudesSSTF);
        }

        private void btnSCAN_Click(object sender, EventArgs e)
        {
            List<int> solicitudesSCAN = new List<int>();

            foreach (DataGridViewRow row in dataGridView6.Rows)
            {
                if (row.Cells["coSCANAC"].Value != null && int.TryParse(row.Cells["coSCANAC"].Value.ToString(), out int pista))
                {
                    solicitudesSCAN.Add(pista);
                }
            }
            GraficoSCAN(solicitudesSCAN);
        }

        private void btnCSCAN_Click(object sender, EventArgs e)
        {
            List<int> solicitudesCSCAN = new List<int>();

            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                if (row.Cells["coCSCANAC"].Value != null && int.TryParse(row.Cells["coCSCANAC"].Value.ToString(), out int pista))
                {
                    solicitudesCSCAN.Add(pista);
                }
            }
            GraficoCSCAN(solicitudesCSCAN);
        }

        private void btnLOOK_Click(object sender, EventArgs e)
        {
            List<int> solicitudesLOOK = new List<int>();

            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (row.Cells["coLOOKAC"].Value != null && int.TryParse(row.Cells["coLOOKAC"].Value.ToString(), out int pista))
                {
                    solicitudesLOOK.Add(pista);
                }
            }
            GraficoLOOK(solicitudesLOOK);
        }

        private void btnCLOOK_Click(object sender, EventArgs e)
        {
            List<int> solicitudesCLOOK = new List<int>();

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells["coCLOOKAC"].Value != null && int.TryParse(row.Cells["coCLOOKAC"].Value.ToString(), out int pista))
                {
                    solicitudesCLOOK.Add(pista);
                }
            }
            GraficoCLOOK(solicitudesCLOOK);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else if (dataGridView1.Rows.Count > 1)
            {
                int lastRowIndex = dataGridView1.Rows.Count - 2;

                dataGridView1.Rows.RemoveAt(lastRowIndex);
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar", "Servicio TI - Grupo 06", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
