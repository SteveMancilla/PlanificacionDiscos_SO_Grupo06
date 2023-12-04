namespace Programa_Final___Sistemas_Operativos
{
    partial class frmPantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.txtPeticion = new System.Windows.Forms.TextBox();
            this.txtFIFO = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coPetición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coPista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDesarrollar = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.coCLOOKAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coCLOOKAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.coLOOKAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coLOOKAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.coCSCANAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coCSCANAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.coSCANAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coSCANAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.coSSTFAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coSSTFAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.coFIFOAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coFIFOAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSSTF = new System.Windows.Forms.TextBox();
            this.txtSCAN = new System.Windows.Forms.TextBox();
            this.txtCSCAN = new System.Windows.Forms.TextBox();
            this.txtLOOK = new System.Windows.Forms.TextBox();
            this.txtCLOOK = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFIFO = new System.Windows.Forms.Button();
            this.btnSSTF = new System.Windows.Forms.Button();
            this.btnSCAN = new System.Windows.Forms.Button();
            this.btnCSCAN = new System.Windows.Forms.Button();
            this.btnLOOK = new System.Windows.Forms.Button();
            this.btnCLOOK = new System.Windows.Forms.Button();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCopy = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algoritmos de Planificación de Disco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el tamaño total de pistas del disco duro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la posición inicial del cabezal del disco duro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese una petición de pista del disco duro:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(737, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 35);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTamaño
            // 
            this.txtTamaño.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamaño.Location = new System.Drawing.Point(588, 65);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 23);
            this.txtTamaño.TabIndex = 5;
            this.txtTamaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicion.Location = new System.Drawing.Point(588, 113);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(100, 23);
            this.txtPosicion.TabIndex = 6;
            this.txtPosicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPeticion
            // 
            this.txtPeticion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeticion.Location = new System.Drawing.Point(588, 164);
            this.txtPeticion.Name = "txtPeticion";
            this.txtPeticion.Size = new System.Drawing.Size(100, 23);
            this.txtPeticion.TabIndex = 7;
            this.txtPeticion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeticion.TextChanged += new System.EventHandler(this.txtPeticion_TextChanged);
            // 
            // txtFIFO
            // 
            this.txtFIFO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFIFO.Location = new System.Drawing.Point(123, 603);
            this.txtFIFO.Name = "txtFIFO";
            this.txtFIFO.Size = new System.Drawing.Size(100, 23);
            this.txtFIFO.TabIndex = 11;
            this.txtFIFO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(540, 685);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 35);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(723, 685);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 35);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coPetición,
            this.coPista});
            this.dataGridView1.Location = new System.Drawing.Point(1039, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 119);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // coPetición
            // 
            this.coPetición.HeaderText = "Petición";
            this.coPetición.Name = "coPetición";
            // 
            // coPista
            // 
            this.coPista.HeaderText = "Pista";
            this.coPista.Name = "coPista";
            // 
            // btnDesarrollar
            // 
            this.btnDesarrollar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesarrollar.Location = new System.Drawing.Point(874, 116);
            this.btnDesarrollar.Name = "btnDesarrollar";
            this.btnDesarrollar.Size = new System.Drawing.Size(100, 35);
            this.btnDesarrollar.TabIndex = 16;
            this.btnDesarrollar.Text = "Comparar";
            this.btnDesarrollar.UseVisualStyleBackColor = true;
            this.btnDesarrollar.Click += new System.EventHandler(this.btnDesarrollar_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coCLOOKAC,
            this.coCLOOKAT});
            this.dataGridView3.Location = new System.Drawing.Point(1062, 311);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(243, 252);
            this.dataGridView3.TabIndex = 17;
            // 
            // coCLOOKAC
            // 
            this.coCLOOKAC.HeaderText = "     CLOOK Próxima Pista    Accedida";
            this.coCLOOKAC.Name = "coCLOOKAC";
            // 
            // coCLOOKAT
            // 
            this.coCLOOKAT.HeaderText = "   CLOOK Número de      Pistas Atravesadas";
            this.coCLOOKAT.Name = "coCLOOKAT";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coLOOKAC,
            this.coLOOKAT});
            this.dataGridView4.Location = new System.Drawing.Point(861, 311);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(243, 252);
            this.dataGridView4.TabIndex = 18;
            // 
            // coLOOKAC
            // 
            this.coLOOKAC.HeaderText = "      LOOK Próxima Pista    Accedida";
            this.coLOOKAC.Name = "coLOOKAC";
            // 
            // coLOOKAT
            // 
            this.coLOOKAT.HeaderText = "    LOOK Número de      Pistas Atravesadas";
            this.coLOOKAT.Name = "coLOOKAT";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coCSCANAC,
            this.coCSCANAT});
            this.dataGridView5.Location = new System.Drawing.Point(660, 311);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(243, 252);
            this.dataGridView5.TabIndex = 19;
            // 
            // coCSCANAC
            // 
            this.coCSCANAC.HeaderText = "     CSCAN Próxima Pista     Accedida";
            this.coCSCANAC.Name = "coCSCANAC";
            // 
            // coCSCANAT
            // 
            this.coCSCANAT.HeaderText = "    CSCAN Número de Pistas Atravesadas";
            this.coCSCANAT.Name = "coCSCANAT";
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coSCANAC,
            this.coSCANAT});
            this.dataGridView6.Location = new System.Drawing.Point(459, 311);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(243, 252);
            this.dataGridView6.TabIndex = 20;
            // 
            // coSCANAC
            // 
            this.coSCANAC.HeaderText = "     SCAN Próxima Pista     Accedida";
            this.coSCANAC.Name = "coSCANAC";
            // 
            // coSCANAT
            // 
            this.coSCANAT.HeaderText = "    SCAN Número de Pistas Atravesadas";
            this.coSCANAT.Name = "coSCANAT";
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coSSTFAC,
            this.coSSTFAT});
            this.dataGridView7.Location = new System.Drawing.Point(259, 311);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(243, 252);
            this.dataGridView7.TabIndex = 21;
            // 
            // coSSTFAC
            // 
            this.coSSTFAC.HeaderText = "      SSTF Próxima Pista     Accedida";
            this.coSSTFAC.Name = "coSSTFAC";
            // 
            // coSSTFAT
            // 
            this.coSSTFAT.HeaderText = "     SSTF Número de Pistas Atravesadas";
            this.coSSTFAT.Name = "coSSTFAT";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coFIFOAC,
            this.coFIFOAT});
            this.dataGridView2.Location = new System.Drawing.Point(60, 311);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 252);
            this.dataGridView2.TabIndex = 22;
            // 
            // coFIFOAC
            // 
            this.coFIFOAC.HeaderText = "      FIFO Próxima Pista     Accedida";
            this.coFIFOAC.Name = "coFIFOAC";
            // 
            // coFIFOAT
            // 
            this.coFIFOAT.HeaderText = "     FIFO Número de Pistas Atravesadas";
            this.coFIFOAT.Name = "coFIFOAT";
            // 
            // txtSSTF
            // 
            this.txtSSTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSTF.Location = new System.Drawing.Point(347, 603);
            this.txtSSTF.Name = "txtSSTF";
            this.txtSSTF.Size = new System.Drawing.Size(100, 23);
            this.txtSSTF.TabIndex = 23;
            this.txtSSTF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSCAN
            // 
            this.txtSCAN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCAN.Location = new System.Drawing.Point(539, 603);
            this.txtSCAN.Name = "txtSCAN";
            this.txtSCAN.Size = new System.Drawing.Size(100, 23);
            this.txtSCAN.TabIndex = 24;
            this.txtSCAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCSCAN
            // 
            this.txtCSCAN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSCAN.Location = new System.Drawing.Point(745, 603);
            this.txtCSCAN.Name = "txtCSCAN";
            this.txtCSCAN.Size = new System.Drawing.Size(100, 23);
            this.txtCSCAN.TabIndex = 25;
            this.txtCSCAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLOOK
            // 
            this.txtLOOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLOOK.Location = new System.Drawing.Point(947, 603);
            this.txtLOOK.Name = "txtLOOK";
            this.txtLOOK.Size = new System.Drawing.Size(100, 23);
            this.txtLOOK.TabIndex = 26;
            this.txtLOOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCLOOK
            // 
            this.txtCLOOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCLOOK.Location = new System.Drawing.Point(1144, 603);
            this.txtCLOOK.Name = "txtCLOOK";
            this.txtCLOOK.Size = new System.Drawing.Size(100, 23);
            this.txtCLOOK.TabIndex = 27;
            this.txtCLOOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(169, 646);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 21);
            this.lblResultado.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(374, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "SSTF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "SCAN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(759, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "CSCAN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(969, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "LOOK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1158, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "CLOOK";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 566);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 34);
            this.label11.TabIndex = 40;
            this.label11.Text = "Longitud media \r\nde busqueda:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(344, 566);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 34);
            this.label12.TabIndex = 41;
            this.label12.Text = "Longitud media \r\nde busqueda:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(536, 566);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 34);
            this.label13.TabIndex = 42;
            this.label13.Text = "Longitud media \r\nde busqueda:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(742, 566);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 34);
            this.label14.TabIndex = 43;
            this.label14.Text = "Longitud media \r\nde busqueda:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(944, 566);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 34);
            this.label15.TabIndex = 44;
            this.label15.Text = "Longitud media \r\nde busqueda:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1145, 566);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 34);
            this.label16.TabIndex = 45;
            this.label16.Text = "Longitud media \r\nde busqueda:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1339, -120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 23);
            this.label17.TabIndex = 46;
            this.label17.Text = "Lista de Peticiones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "FIFO";
            // 
            // btnFIFO
            // 
            this.btnFIFO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFIFO.Location = new System.Drawing.Point(154, 249);
            this.btnFIFO.Name = "btnFIFO";
            this.btnFIFO.Size = new System.Drawing.Size(73, 48);
            this.btnFIFO.TabIndex = 47;
            this.btnFIFO.Text = "Generar \r\ngráfico";
            this.btnFIFO.UseVisualStyleBackColor = true;
            this.btnFIFO.Click += new System.EventHandler(this.btnFIFO_Click);
            // 
            // btnSSTF
            // 
            this.btnSSTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSTF.Location = new System.Drawing.Point(363, 249);
            this.btnSSTF.Name = "btnSSTF";
            this.btnSSTF.Size = new System.Drawing.Size(73, 48);
            this.btnSSTF.TabIndex = 48;
            this.btnSSTF.Text = "Generar \r\ngráfico";
            this.btnSSTF.UseVisualStyleBackColor = true;
            this.btnSSTF.Click += new System.EventHandler(this.btnSSTF_Click);
            // 
            // btnSCAN
            // 
            this.btnSCAN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCAN.Location = new System.Drawing.Point(561, 249);
            this.btnSCAN.Name = "btnSCAN";
            this.btnSCAN.Size = new System.Drawing.Size(73, 48);
            this.btnSCAN.TabIndex = 49;
            this.btnSCAN.Text = "Generar \r\ngráfico";
            this.btnSCAN.UseVisualStyleBackColor = true;
            this.btnSCAN.Click += new System.EventHandler(this.btnSCAN_Click);
            // 
            // btnCSCAN
            // 
            this.btnCSCAN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSCAN.Location = new System.Drawing.Point(764, 249);
            this.btnCSCAN.Name = "btnCSCAN";
            this.btnCSCAN.Size = new System.Drawing.Size(73, 48);
            this.btnCSCAN.TabIndex = 50;
            this.btnCSCAN.Text = "Generar \r\ngráfico";
            this.btnCSCAN.UseVisualStyleBackColor = true;
            this.btnCSCAN.Click += new System.EventHandler(this.btnCSCAN_Click);
            // 
            // btnLOOK
            // 
            this.btnLOOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOOK.Location = new System.Drawing.Point(966, 249);
            this.btnLOOK.Name = "btnLOOK";
            this.btnLOOK.Size = new System.Drawing.Size(73, 48);
            this.btnLOOK.TabIndex = 51;
            this.btnLOOK.Text = "Generar \r\ngráfico";
            this.btnLOOK.UseVisualStyleBackColor = true;
            this.btnLOOK.Click += new System.EventHandler(this.btnLOOK_Click);
            // 
            // btnCLOOK
            // 
            this.btnCLOOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLOOK.Location = new System.Drawing.Point(1163, 249);
            this.btnCLOOK.Name = "btnCLOOK";
            this.btnCLOOK.Size = new System.Drawing.Size(73, 48);
            this.btnCLOOK.TabIndex = 52;
            this.btnCLOOK.Text = "Generar \r\ngráfico";
            this.btnCLOOK.UseVisualStyleBackColor = true;
            this.btnCLOOK.Click += new System.EventHandler(this.btnCLOOK_Click);
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConclusion.Location = new System.Drawing.Point(56, 648);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(116, 19);
            this.lblConclusion.TabIndex = 53;
            this.lblConclusion.Text = "CONCLUSIÓN:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(737, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.TabIndex = 54;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopy.Location = new System.Drawing.Point(718, 773);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(177, 17);
            this.lblCopy.TabIndex = 55;
            this.lblCopy.Text = "Copyright© 2023 Grupo 06";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1092, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 21);
            this.label18.TabIndex = 56;
            this.label18.Text = "Lista de Peticiones";
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.btnCLOOK);
            this.Controls.Add(this.btnLOOK);
            this.Controls.Add(this.btnCSCAN);
            this.Controls.Add(this.btnSCAN);
            this.Controls.Add(this.btnSSTF);
            this.Controls.Add(this.btnFIFO);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtCLOOK);
            this.Controls.Add(this.txtLOOK);
            this.Controls.Add(this.txtCSCAN);
            this.Controls.Add(this.txtSCAN);
            this.Controls.Add(this.txtSSTF);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnDesarrollar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtFIFO);
            this.Controls.Add(this.txtPeticion);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen Final - Grupo 06";
            this.Load += new System.EventHandler(this.frmPantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.TextBox txtPeticion;
        private System.Windows.Forms.TextBox txtFIFO;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coPetición;
        private System.Windows.Forms.DataGridViewTextBoxColumn coPista;
        private System.Windows.Forms.Button btnDesarrollar;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCSCANAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCSCANAT;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSCANAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSCANAT;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSSTFAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSSTFAT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coFIFOAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coFIFOAT;
        private System.Windows.Forms.TextBox txtSSTF;
        private System.Windows.Forms.TextBox txtSCAN;
        private System.Windows.Forms.TextBox txtCSCAN;
        private System.Windows.Forms.TextBox txtLOOK;
        private System.Windows.Forms.TextBox txtCLOOK;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn coLOOKAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coLOOKAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCLOOKAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCLOOKAT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFIFO;
        private System.Windows.Forms.Button btnSSTF;
        private System.Windows.Forms.Button btnSCAN;
        private System.Windows.Forms.Button btnCSCAN;
        private System.Windows.Forms.Button btnLOOK;
        private System.Windows.Forms.Button btnCLOOK;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label label18;
    }
}

