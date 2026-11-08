using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataStructuresDynamicWinForms
{
    public partial class Form1 : Form
    {
        private SimpleLinkedList listaDinamica = new SimpleLinkedList();
        private DynamicStack pilaDinamica = new DynamicStack();
        private DynamicQueue colaDinamica = new DynamicQueue();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                listaDinamica.Add(valor);
                lstResultados.Items.Add($"[DINÁMICA] Agregado: {valor}");
                lstResultados.Items.Add($"Estructura actual: {listaDinamica.PrintList()}");
                txtDato.Clear();
                txtDato.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                listaDinamica.Remove(valor);
                lstResultados.Items.Add($"[DINÁMICA] Eliminado (si existía): {valor}");
                lstResultados.Items.Add($"Estructura actual: {listaDinamica.PrintList()}");
                txtDato.Clear();
                txtDato.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                bool encontrado = listaDinamica.Search(valor);

                if (encontrado)
                {
                    MessageBox.Show($"¡El valor [{valor}] SÍ se encuentra en la lista enlazada!", "Búsqueda Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstResultados.Items.Add($"[DINÁMICA] Búsqueda: El valor {valor} fue ENCONTRADO.");
                }
                else
                {
                    MessageBox.Show($"El valor [{valor}] NO existe en la lista.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lstResultados.Items.Add($"[DINÁMICA] Búsqueda: El valor {valor} NO fue encontrado.");
                }

                txtDato.Clear();
                txtDato.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                pilaDinamica.Push(valor);
                lstResultados.Items.Add($"[PILA DINÁMICA] Push({valor})");
                lstResultados.Items.Add($"Cima actual: {pilaDinamica.PrintStack()}");
                txtDato.Clear();
                txtDato.Focus();
            }
            else
            {
                MessageBox.Show("Ingresa un número para hacer Push.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            int? extraido = pilaDinamica.Pop();
            if (extraido != null)
            {
                MessageBox.Show($"Elemento extraído de la Pila: {extraido}", "Pop Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstResultados.Items.Add($"[PILA DINÁMICA] Pop(): Se extrajo {extraido}");
                lstResultados.Items.Add($"Cima actual: {pilaDinamica.PrintStack()}");
            }
            else
            {
                MessageBox.Show("La pila dinámica está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                colaDinamica.Enqueue(valor);
                lstResultados.Items.Add($"[COLA DINÁMICA] Enqueue({valor})");
                lstResultados.Items.Add($"Estado cola: {colaDinamica.PrintQueue()}");
                txtDato.Clear();
                txtDato.Focus();
            }
            else
            {
                MessageBox.Show("Ingresa un número para encolar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            int? atendido = colaDinamica.Dequeue();
            if (atendido != null)
            {
                MessageBox.Show($"Elemento atendido de la Cola: {atendido}", "Dequeue Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstResultados.Items.Add($"[COLA DINÁMICA] Dequeue(): Se atendió a {atendido}");
                lstResultados.Items.Add($"Estado cola: {colaDinamica.PrintQueue()}");
            }
            else
            {
                MessageBox.Show("La cola dinámica está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
