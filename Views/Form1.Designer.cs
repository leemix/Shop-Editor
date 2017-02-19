using Sorted.Src.Interface;

namespace Sorted
{
    public partial class SortEditor 
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
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemEditor = new System.Windows.Forms.GroupBox();
            this.PeriodLabel = new System.Windows.Forms.Label();
            this.PeriodBox = new System.Windows.Forms.TextBox();
            this.GoodsNumLabel = new System.Windows.Forms.Label();
            this.GoodsNumEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HpEdit = new System.Windows.Forms.TextBox();
            this.DefenseLabel = new System.Windows.Forms.Label();
            this.DefenseEdit = new System.Windows.Forms.TextBox();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.AttackEdit = new System.Windows.Forms.TextBox();
            this.CharacterClassLabel = new System.Windows.Forms.Label();
            this.CharacterclassBox = new System.Windows.Forms.ComboBox();
            this.AcessoryBox = new System.Windows.Forms.ComboBox();
            this.AcessoryLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ItemTypeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CoinLabel = new System.Windows.Forms.Label();
            this.CharacterBox = new System.Windows.Forms.ComboBox();
            this.CharacterLabel = new System.Windows.Forms.Label();
            this.PriceEdit = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ItemLevelEdit = new System.Windows.Forms.TextBox();
            this.ItemLevelLabel = new System.Windows.Forms.Label();
            this.LevelEdit = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionEdit = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ItemEdit = new System.Windows.Forms.TextBox();
            this.Idlabel = new System.Windows.Forms.Label();
            this.IdEdit = new System.Windows.Forms.TextBox();
            this.SearchEdit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CharacterSearchBox = new System.Windows.Forms.ComboBox();
            this.SearchTypeBox = new System.Windows.Forms.ComboBox();
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList)).BeginInit();
            this.ItemEditor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(808, 24);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.closeToolStripMenuItem.Text = "Refresh";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editItemToolStripMenuItem,
            this.newItemToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.editToolStripMenuItem.Text = "Item";
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.newItemToolStripMenuItem.Text = "New Item";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatePricesToolStripMenuItem,
            this.generateQueryToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.viewToolStripMenuItem.Text = "Tools";
            // 
            // updatePricesToolStripMenuItem
            // 
            this.updatePricesToolStripMenuItem.Name = "updatePricesToolStripMenuItem";
            this.updatePricesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.updatePricesToolStripMenuItem.Text = "Update Prices";
            // 
            // generateQueryToolStripMenuItem
            // 
            this.generateQueryToolStripMenuItem.Name = "generateQueryToolStripMenuItem";
            this.generateQueryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.generateQueryToolStripMenuItem.Text = "Generate Query";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // ItemList
            // 
            this.ItemList.AllowUserToAddRows = false;
            this.ItemList.AllowUserToDeleteRows = false;
            this.ItemList.AllowUserToResizeColumns = false;
            this.ItemList.AllowUserToResizeRows = false;
            this.ItemList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.ItemList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ItemList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ItemList.Location = new System.Drawing.Point(12, 108);
            this.ItemList.Name = "ItemList";
            this.ItemList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ItemList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ItemList.Size = new System.Drawing.Size(346, 304);
            this.ItemList.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Item";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 600;
            // 
            // ItemEditor
            // 
            this.ItemEditor.Controls.Add(this.PeriodLabel);
            this.ItemEditor.Controls.Add(this.PeriodBox);
            this.ItemEditor.Controls.Add(this.GoodsNumLabel);
            this.ItemEditor.Controls.Add(this.GoodsNumEdit);
            this.ItemEditor.Controls.Add(this.label3);
            this.ItemEditor.Controls.Add(this.HpEdit);
            this.ItemEditor.Controls.Add(this.DefenseLabel);
            this.ItemEditor.Controls.Add(this.DefenseEdit);
            this.ItemEditor.Controls.Add(this.AttackLabel);
            this.ItemEditor.Controls.Add(this.AttackEdit);
            this.ItemEditor.Controls.Add(this.CharacterClassLabel);
            this.ItemEditor.Controls.Add(this.CharacterclassBox);
            this.ItemEditor.Controls.Add(this.AcessoryBox);
            this.ItemEditor.Controls.Add(this.AcessoryLabel);
            this.ItemEditor.Controls.Add(this.radioButton1);
            this.ItemEditor.Controls.Add(this.comboBox2);
            this.ItemEditor.Controls.Add(this.ItemTypeLabel);
            this.ItemEditor.Controls.Add(this.comboBox1);
            this.ItemEditor.Controls.Add(this.CoinLabel);
            this.ItemEditor.Controls.Add(this.CharacterBox);
            this.ItemEditor.Controls.Add(this.CharacterLabel);
            this.ItemEditor.Controls.Add(this.PriceEdit);
            this.ItemEditor.Controls.Add(this.PriceLabel);
            this.ItemEditor.Controls.Add(this.ItemLevelEdit);
            this.ItemEditor.Controls.Add(this.ItemLevelLabel);
            this.ItemEditor.Controls.Add(this.LevelEdit);
            this.ItemEditor.Controls.Add(this.LevelLabel);
            this.ItemEditor.Controls.Add(this.DescriptionLabel);
            this.ItemEditor.Controls.Add(this.DescriptionEdit);
            this.ItemEditor.Controls.Add(this.TitleLabel);
            this.ItemEditor.Controls.Add(this.ItemEdit);
            this.ItemEditor.Controls.Add(this.Idlabel);
            this.ItemEditor.Controls.Add(this.IdEdit);
            this.ItemEditor.Location = new System.Drawing.Point(364, 108);
            this.ItemEditor.Name = "ItemEditor";
            this.ItemEditor.Size = new System.Drawing.Size(431, 304);
            this.ItemEditor.TabIndex = 2;
            this.ItemEditor.TabStop = false;
            this.ItemEditor.Text = "Item";
            // 
            // PeriodLabel
            // 
            this.PeriodLabel.AutoSize = true;
            this.PeriodLabel.Location = new System.Drawing.Point(323, 186);
            this.PeriodLabel.Name = "PeriodLabel";
            this.PeriodLabel.Size = new System.Drawing.Size(40, 13);
            this.PeriodLabel.TabIndex = 32;
            this.PeriodLabel.Text = "Period:";
            // 
            // PeriodBox
            // 
            this.PeriodBox.Location = new System.Drawing.Point(364, 182);
            this.PeriodBox.Name = "PeriodBox";
            this.PeriodBox.Size = new System.Drawing.Size(59, 20);
            this.PeriodBox.TabIndex = 31;
            // 
            // GoodsNumLabel
            // 
            this.GoodsNumLabel.AutoSize = true;
            this.GoodsNumLabel.Location = new System.Drawing.Point(7, 211);
            this.GoodsNumLabel.Name = "GoodsNumLabel";
            this.GoodsNumLabel.Size = new System.Drawing.Size(63, 13);
            this.GoodsNumLabel.TabIndex = 30;
            this.GoodsNumLabel.Text = "GoodsNum:";
            // 
            // GoodsNumEdit
            // 
            this.GoodsNumEdit.Location = new System.Drawing.Point(72, 208);
            this.GoodsNumEdit.Name = "GoodsNumEdit";
            this.GoodsNumEdit.Size = new System.Drawing.Size(59, 20);
            this.GoodsNumEdit.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "HP:";
            // 
            // HpEdit
            // 
            this.HpEdit.Location = new System.Drawing.Point(261, 181);
            this.HpEdit.Name = "HpEdit";
            this.HpEdit.Size = new System.Drawing.Size(59, 20);
            this.HpEdit.TabIndex = 27;
            // 
            // DefenseLabel
            // 
            this.DefenseLabel.AutoSize = true;
            this.DefenseLabel.Location = new System.Drawing.Point(115, 184);
            this.DefenseLabel.Name = "DefenseLabel";
            this.DefenseLabel.Size = new System.Drawing.Size(50, 13);
            this.DefenseLabel.TabIndex = 26;
            this.DefenseLabel.Text = "Defense:";
            // 
            // DefenseEdit
            // 
            this.DefenseEdit.Location = new System.Drawing.Point(169, 181);
            this.DefenseEdit.Name = "DefenseEdit";
            this.DefenseEdit.Size = new System.Drawing.Size(59, 20);
            this.DefenseEdit.TabIndex = 25;
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Location = new System.Drawing.Point(6, 184);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(41, 13);
            this.AttackLabel.TabIndex = 24;
            this.AttackLabel.Text = "Attack:";
            // 
            // AttackEdit
            // 
            this.AttackEdit.Location = new System.Drawing.Point(51, 181);
            this.AttackEdit.Name = "AttackEdit";
            this.AttackEdit.Size = new System.Drawing.Size(59, 20);
            this.AttackEdit.TabIndex = 23;
            // 
            // CharacterClassLabel
            // 
            this.CharacterClassLabel.AutoSize = true;
            this.CharacterClassLabel.Location = new System.Drawing.Point(222, 130);
            this.CharacterClassLabel.Name = "CharacterClassLabel";
            this.CharacterClassLabel.Size = new System.Drawing.Size(84, 13);
            this.CharacterClassLabel.TabIndex = 22;
            this.CharacterClassLabel.Text = "Character Class:";
            // 
            // CharacterclassBox
            // 
            this.CharacterclassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharacterclassBox.Items.AddRange(new object[] {
            "Elesis",
            "Lire",
            "Arme",
            "Lass",
            "Ryan",
            "Ronan",
            "Amy",
            "Jin",
            "Sieghart",
            "Mari",
            "Dio",
            "Zero",
            "Rey",
            "Lupus",
            "Lin",
            "Azin",
            "Holy",
            "Edel",
            "Veigas",
            "Uno"});
            this.CharacterclassBox.Location = new System.Drawing.Point(225, 152);
            this.CharacterclassBox.Name = "CharacterclassBox";
            this.CharacterclassBox.Size = new System.Drawing.Size(102, 21);
            this.CharacterclassBox.TabIndex = 21;
            // 
            // AcessoryBox
            // 
            this.AcessoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AcessoryBox.Items.AddRange(new object[] {
            "Elesis",
            "Lire",
            "Arme",
            "Lass",
            "Ryan",
            "Ronan",
            "Amy",
            "Jin",
            "Sieghart",
            "Mari",
            "Dio",
            "Zero",
            "Rey",
            "Lupus",
            "Lin",
            "Azin",
            "Holy",
            "Edel",
            "Veigas",
            "Uno"});
            this.AcessoryBox.Location = new System.Drawing.Point(117, 152);
            this.AcessoryBox.Name = "AcessoryBox";
            this.AcessoryBox.Size = new System.Drawing.Size(102, 21);
            this.AcessoryBox.TabIndex = 19;
            // 
            // AcessoryLabel
            // 
            this.AcessoryLabel.AutoSize = true;
            this.AcessoryLabel.Location = new System.Drawing.Point(114, 130);
            this.AcessoryLabel.Name = "AcessoryLabel";
            this.AcessoryLabel.Size = new System.Drawing.Size(53, 13);
            this.AcessoryLabel.TabIndex = 20;
            this.AcessoryLabel.Text = "Acessory:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(362, 102);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Visible";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "Elesis",
            "Lire",
            "Arme",
            "Lass",
            "Ryan",
            "Ronan",
            "Amy",
            "Jin",
            "Sieghart",
            "Mari",
            "Dio",
            "Zero",
            "Rey",
            "Lupus",
            "Lin",
            "Azin",
            "Holy",
            "Edel",
            "Veigas",
            "Uno"});
            this.comboBox2.Location = new System.Drawing.Point(9, 152);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(102, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // ItemTypeLabel
            // 
            this.ItemTypeLabel.AutoSize = true;
            this.ItemTypeLabel.Location = new System.Drawing.Point(6, 130);
            this.ItemTypeLabel.Name = "ItemTypeLabel";
            this.ItemTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.ItemTypeLabel.TabIndex = 16;
            this.ItemTypeLabel.Text = "Item Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "GP",
            "Cash",
            "Cristal",
            "Gem",
            "Epic Coin"});
            this.comboBox1.Location = new System.Drawing.Point(272, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // CoinLabel
            // 
            this.CoinLabel.AutoSize = true;
            this.CoinLabel.Location = new System.Drawing.Point(269, 79);
            this.CoinLabel.Name = "CoinLabel";
            this.CoinLabel.Size = new System.Drawing.Size(31, 13);
            this.CoinLabel.TabIndex = 14;
            this.CoinLabel.Text = "Coin:";
            // 
            // CharacterBox
            // 
            this.CharacterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharacterBox.Items.AddRange(new object[] {
            "Elesis",
            "Lire",
            "Arme",
            "Lass",
            "Ryan",
            "Ronan",
            "Amy",
            "Jin",
            "Sieghart",
            "Mari",
            "Dio",
            "Zero",
            "Rey",
            "Lupus",
            "Lin",
            "Azin",
            "Holy",
            "Edel",
            "Veigas",
            "Uno"});
            this.CharacterBox.Location = new System.Drawing.Point(182, 100);
            this.CharacterBox.Name = "CharacterBox";
            this.CharacterBox.Size = new System.Drawing.Size(81, 21);
            this.CharacterBox.TabIndex = 3;
            // 
            // CharacterLabel
            // 
            this.CharacterLabel.AutoSize = true;
            this.CharacterLabel.Location = new System.Drawing.Point(179, 78);
            this.CharacterLabel.Name = "CharacterLabel";
            this.CharacterLabel.Size = new System.Drawing.Size(56, 13);
            this.CharacterLabel.TabIndex = 12;
            this.CharacterLabel.Text = "Character:";
            // 
            // PriceEdit
            // 
            this.PriceEdit.Location = new System.Drawing.Point(42, 101);
            this.PriceEdit.Name = "PriceEdit";
            this.PriceEdit.Size = new System.Drawing.Size(131, 20);
            this.PriceEdit.TabIndex = 11;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(5, 105);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(34, 13);
            this.PriceLabel.TabIndex = 10;
            this.PriceLabel.Text = "Price:";
            // 
            // ItemLevelEdit
            // 
            this.ItemLevelEdit.Location = new System.Drawing.Point(140, 74);
            this.ItemLevelEdit.Name = "ItemLevelEdit";
            this.ItemLevelEdit.Size = new System.Drawing.Size(33, 20);
            this.ItemLevelEdit.TabIndex = 9;
            // 
            // ItemLevelLabel
            // 
            this.ItemLevelLabel.AutoSize = true;
            this.ItemLevelLabel.Location = new System.Drawing.Point(79, 78);
            this.ItemLevelLabel.Name = "ItemLevelLabel";
            this.ItemLevelLabel.Size = new System.Drawing.Size(59, 13);
            this.ItemLevelLabel.TabIndex = 8;
            this.ItemLevelLabel.Text = "Item Level:";
            // 
            // LevelEdit
            // 
            this.LevelEdit.Location = new System.Drawing.Point(42, 74);
            this.LevelEdit.Name = "LevelEdit";
            this.LevelEdit.Size = new System.Drawing.Size(33, 20);
            this.LevelEdit.TabIndex = 7;
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(5, 78);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(36, 13);
            this.LevelLabel.TabIndex = 6;
            this.LevelLabel.Text = "Level:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(7, 48);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionEdit
            // 
            this.DescriptionEdit.Location = new System.Drawing.Point(76, 47);
            this.DescriptionEdit.Name = "DescriptionEdit";
            this.DescriptionEdit.Size = new System.Drawing.Size(349, 20);
            this.DescriptionEdit.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(100, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title:";
            // 
            // ItemEdit
            // 
            this.ItemEdit.Location = new System.Drawing.Point(133, 19);
            this.ItemEdit.Name = "ItemEdit";
            this.ItemEdit.Size = new System.Drawing.Size(292, 20);
            this.ItemEdit.TabIndex = 2;
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(6, 22);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(21, 13);
            this.Idlabel.TabIndex = 1;
            this.Idlabel.Text = "ID:";
            // 
            // IdEdit
            // 
            this.IdEdit.Location = new System.Drawing.Point(33, 19);
            this.IdEdit.Name = "IdEdit";
            this.IdEdit.Size = new System.Drawing.Size(59, 20);
            this.IdEdit.TabIndex = 0;
            // 
            // SearchEdit
            // 
            this.SearchEdit.Location = new System.Drawing.Point(97, 29);
            this.SearchEdit.Name = "SearchEdit";
            this.SearchEdit.Size = new System.Drawing.Size(514, 20);
            this.SearchEdit.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CharacterSearchBox);
            this.groupBox1.Controls.Add(this.SearchTypeBox);
            this.groupBox1.Controls.Add(this.SearchEdit);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 72);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Start);
            // 
            // CharacterSearchBox
            // 
            this.CharacterSearchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharacterSearchBox.Items.AddRange(new object[] {
            "Todos",
            "Elesis",
            "Lire",
            "Arme",
            "Lass",
            "Ryan",
            "Ronan",
            "Amy",
            "Jin",
            "Sieghart",
            "Mari",
            "Dio",
            "Zero",
            "Rey",
            "Lupus",
            "Lin",
            "Azin",
            "Holy",
            "Edel",
            "Veigas",
            "Uno"});
            this.CharacterSearchBox.Location = new System.Drawing.Point(615, 29);
            this.CharacterSearchBox.Name = "CharacterSearchBox";
            this.CharacterSearchBox.Size = new System.Drawing.Size(81, 21);
            this.CharacterSearchBox.TabIndex = 0;
            // 
            // SearchTypeBox
            // 
            this.SearchTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchTypeBox.Items.AddRange(new object[] {
            "ID",
            "Title"});
            this.SearchTypeBox.Location = new System.Drawing.Point(14, 28);
            this.SearchTypeBox.Name = "SearchTypeBox";
            this.SearchTypeBox.Size = new System.Drawing.Size(76, 21);
            this.SearchTypeBox.TabIndex = 19;
            // 
            // SortEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(808, 420);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.ItemEditor);
            this.Controls.Add(this.TopMenu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.TopMenu;
            this.Name = "SortEditor";
            this.Text = "Sort Editor 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList)).EndInit();
            this.ItemEditor.ResumeLayout(false);
            this.ItemEditor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateQueryToolStripMenuItem;
        private System.Windows.Forms.GroupBox ItemEditor;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox ItemEdit;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.TextBox IdEdit;
        private System.Windows.Forms.TextBox LevelEdit;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionEdit;
        private System.Windows.Forms.TextBox ItemLevelEdit;
        private System.Windows.Forms.Label ItemLevelLabel;
        private System.Windows.Forms.TextBox PriceEdit;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.ComboBox CharacterBox;
        private System.Windows.Forms.Label CharacterLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label CoinLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label ItemTypeLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox SearchEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CharacterSearchBox;
        private System.Windows.Forms.ComboBox SearchTypeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DefenseLabel;
        private System.Windows.Forms.TextBox DefenseEdit;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.TextBox AttackEdit;
        private System.Windows.Forms.Label CharacterClassLabel;
        private System.Windows.Forms.ComboBox CharacterclassBox;
        private System.Windows.Forms.ComboBox AcessoryBox;
        private System.Windows.Forms.Label AcessoryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HpEdit;
        private System.Windows.Forms.Label PeriodLabel;
        private System.Windows.Forms.TextBox PeriodBox;
        private System.Windows.Forms.Label GoodsNumLabel;
        private System.Windows.Forms.TextBox GoodsNumEdit;
        public System.Windows.Forms.DataGridView ItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}

