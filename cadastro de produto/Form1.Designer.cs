namespace cadastro_de_produto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tx_codigo = new TextBox();
            tx_descricao = new TextBox();
            tx_preco = new TextBox();
            tx_lucro = new TextBox();
            tx_valor = new TextBox();
            bt_excluir = new Button();
            bt_Cadastrar = new Button();
            bt_novo = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // tx_codigo
            // 
            tx_codigo.Location = new Point(140, 94);
            tx_codigo.Name = "tx_codigo";
            tx_codigo.Size = new Size(100, 23);
            tx_codigo.TabIndex = 0;
            // 
            // tx_descricao
            // 
            tx_descricao.Location = new Point(354, 94);
            tx_descricao.Name = "tx_descricao";
            tx_descricao.Size = new Size(159, 23);
            tx_descricao.TabIndex = 1;
            // 
            // tx_preco
            // 
            tx_preco.Location = new Point(140, 166);
            tx_preco.Name = "tx_preco";
            tx_preco.Size = new Size(122, 23);
            tx_preco.TabIndex = 2;
            // 
            // tx_lucro
            // 
            tx_lucro.Location = new Point(377, 166);
            tx_lucro.Name = "tx_lucro";
            tx_lucro.Size = new Size(100, 23);
            tx_lucro.TabIndex = 3;
            // 
            // tx_valor
            // 
            tx_valor.Location = new Point(140, 233);
            tx_valor.Name = "tx_valor";
            tx_valor.Size = new Size(109, 23);
            tx_valor.TabIndex = 4;
            // 
            // bt_excluir
            // 
            bt_excluir.Location = new Point(415, 286);
            bt_excluir.Name = "bt_excluir";
            bt_excluir.Size = new Size(88, 38);
            bt_excluir.TabIndex = 5;
            bt_excluir.Text = "Excluir";
            bt_excluir.UseVisualStyleBackColor = true;
            // 
            // bt_Cadastrar
            // 
            bt_Cadastrar.Location = new Point(308, 286);
            bt_Cadastrar.Name = "bt_Cadastrar";
            bt_Cadastrar.Size = new Size(78, 40);
            bt_Cadastrar.TabIndex = 6;
            bt_Cadastrar.Text = "Cadastrar";
            bt_Cadastrar.UseVisualStyleBackColor = true;
            bt_Cadastrar.Click += bt_Cadastrar_Click;
            // 
            // bt_novo
            // 
            bt_novo.Location = new Point(201, 286);
            bt_novo.Name = "bt_novo";
            bt_novo.Size = new Size(75, 38);
            bt_novo.TabIndex = 7;
            bt_novo.Text = "Novo";
            bt_novo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 97);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 8;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 168);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 9;
            label2.Text = "Preço de Aquisição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 241);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 10;
            label3.Text = "Valor de Venda:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 97);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 11;
            label4.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(308, 168);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 12;
            label5.Text = "Lucro %:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 411);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_novo);
            Controls.Add(bt_Cadastrar);
            Controls.Add(bt_excluir);
            Controls.Add(tx_valor);
            Controls.Add(tx_lucro);
            Controls.Add(tx_preco);
            Controls.Add(tx_descricao);
            Controls.Add(tx_codigo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_codigo;
        private TextBox tx_descricao;
        private TextBox tx_preco;
        private TextBox tx_lucro;
        private TextBox tx_valor;
        private Button bt_excluir;
        private Button bt_Cadastrar;
        private Button bt_novo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}