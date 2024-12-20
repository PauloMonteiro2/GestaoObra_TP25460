﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestaoObra_TP25460
{
    public partial class DeleteFuncionario : Form
    {
        private List<Classes.Funcionario> funcionarios;
        private static string CaminhoArquivo => Path.Combine("C:\\GestaoObra_TP25460\\Data", "funcionarios.txt");

        public DeleteFuncionario()
        {
            InitializeComponent();
            CarregarFuncionarios();
        }

        private void CarregarFuncionarios()
        {
            funcionarios = Classes.Funcionario.CarregarFuncionarios();
            cmbFuncionarios.DataSource = funcionarios;
            cmbFuncionarios.DisplayMember = "Nome";
            cmbFuncionarios.ValueMember = "Id";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (cmbFuncionarios.SelectedItem is Classes.Funcionario funcionarioSelecionado)
            {
                funcionarios.RemoveAll(f => f.Id == funcionarioSelecionado.Id);
                SalvarFuncionariosAtualizados();
                MessageBox.Show("Funcionário apagado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarFuncionarios();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalvarFuncionariosAtualizados()
        {
            var linhas = funcionarios.Select(f => f.ToString());
            File.WriteAllLines(CaminhoArquivo, linhas);
        }

        private void cmbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler vazio ou adicione a lógica desejada
        }

        private void DeleteFuncionario_Load(object sender, EventArgs e)
        {
            // Event handler vazio ou adicione a lógica desejada
        }
    }
}
