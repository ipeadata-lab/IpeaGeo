﻿namespace IpeaGEO
{
    partial class frmCluster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRedefinirClusters = new System.Windows.Forms.Button();
            this.cmbVizinhanca = new System.Windows.Forms.ComboBox();
            this.Cores = new System.Windows.Forms.Label();
            this.cmbCores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAleatorio = new System.Windows.Forms.CheckBox();
            this.chkRelatorio = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.percMaxPolygon = new System.Windows.Forms.NumericUpDown();
            this.numMaxPolygon = new System.Windows.Forms.NumericUpDown();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numCluster = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numMaxClusters = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numMinClusters = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.gbDistancias = new System.Windows.Forms.GroupBox();
            this.numPesoOrdinais = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numPesoCategorica = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numPesoBinaria = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDistanciaOrdinaria = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDistanciaCategorica = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDistanciaBinaria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDistancia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numMinkowsky = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoVariaveis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label7 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percMaxPolygon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPolygon)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCluster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxClusters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinClusters)).BeginInit();
            this.gbDistancias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoOrdinais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoCategorica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoBinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinkowsky)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(971, 492);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(850, 492);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 5;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Variável";
            this.dataColumn1.ColumnName = "Variável";
            this.dataColumn1.ReadOnly = true;
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Peso";
            this.dataColumn2.ColumnName = "Peso";
            this.dataColumn2.DataType = typeof(double);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 545);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnCancela);
            this.tabPage1.Controls.Add(this.btnOK);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parâmetros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView2);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(397, 480);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Seleção de variáveis";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(391, 461);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.gbDistancias);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbTipoVariaveis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbMetodo);
            this.groupBox1.Location = new System.Drawing.Point(409, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 480);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.btnRedefinirClusters);
            this.groupBox6.Controls.Add(this.cmbVizinhanca);
            this.groupBox6.Controls.Add(this.Cores);
            this.groupBox6.Controls.Add(this.cmbCores);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.chkAleatorio);
            this.groupBox6.Controls.Add(this.chkRelatorio);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Location = new System.Drawing.Point(369, 233);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(268, 235);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Outras opções";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Gera árvore de conglomerados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRedefinirClusters
            // 
            this.btnRedefinirClusters.Enabled = false;
            this.btnRedefinirClusters.Location = new System.Drawing.Point(24, 196);
            this.btnRedefinirClusters.Name = "btnRedefinirClusters";
            this.btnRedefinirClusters.Size = new System.Drawing.Size(226, 23);
            this.btnRedefinirClusters.TabIndex = 17;
            this.btnRedefinirClusters.Text = "Redefinir conglomerados";
            this.btnRedefinirClusters.UseVisualStyleBackColor = true;
            this.btnRedefinirClusters.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbVizinhanca
            // 
            this.cmbVizinhanca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVizinhanca.FormattingEnabled = true;
            this.cmbVizinhanca.Items.AddRange(new object[] {
            "Queen",
            "Rook"});
            this.cmbVizinhanca.Location = new System.Drawing.Point(24, 45);
            this.cmbVizinhanca.Name = "cmbVizinhanca";
            this.cmbVizinhanca.Size = new System.Drawing.Size(226, 21);
            this.cmbVizinhanca.TabIndex = 12;
            // 
            // Cores
            // 
            this.Cores.AutoSize = true;
            this.Cores.Location = new System.Drawing.Point(21, 86);
            this.Cores.Name = "Cores";
            this.Cores.Size = new System.Drawing.Size(34, 13);
            this.Cores.TabIndex = 5;
            this.Cores.Text = "Cores";
            // 
            // cmbCores
            // 
            this.cmbCores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCores.FormattingEnabled = true;
            this.cmbCores.Items.AddRange(new object[] {
            "Mahalanobis",
            "Ward",
            "Euclidiana",
            "K-means"});
            this.cmbCores.Location = new System.Drawing.Point(24, 102);
            this.cmbCores.Name = "cmbCores";
            this.cmbCores.Size = new System.Drawing.Size(226, 21);
            this.cmbCores.TabIndex = 4;
            this.cmbCores.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbCores_DrawItem_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vizinhança";
            this.label4.Visible = false;
            // 
            // chkAleatorio
            // 
            this.chkAleatorio.AutoSize = true;
            this.chkAleatorio.Checked = true;
            this.chkAleatorio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAleatorio.Location = new System.Drawing.Point(24, 129);
            this.chkAleatorio.Name = "chkAleatorio";
            this.chkAleatorio.Size = new System.Drawing.Size(102, 17);
            this.chkAleatorio.TabIndex = 14;
            this.chkAleatorio.Text = "Cores Aleatórias";
            this.chkAleatorio.UseVisualStyleBackColor = true;
            this.chkAleatorio.CheckedChanged += new System.EventHandler(this.chkAleatorio_CheckedChanged_1);
            // 
            // chkRelatorio
            // 
            this.chkRelatorio.AutoSize = true;
            this.chkRelatorio.Checked = true;
            this.chkRelatorio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRelatorio.Location = new System.Drawing.Point(161, 129);
            this.chkRelatorio.Name = "chkRelatorio";
            this.chkRelatorio.Size = new System.Drawing.Size(89, 17);
            this.chkRelatorio.TabIndex = 16;
            this.chkRelatorio.Text = "Gera relatório";
            this.chkRelatorio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 10);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.percMaxPolygon);
            this.groupBox5.Controls.Add(this.numMaxPolygon);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(17, 362);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 106);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controle do tamanho máximo dos clusters";
            // 
            // percMaxPolygon
            // 
            this.percMaxPolygon.DecimalPlaces = 2;
            this.percMaxPolygon.Enabled = false;
            this.percMaxPolygon.Location = new System.Drawing.Point(236, 70);
            this.percMaxPolygon.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.percMaxPolygon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.percMaxPolygon.Name = "percMaxPolygon";
            this.percMaxPolygon.Size = new System.Drawing.Size(82, 20);
            this.percMaxPolygon.TabIndex = 26;
            this.percMaxPolygon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.percMaxPolygon.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numMaxPolygon
            // 
            this.numMaxPolygon.Enabled = false;
            this.numMaxPolygon.Location = new System.Drawing.Point(236, 47);
            this.numMaxPolygon.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxPolygon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxPolygon.Name = "numMaxPolygon";
            this.numMaxPolygon.Size = new System.Drawing.Size(82, 20);
            this.numMaxPolygon.TabIndex = 25;
            this.numMaxPolygon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaxPolygon.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(191, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Percentagem máximo de polígonos";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(165, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Número máximo de polígonos";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sem limitação";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numCluster);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.numMaxClusters);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.numMinClusters);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(17, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 124);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Árvore de clusters";
            // 
            // numCluster
            // 
            this.numCluster.Location = new System.Drawing.Point(236, 84);
            this.numCluster.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCluster.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCluster.Name = "numCluster";
            this.numCluster.Size = new System.Drawing.Size(82, 20);
            this.numCluster.TabIndex = 24;
            this.numCluster.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCluster.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Número escolhido de clusters";
            // 
            // numMaxClusters
            // 
            this.numMaxClusters.Location = new System.Drawing.Point(236, 56);
            this.numMaxClusters.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxClusters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxClusters.Name = "numMaxClusters";
            this.numMaxClusters.Size = new System.Drawing.Size(82, 20);
            this.numMaxClusters.TabIndex = 22;
            this.numMaxClusters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaxClusters.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Número máximo de clusters";
            // 
            // numMinClusters
            // 
            this.numMinClusters.Location = new System.Drawing.Point(236, 29);
            this.numMinClusters.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMinClusters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinClusters.Name = "numMinClusters";
            this.numMinClusters.Size = new System.Drawing.Size(82, 20);
            this.numMinClusters.TabIndex = 20;
            this.numMinClusters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMinClusters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Número mínimo de clusters";
            // 
            // gbDistancias
            // 
            this.gbDistancias.Controls.Add(this.numPesoOrdinais);
            this.gbDistancias.Controls.Add(this.label14);
            this.gbDistancias.Controls.Add(this.numPesoCategorica);
            this.gbDistancias.Controls.Add(this.label13);
            this.gbDistancias.Controls.Add(this.numPesoBinaria);
            this.gbDistancias.Controls.Add(this.label12);
            this.gbDistancias.Controls.Add(this.cmbDistanciaOrdinaria);
            this.gbDistancias.Controls.Add(this.label11);
            this.gbDistancias.Controls.Add(this.cmbDistanciaCategorica);
            this.gbDistancias.Controls.Add(this.label10);
            this.gbDistancias.Controls.Add(this.cmbDistanciaBinaria);
            this.gbDistancias.Controls.Add(this.label9);
            this.gbDistancias.Controls.Add(this.cmbDistancia);
            this.gbDistancias.Controls.Add(this.label2);
            this.gbDistancias.Controls.Add(this.numMinkowsky);
            this.gbDistancias.Controls.Add(this.label6);
            this.gbDistancias.Location = new System.Drawing.Point(17, 83);
            this.gbDistancias.Name = "gbDistancias";
            this.gbDistancias.Size = new System.Drawing.Size(620, 144);
            this.gbDistancias.TabIndex = 19;
            this.gbDistancias.TabStop = false;
            this.gbDistancias.Text = "Especificação das Distâncias";
            // 
            // numPesoOrdinais
            // 
            this.numPesoOrdinais.DecimalPlaces = 2;
            this.numPesoOrdinais.Enabled = false;
            this.numPesoOrdinais.Location = new System.Drawing.Point(520, 107);
            this.numPesoOrdinais.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPesoOrdinais.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPesoOrdinais.Name = "numPesoOrdinais";
            this.numPesoOrdinais.Size = new System.Drawing.Size(82, 20);
            this.numPesoOrdinais.TabIndex = 20;
            this.numPesoOrdinais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPesoOrdinais.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(403, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Pesos vars. ordinais";
            // 
            // numPesoCategorica
            // 
            this.numPesoCategorica.DecimalPlaces = 2;
            this.numPesoCategorica.Enabled = false;
            this.numPesoCategorica.Location = new System.Drawing.Point(520, 80);
            this.numPesoCategorica.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPesoCategorica.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPesoCategorica.Name = "numPesoCategorica";
            this.numPesoCategorica.Size = new System.Drawing.Size(82, 20);
            this.numPesoCategorica.TabIndex = 18;
            this.numPesoCategorica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPesoCategorica.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(403, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Peso vars. categóricas";
            // 
            // numPesoBinaria
            // 
            this.numPesoBinaria.DecimalPlaces = 2;
            this.numPesoBinaria.Enabled = false;
            this.numPesoBinaria.Location = new System.Drawing.Point(520, 52);
            this.numPesoBinaria.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPesoBinaria.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPesoBinaria.Name = "numPesoBinaria";
            this.numPesoBinaria.Size = new System.Drawing.Size(82, 20);
            this.numPesoBinaria.TabIndex = 16;
            this.numPesoBinaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPesoBinaria.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Peso vars. binárias";
            // 
            // cmbDistanciaOrdinaria
            // 
            this.cmbDistanciaOrdinaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistanciaOrdinaria.Enabled = false;
            this.cmbDistanciaOrdinaria.FormattingEnabled = true;
            this.cmbDistanciaOrdinaria.Items.AddRange(new object[] {
            "Euclidiana",
            "Manhattan",
            "Minkowsky",
            "Variance Corrected ",
            "Mahalanobis"});
            this.cmbDistanciaOrdinaria.Location = new System.Drawing.Point(137, 106);
            this.cmbDistanciaOrdinaria.Name = "cmbDistanciaOrdinaria";
            this.cmbDistanciaOrdinaria.Size = new System.Drawing.Size(247, 21);
            this.cmbDistanciaOrdinaria.TabIndex = 14;
            this.cmbDistanciaOrdinaria.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Variáveis ordinais";
            // 
            // cmbDistanciaCategorica
            // 
            this.cmbDistanciaCategorica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistanciaCategorica.Enabled = false;
            this.cmbDistanciaCategorica.FormattingEnabled = true;
            this.cmbDistanciaCategorica.Items.AddRange(new object[] {
            "SimpleMatching"});
            this.cmbDistanciaCategorica.Location = new System.Drawing.Point(137, 79);
            this.cmbDistanciaCategorica.Name = "cmbDistanciaCategorica";
            this.cmbDistanciaCategorica.Size = new System.Drawing.Size(247, 21);
            this.cmbDistanciaCategorica.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Variáveis categóricas";
            // 
            // cmbDistanciaBinaria
            // 
            this.cmbDistanciaBinaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistanciaBinaria.Enabled = false;
            this.cmbDistanciaBinaria.FormattingEnabled = true;
            this.cmbDistanciaBinaria.Items.AddRange(new object[] {
            "Dice",
            "Jaccard",
            "Kulczynski",
            "RusselRao",
            "SimpleMatching",
            "Tanimoto"});
            this.cmbDistanciaBinaria.Location = new System.Drawing.Point(137, 51);
            this.cmbDistanciaBinaria.Name = "cmbDistanciaBinaria";
            this.cmbDistanciaBinaria.Size = new System.Drawing.Size(247, 21);
            this.cmbDistanciaBinaria.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Variáveis binárias";
            // 
            // cmbDistancia
            // 
            this.cmbDistancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistancia.Enabled = false;
            this.cmbDistancia.FormattingEnabled = true;
            this.cmbDistancia.Items.AddRange(new object[] {
            "Euclidiana",
            "Manhattan",
            "Minkowsky",
            "Variance Corrected ",
            "Mahalanobis"});
            this.cmbDistancia.Location = new System.Drawing.Point(137, 24);
            this.cmbDistancia.Name = "cmbDistancia";
            this.cmbDistancia.Size = new System.Drawing.Size(247, 21);
            this.cmbDistancia.TabIndex = 0;
            this.cmbDistancia.SelectedIndexChanged += new System.EventHandler(this.cmbDistancia_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variáveis contínuas";
            // 
            // numMinkowsky
            // 
            this.numMinkowsky.DecimalPlaces = 2;
            this.numMinkowsky.Enabled = false;
            this.numMinkowsky.Location = new System.Drawing.Point(520, 25);
            this.numMinkowsky.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMinkowsky.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinkowsky.Name = "numMinkowsky";
            this.numMinkowsky.Size = new System.Drawing.Size(82, 20);
            this.numMinkowsky.TabIndex = 8;
            this.numMinkowsky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMinkowsky.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fator Minkowsky";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo de variáveis";
            // 
            // cmbTipoVariaveis
            // 
            this.cmbTipoVariaveis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVariaveis.FormattingEnabled = true;
            this.cmbTipoVariaveis.Items.AddRange(new object[] {
            "Contínuas",
            "Binárias",
            "Categóricas",
            "Ordinais",
            "Mistas"});
            this.cmbTipoVariaveis.Location = new System.Drawing.Point(154, 46);
            this.cmbTipoVariaveis.Name = "cmbTipoVariaveis";
            this.cmbTipoVariaveis.Size = new System.Drawing.Size(247, 21);
            this.cmbTipoVariaveis.TabIndex = 17;
            this.cmbTipoVariaveis.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVariaveis_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Método";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Items.AddRange(new object[] {
            "Ward",
            "Average Linkage",
            "Centroid",
            "Complete Linkage",
            "Single Linkage"});
            this.cmbMetodo.Location = new System.Drawing.Point(154, 22);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(247, 21);
            this.cmbMetodo.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Árvore de conglomerados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1059, 513);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.zedGraphControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1065, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Critérios de seleção";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0;
            this.zedGraphControl1.ScrollMaxX = 0;
            this.zedGraphControl1.ScrollMaxY = 0;
            this.zedGraphControl1.ScrollMaxY2 = 0;
            this.zedGraphControl1.ScrollMinX = 0;
            this.zedGraphControl1.ScrollMinY = 0;
            this.zedGraphControl1.ScrollMinY2 = 0;
            this.zedGraphControl1.Size = new System.Drawing.Size(1059, 513);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1,
            this.label7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1075, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 16);
            // 
            // label7
            // 
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            // 
            // frmCluster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 568);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCluster";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conglomerados Espaciais Hierárquicos";
            this.Load += new System.EventHandler(this.frmCluster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percMaxPolygon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPolygon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCluster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxClusters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinClusters)).EndInit();
            this.gbDistancias.ResumeLayout(false);
            this.gbDistancias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoOrdinais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoCategorica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoBinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinkowsky)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancela;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.ComboBox cmbVizinhanca;
        private System.Windows.Forms.Label Cores;
        private System.Windows.Forms.ComboBox cmbCores;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAleatorio;
        private System.Windows.Forms.CheckBox chkRelatorio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown percMaxPolygon;
        private System.Windows.Forms.NumericUpDown numMaxPolygon;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numCluster;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numMaxClusters;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numMinClusters;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbDistancias;
        private System.Windows.Forms.NumericUpDown numPesoOrdinais;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numPesoCategorica;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numPesoBinaria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbDistanciaOrdinaria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDistanciaCategorica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDistanciaBinaria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDistancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMinkowsky;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoVariaveis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button btnRedefinirClusters;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
    }
}