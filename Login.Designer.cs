
namespace AviatTur
{
  partial class Login
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
      this.panel1 = new System.Windows.Forms.Panel();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.txtContraseña = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnAcceder = new System.Windows.Forms.Button();
      this.btnCerrar = new System.Windows.Forms.PictureBox();
      this.btnMinimizar = new System.Windows.Forms.PictureBox();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.lblError = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
      this.panel1.Controls.Add(this.pictureBox3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(250, 450);
      this.panel1.TabIndex = 0;
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
      this.pictureBox3.Location = new System.Drawing.Point(12, 54);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(218, 312);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox3.TabIndex = 0;
      this.pictureBox3.TabStop = false;
      // 
      // txtUsuario
      // 
      this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
      this.txtUsuario.Location = new System.Drawing.Point(337, 156);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(357, 22);
      this.txtUsuario.TabIndex = 2;
      this.txtUsuario.Text = "USUARIO";
      this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
      this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
      // 
      // txtContraseña
      // 
      this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
      this.txtContraseña.Location = new System.Drawing.Point(337, 265);
      this.txtContraseña.Name = "txtContraseña";
      this.txtContraseña.Size = new System.Drawing.Size(357, 22);
      this.txtContraseña.TabIndex = 3;
      this.txtContraseña.Text = "CONTRASEÑA";
      this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
      this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
      this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Nirmala UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.DimGray;
      this.label1.Location = new System.Drawing.Point(432, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(167, 65);
      this.label1.TabIndex = 1;
      this.label1.Text = "LOGIN";
      // 
      // btnAcceder
      // 
      this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btnAcceder.ForeColor = System.Drawing.Color.DimGray;
      this.btnAcceder.Location = new System.Drawing.Point(337, 376);
      this.btnAcceder.Name = "btnAcceder";
      this.btnAcceder.Size = new System.Drawing.Size(357, 40);
      this.btnAcceder.TabIndex = 4;
      this.btnAcceder.Text = "ACCEDER";
      this.btnAcceder.UseVisualStyleBackColor = true;
      this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
      // 
      // btnCerrar
      // 
      this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
      this.btnCerrar.InitialImage = null;
      this.btnCerrar.Location = new System.Drawing.Point(753, 12);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(17, 17);
      this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.btnCerrar.TabIndex = 6;
      this.btnCerrar.TabStop = false;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
      this.btnMinimizar.InitialImage = null;
      this.btnMinimizar.Location = new System.Drawing.Point(720, 12);
      this.btnMinimizar.Name = "btnMinimizar";
      this.btnMinimizar.Size = new System.Drawing.Size(17, 17);
      this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.btnMinimizar.TabIndex = 7;
      this.btnMinimizar.TabStop = false;
      this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.LinkColor = System.Drawing.Color.White;
      this.linkLabel1.Location = new System.Drawing.Point(464, 442);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(16, 17);
      this.linkLabel1.TabIndex = 1;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "a";
      // 
      // lblError
      // 
      this.lblError.AutoSize = true;
      this.lblError.BackColor = System.Drawing.Color.Transparent;
      this.lblError.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblError.ForeColor = System.Drawing.Color.DimGray;
      this.lblError.Location = new System.Drawing.Point(391, 330);
      this.lblError.Name = "lblError";
      this.lblError.Size = new System.Drawing.Size(139, 23);
      this.lblError.TabIndex = 8;
      this.lblError.Text = "Error Message";
      this.lblError.Visible = false;
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(780, 450);
      this.Controls.Add(this.lblError);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.btnMinimizar);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.btnAcceder);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtContraseña);
      this.Controls.Add(this.txtUsuario);
      this.Controls.Add(this.panel1);
      this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Login";
      this.Opacity = 0.85D;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.TextBox txtContraseña;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnAcceder;
    private System.Windows.Forms.PictureBox btnCerrar;
    private System.Windows.Forms.PictureBox btnMinimizar;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.Label lblError;
  }
}

