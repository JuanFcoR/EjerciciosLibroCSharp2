using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosLibro.BLL;
using System.Collections;

namespace EjerciciosLibro.UI
{
    public partial class Diccionario : Form
    {
        Hashtable hash = new Hashtable();
        public Diccionario()
        {
            InitializeComponent();
            
        }

       
        
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            DiccionariolistBox.Items.Clear();

            DiccionarioBLL.insertar(hash,Convert.ToString(PalabraTextBox.Text),Convert.ToString(SignificadoRichTextBox.Text));

            foreach(DictionaryEntry datos in hash)
            {
                DiccionariolistBox.Items.Add("Palabra: "+datos.Key+" Significado: "+datos.Value);
            }
            

        }
    }
}
