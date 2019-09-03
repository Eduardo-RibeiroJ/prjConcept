using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PrjConcept.Formularios.Sistema
{
    public partial class frmCriarBackup : Form
    {
        public frmCriarBackup()
        {
            InitializeComponent();
        }
        string directoriocriar, directoriorestaurar;

        private void btnPesProd_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
            {
                dirDialog.Description = "Selecione o endereço do backup:";
                dirDialog.SelectedPath = @"C:\Backups";
                // Mostra a janela de escolha do directorio
                DialogResult res = dirDialog.ShowDialog();

                if (res == DialogResult.OK)
                {
                    // Como o utilizador carregou no OK, o directorio escolhido pode ser acedido da seguinte forma:
                    directoriocriar = dirDialog.SelectedPath;
                    txtLocalCriar.Text = directoriocriar;
                }
                else
                {
                    // Caso o utilizador tenha cancelado
                    // ...
                }
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCriarBackup_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            txtNomeArquivo.Text = "Backup - " + d.Day + "." + d.Month + "." + d.Year + " - " + d.Hour + "."+ d.Minute + ".bak";
            if (!Directory.Exists(@"C:\Backups"))
            {
                Directory.CreateDirectory(@"C:\Backups");
            }
            if (!Directory.Exists(@"C:\Backups\Logs"))
            {
                Directory.CreateDirectory(@"C:\Backups\Logs");
            }
        }

        private void btnPesRest_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialogo = new OpenFileDialog();
            filedialogo.Title = "Buscar arquivo de backup";
            filedialogo.InitialDirectory = @"C:\";
            filedialogo.Filter = "Arquivos de backup (*.bak)|*.bak";
            DialogResult resposta = filedialogo.ShowDialog();

            if (resposta == DialogResult.OK)
            {
                txtLocalRest.Text = filedialogo.FileName;
                directoriorestaurar = txtLocalRest.Text;
            }
            else
            {

            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                //Comando

                //Criando a Conexão
                SqlConnection LCN = new SqlConnection();
                //Criando um SQLCommand
                SqlCommand LCom = new SqlCommand();
                string LStrSql = "";
                //String de Conexão deve ser substituída pela do seu Servidor
                string conexao = "Data Source=EDUARDO-PC;Initial Catalog=DB_Concept;Integrated Security=True";
                SqlConnectionStringBuilder Lstr = new SqlConnectionStringBuilder(conexao);
                Lstr.Remove("User ID");
                Lstr.Remove("Password");

                // Turn on integrated security:
                Lstr.IntegratedSecurity = true;

                LCN.ConnectionString = Lstr.ToString();
                //Abrindo a conexão
                LCN.Open();
                LCom.Connection = LCN;
                
                LStrSql = "BACKUP DATABASE [DB_Concept] TO DISK='" + txtLocalCriar.Text + "\\" +txtNomeArquivo.Text + "' WITH COPY_ONLY";
                LCom.CommandText = LStrSql;
                LCom.ExecuteNonQuery();
                LCN.Close();
                MessageBox.Show("Backup gerado com sucesso em " + txtLocalCriar.Text, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao criar o backup, verifique a conexão com o banco de dados.\n\nErro: " +ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtLocalRest.Text == "")
            {
                MessageBox.Show("Selecione um arquivo de backup para a restauração.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                //Comando

                //Criando a Conexão
                SqlConnection LCN = new SqlConnection();
                //Criando um SQLCommand
                SqlCommand LCom = new SqlCommand();
                string LStrSql = "";
                //String de Conexão deve ser substituída pela do seu Servidor
                string conexao = "Data Source=EDUARDO-PC;Initial Catalog=DB_Concept;Integrated Security=True";
                SqlConnectionStringBuilder Lstr = new SqlConnectionStringBuilder(conexao);
                Lstr.Remove("User ID");
                Lstr.Remove("Password");

                // Turn on integrated security:
                Lstr.IntegratedSecurity = true;

                LCN.ConnectionString = Lstr.ToString();
                //Abrindo a conexão
                LCN.Open();
                LCom.Connection = LCN;

                string strsql1 = "USE master; ALTER DATABASE DB_Concept SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                string strsql2 = "ALTER DATABASE DB_Concept SET MULTI_USER;";

                LCom.CommandText = strsql1;
                LCom.ExecuteNonQuery();

                LStrSql = "RESTORE DATABASE DB_Concept FROM DISK = '" + txtLocalRest.Text + "' WITH MOVE 'DB_Concept' TO 'c:\\Backups\\Logs\\DB_Concept_Data.mdf', MOVE 'DB_Concept_Log' TO 'c:\\Backups\\Logs\\DB_Concept_Log.ldf', RECOVERY, REPLACE;";
                LCom.CommandText = LStrSql;
                LCom.ExecuteNonQuery();
                LCom.CommandText = strsql2;
                LCom.ExecuteNonQuery();
                LCN.Close();
                MessageBox.Show("Backup restaurado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao restaurar o backup, verifique a conexão com o banco de dados.\n\nErro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
