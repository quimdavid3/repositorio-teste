using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace m8_ficha3_davidpereira
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox_marca.SelectedItem)
            {
                case "toyota":
                    comboBox_modelos.Items.Clear();
                    comboBox_modelos.Items.Add("GR supra");
                    comboBox_modelos.Items.Add("corolla");
                    comboBox_modelos.Items.Add("C-hr");
                    break;
                case "seat":
                    comboBox_modelos.Items.Clear();
                    comboBox_modelos.Items.Add("ateca");
                    comboBox_modelos.Items.Add("arona");
                    comboBox_modelos.Items.Add("leon");
                    break;

                case "Volkswagen":

                    comboBox_modelos.Items.Clear();
                    comboBox_modelos.Items.Add("T-cross");
                    comboBox_modelos.Items.Add("Virtus");
                    comboBox_modelos.Items.Add("Nivus");
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseReason.UserClosing == e.CloseReason)
            {
                var resultado = MessageBox.Show("Tem a certeza que deseja fechar o programa?", "sair", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox_marca.SelectedIndex = -1;
            comboBox_modelos.SelectedIndex = -1;
            maskedTextBox_matricula.Text = null;
            maskedTextBox_ano.Text = null;
        }
        private void salvar()
        {

            using (StreamWriter writer = new StreamWriter(selectedFilePath, true))
            {
                // Escreve o conteúdo no ficheiro

                writer.WriteLine(comboBox_marca.SelectedItem + "/" + comboBox_modelos.SelectedItem + "/" + maskedTextBox_matricula.Text + "/" + maskedTextBox_ano.Text);
                // Escreve o conteúdo na tabela
                dataGridView1.Rows.Add(comboBox_marca.SelectedItem, comboBox_modelos.SelectedItem, maskedTextBox_matricula.Text, maskedTextBox_ano.Text);


                string Carros = dataGridView1.Rows.Count.ToString();
                total_carros.Text = "exstem " + Carros + " carros no stand";
            }
        }
        private void eliminar()
        {
            
                if (dataGridView1.SelectedRows.Count > 0)
                {
                var resultado = MessageBox.Show(" tem a certeza que deseja excluir ou alterar este registo?", "excluir/alterar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;

                    // Remover a linha selecionada do DataGridView
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    // Atualizar o ficheiro removendo a linha correspondente
                    List<string> linhas = new List<string>();//lista das linhas
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        List<string> colunas = new List<string>();//lista das colunas
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            colunas.Add(cell.Value.ToString());
                        }
                        linhas.Add(string.Join("/", colunas));
                    }

                    File.WriteAllLines(selectedFilePath, linhas);
                    string Carros = dataGridView1.Rows.Count.ToString();
                    total_carros.Text = "exstem " + Carros + " carros no stand";
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir ou alterar.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedFilePath=="")
            {
                ficheiro();
            }
            else
            {
                if (comboBox_marca.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("tem de selecionar uma marca", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBox_modelos.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("tem de selecionar um modelo", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (maskedTextBox_matricula.Text.Equals("  -  -"))
                        {
                            MessageBox.Show("tem de selecionar uma matricula", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (maskedTextBox_ano.Text.Equals(""))
                            {
                                MessageBox.Show("tem de selecionar um ano", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                salvar();
                            }
                        }
                    }
                }
            }
           
            
        }

        string selectedFilePath="";
        
        private void ficheiro()
        {
            var resultado = MessageBox.Show("deseja abrir um ficheiro existente?\n (se clicar em 'não' terá de criar um ficheiro)", "escolher ficheiro", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    string[] lines = File.ReadAllLines(selectedFilePath);
                    string[] values;
                    for (int i = 0; i < lines.Length; i++)//ler as linhas do ficheiro
                    {
                        values = lines[i].ToString().Split('/');
                        string[] row = new string[values.Length];
                        for (int j = 0; j < values.Length; j++)//colocar na row da tabela
                        {
                            row[j] = values[j].Trim();
                        }
                        dataGridView1.Rows.Add(row);
                    }
                }
                
                
                string Carros = dataGridView1.Rows.Count.ToString();
                total_carros.Text = "exstem " + Carros + " carros no stand";

                listBox1.Items.Clear();


                for (int i = 0; i <= 3 && i < dataGridView1.Rows.Count; i++)
                {

                    string valor = dataGridView1.Rows[i].Cells[2].Value.ToString();

                    valor += "\n";


                    listBox1.Items.Add(valor);
                }
            }
            else
            {

                SaveFileDialog SaveFileDialog = new SaveFileDialog();
                SaveFileDialog.FileName = ".txt";
                SaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                DialogResult result = SaveFileDialog.ShowDialog();

                if (result != DialogResult.Cancel)
                {
                    selectedFilePath = SaveFileDialog.FileName;

                    MessageBox.Show("Ficheiro Salvo com sucesso!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    string Carros = dataGridView1.Rows.Count.ToString();
                    total_carros.Text = "exstem " + Carros + " carros no stand";

                    listBox1.Items.Clear();


                    for (int i = 0; i <= 3 && i < dataGridView1.Rows.Count; i++)
                    {

                        string valor = dataGridView1.Rows[i].Cells[2].Value.ToString();

                        valor += "\n";


                        listBox1.Items.Add(valor);
                    }
                }
                else
                    MessageBox.Show("O processo de salvar foi cancelado.", "Canceled",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            ficheiro();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {

            if (selectedFilePath == "")
            {
                ficheiro();
            }
            else
            {
                eliminar();
            }
            

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // Verifica se a célula clicada pertence a uma linha válida
            
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                comboBox_marca.Text = row.Cells[0].Value.ToString();
                comboBox_modelos.Text = row.Cells[1].Value.ToString();
                maskedTextBox_matricula.Text = row.Cells[2].Value.ToString();
                maskedTextBox_ano.Text = row.Cells[3].Value.ToString();
            
        }

        private void button_alterar_Click(object sender, EventArgs e)
        {


            if (selectedFilePath == "")
            {
                ficheiro();
            }
            else
            {
                if (dataGridView1.SelectedRows == null)
                {
                    MessageBox.Show("tem de selecionar uma linha da tabela", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBox_marca.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("tem de selecionar uma marca", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (comboBox_modelos.SelectedIndex.Equals(-1))
                        {
                            MessageBox.Show("tem de selecionar um modelo", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (maskedTextBox_matricula.Text.Equals("  -  -"))
                            {
                                MessageBox.Show("tem de selecionar uma matricula", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (maskedTextBox_ano.Text.Equals(""))
                                {
                                    MessageBox.Show("tem de selecionar um ano", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    salvar();
                                    eliminar();
                                }
                            }
                        }
                    }


                   
                }
            }


        }

        private void comboBox_marcas2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marca = comboBox_marcas2.SelectedItem.ToString();
            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == marca)
                {
                    count++;
                }
            }


            label_cont_marca.Text = "existem " + count + " carros da marca " + marca + " no stand";


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int ano_count = 0;
            string ano = textBox1.Text.Trim();

            if (DateTime.TryParseExact(ano, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inputYear))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[3].Value != null && DateTime.TryParseExact(row.Cells[3].Value.ToString(), "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime anoCarro))
                    {
                        if (inputYear > anoCarro)
                        {
                            ano_count++;
                        }
                    }
                }

                label_ano.Text = "Existem " + ano_count + " carros com ano anterior a " + ano + " no stand";
            }
            else
            {
                label_ano.Text = "Ano inserido inválido. Por favor, insira um ano válido no formato YYYY.";
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
              

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            ficheiro();
        }
    }






}
