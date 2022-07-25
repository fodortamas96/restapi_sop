namespace csharp_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.getAll_btn = new System.Windows.Forms.Button();
            this.getPokemonById_btn = new System.Windows.Forms.Button();
            this.id_numeric = new System.Windows.Forms.NumericUpDown();
            this.insertPokemon_btn = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.health_label = new System.Windows.Forms.Label();
            this.region_label = new System.Windows.Forms.Label();
            this.updatePokemon_btn = new System.Windows.Forms.Button();
            this.deletePokemon_btn = new System.Windows.Forms.Button();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.type_tb = new System.Windows.Forms.TextBox();
            this.health_numeric = new System.Windows.Forms.NumericUpDown();
            this.region_tb = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.id_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(459, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 420);
            this.listBox1.TabIndex = 0;
            // 
            // getAll_btn
            // 
            this.getAll_btn.Location = new System.Drawing.Point(12, 34);
            this.getAll_btn.Name = "getAll_btn";
            this.getAll_btn.Size = new System.Drawing.Size(182, 48);
            this.getAll_btn.TabIndex = 1;
            this.getAll_btn.Text = "Get All Pokemon";
            this.getAll_btn.UseVisualStyleBackColor = true;
            this.getAll_btn.Click += new System.EventHandler(this.getAll_btn_Click);
            // 
            // getPokemonById_btn
            // 
            this.getPokemonById_btn.Location = new System.Drawing.Point(12, 88);
            this.getPokemonById_btn.Name = "getPokemonById_btn";
            this.getPokemonById_btn.Size = new System.Drawing.Size(182, 48);
            this.getPokemonById_btn.TabIndex = 2;
            this.getPokemonById_btn.Text = "Get Pokemon by ID";
            this.getPokemonById_btn.UseVisualStyleBackColor = true;
            this.getPokemonById_btn.Click += new System.EventHandler(this.getPokemonById_btn_Click);
            // 
            // id_numeric
            // 
            this.id_numeric.Location = new System.Drawing.Point(284, 50);
            this.id_numeric.Name = "id_numeric";
            this.id_numeric.Size = new System.Drawing.Size(120, 20);
            this.id_numeric.TabIndex = 3;
            this.id_numeric.ValueChanged += new System.EventHandler(this.id_numeric_ValueChanged);
            // 
            // insertPokemon_btn
            // 
            this.insertPokemon_btn.Location = new System.Drawing.Point(12, 142);
            this.insertPokemon_btn.Name = "insertPokemon_btn";
            this.insertPokemon_btn.Size = new System.Drawing.Size(182, 48);
            this.insertPokemon_btn.TabIndex = 4;
            this.insertPokemon_btn.Text = "Insert Pokemon";
            this.insertPokemon_btn.UseVisualStyleBackColor = true;
            this.insertPokemon_btn.Click += new System.EventHandler(this.insertPokemon_btn_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(257, 52);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 13);
            this.id_label.TabIndex = 5;
            this.id_label.Text = "ID:";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(240, 106);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 6;
            this.name_label.Text = "Name:";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(243, 160);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(34, 13);
            this.type_label.TabIndex = 7;
            this.type_label.Text = "Type:";
            this.type_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // health_label
            // 
            this.health_label.AutoSize = true;
            this.health_label.Location = new System.Drawing.Point(236, 214);
            this.health_label.Name = "health_label";
            this.health_label.Size = new System.Drawing.Size(41, 13);
            this.health_label.TabIndex = 8;
            this.health_label.Text = "Health:";
            this.health_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // region_label
            // 
            this.region_label.AutoSize = true;
            this.region_label.Location = new System.Drawing.Point(233, 268);
            this.region_label.Name = "region_label";
            this.region_label.Size = new System.Drawing.Size(44, 13);
            this.region_label.TabIndex = 9;
            this.region_label.Text = "Region:";
            // 
            // updatePokemon_btn
            // 
            this.updatePokemon_btn.Location = new System.Drawing.Point(12, 196);
            this.updatePokemon_btn.Name = "updatePokemon_btn";
            this.updatePokemon_btn.Size = new System.Drawing.Size(182, 48);
            this.updatePokemon_btn.TabIndex = 10;
            this.updatePokemon_btn.Text = "Update Pokemon";
            this.updatePokemon_btn.UseVisualStyleBackColor = true;
            this.updatePokemon_btn.Click += new System.EventHandler(this.updatePokemon_btn_Click);
            // 
            // deletePokemon_btn
            // 
            this.deletePokemon_btn.Location = new System.Drawing.Point(12, 250);
            this.deletePokemon_btn.Name = "deletePokemon_btn";
            this.deletePokemon_btn.Size = new System.Drawing.Size(182, 48);
            this.deletePokemon_btn.TabIndex = 11;
            this.deletePokemon_btn.Text = "Delete Pokemon";
            this.deletePokemon_btn.UseVisualStyleBackColor = true;
            this.deletePokemon_btn.Click += new System.EventHandler(this.deletePokemon_btn_Click);
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(284, 103);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(100, 20);
            this.name_tb.TabIndex = 12;
            // 
            // type_tb
            // 
            this.type_tb.Location = new System.Drawing.Point(283, 157);
            this.type_tb.Name = "type_tb";
            this.type_tb.Size = new System.Drawing.Size(100, 20);
            this.type_tb.TabIndex = 13;
            // 
            // health_numeric
            // 
            this.health_numeric.Location = new System.Drawing.Point(283, 212);
            this.health_numeric.Name = "health_numeric";
            this.health_numeric.Size = new System.Drawing.Size(120, 20);
            this.health_numeric.TabIndex = 14;
            // 
            // region_tb
            // 
            this.region_tb.Location = new System.Drawing.Point(283, 265);
            this.region_tb.Name = "region_tb";
            this.region_tb.Size = new System.Drawing.Size(100, 20);
            this.region_tb.TabIndex = 15;
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(12, 386);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(101, 46);
            this.register_btn.TabIndex = 16;
            this.register_btn.Text = "Registration";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.region_tb);
            this.Controls.Add(this.health_numeric);
            this.Controls.Add(this.type_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.deletePokemon_btn);
            this.Controls.Add(this.updatePokemon_btn);
            this.Controls.Add(this.region_label);
            this.Controls.Add(this.health_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.insertPokemon_btn);
            this.Controls.Add(this.id_numeric);
            this.Controls.Add(this.getPokemonById_btn);
            this.Controls.Add(this.getAll_btn);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.id_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button getAll_btn;
        private System.Windows.Forms.Button getPokemonById_btn;
        private System.Windows.Forms.NumericUpDown id_numeric;
        private System.Windows.Forms.Button insertPokemon_btn;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label health_label;
        private System.Windows.Forms.Label region_label;
        private System.Windows.Forms.Button updatePokemon_btn;
        private System.Windows.Forms.Button deletePokemon_btn;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox type_tb;
        private System.Windows.Forms.NumericUpDown health_numeric;
        private System.Windows.Forms.TextBox region_tb;
        private System.Windows.Forms.Button register_btn;
    }
}

