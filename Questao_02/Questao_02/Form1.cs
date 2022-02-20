using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questao_02
{
    public partial class Form1 : Form
    {
        List<Usuario> listaUsuario = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("dadosUsuario.json"))
            {
                CarregarArquivo();
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario()
                {
                    Nome = tb_nome.Text,
                    Senha = tb_senha.Text
                };

                listaUsuario.Add(usuario);
                GravarArquivo();
                MessageBox.Show("Salvo");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        /// <summary>
        ///  Serializa e grava a lista em arquivo "dadosUsuario.json".
        /// </summary>
        private void GravarArquivo()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudoMarca = JsonConvert.SerializeObject(listaUsuario, settings);
            File.WriteAllText("dadosUsuario.json", conteudoMarca);
        }
        /// <summary>
        /// Desserializa e carrega o arquivo "dadosUsuario.json" em lista.
        /// </summary>
        private void CarregarArquivo()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudo = File.ReadAllText("dadosUsuario.json");
            listaUsuario = JsonConvert.DeserializeObject<List<Usuario>>(conteudo, settings);
        }

        private void rb_visualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
