namespace ajandekadatbazis
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbox_adatlista = new System.Windows.Forms.GroupBox();
            this.gbox_felvetel = new System.Windows.Forms.GroupBox();
            this.txtbx_nev = new System.Windows.Forms.TextBox();
            this.txtbx_uzlet = new System.Windows.Forms.TextBox();
            this.lbl_nevmegadas = new System.Windows.Forms.Label();
            this.lbl_uzletneve = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txbx_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.gbox_adatreszlet = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_nevreszlet = new System.Windows.Forms.Label();
            this.lbl_uzletreszlet = new System.Windows.Forms.Label();
            this.lbl_idreszlet = new System.Windows.Forms.Label();
            this.gbox_adatlista.SuspendLayout();
            this.gbox_felvetel.SuspendLayout();
            this.gbox_adatreszlet.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gbox_adatlista
            // 
            this.gbox_adatlista.Controls.Add(this.btn_delete);
            this.gbox_adatlista.Controls.Add(this.listBox1);
            this.gbox_adatlista.Location = new System.Drawing.Point(12, 21);
            this.gbox_adatlista.Name = "gbox_adatlista";
            this.gbox_adatlista.Size = new System.Drawing.Size(233, 392);
            this.gbox_adatlista.TabIndex = 1;
            this.gbox_adatlista.TabStop = false;
            this.gbox_adatlista.Text = "Adatok";
            // 
            // gbox_felvetel
            // 
            this.gbox_felvetel.Controls.Add(this.btn_update);
            this.gbox_felvetel.Controls.Add(this.lbl_id);
            this.gbox_felvetel.Controls.Add(this.txbx_id);
            this.gbox_felvetel.Controls.Add(this.btn_insert);
            this.gbox_felvetel.Controls.Add(this.lbl_uzletneve);
            this.gbox_felvetel.Controls.Add(this.lbl_nevmegadas);
            this.gbox_felvetel.Controls.Add(this.txtbx_uzlet);
            this.gbox_felvetel.Controls.Add(this.txtbx_nev);
            this.gbox_felvetel.Location = new System.Drawing.Point(280, 21);
            this.gbox_felvetel.Name = "gbox_felvetel";
            this.gbox_felvetel.Size = new System.Drawing.Size(236, 391);
            this.gbox_felvetel.TabIndex = 2;
            this.gbox_felvetel.TabStop = false;
            this.gbox_felvetel.Text = "Adat Felvétel";
            // 
            // txtbx_nev
            // 
            this.txtbx_nev.Location = new System.Drawing.Point(6, 121);
            this.txtbx_nev.Name = "txtbx_nev";
            this.txtbx_nev.Size = new System.Drawing.Size(224, 20);
            this.txtbx_nev.TabIndex = 0;
            // 
            // txtbx_uzlet
            // 
            this.txtbx_uzlet.Location = new System.Drawing.Point(6, 179);
            this.txtbx_uzlet.Name = "txtbx_uzlet";
            this.txtbx_uzlet.Size = new System.Drawing.Size(224, 20);
            this.txtbx_uzlet.TabIndex = 1;
            // 
            // lbl_nevmegadas
            // 
            this.lbl_nevmegadas.AutoSize = true;
            this.lbl_nevmegadas.Location = new System.Drawing.Point(6, 93);
            this.lbl_nevmegadas.Name = "lbl_nevmegadas";
            this.lbl_nevmegadas.Size = new System.Drawing.Size(76, 13);
            this.lbl_nevmegadas.TabIndex = 2;
            this.lbl_nevmegadas.Text = "Ajándék neve:";
            // 
            // lbl_uzletneve
            // 
            this.lbl_uzletneve.AutoSize = true;
            this.lbl_uzletneve.Location = new System.Drawing.Point(6, 154);
            this.lbl_uzletneve.Name = "lbl_uzletneve";
            this.lbl_uzletneve.Size = new System.Drawing.Size(61, 13);
            this.lbl_uzletneve.TabIndex = 3;
            this.lbl_uzletneve.Text = "Üzlet neve:";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(76, 214);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "Felvétel";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(72, 316);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Törlés";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txbx_id
            // 
            this.txbx_id.Location = new System.Drawing.Point(6, 56);
            this.txbx_id.Name = "txbx_id";
            this.txbx_id.Size = new System.Drawing.Size(221, 20);
            this.txbx_id.TabIndex = 5;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(6, 26);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "ID:";
            // 
            // gbox_adatreszlet
            // 
            this.gbox_adatreszlet.Controls.Add(this.lbl_idreszlet);
            this.gbox_adatreszlet.Controls.Add(this.lbl_uzletreszlet);
            this.gbox_adatreszlet.Controls.Add(this.lbl_nevreszlet);
            this.gbox_adatreszlet.Location = new System.Drawing.Point(557, 21);
            this.gbox_adatreszlet.Name = "gbox_adatreszlet";
            this.gbox_adatreszlet.Size = new System.Drawing.Size(234, 391);
            this.gbox_adatreszlet.TabIndex = 3;
            this.gbox_adatreszlet.TabStop = false;
            this.gbox_adatreszlet.Text = "Kiválasztott Adat részletei";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(76, 255);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Módosít";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_nevreszlet
            // 
            this.lbl_nevreszlet.AutoSize = true;
            this.lbl_nevreszlet.Location = new System.Drawing.Point(15, 85);
            this.lbl_nevreszlet.Name = "lbl_nevreszlet";
            this.lbl_nevreszlet.Size = new System.Drawing.Size(30, 13);
            this.lbl_nevreszlet.TabIndex = 0;
            this.lbl_nevreszlet.Text = "Név:";
            // 
            // lbl_uzletreszlet
            // 
            this.lbl_uzletreszlet.AutoSize = true;
            this.lbl_uzletreszlet.Location = new System.Drawing.Point(15, 122);
            this.lbl_uzletreszlet.Name = "lbl_uzletreszlet";
            this.lbl_uzletreszlet.Size = new System.Drawing.Size(34, 13);
            this.lbl_uzletreszlet.TabIndex = 1;
            this.lbl_uzletreszlet.Text = "Üzlet:";
            // 
            // lbl_idreszlet
            // 
            this.lbl_idreszlet.AutoSize = true;
            this.lbl_idreszlet.Location = new System.Drawing.Point(15, 48);
            this.lbl_idreszlet.Name = "lbl_idreszlet";
            this.lbl_idreszlet.Size = new System.Drawing.Size(21, 13);
            this.lbl_idreszlet.TabIndex = 2;
            this.lbl_idreszlet.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.gbox_adatreszlet);
            this.Controls.Add(this.gbox_felvetel);
            this.Controls.Add(this.gbox_adatlista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbox_adatlista.ResumeLayout(false);
            this.gbox_felvetel.ResumeLayout(false);
            this.gbox_felvetel.PerformLayout();
            this.gbox_adatreszlet.ResumeLayout(false);
            this.gbox_adatreszlet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbox_adatlista;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox gbox_felvetel;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lbl_uzletneve;
        private System.Windows.Forms.Label lbl_nevmegadas;
        private System.Windows.Forms.TextBox txtbx_uzlet;
        private System.Windows.Forms.TextBox txtbx_nev;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txbx_id;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox gbox_adatreszlet;
        private System.Windows.Forms.Label lbl_idreszlet;
        private System.Windows.Forms.Label lbl_uzletreszlet;
        private System.Windows.Forms.Label lbl_nevreszlet;
    }
}

