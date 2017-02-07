using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GEDConsultar
{
    public partial class frmPrincipal : Form
    {
        private Mes mesIniProcessos;
        private Mes mesFimProcessos;
        private Mes mesIniLicitacao;
        private Mes mesFimLicitacao;
        private Mes mesIniExtratos;
        private Mes mesFimExtratos;
        private ModalidadeProc modalidadeProc;

        public frmPrincipal()
        {
            InitializeComponent();

            mesIniProcessos = new Mes();
            mesFimProcessos = new Mes();
            mesIniLicitacao = new Mes();
            mesFimLicitacao = new Mes();
            mesIniExtratos = new Mes();
            mesFimExtratos = new Mes();
            modalidadeProc = new ModalidadeProc();
        }

        private void frmPrincipal_Load( object sender, EventArgs e )
        {
            try
            {
                Application.DoEvents();
                Cursor.Current = Cursors.WaitCursor;

                Meses Mesesobj = new Meses();

                this.mesIniProcessosBindingSource.DataSource = Mesesobj.Dados();
                this.mesFimProcessosBindingSource.DataSource = Mesesobj.Dados();
                this.mesIniLicitacaoBindingSource.DataSource = Mesesobj.Dados();
                this.mesFimLicitacaoBindingSource.DataSource = Mesesobj.Dados();
                this.mesIniExtratosBindingSource.DataSource = Mesesobj.Dados();
                this.mesFimExtratosBindingSource.DataSource = Mesesobj.Dados();
                this.modalidadeProcBindingSource.DataSource = modalidadeProc.Dados();
            }
            catch ( Exception ex )
            {

                MessageBox.Show( this, $"Erro\n\n{ex.Message}", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1 );
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void comboBoxMesIniProcessos_SelectedValueChanged( object sender, EventArgs e )
        {
            if ( this.comboBoxMesIniProcessos.SelectedItem != null )
                mesIniProcessos = this.mesIniProcessosBindingSource.Current as Mes;
        }

        private void comboBoxMesFimProcessos_SelectedValueChanged( object sender, EventArgs e )
        {
            if ( this.comboBoxMesFimProcessos.SelectedItem != null )
                mesFimProcessos = this.mesFimProcessosBindingSource.Current as Mes;
        }

        private void comboBoxMesIniLicitacao_SelectedValueChanged( object sender, EventArgs e )
        {
            if ( this.comboBoxMesIniLicitacao.SelectedItem != null )
                mesIniLicitacao = this.mesIniLicitacaoBindingSource.Current as Mes;
        }

        private void comboBoxMesFimLicitacao_SelectedValueChanged( object sender, EventArgs e )
        {
            if ( this.comboBoxMesFimLicitacao.SelectedItem != null )
                mesFimLicitacao = this.mesFimLicitacaoBindingSource.Current as Mes;
        }

        private void comboBoxMesIniExtratos_SelectedValueChanged( object sender, EventArgs e )
        {
            if ( this.comboBoxMesIniExtratos.SelectedItem != null )
                mesIniExtratos = this.mesIniExtratosBindingSource.Current as Mes;
        }

        private void comboBoxMesFimExtratos_SelectedValueChanged( object sender, EventArgs e )
        {
            if ( this.comboBoxMesFimExtratos.SelectedItem != null )
                mesFimExtratos = this.mesFimExtratosBindingSource.Current as Mes;
        }
    }
}
