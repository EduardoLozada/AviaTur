namespace AviatTur
{
  partial class Administracion
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.dtgVuelos = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.lblError = new System.Windows.Forms.Label();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.cmbEstado = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dtpHoraL = new System.Windows.Forms.DateTimePicker();
      this.dtpHoras = new System.Windows.Forms.DateTimePicker();
      this.dtpFecha = new System.Windows.Forms.DateTimePicker();
      this.lblCiudadD = new System.Windows.Forms.Label();
      this.lblCiudadO = new System.Windows.Forms.Label();
      this.cmbCiudadD = new System.Windows.Forms.ComboBox();
      this.cmbCiudadO = new System.Windows.Forms.ComboBox();
      this.btnReprogramar = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // dtgVuelos
      // 
      this.dtgVuelos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
      this.dtgVuelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dtgVuelos.ColumnHeadersHeight = 29;
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
      dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgVuelos.DefaultCellStyle = dataGridViewCellStyle10;
      this.dtgVuelos.Location = new System.Drawing.Point(12, 56);
      this.dtgVuelos.Name = "dtgVuelos";
      this.dtgVuelos.RowHeadersWidth = 51;
      this.dtgVuelos.RowTemplate.Height = 24;
      this.dtgVuelos.Size = new System.Drawing.Size(1188, 374);
      this.dtgVuelos.TabIndex = 2;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.lblError);
      this.panel1.Controls.Add(this.btnGuardar);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.cmbEstado);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.dtpHoraL);
      this.panel1.Controls.Add(this.dtpHoras);
      this.panel1.Controls.Add(this.dtpFecha);
      this.panel1.Controls.Add(this.lblCiudadD);
      this.panel1.Controls.Add(this.lblCiudadO);
      this.panel1.Controls.Add(this.cmbCiudadD);
      this.panel1.Controls.Add(this.cmbCiudadO);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(632, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(580, 517);
      this.panel1.TabIndex = 3;
      // 
      // label5
      // 
      this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.LightGray;
      this.label5.Location = new System.Drawing.Point(200, 21);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(172, 23);
      this.label5.TabIndex = 14;
      this.label5.Text = "Programar Vuelos";
      // 
      // lblError
      // 
      this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblError.AutoSize = true;
      this.lblError.BackColor = System.Drawing.Color.Transparent;
      this.lblError.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblError.ForeColor = System.Drawing.Color.White;
      this.lblError.Location = new System.Drawing.Point(16, 355);
      this.lblError.Name = "lblError";
      this.lblError.Size = new System.Drawing.Size(139, 23);
      this.lblError.TabIndex = 13;
      this.lblError.Text = "Error Message";
      this.lblError.Visible = false;
      // 
      // btnGuardar
      // 
      this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnGuardar.Location = new System.Drawing.Point(177, 335);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(195, 43);
      this.btnGuardar.TabIndex = 12;
      this.btnGuardar.Text = "Programar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.SystemColors.Control;
      this.label4.Location = new System.Drawing.Point(107, 281);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(66, 18);
      this.label4.TabIndex = 11;
      this.label4.Text = "Estado:";
      // 
      // cmbEstado
      // 
      this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEstado.FormattingEnabled = true;
      this.cmbEstado.Location = new System.Drawing.Point(215, 275);
      this.cmbEstado.Name = "cmbEstado";
      this.cmbEstado.Size = new System.Drawing.Size(241, 24);
      this.cmbEstado.TabIndex = 10;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.SystemColors.Control;
      this.label3.Location = new System.Drawing.Point(59, 237);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(113, 18);
      this.label3.TabIndex = 9;
      this.label3.Text = "Hora Llegada:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.SystemColors.Control;
      this.label2.Location = new System.Drawing.Point(76, 195);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(101, 18);
      this.label2.TabIndex = 8;
      this.label2.Text = "Hora Salida:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.Control;
      this.label1.Location = new System.Drawing.Point(67, 157);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(106, 18);
      this.label1.TabIndex = 7;
      this.label1.Text = "Fecha Vuelo:";
      // 
      // dtpHoraL
      // 
      this.dtpHoraL.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpHoraL.Location = new System.Drawing.Point(215, 234);
      this.dtpHoraL.Name = "dtpHoraL";
      this.dtpHoraL.Size = new System.Drawing.Size(241, 22);
      this.dtpHoraL.TabIndex = 6;
      this.dtpHoraL.Value = new System.DateTime(2022, 5, 14, 0, 0, 0, 0);
      // 
      // dtpHoras
      // 
      this.dtpHoras.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpHoras.Location = new System.Drawing.Point(215, 195);
      this.dtpHoras.Name = "dtpHoras";
      this.dtpHoras.Size = new System.Drawing.Size(241, 22);
      this.dtpHoras.TabIndex = 5;
      this.dtpHoras.Value = new System.DateTime(2022, 5, 14, 0, 0, 0, 0);
      // 
      // dtpFecha
      // 
      this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFecha.Location = new System.Drawing.Point(215, 153);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new System.Drawing.Size(241, 22);
      this.dtpFecha.TabIndex = 4;
      this.dtpFecha.Value = new System.DateTime(2022, 5, 14, 0, 0, 0, 0);
      // 
      // lblCiudadD
      // 
      this.lblCiudadD.AutoSize = true;
      this.lblCiudadD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCiudadD.ForeColor = System.Drawing.SystemColors.Control;
      this.lblCiudadD.Location = new System.Drawing.Point(45, 119);
      this.lblCiudadD.Name = "lblCiudadD";
      this.lblCiudadD.Size = new System.Drawing.Size(128, 18);
      this.lblCiudadD.TabIndex = 3;
      this.lblCiudadD.Text = "Ciudad Destino:";
      // 
      // lblCiudadO
      // 
      this.lblCiudadO.AutoSize = true;
      this.lblCiudadO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCiudadO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblCiudadO.Location = new System.Drawing.Point(53, 80);
      this.lblCiudadO.Name = "lblCiudadO";
      this.lblCiudadO.Size = new System.Drawing.Size(120, 18);
      this.lblCiudadO.TabIndex = 2;
      this.lblCiudadO.Text = "Ciudad Origen:";
      // 
      // cmbCiudadD
      // 
      this.cmbCiudadD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCiudadD.FormattingEnabled = true;
      this.cmbCiudadD.Location = new System.Drawing.Point(215, 113);
      this.cmbCiudadD.Name = "cmbCiudadD";
      this.cmbCiudadD.Size = new System.Drawing.Size(241, 24);
      this.cmbCiudadD.TabIndex = 1;
      // 
      // cmbCiudadO
      // 
      this.cmbCiudadO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCiudadO.FormattingEnabled = true;
      this.cmbCiudadO.Location = new System.Drawing.Point(215, 74);
      this.cmbCiudadO.Name = "cmbCiudadO";
      this.cmbCiudadO.Size = new System.Drawing.Size(241, 24);
      this.cmbCiudadO.TabIndex = 0;
      // 
      // btnReprogramar
      // 
      this.btnReprogramar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnReprogramar.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnReprogramar.Location = new System.Drawing.Point(39, 462);
      this.btnReprogramar.Name = "btnReprogramar";
      this.btnReprogramar.Size = new System.Drawing.Size(195, 43);
      this.btnReprogramar.TabIndex = 13;
      this.btnReprogramar.Text = "Reprogramar";
      this.btnReprogramar.UseVisualStyleBackColor = true;
      this.btnReprogramar.Click += new System.EventHandler(this.btnReprogramar_Click);
      // 
      // textBox1
      // 
      this.textBox1.ForeColor = System.Drawing.Color.DimGray;
      this.textBox1.Location = new System.Drawing.Point(12, 21);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(185, 22);
      this.textBox1.TabIndex = 15;
      this.textBox1.Text = "Buscar y/o Filtrar";
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
      this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
      // 
      // Administracion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(1212, 517);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.btnReprogramar);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dtgVuelos);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Administracion";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmAnalytics";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmAnalytics_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.DataGridView dtgVuelos;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblCiudadD;
    private System.Windows.Forms.Label lblCiudadO;
    private System.Windows.Forms.ComboBox cmbCiudadD;
    private System.Windows.Forms.ComboBox cmbCiudadO;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dtpHoraL;
    private System.Windows.Forms.DateTimePicker dtpHoras;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmbEstado;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnReprogramar;
    private System.Windows.Forms.TextBox textBox1;
  }
}