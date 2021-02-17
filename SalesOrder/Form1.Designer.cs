namespace SalesOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label physical1Label;
            System.Windows.Forms.Label physical2Label;
            System.Windows.Forms.Label physical3Label;
            System.Windows.Forms.Label physical4Label;
            System.Windows.Forms.Label physical5Label;
            System.Windows.Forms.Label physicalPCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet_CustInfo = new SalesOrder.DataSet_CustInfo();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new SalesOrder.DataSet_CustInfoTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new SalesOrder.DataSet_CustInfoTableAdapters.TableAdapterManager();
            this.clientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.physical1TextBox = new System.Windows.Forms.TextBox();
            this.physical2TextBox = new System.Windows.Forms.TextBox();
            this.physical3TextBox = new System.Windows.Forms.TextBox();
            this.physical4TextBox = new System.Windows.Forms.TextBox();
            this.physical5TextBox = new System.Windows.Forms.TextBox();
            this.physicalPCTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_CustList = new SalesOrder.DataSet_CustList();
            this.label1 = new System.Windows.Forms.Label();
            this.clientTableAdapter1 = new SalesOrder.DataSet_CustListTableAdapters.ClientTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtBoxReferenceNo = new System.Windows.Forms.TextBox();
            this.txtBoxNote = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exclAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inclAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxTotExcl = new System.Windows.Forms.TextBox();
            this.txtBoxTotTax = new System.Windows.Forms.TextBox();
            this.txtBoxTotIncl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            physical1Label = new System.Windows.Forms.Label();
            physical2Label = new System.Windows.Forms.Label();
            physical3Label = new System.Windows.Forms.Label();
            physical4Label = new System.Windows.Forms.Label();
            physical5Label = new System.Windows.Forms.Label();
            physicalPCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CustInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).BeginInit();
            this.clientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CustList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // physical1Label
            // 
            physical1Label.AutoSize = true;
            physical1Label.Location = new System.Drawing.Point(58, 119);
            physical1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            physical1Label.Name = "physical1Label";
            physical1Label.Size = new System.Drawing.Size(54, 13);
            physical1Label.TabIndex = 4;
            physical1Label.Text = "Address 1";
            // 
            // physical2Label
            // 
            physical2Label.AutoSize = true;
            physical2Label.Location = new System.Drawing.Point(58, 141);
            physical2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            physical2Label.Name = "physical2Label";
            physical2Label.Size = new System.Drawing.Size(54, 13);
            physical2Label.TabIndex = 6;
            physical2Label.Text = "Address 2";
            // 
            // physical3Label
            // 
            physical3Label.AutoSize = true;
            physical3Label.Location = new System.Drawing.Point(58, 164);
            physical3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            physical3Label.Name = "physical3Label";
            physical3Label.Size = new System.Drawing.Size(54, 13);
            physical3Label.TabIndex = 8;
            physical3Label.Text = "Address 3";
            // 
            // physical4Label
            // 
            physical4Label.AutoSize = true;
            physical4Label.Location = new System.Drawing.Point(58, 187);
            physical4Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            physical4Label.Name = "physical4Label";
            physical4Label.Size = new System.Drawing.Size(41, 13);
            physical4Label.TabIndex = 10;
            physical4Label.Text = "Suburb";
            // 
            // physical5Label
            // 
            physical5Label.AutoSize = true;
            physical5Label.Location = new System.Drawing.Point(58, 210);
            physical5Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            physical5Label.Name = "physical5Label";
            physical5Label.Size = new System.Drawing.Size(32, 13);
            physical5Label.TabIndex = 12;
            physical5Label.Text = "State";
            // 
            // physicalPCLabel
            // 
            physicalPCLabel.AutoSize = true;
            physicalPCLabel.Location = new System.Drawing.Point(58, 232);
            physicalPCLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            physicalPCLabel.Name = "physicalPCLabel";
            physicalPCLabel.Size = new System.Drawing.Size(56, 13);
            physicalPCLabel.TabIndex = 14;
            physicalPCLabel.Text = "Post Code";
            // 
            // dataSet_CustInfo
            // 
            this.dataSet_CustInfo.DataSetName = "DataSet_CustInfo";
            this.dataSet_CustInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataSet_CustInfo;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.UpdateOrder = SalesOrder.DataSet_CustInfoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientBindingNavigator
            // 
            this.clientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientBindingNavigator.BindingSource = this.clientBindingSource;
            this.clientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientBindingNavigatorSaveItem});
            this.clientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientBindingNavigator.Name = "clientBindingNavigator";
            this.clientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientBindingNavigator.Size = new System.Drawing.Size(626, 27);
            this.clientBindingNavigator.TabIndex = 0;
            this.clientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // clientBindingNavigatorSaveItem
            // 
            this.clientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientBindingNavigatorSaveItem.Image")));
            this.clientBindingNavigatorSaveItem.Name = "clientBindingNavigatorSaveItem";
            this.clientBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.clientBindingNavigatorSaveItem.Text = "Save Data";
            this.clientBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientBindingNavigatorSaveItem_Click);
            // 
            // physical1TextBox
            // 
            this.physical1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Physical1", true));
            this.physical1TextBox.Location = new System.Drawing.Point(147, 115);
            this.physical1TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.physical1TextBox.Name = "physical1TextBox";
            this.physical1TextBox.Size = new System.Drawing.Size(92, 20);
            this.physical1TextBox.TabIndex = 5;
            // 
            // physical2TextBox
            // 
            this.physical2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Physical2", true));
            this.physical2TextBox.Location = new System.Drawing.Point(147, 139);
            this.physical2TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.physical2TextBox.Name = "physical2TextBox";
            this.physical2TextBox.Size = new System.Drawing.Size(92, 20);
            this.physical2TextBox.TabIndex = 7;
            // 
            // physical3TextBox
            // 
            this.physical3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Physical3", true));
            this.physical3TextBox.Location = new System.Drawing.Point(147, 162);
            this.physical3TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.physical3TextBox.Name = "physical3TextBox";
            this.physical3TextBox.Size = new System.Drawing.Size(92, 20);
            this.physical3TextBox.TabIndex = 9;
            // 
            // physical4TextBox
            // 
            this.physical4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Physical4", true));
            this.physical4TextBox.Location = new System.Drawing.Point(147, 184);
            this.physical4TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.physical4TextBox.Name = "physical4TextBox";
            this.physical4TextBox.Size = new System.Drawing.Size(92, 20);
            this.physical4TextBox.TabIndex = 11;
            // 
            // physical5TextBox
            // 
            this.physical5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Physical5", true));
            this.physical5TextBox.Location = new System.Drawing.Point(147, 207);
            this.physical5TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.physical5TextBox.Name = "physical5TextBox";
            this.physical5TextBox.Size = new System.Drawing.Size(92, 20);
            this.physical5TextBox.TabIndex = 13;
            // 
            // physicalPCTextBox
            // 
            this.physicalPCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PhysicalPC", true));
            this.physicalPCTextBox.Location = new System.Drawing.Point(147, 230);
            this.physicalPCTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.physicalPCTextBox.Name = "physicalPCTextBox";
            this.physicalPCTextBox.Size = new System.Drawing.Size(92, 20);
            this.physicalPCTextBox.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientBindingSource1;
            this.comboBox1.DisplayMember = "Contact_Person";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 90);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "DCLink";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.dataSet_CustList;
            // 
            // dataSet_CustList
            // 
            this.dataSet_CustList.DataSetName = "DataSet_CustList";
            this.dataSet_CustList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Customer Name";
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Invoice No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Invoice Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Reference No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Note";
            // 
            // txtBoxInvoiceNo
            // 
            this.txtBoxInvoiceNo.Location = new System.Drawing.Point(443, 91);
            this.txtBoxInvoiceNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxInvoiceNo.Name = "txtBoxInvoiceNo";
            this.txtBoxInvoiceNo.Size = new System.Drawing.Size(128, 20);
            this.txtBoxInvoiceNo.TabIndex = 22;
            // 
            // txtBoxReferenceNo
            // 
            this.txtBoxReferenceNo.Location = new System.Drawing.Point(443, 142);
            this.txtBoxReferenceNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxReferenceNo.Name = "txtBoxReferenceNo";
            this.txtBoxReferenceNo.Size = new System.Drawing.Size(128, 20);
            this.txtBoxReferenceNo.TabIndex = 24;
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Location = new System.Drawing.Point(443, 166);
            this.txtBoxNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(128, 79);
            this.txtBoxNote.TabIndex = 25;
            this.txtBoxNote.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCode,
            this.desc,
            this.not,
            this.quan,
            this.pri,
            this.tax,
            this.exclAmount,
            this.taxAmount,
            this.inclAmount});
            this.dataGridView1.Location = new System.Drawing.Point(61, 275);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 122);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing_1);
            // 
            // itemCode
            // 
            this.itemCode.DataPropertyName = "itemCode";
            this.itemCode.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.itemCode.HeaderText = "Item Code";
            this.itemCode.MinimumWidth = 6;
            this.itemCode.Name = "itemCode";
            this.itemCode.Width = 125;
            // 
            // desc
            // 
            this.desc.DataPropertyName = "desc";
            this.desc.HeaderText = "Description";
            this.desc.MinimumWidth = 6;
            this.desc.Name = "desc";
            this.desc.Width = 125;
            // 
            // not
            // 
            this.not.DataPropertyName = "not";
            this.not.HeaderText = "Note";
            this.not.MinimumWidth = 6;
            this.not.Name = "not";
            this.not.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.not.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.not.Width = 125;
            // 
            // quan
            // 
            this.quan.DataPropertyName = "quan";
            this.quan.HeaderText = "Quantity";
            this.quan.MinimumWidth = 6;
            this.quan.Name = "quan";
            this.quan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.quan.Width = 125;
            // 
            // pri
            // 
            this.pri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pri.DataPropertyName = "pri";
            this.pri.HeaderText = "Price";
            this.pri.MinimumWidth = 6;
            this.pri.Name = "pri";
            this.pri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pri.Width = 125;
            // 
            // tax
            // 
            this.tax.DataPropertyName = "tax";
            this.tax.HeaderText = "Tax";
            this.tax.MinimumWidth = 6;
            this.tax.Name = "tax";
            this.tax.Width = 125;
            // 
            // exclAmount
            // 
            this.exclAmount.DataPropertyName = "exclAmount";
            this.exclAmount.HeaderText = "Excl Amount";
            this.exclAmount.MinimumWidth = 6;
            this.exclAmount.Name = "exclAmount";
            this.exclAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exclAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exclAmount.Width = 125;
            // 
            // taxAmount
            // 
            this.taxAmount.DataPropertyName = "taxAmount";
            this.taxAmount.HeaderText = "Tax Amount";
            this.taxAmount.MinimumWidth = 6;
            this.taxAmount.Name = "taxAmount";
            this.taxAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.taxAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.taxAmount.Width = 125;
            // 
            // inclAmount
            // 
            this.inclAmount.DataPropertyName = "inclAmount";
            this.inclAmount.HeaderText = "Incl Amount";
            this.inclAmount.MinimumWidth = 6;
            this.inclAmount.Name = "inclAmount";
            this.inclAmount.Width = 125;
            // 
            // txtBoxTotExcl
            // 
            this.txtBoxTotExcl.Location = new System.Drawing.Point(331, 422);
            this.txtBoxTotExcl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTotExcl.Name = "txtBoxTotExcl";
            this.txtBoxTotExcl.Size = new System.Drawing.Size(128, 20);
            this.txtBoxTotExcl.TabIndex = 27;
            // 
            // txtBoxTotTax
            // 
            this.txtBoxTotTax.Location = new System.Drawing.Point(331, 444);
            this.txtBoxTotTax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTotTax.Name = "txtBoxTotTax";
            this.txtBoxTotTax.Size = new System.Drawing.Size(128, 20);
            this.txtBoxTotTax.TabIndex = 28;
            // 
            // txtBoxTotIncl
            // 
            this.txtBoxTotIncl.Location = new System.Drawing.Point(331, 468);
            this.txtBoxTotIncl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTotIncl.Name = "txtBoxTotIncl";
            this.txtBoxTotIncl.Size = new System.Drawing.Size(128, 20);
            this.txtBoxTotIncl.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 424);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Total Excl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 447);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 470);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total Incl";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(481, 464);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 27);
            this.btnCalculate.TabIndex = 33;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(481, 500);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 27);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(443, 117);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(373, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 27);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 540);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxTotIncl);
            this.Controls.Add(this.txtBoxTotTax);
            this.Controls.Add(this.txtBoxTotExcl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxNote);
            this.Controls.Add(this.txtBoxReferenceNo);
            this.Controls.Add(this.txtBoxInvoiceNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(physical1Label);
            this.Controls.Add(this.physical1TextBox);
            this.Controls.Add(physical2Label);
            this.Controls.Add(this.physical2TextBox);
            this.Controls.Add(physical3Label);
            this.Controls.Add(this.physical3TextBox);
            this.Controls.Add(physical4Label);
            this.Controls.Add(this.physical4TextBox);
            this.Controls.Add(physical5Label);
            this.Controls.Add(this.physical5TextBox);
            this.Controls.Add(physicalPCLabel);
            this.Controls.Add(this.physicalPCTextBox);
            this.Controls.Add(this.clientBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Sales Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CustInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).EndInit();
            this.clientBindingNavigator.ResumeLayout(false);
            this.clientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CustList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet_CustInfo dataSet_CustInfo;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet_CustInfoTableAdapters.ClientTableAdapter clientTableAdapter;
        private DataSet_CustInfoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox physical1TextBox;
        private System.Windows.Forms.TextBox physical2TextBox;
        private System.Windows.Forms.TextBox physical3TextBox;
        private System.Windows.Forms.TextBox physical4TextBox;
        private System.Windows.Forms.TextBox physical5TextBox;
        private System.Windows.Forms.TextBox physicalPCTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private DataSet_CustList dataSet_CustList;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private DataSet_CustListTableAdapters.ClientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxInvoiceNo;
        private System.Windows.Forms.TextBox txtBoxReferenceNo;
        private System.Windows.Forms.RichTextBox txtBoxNote;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxTotExcl;
        private System.Windows.Forms.TextBox txtBoxTotTax;
        private System.Windows.Forms.TextBox txtBoxTotIncl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn not;
        private System.Windows.Forms.DataGridViewTextBoxColumn quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn exclAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn inclAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnUpdate;
    }
}