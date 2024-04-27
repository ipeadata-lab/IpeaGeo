﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace IpeaGEO
{
    public partial class frmDependenciaLocal : Form
    {
        private clsIpeaShape shapeAlex;
        public clsIpeaShape EstruturaShape
        {
            get
            {
                return shapeAlex;
            }
            set
            {
                shapeAlex = value;
            }
        }
        private Brush[] classeCor;
        public Brush[] CoresParaMapa
        {
            get
            {
                return classeCor;
            }
            set
            {
                classeCor = value;
            }
        }
        private string[] strVariaveisQualitativas;
        public string[] VariaveisQualitativas
        {
            get
            {
                return strVariaveisQualitativas;
            }
            set
            {
                strVariaveisQualitativas = value;
            }
        }
        private string[] strVariaveisQuantitativas;
        public string[] VariaveisQuantitativas
        {
            get
            {
                return strVariaveisQuantitativas;
            }
            set
            {
                strVariaveisQuantitativas = value;
            }
        }

        private string[] strVariaveisSelecionadasQuantitativas;
        public string[] VariaveisSelecionadasQuantitativas
        {
            get
            {
                return strVariaveisSelecionadasQuantitativas;
            }
            set
            {
                strVariaveisSelecionadasQuantitativas = value;
            }
        }


        private int[] classePoligonos;
        public int[] vetorPoligonos
        {
            get
            {
                return classePoligonos;
            }
            set
            {
                classePoligonos = value;
            }
        }
        private string strIDmapa;
        public string IdentificadorMapa
        {
            get
            {
                return strIDmapa;
            }
            set
            {
                strIDmapa = value;
            }
        }

        private bool blRelatorio;
        public bool GeraRelatorio
        {
            get
            {
                return blRelatorio;
            }
            set
            {
                blRelatorio = value;
            }
        }

        private string strID;
        public string IdentificadorDados
        {
            get
            {
                return strID;
            }
            set
            {
                strID = value;
            }
        }
        private DataTable dTable;
        public DataTable DataTableDados
        {
            get
            {
                return dTable;
            }
            set
            {
                dTable = value;
            }
        }

        private string strEnderecoMapa;
        public string EnderecoMapa
        {
            get
            {
                return strEnderecoMapa;
            }
            set
            {
                strEnderecoMapa = value;
            }
        }

        private ArrayList aPintaLISA;
        public ArrayList LISAmapa
        {
            get
            {
                return aPintaLISA;
            }
            set
            {
                aPintaLISA = value;
            }
        }
        private ArrayList aPintaGETIS;
        public ArrayList GETISmapa
        {
            get
            {
                return aPintaGETIS;
            }
            set
            {
                aPintaGETIS = value;
            }
        }
        private ArrayList aEspalhamento;
        public ArrayList ESPALHAMENTOmapa
        {
            get
            {
                return aEspalhamento;
            }
            set
            {
                aEspalhamento = value;
            }
        }
        private ArrayList aPintaESCORE;
        public ArrayList ESCOREmapa
        {
            get
            {
                return aPintaESCORE;
            }
            set
            {
                aPintaESCORE = value;
            }
        }
        private string strCorrecao;
        public string CorrecaoProbabilidade
        {
            get
            {
                return strCorrecao;
            }
            set
            {
                strCorrecao = value;
            }
        }
        private string strTipoVizinhanca;
        public string TipoDeVizinhanca
        {
            get
            {
                return strTipoVizinhanca;
            }
            set
            {
                strTipoVizinhanca = value;
            }
        }
        private string strNivelConfianca;
        public string Confiabilidade
        {
            get
            {
                return strNivelConfianca;
            }
            set
            {
                strNivelConfianca = value;
            }
        }
        private string strTipoCorrecao;
        public string TipoDeCorrecao
        {
            get
            {
                return strTipoCorrecao;
            }
            set
            {
                strTipoCorrecao = value;
            }
        }
        private string strVarPOP;
        public string Populacao
        {
            get
            {
                return strVarPOP;
            }
            set
            {
                strVarPOP = value;
            }
        }
        private string[] strCoresRGB;
        public string[] CoresRGB
        {
            get
            {
                return strCoresRGB;
            }
            set
            {
                strCoresRGB = value;
            }
        }

        public frmDependenciaLocal()
        {
            InitializeComponent();
        }
        private double[,] mDadosQuanti;
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                blRelatorio = chkRelatorio.Checked;
                progressBar1.Visible = true;
                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();


                #region Guarda as variáveis
                int cSelected1 = 0;
                //Variáveis QUANTITATIVAS

                for (int i = 0; i < checkedListBox1.Items.Count; i++) if (checkedListBox1.GetItemChecked(i) == true) cSelected1++;
                string[] strSelecionadasQuanti = new string[cSelected1];
                cSelected1 = 0;
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i) == true)
                    {
                        strSelecionadasQuanti[cSelected1] = checkedListBox1.Items[i].ToString();
                        cSelected1++;
                    }
                }
                strVariaveisSelecionadasQuantitativas = strSelecionadasQuanti;
                #endregion

                if (cSelected1 == 0)
                {
                    MessageBox.Show("Pelo menos uma variável deve ser selecionada.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    #region Encontra a matriz de vizinhança
                    if (shapeAlex.TipoVizinhanca == "")
                    {
                        //Modifica o label
                        labelProgress.Text = "Gerando a matriz de vizinhanças...";
                        Application.DoEvents();

                        //Cria a vizinhnaça
                        clsIpeaShape cps = new clsIpeaShape();
                        int tipo_vizinhanca = -1;
                        if (cmbVizinhanca.SelectedItem.ToString() == "Queen" && chkNormal.Checked == false)
                        {
                            tipo_vizinhanca = 1;
                            shapeAlex.TipoVizinhanca = "Queen";
                        }
                        else if (cmbVizinhanca.SelectedItem.ToString() == "Rook" && chkNormal.Checked == false)
                        {
                            tipo_vizinhanca = 2;
                            shapeAlex.TipoVizinhanca = "Rook";
                        }
                        else if (cmbVizinhanca.SelectedItem.ToString() == "Queen" && chkNormal.Checked == true)
                        {
                            tipo_vizinhanca = 3;
                            shapeAlex.TipoVizinhanca = "Queen Normalizada";
                        }
                        else if (cmbVizinhanca.SelectedItem.ToString() == "Rook" && chkNormal.Checked == true)
                        {
                            tipo_vizinhanca = 4;
                            shapeAlex.TipoVizinhanca = "Rook Normalizada";
                        }

                        cps.DefinicaoVizinhos(ref shapeAlex, tipo_vizinhanca, ref progressBar1);
                    }

                    #endregion

                    //Habilita o label
                    labelProgress.Text = "Inicializando procedimento...";
                    Application.DoEvents();

                    #region Guarda os dados

                    if (cSelected1 > 0 && cmbPop.SelectedItem == null)
                    {
                        mDadosQuanti = new double[dTable.Rows.Count, strVariaveisSelecionadasQuantitativas.Length];
                        for (int i = 0; i < strVariaveisSelecionadasQuantitativas.Length; i++)
                        {
                            for (int j = 0; j < dTable.Rows.Count; j++)
                            {
                                if (double.IsNaN(Convert.ToDouble(dTable.Rows[j][strVariaveisSelecionadasQuantitativas[i]])) == false)
                                {
                                    mDadosQuanti[j, i] = Convert.ToDouble(dTable.Rows[j][strVariaveisSelecionadasQuantitativas[i]]);
                                }
                                else
                                {
                                    mDadosQuanti[j, i] = double.NaN;
                                }
                            }
                        }
                    }
                    if (cSelected1 > 0 && cmbPop.SelectedItem != null)
                    {
                        mDadosQuanti = new double[dTable.Rows.Count, strVariaveisSelecionadasQuantitativas.Length + 1];
                        for (int i = 0; i < strVariaveisSelecionadasQuantitativas.Length; i++)
                        {
                            for (int j = 0; j < dTable.Rows.Count; j++)
                            {
                                if (double.IsNaN(Convert.ToDouble(dTable.Rows[j][strVariaveisSelecionadasQuantitativas[i]])) == false)
                                {
                                    mDadosQuanti[j, i] = Convert.ToDouble(dTable.Rows[j][strVariaveisSelecionadasQuantitativas[i]]);
                                }
                                else
                                {
                                    mDadosQuanti[j, i] = double.NaN;
                                }
                            }
                        }

                        for (int j = 0; j < dTable.Rows.Count; j++)
                        {
                            if (double.IsNaN(Convert.ToDouble(dTable.Rows[j][cmbPop.SelectedItem.ToString()])) == false)
                            {
                                mDadosQuanti[j, mDadosQuanti.GetLength(1) - 1] = Convert.ToDouble(dTable.Rows[j][cmbPop.SelectedItem.ToString()]);
                            }
                            else
                            {
                                mDadosQuanti[j, mDadosQuanti.GetLength(1) - 1] = double.NaN;
                            }
                        }

                    }
                    #endregion

                    clsIndicesLocaisDeDependenciaEspacial clsLocal = new clsIndicesLocaisDeDependenciaEspacial();
                    ArrayList arEspalhamento = new ArrayList();
                    ArrayList arPintaMapaLisa = new ArrayList();
                    ArrayList arPintaMapaGetis = new ArrayList();
                    ArrayList arPintaMapaEscore = new ArrayList();

                    double dblSig = (double)numericUpDown1.Value;
                    strCorrecao = "Nenhuma";
                    if (rdBonferroni.Checked)
                    {
                        dblSig /= (double)shapeAlex.Count;
                        strCorrecao = "Bonferroni";
                    }
                    else if (rdSidak.Checked)
                    {
                        dblSig = 1 - Math.Pow(1 - dblSig, 1.0 / (double)shapeAlex.Count);
                        strCorrecao = "Sidák";
                    }


                    int numColunas = mDadosQuanti.GetLength(1);
                    if (cmbPop.SelectedItem != null) numColunas--;
                    for (int i = 0; i < numColunas; i++)
                    {
                        if (chkLISA.Checked)
                        {
                            //Indice LISA
                            labelProgress.Text = "Calculando indice LISA...";
                            clsLocal.LISA(ref dTable, strIDmapa, mDadosQuanti, strVariaveisSelecionadasQuantitativas[i], i, shapeAlex, dblSig, ref arEspalhamento,
                            ref arPintaMapaLisa, ref progressBar1, ref labelProgress);
                        }
                        if (chkGetis.Checked)
                        {
                            //Indice Getis
                            labelProgress.Text = "Calculando indice Getis-Ord Gi*...";
                            clsLocal.Getis_Ord_Gi(ref dTable, strIDmapa, mDadosQuanti, strVariaveisSelecionadasQuantitativas[i], i, shapeAlex, dblSig,
                            ref arPintaMapaGetis, ref progressBar1, ref labelProgress);
                        }
                        if (chkEscore.Checked)
                        {
                            //Indice ESCORE
                            labelProgress.Text = "Calculando indice Escore...";
                            clsLocal.Escore(ref dTable, strIDmapa, mDadosQuanti, strVariaveisSelecionadasQuantitativas[i], i, shapeAlex, dblSig,
                            ref arPintaMapaEscore, ref progressBar1, ref labelProgress);
                        }
                    }


                    //OK
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                    #region Informações para o relatório

                    strNivelConfianca = dblSig.ToString();
                    strTipoVizinhanca = shapeAlex.TipoVizinhanca;

                    aPintaESCORE = arPintaMapaEscore;
                    aPintaGETIS = arPintaMapaGetis;
                    aPintaLISA = arPintaMapaLisa;
                    aEspalhamento = arEspalhamento;

                    strTipoCorrecao = strCorrecao;
                    if (cmbPop.SelectedItem != null) strVarPOP = cmbPop.SelectedItem.ToString();

                    #region Cores
                    classeCor = new Brush[5];
                    strCoresRGB = new string[5];


                    Color mCor0 = new Color();
                    mCor0 = Color.FromArgb(Color.White.ToArgb());
                    strCoresRGB[0] = System.Drawing.ColorTranslator.ToHtml(mCor0);
                    classeCor[0] = Brushes.White;

                    Color mCor1 = new Color();
                    mCor1 = Color.FromArgb(txtAltoAlto.BackColor.ToArgb());
                    strCoresRGB[1] = System.Drawing.ColorTranslator.ToHtml(mCor1);
                    classeCor[1] = new SolidBrush(mCor1);

                    Color mCor2 = new Color();
                    mCor2 = Color.FromArgb(txtAltoBaixo.BackColor.ToArgb());
                    strCoresRGB[2] = System.Drawing.ColorTranslator.ToHtml(mCor2);
                    classeCor[2] = new SolidBrush(mCor2);

                    Color mCor3 = new Color();
                    mCor3 = Color.FromArgb(txtBaixoBaixo.BackColor.ToArgb());
                    strCoresRGB[3] = System.Drawing.ColorTranslator.ToHtml(mCor3);
                    classeCor[3] = new SolidBrush(mCor3);

                    Color mCor4 = new Color();
                    mCor4 = Color.FromArgb(txtBaixoAlto.BackColor.ToArgb());
                    strCoresRGB[4] = System.Drawing.ColorTranslator.ToHtml(mCor4);
                    classeCor[4] = new SolidBrush(mCor4);

                    #endregion

                    #endregion

                    this.Cursor = Cursors.Default;
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDependenciaLocal_Load(object sender, EventArgs e)
        {
            //Adiciona as variáveis
            checkedListBox1.Items.AddRange(strVariaveisQuantitativas);
            cmbVizinhanca.SelectedIndex = 0;
            cmbPop.Items.AddRange(strVariaveisQuantitativas);
        }

  

        private void txtAltoAlto_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;

            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;

            // Sets the initial color select to the current text color,
            // so that if the user cancels out, the original color is restored.
            MyDialog.Color = txtAltoAlto.BackColor;

            // Open color selection dialog box
            MyDialog.ShowDialog();

            txtAltoAlto.BackColor = Color.FromArgb((int)MyDialog.Color.R, (int)MyDialog.Color.G, (int)MyDialog.Color.B);

            btnOk.Focus();
        }

        private void txtAltoBaixo_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;

            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;

            // Sets the initial color select to the current text color,
            // so that if the user cancels out, the original color is restored.
            MyDialog.Color = txtAltoBaixo.BackColor;

            // Open color selection dialog box
            MyDialog.ShowDialog();

            txtAltoBaixo.BackColor = Color.FromArgb((int)MyDialog.Color.R, (int)MyDialog.Color.G, (int)MyDialog.Color.B);

            btnOk.Focus();
        }

        private void txtBaixoBaixo_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;

            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;

            // Sets the initial color select to the current text color,
            // so that if the user cancels out, the original color is restored.
            MyDialog.Color = txtBaixoBaixo.BackColor;

            // Open color selection dialog box
            MyDialog.ShowDialog();

            txtBaixoBaixo.BackColor = Color.FromArgb((int)MyDialog.Color.R, (int)MyDialog.Color.G, (int)MyDialog.Color.B);

            btnOk.Focus();
        }

        private void txtBaixoAlto_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;

            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;

            // Sets the initial color select to the current text color,
            // so that if the user cancels out, the original color is restored.
            MyDialog.Color = txtBaixoAlto.BackColor;

            // Open color selection dialog box
            MyDialog.ShowDialog();

            txtBaixoAlto.BackColor = Color.FromArgb((int)MyDialog.Color.R, (int)MyDialog.Color.G, (int)MyDialog.Color.B);

            btnOk.Focus();
        }

        private void chkEscore_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEscore.Checked)
            {
                cmbPop.SelectedIndex = 0;
                cmbPop.Enabled = true;
            }
            else
            {
                cmbPop.Enabled = false;
                cmbPop.SelectedIndex = -1;
            }
        }
    }
}