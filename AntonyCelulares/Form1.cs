using AntonyCelulares.Helpers;
using AntonyCelulares.Interfaces;
using AntonyCelulares.Views.Account;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AntonyCelulares
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider service;

        public Form1(IServiceProvider service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           RegisterUsuarioPage form = service.GetRequiredService<RegisterUsuarioPage>();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = HashHelper.GetSHA1(textBox1.Text);
        }

        private void Compara_Click(object sender, EventArgs e)
        {
            var result = HashHelper.VerifySHA1(textBox1.Text, label1.Text);
            label2.Text = result.ToString();
        }
    }
}
