namespace Memoria_Dinamica
{
    public partial class Form1 : Form
    {
        private List<int> listaDinamica;

        public Form1()
        {
            InitializeComponent();
            listaDinamica = new List<int>(); // Inicializamos la lista din�mica
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar el elemento ingresado
            if (int.TryParse(txtElemento.Text, out int elemento))
            {
                listaDinamica.Add(elemento); // Agregar elemento a la lista din�mica
                ActualizarLista(); // Actualizar el ListBox
                txtElemento.Clear(); // Limpiar el TextBox
            }
            else
            {
                MessageBox.Show("Ingrese un n�mero v�lido.", "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si la lista tiene elementos
            if (listaDinamica.Count > 0)
            {
                listaDinamica.RemoveAt(listaDinamica.Count - 1); // Eliminar el �ltimo elemento
                ActualizarLista(); // Actualizar el ListBox
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar.", "Informaci�n");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaDinamica.Clear(); // Limpiar la lista din�mica
            ActualizarLista(); // Actualizar el ListBox
        }

        private void ActualizarLista()
        {
            // Actualizar el ListBox con los elementos actuales de la lista
            lstElementos.Items.Clear();
            foreach (var elemento in listaDinamica)
            {
                lstElementos.Items.Add(elemento);
            }
        }
    }
}
