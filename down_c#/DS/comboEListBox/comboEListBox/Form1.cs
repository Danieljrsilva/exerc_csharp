using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboEListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ao carregar o form,vms popular o cmb
            cmbAddViaCod.Items.Add("Acre");
            cmbAddViaCod.Items.Add("São Paulo");
            cmbAddViaCod.Items.Add("Rio de janeiro");
        }

        private void cmbAddViaPropriedade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAddViaPropriedade.Text.Equals("Acre"))
            {
                //passando valor para o text
                txtRecebeValorCombo.Text = cmbAddViaPropriedade.Text;

                //aproveitando o if e passando as cidades
                lstRecebeValorCombo.Items.Clear();
                lstRecebeValorCombo.Items.Add("Xarupi");
                lstRecebeValorCombo.Items.Add("Brasiléia");
                lstRecebeValorCombo.Items.Add("Feijó");
                lstRecebeValorCombo.Items.Add("Foz do Jordão");
                lstRecebeValorCombo.Items.Add("Rio Branco");
            }

            else if (cmbAddViaPropriedade.Text.Equals("São Paulo"))
            {
                //passando valor para o text
                txtRecebeValorCombo.Text = cmbAddViaPropriedade.Text;

                //aproveitando o if e passando as cidades
                lstRecebeValorCombo.Items.Clear();
                lstRecebeValorCombo.Items.Add("Amparo");
                lstRecebeValorCombo.Items.Add("Pedreira");
                lstRecebeValorCombo.Items.Add("Jaguariuna");
                lstRecebeValorCombo.Items.Add("Monte Alegre do Sul");
                lstRecebeValorCombo.Items.Add("Serra Negra");
            }

            else if (cmbAddViaPropriedade.Text.Equals("Rio de Janeiro"))
            {
                //passando valor para o text
                txtRecebeValorCombo.Text = cmbAddViaPropriedade.Text;

                //aproveitando o if e passando as cidades
                lstRecebeValorCombo.Items.Clear();
                lstRecebeValorCombo.Items.Add("Petropolis");
                lstRecebeValorCombo.Items.Add("Rio de Janeiro");
                lstRecebeValorCombo.Items.Add("Angra dos Reis");
                lstRecebeValorCombo.Items.Add("Arraial do Cabo");
                lstRecebeValorCombo.Items.Add("São Gonçalo");
            }
        }

        private void lstRecebeValorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pegando o ITEM selecionado e enviando a um text. Vms passar o Index de item selecionado
            txtRecebeValorList.Text = lstRecebeValorCombo.SelectedIndex.ToString() + " - " +
                lstRecebeValorCombo.SelectedItem.ToString();
            cmbCidade.Items.Add(lstRecebeValorCombo.SelectedItem.ToString());

            if (cmbCidade.Items.Contains(txtRecebeValorList.Text))
            {
                MessageBox.Show("A cidade: " + txtRecebeValorList.Text + " já foi inserida no combo");
            }
            else
            {
                //Passando o ITEM selecionadp e junto,vms passar o Index do ITEM selecionado
                cmbCidade.Items.Add(lstRecebeValorCombo.SelectedIndex.ToString() + " - " +
                    lstRecebeValorCombo.SelectedItem.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbRecebeEstado.Items.Contains(txtEstado.Text))
            {
                MessageBox.Show("O Estado: " + txtEstado.Text + " já foi digitado");
            }
            else
            {
                cmbRecebeEstado.Items.Add(txtEstado.Text);
                lstRecebeEstadoDigitado.Items.Add(txtEstado.Text);
                txtEstado.Clear();
                txtEstado.Focus();
            }
        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            cmbRecebeEstado.Sorted = true;
            lstRecebeEstadoDigitado.Sorted = true;
        }

        private void btnRemoveCombo_Click(object sender, EventArgs e)
        {
            if (cmbRecebeEstado.Text == "" )
            {
                MessageBox.Show("Favor selecionar algum valor a ser deletado");
            }
            else
            {
                cmbRecebeEstado.Items.Remove(cmbRecebeEstado.SelectedItem);
                //deixando o combo sem seleção
                cmbRecebeEstado.Text = null;
            }
        }

        private void btnRemovedoList_Click(object sender, EventArgs e)
        {
            if (lstRecebeEstadoDigitado.Text == "")
            {
                MessageBox.Show("Favor selecionar algum valor a ser deletado");
            }
            else
            {
                lstRecebeEstadoDigitado.Items.Remove(lstRecebeEstadoDigitado.SelectedItem);
                //deixando o combo sem seleção
                lstRecebeEstadoDigitado.Text = null;
            }
        }

        
    }
}
