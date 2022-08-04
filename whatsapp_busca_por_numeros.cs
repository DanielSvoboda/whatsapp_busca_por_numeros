using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace whatsapp_busca_por_numeros
{
    public partial class whatsapp_busca_por_numeros : Form
    {
        public whatsapp_busca_por_numeros()
        {
            InitializeComponent();
        }

        int quantidade_localizado;
        string url = "https://api.whatsapp.com/send/?phone=";
        double num_inicio;
        double num_fim;


        private async void Procurar_Click(object sender, EventArgs e)
        {
            num_inicio  = Convert.ToDouble(textBox_DDD.Text + textBox_num_inicio.Text);
             num_fim    = Convert.ToDouble(textBox_DDD.Text + textBox_num_fim.Text);

            progressBar.Value = 0;
            progressBar.Maximum = (int)(num_fim - num_inicio)+1;

            quantidade_localizado = 0;

            this.Enabled = false;
            await procurar(num_inicio, num_fim);          
            this.Enabled = true;

            label_quantidade_loc.Text = "Números Localizados:"+ quantidade_localizado;
            MessageBox.Show("Busca concluída \nQuantidade localizado: " + quantidade_localizado);
        }

        private async Task procurar (double num_inicio, double num_fim)
        {
            if (num_fim >= num_inicio)      //apenas busca crescente
            {
                for (double numero = num_inicio; numero <= num_fim; numero++)   //loop do 1° número até o último
                {
                    //label_quantidade_loc.Invoke(new Action(() => label_quantidade_loc.Text = numero.ToString()));
                    progressBar.Value++;    //a cada numero + na barra de progresso

                    var webClient_html = new WebClient();
                    webClient_html.Encoding = Encoding.UTF8;
                    webClient_html.Headers.Add("user-agent", "Mozilla/5.0 (Macintosh; PPC Mac OS X 10_5_9) AppleWebKit/5330 (KHTML, like Gecko) Chrome/39.0.825.0 Mobile Safari/5330");
                    var html_raw = webClient_html.DownloadString( url + numero );   //html da pagina de um numero por vez               
                    
                    int nun_inicio_nome = html_raw.IndexOf("_9vd5 _9scb _9scr");    //Numero onde inicia a palavra

                    if (nun_inicio_nome.ToString() != "-1") //se não achar é pq não exite ou é privado
                    {
                        int nun_final_nome = html_raw.IndexOf("</h3><a href");  //Numero onde termina a palavra
                        string nome = html_raw.Substring(nun_inicio_nome + 19,  //Corta o conteudo entre os 2 'Numeros'
                            nun_final_nome - nun_inicio_nome - 19);

                        nome = HttpUtility.HtmlDecode(nome);    //sim, tem gente q usa simbolos no nome &amp;  

                        if (checkBox_Foto.Checked == true)      //se o checkbox estiver ativo ver a foto
                        {
                            int nun_inicio_foto = html_raw.IndexOf("og:image");
                            int nun_final_foto = html_raw.IndexOf("/><meta property=\"og:s");
                            string foto = html_raw.Substring(nun_inicio_foto + 19, nun_final_foto - nun_inicio_foto - 21);

                            using (WebClient webClient_foto = new WebClient())
                            {
                                byte[] data = webClient_foto.DownloadData(HttpUtility.HtmlDecode(foto));
                                MemoryStream stream = new MemoryStream(data);
                                Image imagem = Image.FromStream(stream);

                                await add_datagrid(imagem, nome, numero);
                            }
                        }
                        else
                        {
                            await add_datagrid(null, nome, numero); //desmarcado só add NULL na imagem
                        }
                        quantidade_localizado++;    //contador de números localizados
                    }
                }
            }
            else
            {
                MessageBox.Show("O número final deve ser 'maior' que o inicial.");
            }
        }

        private async Task add_datagrid(Image imagem,string nome, double numero)    //função para atualizar o datagrid de forma assíncrona
        {
            this.dataGridView.Rows.Add(imagem, nome, numero);

            if (dataGridView.Rows.Count > 5)
            {
                dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.Rows[dataGridView.Rows.Count - 4].Index;
            }

            await Task.Delay(1);
        }

        private void botao_limpar_Click(object sender, EventArgs e)
        {
            this.dataGridView.Rows.Clear();
            label_quantidade_loc.Text = "Números Localizados:";
        }

        private void button_exportar_Click(object sender, EventArgs e)
        {
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView.SelectAll();
            DataObject conteudo_tabela = dataGridView.GetClipboardContent();

            SaveFileDialog sfd = new SaveFileDialog();  // tela escolha de diretorio para salvar
            sfd.FileName = "Números_whatsapp.csv";      // nome do arquivo 
            sfd.Filter = "CSV | *.csv";                 // exibe apenas .csv
            sfd.Title = "Escolha um local para salvar o .csv";
            sfd.ValidateNames = true;
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, conteudo_tabela.GetText(TextDataFormat.CommaSeparatedValue));
                    MessageBox.Show("Arquivo exportado com sucesso!\n"+sfd.FileName);
                }
            }        
        }

        private void linkLabel_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanielSvoboda");
        }

    }
}
