namespace LavaJ
{
    partial class FrmCadCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskContato2 = new System.Windows.Forms.MaskedTextBox();
            this.mskContato1 = new System.Windows.Forms.MaskedTextBox();
            this.mskPlaca = new System.Windows.Forms.MaskedTextBox();
            this.mskDtCadCli = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntFechar = new System.Windows.Forms.Button();
            this.bntAtualizar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntSalva = new System.Windows.Forms.Button();
            this.bntNovo = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCliente = new LavaJ.DataSetCliente();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new LavaJ.DataSetClienteTableAdapters.TbClienteTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskContato2);
            this.groupBox1.Controls.Add(this.mskContato1);
            this.groupBox1.Controls.Add(this.mskPlaca);
            this.groupBox1.Controls.Add(this.mskDtCadCli);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtVeiculo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIDCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(26, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(477, 291);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // mskContato2
            // 
            this.mskContato2.Location = new System.Drawing.Point(336, 32);
            this.mskContato2.Mask = "(99) 00000-0000";
            this.mskContato2.Name = "mskContato2";
            this.mskContato2.Size = new System.Drawing.Size(126, 26);
            this.mskContato2.TabIndex = 2;
            // 
            // mskContato1
            // 
            this.mskContato1.Location = new System.Drawing.Point(200, 32);
            this.mskContato1.Mask = "(99) 00000-0000";
            this.mskContato1.Name = "mskContato1";
            this.mskContato1.Size = new System.Drawing.Size(126, 26);
            this.mskContato1.TabIndex = 2;
            // 
            // mskPlaca
            // 
            this.mskPlaca.Location = new System.Drawing.Point(13, 170);
            this.mskPlaca.Mask = "AAA-0000";
            this.mskPlaca.Name = "mskPlaca";
            this.mskPlaca.Size = new System.Drawing.Size(77, 26);
            this.mskPlaca.TabIndex = 7;
            // 
            // mskDtCadCli
            // 
            this.mskDtCadCli.BackColor = System.Drawing.Color.White;
            this.mskDtCadCli.Location = new System.Drawing.Point(83, 32);
            this.mskDtCadCli.Mask = "00/00/0000";
            this.mskDtCadCli.Name = "mskDtCadCli";
            this.mskDtCadCli.ReadOnly = true;
            this.mskDtCadCli.Size = new System.Drawing.Size(108, 26);
            this.mskDtCadCli.TabIndex = 2;
            this.mskDtCadCli.ValidatingType = typeof(System.DateTime);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(206, 123);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(256, 26);
            this.txtEndereco.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Endereço";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(13, 216);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(449, 56);
            this.txtObs.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Observações";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(13, 124);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(185, 26);
            this.txtVeiculo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Veículo\\Modelo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Data Cadastro";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(449, 26);
            this.txtNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txtUF
            // 
            this.txtUF.AutoCompleteCustomSource.AddRange(new string[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUF.Location = new System.Drawing.Point(410, 170);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(52, 26);
            this.txtUF.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Contato 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Placa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Contato 1";
            // 
            // txtCidade
            // 
            this.txtCidade.AutoCompleteCustomSource.AddRange(new string[] {
            "Acrelândia",
            "Assis Brasil",
            "Brasiléia",
            "Bujari",
            "Capixaba",
            "Cruzeiro do Sul",
            "Epitaciolândia",
            "Feijó",
            "Jordão",
            "Mâncio Lima",
            "Manoel Urbano",
            "Marechal Thaumaturgo",
            "Plácido de Castro",
            "Porto Acre",
            "Porto Walter",
            "Rio Branco",
            "Rodrigues Alves",
            "Santa Rosa do Purus",
            "Sena Madureira",
            "Senador Guiomard",
            "Tarauacá",
            "Xapuri",
            "Água Branca",
            "Anadia",
            "Arapiraca",
            "Atalaia",
            "Barra de Santo Antônio",
            "Barra de São Miguel",
            "Batalha",
            "Belém",
            "Belo Monte",
            "Boca da Mata",
            "Branquinha",
            "Cacimbinhas",
            "Cajueiro",
            "Campestre",
            "Campo Alegre",
            "Campo Grande",
            "Canapi",
            "Capela",
            "Carneiros",
            "Chã Preta",
            "Coité do Nóia",
            "Colônia Leopoldina",
            "Coqueiro Seco",
            "Coruripe",
            "Craíbas",
            "Delmiro Gouveia",
            "Dois Riachos",
            "Estrela de Alagoas",
            "Feira Grande",
            "Feliz Deserto",
            "Flexeiras",
            "Girau do Ponciano",
            "Ibateguara",
            "Igaci",
            "Igreja Nova",
            "Inhapi",
            "Jacaré dos Homens",
            "Jacuípe",
            "Japaratinga",
            "Jaramataia",
            "Joaquim Gomes",
            "Jundiá",
            "Junqueiro",
            "Lagoa da Canoa",
            "Limoeiro de Anadia",
            "Maceió",
            "Major Isidoro",
            "Mar Vermelho",
            "Maragogi",
            "Maravilha",
            "Marechal Deodoro",
            "Maribondo",
            "Mata Grande",
            "Matriz de Camaragibe",
            "Messias",
            "Minador do Negrão",
            "Monteirópolis",
            "Murici",
            "Novo Lino",
            "Olho d Água das Flores",
            "Olho d Água do Casado",
            "Olho d Água Grande",
            "Olivença",
            "Ouro Branco",
            "Palestina",
            "Palmeira dos Índios",
            "Pão de Açúcar",
            "Pariconha",
            "Paripueira",
            "Passo de Camaragibe",
            "Paulo Jacinto",
            "Penedo",
            "Piaçabuçu",
            "Pilar",
            "Pindoba",
            "Piranhas",
            "Poço das Trincheiras",
            "Porto Calvo",
            "Porto de Pedras",
            "Porto Real do Colégio",
            "Quebrangulo",
            "Rio Largo",
            "Roteiro",
            "Santa Luzia do Norte",
            "Santana do Ipanema",
            "Santana do Mundaú",
            "São Brás",
            "São José da Laje",
            "São José da Tapera",
            "São Luís do Quitunde",
            "São Miguel dos Campos",
            "São Miguel dos Milagres",
            "São Sebastião",
            "Satuba",
            "Senador Rui Palmeira",
            "Tanque d Arca",
            "Taquarana",
            "Teotônio Vilela",
            "Traipu",
            "União dos Palmares",
            "Viçosa",
            "Amapá",
            "Calçoene",
            "Cutias",
            "Ferreira Gomes",
            "Itaubal",
            "Laranjal do Jari",
            "Macapá",
            "Mazagão",
            "Oiapoque",
            "Pedra Branca do Amaparí",
            "Porto Grande",
            "Pracuúba",
            "Santana",
            "Serra do Navio",
            "Tartarugalzinho",
            "Vitória do Jari",
            "Alvarães",
            "Amaturá",
            "namã",
            "Anori",
            "Apuí",
            "Atalaia do Norte",
            "Autazes",
            "Barcelos",
            "Barreirinha",
            "Benjamin Constant",
            "Beruri",
            "Boa Vista do Ramos",
            "Boca do Acre",
            "Borba",
            "Caapiranga",
            "Canutama",
            "Carauari",
            "Careiro",
            "Careiro da Várzea",
            "Coari",
            "Codajás",
            "Eirunepé",
            "Envira",
            "Fonte Boa",
            "Guajará",
            "Humaitá",
            "Ipixuna",
            "Iranduba",
            "Itacoatiara",
            "Itamarati",
            "Itapiranga",
            "Japurá",
            "Juruá",
            "Jutaí",
            "Lábrea",
            "Manacapuru",
            "Manaquiri",
            "Manaus",
            "Manicoré",
            "Maraã",
            "Maués",
            "Nhamundá",
            "Nova Olinda do Norte",
            "Novo Airão",
            "Novo Aripuanã",
            "Parintins",
            "Pauini",
            "Presidente Figueiredo",
            "Rio Preto da Eva",
            "Santa Isabel do Rio Negro",
            "Santo Antônio do Içá",
            "São Gabriel da Cachoeira",
            "São Paulo de Olivença",
            "São Sebastião do Uatumã",
            "Silves",
            "Tabatinga",
            "Tapauá",
            "Tefé",
            "Tonantins",
            "Uarini",
            "Urucará",
            "Urucurituba",
            "Abaíra",
            "Abaré",
            "Acajutiba",
            "Adustina",
            "Água Fria",
            "Aiquara",
            "Alagoinhas",
            "Alcobaça",
            "Almadina",
            "Amargosa",
            "Amélia Rodrigues",
            "América Dourada",
            "Anagé",
            "Andaraí",
            "Andorinha",
            "Angical",
            "Anguera",
            "Antas",
            "Antônio Cardoso",
            "Antônio Gonçalves",
            "Aporá",
            "Apuarema",
            "Araças",
            "Aracatu",
            "Araci",
            "Aramari",
            "Arataca",
            "Aratuípe",
            "Aurelino Leal",
            "Baianópolis",
            "Baixa Grande",
            "Banzaê",
            "Barra",
            "Barra da Estiva",
            "Barra do Choça",
            "Barra do Mendes",
            "Barra do Rocha",
            "Barreiras",
            "Barro Alto",
            "Belmonte",
            "Belo Campo",
            "Biritinga",
            "Boa Nova",
            "Boa Vista do Tupim",
            "Bom Jesus da Lapa",
            "Bom Jesus da Serra",
            "Boninal",
            "Bonito",
            "Boquira",
            "Botuporã",
            "Brejões",
            "Brejolândia",
            "Brotas de Macaúbas",
            "Brumado",
            "Buerarema",
            "Buritirama",
            "Caatiba",
            "Cabaceiras do Paraguaçu",
            "Cachoeira",
            "Caculé",
            "Caém",
            "Caetanos",
            "Caetité",
            "Cafarnaum",
            "Cairu",
            "Caldeirão Grande",
            "Camacan",
            "Camaçari",
            "Camamu",
            "Campo Alegre de Lourdes",
            "Campo Formoso",
            "Canápolis",
            "Canarana",
            "Canavieiras",
            "Candeal",
            "Candeias",
            "Candiba",
            "Cândido Sales",
            "Cansanção",
            "Canudos",
            "Capela do Alto Alegre",
            "Capim Grosso",
            "Caraíbas",
            "Caravelas",
            "Cardeal da Silva",
            "Carinhanha",
            "Casa Nova",
            "Castro Alves",
            "Catolândia",
            "Catu",
            "Caturama",
            "Central",
            "Chorrochó",
            "Cícero Dantas",
            "Cipó",
            "Coaraci",
            "Cocos",
            "Conceição da Feira",
            "Conceição do Almeida",
            "Conceição do Coité",
            "Conceição do Jacuípe",
            "Conde",
            "Condeúba",
            "Contendas do Sincorá",
            "Coração de Maria",
            "Cordeiros",
            "Coribe",
            "Coronel João Sá",
            "Correntina",
            "Cotegipe",
            "Cravolândia",
            "Crisópolis",
            "Cristópolis",
            "Cruz das Almas",
            "Curaçá",
            "Dário Meira",
            "Dias d Ávila",
            "Dom Basílio",
            "Dom Macedo Costa",
            "Elísio Medrado",
            "Encruzilhada",
            "Entre Rios",
            "Érico Cardoso",
            "Esplanada",
            "Euclides da Cunha",
            "Eunápolis",
            "Fátima",
            "Feira da Mata",
            "Feira de Santana",
            "Filadélfia",
            "Firmino Alves",
            "Floresta Azul",
            "Formosa do Rio Preto",
            "Gandu",
            "Gavião",
            "Gentio do Ouro",
            "Glória",
            "Gongogi",
            "Governador Lomanto Júnior",
            "Governador Mangabeira",
            "Guajeru",
            "Guanambi",
            "Guaratinga",
            "Heliópolis",
            "Iaçu",
            "Ibiassucê",
            "Ibicaraí",
            "Ibicoara",
            "Ibicuí",
            "Ibipeba",
            "Ibipitanga",
            "Ibiquera",
            "Ibirapitanga",
            "Ibirapuã",
            "Ibirataia",
            "Ibitiara",
            "Ibititá",
            "Ibotirama",
            "Ichu",
            "Igaporã",
            "Igrapiúna",
            "Iguaí",
            "Ilhéus",
            "Inhambupe",
            "Ipecaetá",
            "Ipiaú",
            "Ipirá",
            "Ipupiara",
            "Irajuba",
            "Iramaia",
            "Iraquara",
            "Irará",
            "Irecê",
            "Itabela",
            "Itaberaba",
            "Itabuna",
            "Itacaré",
            "Itaeté",
            "Itagi",
            "Itagibá",
            "Itagimirim",
            "Itaguaçu da Bahia",
            "Itaju do Colônia",
            "Itajuípe",
            "Itamaraju",
            "Itamari",
            "Itambé",
            "Itanagra",
            "Itanhém",
            "Itaparica",
            "Itapé",
            "Itapebi",
            "Itapetinga",
            "Itapicuru",
            "Itapitanga",
            "Itaquara",
            "Itarantim",
            "Itatim",
            "Itiruçu",
            "Itiúba",
            "Itororó",
            "Ituaçu",
            "Ituberá",
            "Iuiú",
            "Jaborandi",
            "Jacaraci",
            "Jacobina",
            "Jaguaquara",
            "Jaguarari",
            "Jaguaripe",
            "Jandaíra",
            "Jequié",
            "Jeremoabo",
            "Jiquiriçá",
            "Jitaúna",
            "João Dourado",
            "Juazeiro",
            "Jucuruçu",
            "Jussara",
            "Jussari",
            "Jussiape",
            "Lafaiete Coutinho",
            "Lagoa Real",
            "Laje",
            "Lajedão",
            "Lajedinho",
            "Lajedo do Tabocal",
            "Lamarão",
            "Lapão",
            "Lauro de Freitas",
            "Lençóis",
            "Licínio de Almeida",
            "Livramento de Nossa Senhora",
            "Macajuba",
            "Macarani",
            "Macaúbas",
            "Macururé",
            "Madre de Deus",
            "Maetinga",
            "Maiquinique",
            "Mairi",
            "Malhada",
            "Malhada de Pedras",
            "Manoel Vitorino",
            "Mansidão",
            "Maracás",
            "Maragogipe",
            "Maraú",
            "Marcionílio Souza",
            "Mascote",
            "Mata de São João",
            "Matina",
            "Medeiros Neto",
            "Miguel Calmon",
            "Milagres",
            "Mirangaba",
            "Mirante",
            "Monte Santo",
            "Morpará",
            "Morro do Chapéu",
            "Mortugaba",
            "Mucugê",
            "Mucuri",
            "Mulungu do Morro",
            "Mundo Novo",
            "Muniz Ferreira",
            "Muquém de São Francisco",
            "Muritiba",
            "Mutuípe",
            "Nazaré",
            "Nilo Peçanha",
            "Nordestina",
            "Nova Canaã",
            "Nova Fátima",
            "Nova Ibiá",
            "Nova Itarana",
            "Nova Redenção",
            "Nova Soure",
            "Nova Viçosa",
            "Novo Horizonte",
            "Novo Triunfo",
            "Olindina",
            "Oliveira dos Brejinhos",
            "Ouriçangas",
            "Ourolândia",
            "Palmas de Monte Alto",
            "Palmeiras",
            "Paramirim",
            "Paratinga",
            "Paripiranga",
            "Pau Brasil",
            "Paulo Afonso",
            "Pé de Serra",
            "Pedrão",
            "Pedro Alexandre",
            "Piatã",
            "Pilão Arcado",
            "Pindaí",
            "Pindobaçu",
            "Pintadas",
            "Piraí do Norte",
            "Piripá",
            "Piritiba",
            "Planaltino",
            "Planalto",
            "Poções",
            "Pojuca",
            "Ponto Novo",
            "Porto Seguro",
            "Potiraguá",
            "Prado",
            "Presidente Dutra",
            "Presidente Jânio Quadros",
            "Presidente Tancredo Neves",
            "Queimadas",
            "Quijingue",
            "Quixabeira",
            "Rafael Jambeiro",
            "Remanso",
            "Retirolândia",
            "Riachão das Neves",
            "Riachão do Jacuípe",
            "Riacho de Santana",
            "Ribeira do Amparo",
            "Ribeira do Pombal",
            "Ribeirão do Largo",
            "Rio de Contas",
            "Rio do Antônio",
            "Rio do Pires",
            "Rio Real",
            "Rodelas",
            "Ruy Barbosa",
            "Salinas da Margarida",
            "Salvador",
            "Santa Bárbara",
            "Santa Brígida",
            "Santa Cruz Cabrália",
            "Santa Cruz da Vitória",
            "Santa Inês",
            "Santa Luzia",
            "Santa Maria da Vitória",
            "Santa Rita de Cássia",
            "Santa Teresinha",
            "Santaluz",
            "Santana",
            "Santanópolis",
            "Santo Amaro",
            "Santo Antônio de Jesus",
            "Santo Estêvão",
            "São Desidério",
            "São Domingos",
            "São Felipe",
            "São Félix",
            "São Félix do Coribe",
            "São Francisco do Conde",
            "São Gabriel",
            "São Gonçalo dos Campos",
            "São José da Vitória",
            "São José do Jacuípe",
            "São Miguel das Matas",
            "São Sebastião do Passé",
            "Sapeaçu",
            "Sátiro Dias",
            "Saubara",
            "Saúde",
            "Seabra",
            "Sebastião Laranjeiras",
            "Senhor do Bonfim",
            "Sento Sé",
            "Serra do Ramalho",
            "Serra Dourada",
            "Serra Preta",
            "Serrinha",
            "Serrolândia",
            "Simões Filho",
            "Sítio do Mato",
            "Sítio do Quinto",
            "Sobradinho",
            "Souto Soares",
            "Tabocas do Brejo Velho",
            "Tanhaçu",
            "Tanque Novo",
            "Tanquinho",
            "Taperoá",
            "Tapiramutá",
            "Teixeira de Freitas",
            "Teodoro Sampaio",
            "Teofilândia",
            "Teolândia",
            "Terra Nova",
            "Tremedal",
            "Tucano",
            "Uauá",
            "Ubaíra",
            "Ubaitaba",
            "Ubatã",
            "Uibaí",
            "Umburanas",
            "Una",
            "Urandi",
            "Uruçuca",
            "Utinga",
            "Valença",
            "Valente",
            "Várzea da Roça",
            "Várzea do Poço",
            "Várzea Nova",
            "Varzedo",
            "Vera Cruz",
            "Vereda",
            "Vitória da Conquista",
            "Wagner",
            "Wanderley",
            "Wenceslau Guimarães",
            "Xique-Xique",
            "Abaiara",
            "Acarapé",
            "Acaraú",
            "Acopiara",
            "Aiuaba",
            "Alcântaras",
            "Altaneira",
            "Alto Santo",
            "Amontada",
            "Antonina do Norte",
            "Apuiarés",
            "Aquiraz",
            "Aracati",
            "Aracoiaba",
            "Ararendá",
            "Araripe",
            "Aratuba",
            "Arneiroz",
            "Assaré",
            "Aurora",
            "Baixio",
            "Banabuiú",
            "Barbalha",
            "Barreira",
            "Barro",
            "Barroquinha",
            "Baturité",
            "Beberibe",
            "Bela Cruz",
            "Boa Viagem",
            "Brejo Santo",
            "Camocim",
            "Campos Sales",
            "Canindé",
            "Capistrano",
            "Caridade",
            "Cariré",
            "Caririaçu",
            "Cariús",
            "Carnaubal",
            "Cascavel",
            "Catarina",
            "Catunda",
            "Caucaia",
            "Cedro",
            "Chaval",
            "Choró",
            "Chorozinho",
            "Coreaú",
            "Crateús",
            "Crato",
            "Croatá",
            "Cruz",
            "Deputado Irapuan Pinheiro",
            "Ererê",
            "Eusébio",
            "Farias Brito",
            "Forquilha",
            "Fortaleza",
            "Fortim",
            "Frecheirinha",
            "General Sampaio",
            "Graça",
            "Granja",
            "Granjeiro",
            "Groaíras",
            "Guaiúba",
            "Guaraciaba do Norte",
            "Guaramiranga",
            "Hidrolândia",
            "Horizonte",
            "Ibaretama",
            "Ibiapina",
            "Ibicuitinga",
            "Icapuí",
            "Icó",
            "Iguatu",
            "Independência",
            "Ipaporanga",
            "Ipaumirim",
            "Ipu",
            "Ipueiras",
            "Iracema",
            "Irauçuba",
            "Itaiçaba",
            "Itaitinga",
            "Itapagé",
            "Itapipoca",
            "Itapiúna",
            "Itarema",
            "Itatira",
            "Jaguaretama",
            "Jaguaribara",
            "Jaguaribe",
            "Jaguaruana",
            "Jardim",
            "Jati",
            "Jijoca de Jericoacoara",
            "Juazeiro do Norte",
            "Jucás",
            "Lavras da Mangabeira",
            "Limoeiro do Norte",
            "Madalena",
            "Maracanaú",
            "Maranguape",
            "Marco",
            "Martinópole",
            "Massapê",
            "Mauriti",
            "Meruoca",
            "Milagres",
            "Milhã",
            "Miraíma",
            "Missão Velha",
            "Mombaça",
            "Monsenhor Tabosa",
            "Morada Nova",
            "Moraújo",
            "Morrinhos",
            "Mucambo",
            "Mulungu",
            "Nova Olinda",
            "Nova Russas",
            "Novo Oriente",
            "Ocara",
            "Orós",
            "Pacajus",
            "Pacatuba",
            "Pacoti",
            "Pacujá",
            "Palhano",
            "Palmácia",
            "Paracuru",
            "Paraipaba",
            "Parambu",
            "Paramoti",
            "Pedra Branca",
            "Penaforte",
            "Pentecoste",
            "Pereiro",
            "Pindoretama",
            "Piquet Carneiro",
            "Pires Ferreira",
            "Poranga",
            "Porteiras",
            "Potengi",
            "Potiretama",
            "Quiterianópolis",
            "Quixadá",
            "Quixelô",
            "Quixeramobim",
            "Quixeré",
            "Redenção",
            "Reriutaba",
            "Russas",
            "Saboeiro",
            "Salitre",
            "Santa Quitéria",
            "Santana do Acaraú",
            "Santana do Cariri",
            "São Benedito",
            "São Gonçalo do Amarante",
            "São João do Jaguaribe",
            "São Luís do Curu",
            "Senador Pompeu",
            "Senador Sá",
            "Sobral",
            "Solonópole",
            "Tabuleiro do Norte",
            "Tamboril",
            "Tarrafas",
            "Tauá",
            "Tejuçuoca",
            "Tianguá",
            "Trairi",
            "Tururu",
            "Ubajara",
            "Umari",
            "Umirim",
            "Uruburetama",
            "Uruoca",
            "Varjota",
            "Várzea Alegre",
            "Viçosa do Ceará",
            "Brasília",
            "Afonso Cláudio",
            "Água Doce do Norte",
            "Águia Branca",
            "Alegre",
            "Alfredo Chaves",
            "Alto Rio Novo",
            "Anchieta",
            "Apiacá",
            "Aracruz",
            "Atilio Vivacqua",
            "Baixo Guandu",
            "Barra de São Francisco",
            "Boa Esperança",
            "Bom Jesus do Norte",
            "Brejetuba",
            "Cachoeiro de Itapemirim",
            "Cariacica",
            "Castelo",
            "Colatina",
            "Conceição da Barra",
            "Conceição do Castelo",
            "Divino de São Lourenço",
            "Domingos Martins",
            "Dores do Rio Preto",
            "Ecoporanga",
            "Fundão",
            "Guaçuí",
            "Guarapari",
            "Ibatiba",
            "Ibiraçu",
            "Ibitirama",
            "Iconha",
            "Irupi",
            "Itaguaçu",
            "Itapemirim",
            "Itarana",
            "Iúna",
            "Jaguaré",
            "Jerônimo Monteiro",
            "João Neiva",
            "Laranja da Terra",
            "Linhares",
            "Mantenópolis",
            "Marataízes",
            "Marechal Floriano",
            "Marilândia",
            "Mimoso do Sul",
            "Montanha",
            "Mucurici",
            "Muniz Freire",
            "Muqui",
            "Nova Venécia",
            "Pancas",
            "Pedro Canário",
            "Pinheiros",
            "Piúma",
            "Ponto Belo",
            "Presidente Kennedy",
            "Rio Bananal",
            "Rio Novo do Sul",
            "Santa Leopoldina",
            "Santa Maria de Jetibá",
            "Santa Teresa",
            "São Domingos do Norte",
            "São Gabriel da Palha",
            "São José do Calçado",
            "São Mateus",
            "São Roque do Canaã",
            "Serra",
            "Sooretama",
            "Vargem Alta",
            "Venda Nova do Imigrante",
            "Viana",
            "Vila Pavão",
            "Vila Valério",
            "Vila Velha",
            "Vitória",
            "Abadia de Goiás",
            "Abadiânia",
            "Acreúna",
            "Adelândia",
            "Água Fria de Goiás",
            "Água Limpa",
            "Águas Lindas de Goiás",
            "Alexânia",
            "Aloândia",
            "Alto Horizonte",
            "Alto Paraíso de Goiás",
            "Alvorada do Norte",
            "Amaralina",
            "Americano do Brasil",
            "Amorinópolis",
            "Anápolis",
            "Anhanguera",
            "Anicuns",
            "Aparecida de Goiânia",
            "Aparecida do Rio Doce",
            "Aporé",
            "Araçu",
            "Aragarças",
            "Aragoiânia",
            "Araguapaz",
            "Arenópolis",
            "Aruanã",
            "Aurilândia",
            "Avelinópolis",
            "Baliza",
            "Barro Alto",
            "Bela Vista de Goiás",
            "Bom Jardim de Goiás",
            "Bom Jesus de Goiás",
            "Bonfinópolis",
            "Bonópolis",
            "Brazabrantes",
            "Britânia",
            "Buriti Alegre",
            "Buriti de Goiás",
            "Buritinópolis",
            "Cabeceiras",
            "Cachoeira Alta",
            "Cachoeira de Goiás",
            "Cachoeira Dourada",
            "Caçu",
            "Caiapônia",
            "Caldas Novas",
            "Caldazinha",
            "Campestre de Goiás",
            "Campinaçu",
            "Campinorte",
            "Campo Alegre de Goiás",
            "Campos Belos",
            "Campos Verdes",
            "Carmo do Rio Verde",
            "Castelândia",
            "Catalão",
            "Caturaí",
            "Cavalcante",
            "Ceres",
            "Cezarina",
            "Chapadão do Céu",
            "Cidade Ocidental",
            "Cocalzinho de Goiás",
            "Colinas do Sul",
            "Córrego do Ouro",
            "Corumbá de Goiás",
            "Corumbaíba",
            "Cristalina",
            "Cristianópolis",
            "Crixás",
            "Cromínia",
            "Cumari",
            "Damianópolis",
            "Damolândia",
            "Davinópolis",
            "Diorama",
            "Divinópolis de Goiás",
            "Doverlândia",
            "Edealina",
            "Edéia",
            "Estrela do Norte",
            "Faina",
            "Fazenda Nova",
            "Firminópolis",
            "Flores de Goiás",
            "Formosa",
            "Formoso",
            "Goianápolis",
            "Goiandira",
            "Goianésia",
            "Goiânia",
            "Goianira",
            "Goiás",
            "Goiatuba",
            "Gouvelândia",
            "Guapó",
            "Guaraíta",
            "Guarani de Goiás",
            "Guarinos",
            "Heitoraí",
            "Hidrolândia",
            "Hidrolina",
            "Iaciara",
            "Inaciolândia",
            "Indiara",
            "Inhumas",
            "Ipameri",
            "Iporá",
            "Israelândia",
            "Itaberaí",
            "Itaguari",
            "Itaguaru",
            "Itajá",
            "Itapaci",
            "Itapirapuã",
            "Itapuranga",
            "Itarumã",
            "Itauçu",
            "Itumbiara",
            "Ivolândia",
            "Jandaia",
            "Jaraguá",
            "Jataí",
            "Jaupaci",
            "Jesúpolis",
            "Joviânia",
            "Jussara",
            "Leopoldo de Bulhões",
            "Luziânia",
            "Mairipotaba",
            "Mambaí",
            "Mara Rosa",
            "Marzagão",
            "Matrinchã",
            "Maurilândia",
            "Mimoso de Goiás",
            "Minaçu",
            "Mineiros",
            "Moiporá",
            "Monte Alegre de Goiás",
            "Montes Claros de Goiás",
            "Montividiu",
            "Montividiu do Norte",
            "Morrinhos",
            "Morro Agudo de Goiás",
            "Mossâmedes",
            "Mozarlândia",
            "Mundo Novo",
            "Mutunópolis",
            "Nazário",
            "Nerópolis",
            "Niquelândia",
            "Nova América",
            "Nova Aurora",
            "Nova Crixás",
            "Nova Glória",
            "Nova Iguaçu de Goiás",
            "Nova Roma",
            "Nova Veneza",
            "Novo Brasil",
            "Novo Gama",
            "Novo Planalto",
            "Orizona",
            "Ouro Verde de Goiás",
            "Ouvidor",
            "Padre Bernardo",
            "Palestina de Goiás",
            "Palmeiras de Goiás",
            "Palmelo",
            "Palminópolis",
            "Panamá",
            "Paranaiguara",
            "Paraúna",
            "Perolândia",
            "Petrolina de Goiás",
            "Pilar de Goiás",
            "Piracanjuba",
            "Piranhas",
            "Pirenópolis",
            "Pires do Rio",
            "Planaltina",
            "Pontalina",
            "Porangatu",
            "Porteirão",
            "Portelândia",
            "Posse",
            "Professor Jamil",
            "Quirinópolis",
            "Rialma",
            "Rianápolis",
            "Rio Quente",
            "Rio Verde",
            "Rubiataba",
            "Sanclerlândia",
            "Santa Bárbara de Goiás",
            "Santa Cruz de Goiás",
            "Santa Fé de Goiás",
            "Santa Helena de Goiás",
            "Santa Isabel",
            "Santa Rita do Araguaia",
            "Santa Rita do Novo Destino",
            "Santa Rosa de Goiás",
            "Santa Tereza de Goiás",
            "Santa Terezinha de Goiás",
            "Santo Antônio da Barra",
            "Santo Antônio de Goiás",
            "Santo Antônio do Descoberto",
            "São Domingos",
            "São Francisco de Goiás",
            "São João d Aliança",
            "São João da Paraúna",
            "São Luís de Montes Belos",
            "São Luíz do Norte",
            "São Miguel do Araguaia",
            "São Miguel do Passa Quatro",
            "São Patrício",
            "São Simão",
            "Senador Canedo",
            "Serranópolis",
            "Silvânia",
            "Simolândia",
            "Sítio d Abadia",
            "Taquaral de Goiás",
            "Teresina de Goiás",
            "Terezópolis de Goiás",
            "Três Ranchos",
            "Trindade",
            "Trombas",
            "Turvânia",
            "Turvelândia",
            "Uirapuru",
            "Uruaçu",
            "Uruana",
            "Urutaí",
            "Valparaíso de Goiás",
            "Varjão",
            "Vianópolis",
            "Vicentinópolis",
            "Vila Boa",
            "Vila Propício",
            "Açailândia",
            "Afonso Cunha",
            "Água Doce do Maranhão",
            "Alcântara",
            "Aldeias Altas",
            "Altamira do Maranhão",
            "Alto Alegre do Maranhão",
            "Alto Alegre do Pindaré",
            "Alto Parnaíba",
            "Amapá do Maranhão",
            "Amarante do Maranhão",
            "Anajatuba",
            "Anapurus",
            "Apicum-Açu",
            "Araguanã",
            "Araioses",
            "Arame",
            "Arari",
            "Axixá",
            "Bacabal",
            "Bacabeira",
            "Bacuri",
            "Bacurituba",
            "Balsas",
            "Barão de Grajaú",
            "Barra do Corda",
            "Barreirinhas",
            "Bela Vista do Maranhão",
            "Belágua",
            "Benedito Leite",
            "Bequimão",
            "Bernardo do Mearim",
            "Boa Vista do Gurupi",
            "Bom Jardim",
            "Bom Jesus das Selvas",
            "Bom Lugar",
            "Brejo",
            "Brejo de Areia",
            "Buriti",
            "Buriti Bravo",
            "Buriticupu",
            "Buritirana",
            "Cachoeira Grande",
            "Cajapió",
            "Cajari",
            "Campestre do Maranhão",
            "Cândido Mendes",
            "Cantanhede",
            "Capinzal do Norte",
            "Carolina",
            "Carutapera",
            "Caxias",
            "Cedral",
            "Central do Maranhão",
            "Centro do Guilherme",
            "Centro Novo do Maranhão",
            "Chapadinha",
            "Cidelândia",
            "Codó",
            "Coelho Neto",
            "Colinas",
            "Conceição do Lago-Açu",
            "Coroatá",
            "Cururupu",
            "Davinópolis",
            "Dom Pedro",
            "Duque Bacelar",
            "Esperantinópolis",
            "Estreito",
            "Feira Nova do Maranhão",
            "Fernando Falcão",
            "Formosa da Serra Negra",
            "Fortaleza dos Nogueiras",
            "Fortuna",
            "Godofredo Viana",
            "Gonçalves Dias",
            "Governador Archer",
            "Governador Edison Lobão",
            "Governador Eugênio Barros",
            "Governador Luiz Rocha",
            "Governador Newton Bello",
            "Governador Nunes Freire",
            "Graça Aranha",
            "Grajaú",
            "Guimarães",
            "Humberto de Campos",
            "Icatu",
            "Igarapé do Meio",
            "Igarapé Grande",
            "Imperatriz",
            "Itaipava do Grajaú",
            "Itapecuru Mirim",
            "Itinga do Maranhão",
            "Jatobá",
            "Jenipapo dos Vieiras",
            "João Lisboa",
            "Joselândia",
            "Junco do Maranhão",
            "Lago da Pedra",
            "Lago do Junco",
            "Lago dos Rodrigues",
            "Lago Verde",
            "Lagoa do Mato",
            "Lagoa Grande do Maranhão",
            "Lajeado Novo",
            "Lima Campos",
            "Loreto",
            "Luís Domingues",
            "Magalhães de Almeida",
            "Maracaçumé",
            "Marajá do Sena",
            "Maranhãozinho",
            "Mata Roma",
            "Matinha",
            "Matões",
            "Matões do Norte",
            "Milagres do Maranhão",
            "Mirador",
            "Miranda do Norte",
            "Mirinzal",
            "Monção",
            "Montes Altos",
            "Morros",
            "Nina Rodrigues",
            "Nova Colinas",
            "Nova Iorque",
            "Nova Olinda do Maranhão",
            "Olho d Água das Cunhãs",
            "Olinda Nova do Maranhão",
            "Paço do Lumiar",
            "Palmeirândia",
            "Paraibano",
            "Parnarama",
            "Passagem Franca",
            "Pastos Bons",
            "Paulino Neves",
            "Paulo Ramos",
            "Pedreiras",
            "Pedro do Rosário",
            "Penalva",
            "Peri Mirim",
            "Peritoró",
            "Pindaré-Mirim",
            "Pinheiro",
            "Pio XII",
            "Pirapemas",
            "Poção de Pedras",
            "Porto Franco",
            "Porto Rico do Maranhão",
            "Presidente Dutra",
            "Presidente Juscelino",
            "Presidente Médici",
            "Presidente Sarney",
            "Presidente Vargas",
            "Primeira Cruz",
            "Raposa",
            "Riachão",
            "Ribamar Fiquene",
            "Rosário",
            "Sambaíba",
            "Santa Filomena do Maranhão",
            "Santa Helena",
            "Santa Inês",
            "Santa Luzia",
            "Santa Luzia do Paruá",
            "Santa Quitéria do Maranhão",
            "Santa Rita",
            "Santana do Maranhão",
            "Santo Amaro do Maranhão",
            "Santo Antônio dos Lopes",
            "São Benedito do Rio Preto",
            "São Bento",
            "São Bernardo",
            "São Domingos do Azeitão",
            "São Domingos do Maranhão",
            "São Félix de Balsas",
            "São Francisco do Brejão",
            "São Francisco do Maranhão",
            "São João Batista",
            "São João do Carú",
            "São João do Paraíso",
            "São João do Soter",
            "São João dos Patos",
            "São José de Ribamar",
            "São José dos Basílios",
            "São Luís",
            "São Luís Gonzaga do Maranhão",
            "São Mateus do Maranhão",
            "São Pedro da Água Branca",
            "São Pedro dos Crentes",
            "São Raimundo das Mangabeiras",
            "São Raimundo do Doca Bezerra",
            "São Roberto",
            "São Vicente Ferrer",
            "Satubinha",
            "Senador Alexandre Costa",
            "Senador La Rocque",
            "Serrano do Maranhão",
            "Sítio Novo",
            "Sucupira do Norte",
            "Sucupira do Riachão",
            "Tasso Fragoso",
            "Timbiras",
            "Timon",
            "Trizidela do Vale",
            "Tufilândia",
            "Tuntum",
            "Turiaçu",
            "Turilândia",
            "Tutóia",
            "Urbano Santos",
            "Vargem Grande",
            "Viana",
            "Vila Nova dos Martírios",
            "Vitória do Mearim",
            "Vitorino Freire",
            "Zé Doca",
            "Acorizal",
            "Água Boa",
            "Alta Floresta",
            "Alto Araguaia",
            "Alto Boa Vista",
            "Alto Garças",
            "Alto Paraguai",
            "Alto Taquari",
            "Apiacás",
            "Araguaiana",
            "Araguainha",
            "Araputanga",
            "Arenápolis",
            "Aripuanã",
            "Barão de Melgaço",
            "Barra do Bugres",
            "Barra do Garças",
            "Brasnorte",
            "Cáceres",
            "Campinápolis",
            "Campo Novo do Parecis",
            "Campo Verde",
            "Campos de Júlio",
            "Canabrava do Norte",
            "Canarana",
            "Carlinda",
            "Castanheira",
            "Chapada dos Guimarães",
            "Cláudia",
            "Cocalinho",
            "Colíder",
            "Comodoro",
            "Confresa",
            "Cotriguaçu",
            "Cuiabá",
            "Denise",
            "Diamantino",
            "Dom Aquino",
            "Feliz Natal",
            "Figueirópolis d Oeste",
            "Gaúcha do Norte",
            "General Carneiro",
            "Glória d Oeste",
            "Guarantã do Norte",
            "Guiratinga",
            "Indiavaí",
            "Itaúba",
            "Itiquira",
            "Jaciara",
            "Jangada",
            "Jauru",
            "Juara",
            "Juína",
            "Juruena",
            "Juscimeira",
            "Lambari d Oeste",
            "Lucas do Rio Verde",
            "Luciára",
            "Marcelândia",
            "Matupá",
            "Mirassol d Oeste",
            "Nobres",
            "Nortelândia",
            "Nossa Senhora do Livramento",
            "Nova Bandeirantes",
            "Nova Brasilândia",
            "Nova Canaã do Norte",
            "Nova Guarita",
            "Nova Lacerda",
            "Nova Marilândia",
            "Nova Maringá",
            "Nova Monte Verde",
            "Nova Mutum",
            "Nova Olímpia",
            "Nova Ubiratã",
            "Nova Xavantina",
            "Novo Horizonte do Norte",
            "Novo Mundo",
            "Novo São Joaquim",
            "Paranaíta",
            "Paranatinga",
            "Pedra Preta",
            "Peixoto de Azevedo",
            "Planalto da Serra",
            "Poconé",
            "Pontal do Araguaia",
            "Ponte Branca",
            "Pontes e Lacerda",
            "Porto Alegre do Norte",
            "Porto dos Gaúchos",
            "Porto Esperidião",
            "Porto Estrela",
            "Poxoréo",
            "Primavera do Leste",
            "Querência",
            "Reserva do Cabaçal",
            "Ribeirão Cascalheira",
            "Ribeirãozinho",
            "Rio Branco",
            "Rondonópolis",
            "Rosário Oeste",
            "Salto do Céu",
            "Santa Carmem",
            "Santa Terezinha",
            "Santo Afonso",
            "Santo Antônio do Leverger",
            "São Félix do Araguaia",
            "São José do Povo",
            "São José do Rio Claro",
            "São José do Xingu",
            "São José dos Quatro Marcos",
            "São Pedro da Cipa",
            "Sapezal",
            "Sinop",
            "Sorriso",
            "Tabaporã",
            "Tangará da Serra",
            "Tapurah",
            "Terra Nova do Norte",
            "Tesouro",
            "Torixoréu",
            "União do Sul",
            "Várzea Grande",
            "Vera",
            "Vila Bela da Santíssima Trindade",
            "Vila Rica",
            "Água Clara",
            "Alcinópolis",
            "Amambaí",
            "Anastácio",
            "Anaurilândia",
            "Angélica",
            "Antônio João",
            "Aparecida do Taboado",
            "Aquidauana",
            "Aral Moreira",
            "Bandeirantes",
            "Bataguassu",
            "Bataiporã",
            "Bela Vista",
            "Bodoquena",
            "Bonito",
            "Brasilândia",
            "Caarapó",
            "Camapuã",
            "Campo Grande",
            "Caracol",
            "Cassilândia",
            "Chapadão do Sul",
            "Corguinho",
            "Coronel Sapucaia",
            "Corumbá",
            "Costa Rica",
            "Coxim",
            "Deodápolis",
            "Dois Irmãos do Buriti",
            "Douradina",
            "Dourados",
            "Eldorado",
            "Fátima do Sul",
            "Glória de Dourados",
            "Guia Lopes da Laguna",
            "Iguatemi",
            "Inocência",
            "Itaporã",
            "Itaquiraí",
            "Ivinhema",
            "Japorã",
            "Jaraguari",
            "Jardim",
            "Jateí",
            "Juti",
            "Ladário",
            "Laguna Carapã",
            "Maracaju",
            "Miranda",
            "Mundo Novo",
            "Naviraí",
            "Nioaque",
            "Nova Alvorada do Sul",
            "Nova Andradina",
            "Novo Horizonte do Sul",
            "Paranaíba",
            "Paranhos",
            "Pedro Gomes",
            "Ponta Porã",
            "Porto Murtinho",
            "Ribas do Rio Pardo",
            "Rio Brilhante",
            "Rio Negro",
            "Rio Verde de Mato Grosso",
            "Rochedo",
            "Santa Rita do Pardo",
            "São Gabriel do Oeste",
            "Selvíria",
            "Sete Quedas",
            "Sidrolândia",
            "Sonora",
            "Tacuru",
            "Taquarussu",
            "Terenos",
            "Três Lagoas",
            "Vicentina",
            "Abadia dos Dourados",
            "Abaeté",
            "Abre Campo",
            "Acaiaca",
            "Açucena",
            "Água Boa",
            "Água Comprida",
            "Aguanil",
            "Águas Formosas",
            "Águas Vermelhas",
            "Aimorés",
            "Aiuruoca",
            "Alagoa",
            "Albertina",
            "Além Paraíba",
            "Alfenas",
            "Alfredo Vasconcelos",
            "Almenara",
            "Alpercata",
            "Alpinópolis",
            "Alterosa",
            "Alto Caparaó",
            "Alto Jequitibá",
            "Alto Rio Doce",
            "Alvarenga",
            "Alvinópolis",
            "Alvorada de Minas",
            "Amparo do Serra",
            "Andradas",
            "Andrelândia",
            "Angelândia",
            "Antônio Carlos",
            "Antônio Dias",
            "Antônio Prado de Minas",
            "Araçaí",
            "Aracitaba",
            "Araçuaí",
            "Araguari",
            "Arantina",
            "Araponga",
            "Araporã",
            "Arapuá",
            "Araújos",
            "Araxá",
            "Arceburgo",
            "Arcos",
            "Areado",
            "Argirita",
            "Aricanduva",
            "Arinos",
            "Astolfo Dutra",
            "Ataléia",
            "Augusto de Lima",
            "Baependi",
            "Baldim",
            "Bambuí",
            "Bandeira",
            "Bandeira do Sul",
            "Barão de Cocais",
            "Barão de Monte Alto",
            "Barbacena",
            "Barra Longa",
            "Barroso",
            "Bela Vista de Minas",
            "Belmiro Braga",
            "Belo Horizonte",
            "Belo Oriente",
            "Belo Vale",
            "Berilo",
            "Berizal",
            "Bertópolis",
            "Betim",
            "Bias Fortes",
            "Bicas",
            "Biquinhas",
            "Boa Esperança",
            "Bocaina de Minas",
            "Bocaiúva",
            "Bom Despacho",
            "Bom Jardim de Minas",
            "Bom Jesus da Penha",
            "Bom Jesus do Amparo",
            "Bom Jesus do Galho",
            "Bom Repouso",
            "Bom Sucesso",
            "Bonfim",
            "Bonfinópolis de Minas",
            "Bonito de Minas",
            "Borda da Mata",
            "Botelhos",
            "Botumirim",
            "Brás Pires",
            "Brasilândia de Minas",
            "Brasília de Minas",
            "Brasópolis",
            "Braúnas",
            "Brumadinho",
            "Bueno Brandão",
            "Buenópolis",
            "Bugre",
            "Buritis",
            "Buritizeiro",
            "Cabeceira Grande",
            "Cabo Verde",
            "Cachoeira da Prata",
            "Cachoeira de Minas",
            "Cachoeira de Pajeú",
            "Cachoeira Dourada",
            "Caetanópolis",
            "Caeté",
            "Caiana",
            "Cajuri",
            "Caldas",
            "Camacho",
            "Camanducaia",
            "Cambuí",
            "Cambuquira",
            "Campanário",
            "Campanha",
            "Campestre",
            "Campina Verde",
            "Campo Azul",
            "Campo Belo",
            "Campo do Meio",
            "Campo Florido",
            "Campos Altos",
            "Campos Gerais",
            "Cana Verde",
            "Canaã",
            "Canápolis",
            "Candeias",
            "Cantagalo",
            "Caparaó",
            "Capela Nova",
            "Capelinha",
            "Capetinga",
            "Capim Branco",
            "Capinópolis",
            "Capitão Andrade",
            "Capitão Enéas",
            "Capitólio",
            "Caputira",
            "Caraí",
            "Caranaíba",
            "Carandaí",
            "Carangola",
            "Caratinga",
            "Carbonita",
            "Careaçu",
            "Carlos Chagas",
            "Carmésia",
            "Carmo da Cachoeira",
            "Carmo da Mata",
            "Carmo de Minas",
            "Carmo do Cajuru",
            "Carmo do Paranaíba",
            "Carmo do Rio Claro",
            "Carmópolis de Minas",
            "Carneirinho",
            "Carrancas",
            "Carvalhópolis",
            "Carvalhos",
            "Casa Grande",
            "Cascalho Rico",
            "Cássia",
            "Cataguases",
            "Catas Altas",
            "Catas Altas da Noruega",
            "Catuji",
            "Catuti",
            "Caxambu",
            "Cedro do Abaeté",
            "Central de Minas",
            "Centralina",
            "Chácara",
            "Chalé",
            "Chapada do Norte",
            "Chapada Gaúcha",
            "Chiador",
            "Cipotânea",
            "Claraval",
            "Claro dos Poções",
            "Cláudio",
            "Coimbra",
            "Coluna",
            "Comendador Gomes",
            "Comercinho",
            "Conceição da Aparecida",
            "Conceição da Barra de Minas",
            "Conceição das Alagoas",
            "Conceição das Pedras",
            "Conceição de Ipanema",
            "Conceição do Mato Dentro",
            "Conceição do Pará",
            "Conceição do Rio Verde",
            "Conceição dos Ouros",
            "Cônego Marinho",
            "Confins",
            "Congonhal",
            "Congonhas",
            "Congonhas do Norte",
            "Conquista",
            "Conselheiro Lafaiete",
            "Conselheiro Pena",
            "Consolação",
            "Contagem",
            "Coqueiral",
            "Coração de Jesus",
            "Cordisburgo",
            "Cordislândia",
            "Corinto",
            "Coroaci",
            "Coromandel",
            "Coronel Fabriciano",
            "Coronel Murta",
            "Coronel Pacheco",
            "Coronel Xavier Chaves",
            "Córrego Danta",
            "Córrego do Bom Jesus",
            "Córrego Fundo",
            "Córrego Novo",
            "Couto de Magalhães de Minas",
            "Crisólita",
            "Cristais",
            "Cristália",
            "Cristiano Otoni",
            "Cristina",
            "Crucilândia",
            "Cruzeiro da Fortaleza",
            "Cruzília",
            "Cuparaque",
            "Curral de Dentro",
            "Curvelo",
            "Datas",
            "Delfim Moreira",
            "Delfinópolis",
            "Delta",
            "Descoberto",
            "Desterro de Entre Rios",
            "Desterro do Melo",
            "Diamantina",
            "Diogo de Vasconcelos",
            "Dionísio",
            "Divinésia",
            "Divino",
            "Divino das Laranjeiras",
            "Divinolândia de Minas",
            "Divinópolis",
            "Divisa Alegre",
            "Divisa Nova",
            "Divisópolis",
            "Dom Bosco",
            "Dom Cavati",
            "Dom Joaquim",
            "Dom Silvério",
            "Dom Viçoso",
            "Dona Eusébia",
            "Dores de Campos",
            "Dores de Guanhães",
            "Dores do Indaiá",
            "Dores do Turvo",
            "Doresópolis",
            "Douradoquara",
            "Durandé",
            "Elói Mendes",
            "Engenheiro Caldas",
            "Engenheiro Navarro",
            "Entre Folhas",
            "Entre Rios de Minas",
            "Ervália",
            "Esmeraldas",
            "Espera Feliz",
            "Espinosa",
            "Espírito Santo do Dourado",
            "Estiva",
            "Estrela Dalva",
            "Estrela do Indaiá",
            "Estrela do Sul",
            "Eugenópolis",
            "Ewbank da Câmara",
            "Extrema",
            "Fama",
            "Faria Lemos",
            "Felício dos Santos",
            "Felisburgo",
            "Felixlândia",
            "Fernandes Tourinho",
            "Ferros",
            "Fervedouro",
            "Florestal",
            "Formiga",
            "Formoso",
            "Fortaleza de Minas",
            "Fortuna de Minas",
            "Francisco Badaró",
            "Francisco Dumont",
            "Francisco Sá",
            "Franciscópolis",
            "Frei Gaspar",
            "Frei Inocêncio",
            "Frei Lagonegro",
            "Fronteira",
            "Fronteira dos Vales",
            "Fruta de Leite",
            "Frutal",
            "Funilândia",
            "Galiléia",
            "Gameleiras",
            "Glaucilândia",
            "Goiabeira",
            "Goianá",
            "Gonçalves",
            "Gonzaga",
            "Gouveia",
            "Governador Valadares",
            "Grão Mogol",
            "Grupiara",
            "Guanhães",
            "Guapé",
            "Guaraciaba",
            "Guaraciama",
            "Guaranésia",
            "Guarani",
            "Guarará",
            "Guarda-Mor",
            "Guaxupé",
            "Guidoval",
            "Guimarânia",
            "Guiricema",
            "Gurinhatã",
            "Heliodora",
            "Iapu",
            "Ibertioga",
            "Ibiá",
            "Ibiaí",
            "Ibiracatu",
            "Ibiraci",
            "Ibirité",
            "Ibitiúra de Minas",
            "Ibituruna",
            "Icaraí de Minas",
            "Igarapé",
            "Igaratinga",
            "Iguatama",
            "Ijaci",
            "Ilicínea",
            "Imbé de Minas",
            "Inconfidentes",
            "Indaiabira",
            "Indianópolis",
            "Ingaí",
            "Inhapim",
            "Inhaúma",
            "Inimutaba",
            "Ipaba",
            "Ipanema",
            "Ipatinga",
            "Ipiaçu",
            "Ipuiúna",
            "Iraí de Minas",
            "Itabira",
            "Itabirinha de Mantena",
            "Itabirito",
            "Itacambira",
            "Itacarambi",
            "Itaguara",
            "Itaipé",
            "Itajubá",
            "Itamarandiba",
            "Itamarati de Minas",
            "Itambacuri",
            "Itambé do Mato Dentro",
            "Itamogi",
            "Itamonte",
            "Itanhandu",
            "Itanhomi",
            "Itaobim",
            "Itapagipe",
            "Itapecerica",
            "Itapeva",
            "Itatiaiuçu",
            "Itaú de Minas",
            "Itaúna",
            "Itaverava",
            "Itinga",
            "Itueta",
            "Ituiutaba",
            "Itumirim",
            "Iturama",
            "Itutinga",
            "Jaboticatubas",
            "Jacinto",
            "Jacuí",
            "Jacutinga",
            "Jaguaraçu",
            "Jaíba",
            "Jampruca",
            "Janaúba",
            "Januária",
            "Japaraíba",
            "Japonvar",
            "Jeceaba",
            "Jenipapo de Minas",
            "Jequeri",
            "Jequitaí",
            "Jequitibá",
            "Jequitinhonha",
            "Jesuânia",
            "Joaíma",
            "Joanésia",
            "João Monlevade",
            "João Pinheiro",
            "Joaquim Felício",
            "Jordânia",
            "José Gonçalves de Minas",
            "José Raydan",
            "Josenópolis",
            "Juatuba",
            "Juiz de Fora",
            "Juramento",
            "Juruaia",
            "Juvenília",
            "Ladainha",
            "Lagamar",
            "Lagoa da Prata",
            "Lagoa dos Patos",
            "Lagoa Dourada",
            "Lagoa Formosa",
            "Lagoa Grande",
            "Lagoa Santa",
            "Lajinha",
            "Lambari",
            "Lamim",
            "Laranjal",
            "Lassance",
            "Lavras",
            "Leandro Ferreira",
            "Leme do Prado",
            "Leopoldina",
            "Liberdade",
            "Lima Duarte",
            "Limeira do Oeste",
            "Lontra",
            "Luisburgo",
            "Luislândia",
            "Luminárias",
            "Luz",
            "Machacalis",
            "Machado",
            "Madre de Deus de Minas",
            "Malacacheta",
            "Mamonas",
            "Manga",
            "Manhuaçu",
            "Manhumirim",
            "Mantena",
            "Mar de Espanha",
            "Maravilhas",
            "Maria da Fé",
            "Mariana",
            "Marilac",
            "Mário Campos",
            "Maripá de Minas",
            "Marliéria",
            "Marmelópolis",
            "Martinho Campos",
            "Martins Soares",
            "Mata Verde",
            "Materlândia",
            "Mateus Leme",
            "Mathias Lobato",
            "Matias Barbosa",
            "Matias Cardoso",
            "Matipó",
            "Mato Verde",
            "Matozinhos",
            "Matutina",
            "Medeiros",
            "Medina",
            "Mendes Pimentel",
            "Mercês",
            "Mesquita",
            "Minas Novas",
            "Minduri",
            "Mirabela",
            "Miradouro",
            "Miraí",
            "Miravânia",
            "Moeda",
            "Moema",
            "Monjolos",
            "Monsenhor Paulo",
            "Montalvânia",
            "Monte Alegre de Minas",
            "Monte Azul",
            "Monte Belo",
            "Monte Carmelo",
            "Monte Formoso",
            "Monte Santo de Minas",
            "Monte Sião",
            "Montes Claros",
            "Montezuma",
            "Morada Nova de Minas",
            "Morro da Garça",
            "Morro do Pilar",
            "Munhoz",
            "Muriaé",
            "Mutum",
            "Muzambinho",
            "Nacip Raydan",
            "Nanuque",
            "Naque",
            "Natalândia",
            "Natércia",
            "Nazareno",
            "Nepomuceno",
            "Ninheira",
            "Nova Belém",
            "Nova Era",
            "Nova Lima",
            "Nova Módica",
            "Nova Ponte",
            "Nova Porteirinha",
            "Nova Resende",
            "Nova Serrana",
            "Nova União",
            "Novo Cruzeiro",
            "Novo Oriente de Minas",
            "Novorizonte",
            "Olaria",
            "Olhos-d Água",
            "Olímpio Noronha",
            "Oliveira",
            "Oliveira Fortes",
            "Onça de Pitangui",
            "Oratórios",
            "Orizânia",
            "Ouro Branco",
            "Ouro Fino",
            "Ouro Preto",
            "Ouro Verde de Minas",
            "Padre Carvalho",
            "Padre Paraíso",
            "Pai Pedro",
            "Paineiras",
            "Pains",
            "Paiva",
            "Palma",
            "Palmópolis",
            "Papagaios",
            "Pará de Minas",
            "Paracatu",
            "Paraguaçu",
            "Paraisópolis",
            "Paraopeba",
            "Passa Quatro",
            "Passa Tempo",
            "Passa-Vinte",
            "Passabém",
            "Passos",
            "Patis",
            "Patos de Minas",
            "Patrocínio",
            "Patrocínio do Muriaé",
            "Paula Cândido",
            "Paulistas",
            "Pavão",
            "Peçanha",
            "Pedra Azul",
            "Pedra Bonita",
            "Pedra do Anta",
            "Pedra do Indaiá",
            "Pedra Dourada",
            "Pedralva",
            "Pedras de Maria da Cruz",
            "Pedrinópolis",
            "Pedro Leopoldo",
            "Pedro Teixeira",
            "Pequeri",
            "Pequi",
            "Perdigão",
            "Perdizes",
            "Perdões",
            "Periquito",
            "Pescador",
            "Piau",
            "Piedade de Caratinga",
            "Piedade de Ponte Nova",
            "Piedade do Rio Grande",
            "Piedade dos Gerais",
            "Pimenta",
            "Pingo-d Água",
            "Pintópolis",
            "Piracema",
            "Pirajuba",
            "Piranga",
            "Piranguçu",
            "Piranguinho",
            "Pirapetinga",
            "Pirapora",
            "Piraúba",
            "Pitangui",
            "Piumhi",
            "Planura",
            "Poço Fundo",
            "Poços de Caldas",
            "Pocrane",
            "Pompéu",
            "Ponte Nova",
            "Ponto Chique",
            "Ponto dos Volantes",
            "Porteirinha",
            "Porto Firme",
            "Poté",
            "Pouso Alegre",
            "Pouso Alto",
            "Prados",
            "Prata",
            "Pratápolis",
            "Pratinha",
            "Presidente Bernardes",
            "Presidente Juscelino",
            "Presidente Kubitschek",
            "Presidente Olegário",
            "Prudente de Morais",
            "Quartel Geral",
            "Queluzito",
            "Raposos",
            "Raul Soares",
            "Recreio",
            "Reduto",
            "Resende Costa",
            "Resplendor",
            "Ressaquinha",
            "Riachinho",
            "Riacho dos Machados",
            "Ribeirão das Neves",
            "Ribeirão Vermelho",
            "Rio Acima",
            "Rio Casca",
            "Rio do Prado",
            "Rio Doce",
            "Rio Espera",
            "Rio Manso",
            "Rio Novo",
            "Rio Paranaíba",
            "Rio Pardo de Minas",
            "Rio Piracicaba",
            "Rio Pomba",
            "Rio Preto",
            "Rio Vermelho",
            "Ritápolis",
            "Rochedo de Minas",
            "Rodeiro",
            "Romaria",
            "Rosário da Limeira",
            "Rubelita",
            "Rubim",
            "Sabará",
            "Sabinópolis",
            "Sacramento",
            "Salinas",
            "Salto da Divisa",
            "Santa Bárbara",
            "Santa Bárbara do Leste",
            "Santa Bárbara do Monte Verde",
            "Santa Bárbara do Tugúrio",
            "Santa Cruz de Minas",
            "Santa Cruz de Salinas",
            "Santa Cruz do Escalvado",
            "Santa Efigênia de Minas",
            "Santa Fé de Minas",
            "Santa Helena de Minas",
            "Santa Juliana",
            "Santa Luzia",
            "Santa Margarida",
            "Santa Maria de Itabira",
            "Santa Maria do Salto",
            "Santa Maria do Suaçuí",
            "Santa Rita de Caldas",
            "Santa Rita de Ibitipoca",
            "Santa Rita de Jacutinga",
            "Santa Rita de Minas",
            "Santa Rita do Itueto",
            "Santa Rita do Sapucaí",
            "Santa Rosa da Serra",
            "Santa Vitória",
            "Santana da Vargem",
            "Santana de Cataguases",
            "Santana de Pirapama",
            "Santana do Deserto",
            "Santana do Garambéu",
            "Santana do Jacaré",
            "Santana do Manhuaçu",
            "Santana do Paraíso",
            "Santana do Riacho",
            "Santana dos Montes",
            "Santo Antônio do Amparo",
            "Santo Antônio do Aventureiro",
            "Santo Antônio do Grama",
            "Santo Antônio do Itambé",
            "Santo Antônio do Jacinto",
            "Santo Antônio do Monte",
            "Santo Antônio do Retiro",
            "Santo Antônio do Rio Abaixo",
            "Santo Hipólito",
            "Santos Dumont",
            "São Bento Abade",
            "São Brás do Suaçuí",
            "São Domingos das Dores",
            "São Domingos do Prata",
            "São Félix de Minas",
            "São Francisco",
            "São Francisco de Paula",
            "São Francisco de Sales",
            "São Francisco do Glória",
            "São Geraldo",
            "São Geraldo da Piedade",
            "São Geraldo do Baixio",
            "São Gonçalo do Abaeté",
            "São Gonçalo do Pará",
            "São Gonçalo do Rio Abaixo",
            "São Gonçalo do Rio Preto",
            "São Gonçalo do Sapucaí",
            "São Gotardo",
            "São João Batista do Glória",
            "São João da Lagoa",
            "São João da Mata",
            "São João da Ponte",
            "São João das Missões",
            "São João del Rei",
            "São João do Manhuaçu",
            "São João do Manteninha",
            "São João do Oriente",
            "São João do Pacuí",
            "São João do Paraíso",
            "São João Evangelista",
            "São João Nepomuceno",
            "São Joaquim de Bicas",
            "São José da Barra",
            "São José da Lapa",
            "São José da Safira",
            "São José da Varginha",
            "São José do Alegre",
            "São José do Divino",
            "São José do Goiabal",
            "São José do Jacuri",
            "São José do Mantimento",
            "São Lourenço",
            "São Miguel do Anta",
            "São Pedro da União",
            "São Pedro do Suaçuí",
            "São Pedro dos Ferros",
            "São Romão",
            "São Roque de Minas",
            "São Sebastião da Bela Vista",
            "São Sebastião da Vargem Alegre",
            "São Sebastião do Anta",
            "São Sebastião do Maranhão",
            "São Sebastião do Oeste",
            "São Sebastião do Paraíso",
            "São Sebastião do Rio Preto",
            "São Sebastião do Rio Verde",
            "São Thomé das Letras",
            "São Tiago",
            "São Tomás de Aquino",
            "São Vicente de Minas",
            "Sapucaí-Mirim",
            "Sardoá",
            "Sarzedo",
            "Sem-Peixe",
            "Senador Amaral",
            "Senador Cortes",
            "Senador Firmino",
            "Senador José Bento",
            "Senador Modestino Gonçalves",
            "Senhora de Oliveira",
            "Senhora do Porto",
            "Senhora dos Remédios",
            "Sericita",
            "Seritinga",
            "Serra Azul de Minas",
            "Serra da Saudade",
            "Serra do Salitre",
            "Serra dos Aimorés",
            "Serrania",
            "Serranópolis de Minas",
            "Serranos",
            "Serro",
            "Sete Lagoas",
            "Setubinha",
            "Silveirânia",
            "Silvianópolis",
            "Simão Pereira",
            "Simonésia",
            "Sobrália",
            "Soledade de Minas",
            "Tabuleiro",
            "Taiobeiras",
            "Taparuba",
            "Tapira",
            "Tapiraí",
            "Taquaraçu de Minas",
            "Tarumirim",
            "Teixeiras",
            "Teófilo Otoni",
            "Timóteo",
            "Tiradentes",
            "Tiros",
            "Tocantins",
            "Tocos do Moji",
            "Toledo",
            "Tombos",
            "Três Corações",
            "Três Marias",
            "Três Pontas",
            "Tumiritinga",
            "Tupaciguara",
            "Turmalina",
            "Turvolândia",
            "Ubá",
            "Ubaí",
            "Ubaporanga",
            "Uberaba",
            "Uberlândia",
            "Umburatiba",
            "Unaí",
            "União de Minas",
            "Uruana de Minas",
            "Urucânia",
            "Urucuia",
            "Vargem Alegre",
            "Vargem Bonita",
            "Vargem Grande do Rio Pardo",
            "Varginha",
            "Varjão de Minas",
            "Várzea da Palma",
            "Varzelândia",
            "Vazante",
            "Verdelândia",
            "Veredinha",
            "Veríssimo",
            "Vermelho Novo",
            "Vespasiano",
            "Viçosa",
            "Vieiras",
            "Virgem da Lapa",
            "Virgínia",
            "Virginópolis",
            "Virgolândia",
            "Visconde do Rio Branco",
            "Volta Grande",
            "Wenceslau Braz",
            "Abaetetuba",
            "Abel Figueiredo",
            "Acará",
            "Afuá",
            "Água Azul do Norte",
            "Alenquer",
            "Almeirim",
            "Altamira",
            "Anajás",
            "Ananindeua",
            "Anapu",
            "Augusto Corrêa",
            "Aurora do Pará",
            "Aveiro",
            "Bagre",
            "Baião",
            "Bannach",
            "Barcarena",
            "Belém",
            "Belterra",
            "Benevides",
            "Bom Jesus do Tocantins",
            "Bonito",
            "Bragança",
            "Brasil Novo",
            "Brejo Grande do Araguaia",
            "Breu Branco",
            "Breves",
            "Bujaru",
            "Cachoeira do Arari",
            "Cachoeira do Piriá",
            "Cametá",
            "Canaã dos Carajás",
            "Capanema",
            "Capitão "});
            this.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCidade.Location = new System.Drawing.Point(101, 170);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(299, 26);
            this.txtCidade.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "UF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cidade";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDCliente.Location = new System.Drawing.Point(13, 32);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(65, 26);
            this.txtIDCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntFechar);
            this.groupBox2.Controls.Add(this.bntAtualizar);
            this.groupBox2.Controls.Add(this.bntExcluir);
            this.groupBox2.Controls.Add(this.bntSalva);
            this.groupBox2.Controls.Add(this.bntNovo);
            this.groupBox2.Location = new System.Drawing.Point(522, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(142, 291);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // bntFechar
            // 
            this.bntFechar.Location = new System.Drawing.Point(12, 240);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(121, 43);
            this.bntFechar.TabIndex = 14;
            this.bntFechar.Text = "Fechar";
            this.bntFechar.UseVisualStyleBackColor = true;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            // 
            // bntAtualizar
            // 
            this.bntAtualizar.Location = new System.Drawing.Point(12, 185);
            this.bntAtualizar.Name = "bntAtualizar";
            this.bntAtualizar.Size = new System.Drawing.Size(121, 43);
            this.bntAtualizar.TabIndex = 13;
            this.bntAtualizar.Text = "Atualizar";
            this.bntAtualizar.UseVisualStyleBackColor = true;
            this.bntAtualizar.Click += new System.EventHandler(this.bntAtualizar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Location = new System.Drawing.Point(12, 128);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(121, 43);
            this.bntExcluir.TabIndex = 12;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // bntSalva
            // 
            this.bntSalva.Enabled = false;
            this.bntSalva.Location = new System.Drawing.Point(12, 70);
            this.bntSalva.Name = "bntSalva";
            this.bntSalva.Size = new System.Drawing.Size(121, 43);
            this.bntSalva.TabIndex = 11;
            this.bntSalva.Text = "Salvar";
            this.bntSalva.UseVisualStyleBackColor = true;
            this.bntSalva.Click += new System.EventHandler(this.bntSalva_Click);
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(12, 13);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(121, 43);
            this.bntNovo.TabIndex = 1;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.contato1DataGridViewTextBoxColumn,
            this.contato2DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView.DataSource = this.tbClienteBindingSource1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 305);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(681, 246);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dt_cad";
            this.dataGridViewTextBoxColumn2.HeaderText = "dt_cad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // contato1DataGridViewTextBoxColumn
            // 
            this.contato1DataGridViewTextBoxColumn.DataPropertyName = "contato1";
            this.contato1DataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contato1DataGridViewTextBoxColumn.Name = "contato1DataGridViewTextBoxColumn";
            // 
            // contato2DataGridViewTextBoxColumn
            // 
            this.contato2DataGridViewTextBoxColumn.DataPropertyName = "contato2";
            this.contato2DataGridViewTextBoxColumn.HeaderText = "contato2";
            this.contato2DataGridViewTextBoxColumn.Name = "contato2DataGridViewTextBoxColumn";
            this.contato2DataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "veiculo_mod";
            this.dataGridViewTextBoxColumn4.HeaderText = "Veiculo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn5.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "placa";
            this.dataGridViewTextBoxColumn6.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "uf";
            this.dataGridViewTextBoxColumn8.HeaderText = "UF";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn9.HeaderText = "obs";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // tbClienteBindingSource1
            // 
            this.tbClienteBindingSource1.DataMember = "TbCliente";
            this.tbClienteBindingSource1.DataSource = this.dataSetCliente;
            // 
            // dataSetCliente
            // 
            this.dataSetCliente.DataSetName = "DataSetCliente";
            this.dataSetCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "TbCliente";
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirCompletoToolStripMenuItem,
            this.exibirNormalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 48);
            // 
            // exibirCompletoToolStripMenuItem
            // 
            this.exibirCompletoToolStripMenuItem.Name = "exibirCompletoToolStripMenuItem";
            this.exibirCompletoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exibirCompletoToolStripMenuItem.Text = "Exibir Completo";
            this.exibirCompletoToolStripMenuItem.Click += new System.EventHandler(this.exibirCompletoToolStripMenuItem_Click);
            // 
            // exibirNormalToolStripMenuItem
            // 
            this.exibirNormalToolStripMenuItem.Name = "exibirNormalToolStripMenuItem";
            this.exibirNormalToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exibirNormalToolStripMenuItem.Text = "Exibir Normal";
            this.exibirNormalToolStripMenuItem.Click += new System.EventHandler(this.exibirNormalToolStripMenuItem_Click);
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 551);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadCliente_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskContato1;
        private System.Windows.Forms.MaskedTextBox mskPlaca;
        private System.Windows.Forms.MaskedTextBox mskDtCadCli;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntFechar;
        private System.Windows.Forms.Button bntAtualizar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button bntSalva;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MaskedTextBox mskContato2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculomodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private DataSetCliente dataSetCliente;
        private System.Windows.Forms.BindingSource tbClienteBindingSource1;
        private DataSetClienteTableAdapters.TbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirCompletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirNormalToolStripMenuItem;
    }
}