
namespace MultiBodega_v1.Compras
{
    partial class FrmCompras
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label costFOBDolaresLabel;
            System.Windows.Forms.Label costoCIFDolaresLabel;
            System.Windows.Forms.Label costoCIFLempirasLabel;
            System.Windows.Forms.Label costosDeImportacionLabel;
            System.Windows.Forms.Label costosDeTransporteLabel;
            System.Windows.Forms.Label costoTotalCompraDolaresLabel;
            System.Windows.Forms.Label costoTotalCompraLempirasLabel;
            System.Windows.Forms.Label precioUnitarioCompraDolaresLabel;
            System.Windows.Forms.Label productoLabel;
            System.Windows.Forms.Label proveedorLabel;
            System.Windows.Forms.Label numDeclaracionLabel;
            System.Windows.Forms.Label numFacturaLabel;
            System.Windows.Forms.Label fechaEnBodegaLabel;
            System.Windows.Forms.Label impuestoPagadoLabel;
            System.Windows.Forms.Label numOrdenLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.ComprasDGV = new System.Windows.Forms.DataGridView();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.costFOBDolaresTextBox = new System.Windows.Forms.TextBox();
            this.costoCIFDolaresTextBox = new System.Windows.Forms.TextBox();
            this.costoCIFLempirasTextBox = new System.Windows.Forms.TextBox();
            this.costosDeImportacionTextBox = new System.Windows.Forms.TextBox();
            this.costosDeTransporteTextBox = new System.Windows.Forms.TextBox();
            this.costoTotalCompraDolaresTextBox = new System.Windows.Forms.TextBox();
            this.costoTotalCompraLempirasTextBox = new System.Windows.Forms.TextBox();
            this.precioUnitarioCompraDolaresTextBox = new System.Windows.Forms.TextBox();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.nuevoTextBox = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proveedorTextBox = new System.Windows.Forms.TextBox();
            this.numDeclaracionTextBox = new System.Windows.Forms.TextBox();
            this.numFacturaTextBox = new System.Windows.Forms.TextBox();
            this.fechaEnBodegaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.impuestoPagadoTextBox = new System.Windows.Forms.TextBox();
            this.numOrdenTextBox = new System.Windows.Forms.TextBox();
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.ComprasTableAdapter();
            this.numOrdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotalCompraDolaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotalCompraLempirasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costosDeImportacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCIFLempirasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCIFDolaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costosDeTransporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costFOBDolaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioCompraDolaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtenerComprasConProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cantidadLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            costFOBDolaresLabel = new System.Windows.Forms.Label();
            costoCIFDolaresLabel = new System.Windows.Forms.Label();
            costoCIFLempirasLabel = new System.Windows.Forms.Label();
            costosDeImportacionLabel = new System.Windows.Forms.Label();
            costosDeTransporteLabel = new System.Windows.Forms.Label();
            costoTotalCompraDolaresLabel = new System.Windows.Forms.Label();
            costoTotalCompraLempirasLabel = new System.Windows.Forms.Label();
            precioUnitarioCompraDolaresLabel = new System.Windows.Forms.Label();
            productoLabel = new System.Windows.Forms.Label();
            proveedorLabel = new System.Windows.Forms.Label();
            numDeclaracionLabel = new System.Windows.Forms.Label();
            numFacturaLabel = new System.Windows.Forms.Label();
            fechaEnBodegaLabel = new System.Windows.Forms.Label();
            impuestoPagadoLabel = new System.Windows.Forms.Label();
            numOrdenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerComprasConProveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.BackColor = System.Drawing.Color.Transparent;
            cantidadLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(31, 169);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(74, 16);
            cantidadLabel.TabIndex = 1;
            cantidadLabel.Text = "Cantidad:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(148, 169);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(60, 16);
            codigoLabel.TabIndex = 3;
            codigoLabel.Text = "Codigo:";
            // 
            // costFOBDolaresLabel
            // 
            costFOBDolaresLabel.AutoSize = true;
            costFOBDolaresLabel.BackColor = System.Drawing.Color.Transparent;
            costFOBDolaresLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costFOBDolaresLabel.Location = new System.Drawing.Point(313, 169);
            costFOBDolaresLabel.Name = "costFOBDolaresLabel";
            costFOBDolaresLabel.Size = new System.Drawing.Size(122, 16);
            costFOBDolaresLabel.TabIndex = 5;
            costFOBDolaresLabel.Text = "Cost FOB Dolares:";
            // 
            // costoCIFDolaresLabel
            // 
            costoCIFDolaresLabel.AutoSize = true;
            costoCIFDolaresLabel.BackColor = System.Drawing.Color.Transparent;
            costoCIFDolaresLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoCIFDolaresLabel.Location = new System.Drawing.Point(453, 169);
            costoCIFDolaresLabel.Name = "costoCIFDolaresLabel";
            costoCIFDolaresLabel.Size = new System.Drawing.Size(125, 16);
            costoCIFDolaresLabel.TabIndex = 7;
            costoCIFDolaresLabel.Text = "Costo CIF Dolares:";
            // 
            // costoCIFLempirasLabel
            // 
            costoCIFLempirasLabel.AutoSize = true;
            costoCIFLempirasLabel.BackColor = System.Drawing.Color.Transparent;
            costoCIFLempirasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoCIFLempirasLabel.Location = new System.Drawing.Point(603, 169);
            costoCIFLempirasLabel.Name = "costoCIFLempirasLabel";
            costoCIFLempirasLabel.Size = new System.Drawing.Size(135, 16);
            costoCIFLempirasLabel.TabIndex = 9;
            costoCIFLempirasLabel.Text = "Costo CIF Lempiras:";
            // 
            // costosDeImportacionLabel
            // 
            costosDeImportacionLabel.AutoSize = true;
            costosDeImportacionLabel.BackColor = System.Drawing.Color.Transparent;
            costosDeImportacionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costosDeImportacionLabel.Location = new System.Drawing.Point(758, 169);
            costosDeImportacionLabel.Name = "costosDeImportacionLabel";
            costosDeImportacionLabel.Size = new System.Drawing.Size(158, 16);
            costosDeImportacionLabel.TabIndex = 11;
            costosDeImportacionLabel.Text = "Costos De Importacion:";
            // 
            // costosDeTransporteLabel
            // 
            costosDeTransporteLabel.AutoSize = true;
            costosDeTransporteLabel.BackColor = System.Drawing.Color.Transparent;
            costosDeTransporteLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costosDeTransporteLabel.Location = new System.Drawing.Point(944, 169);
            costosDeTransporteLabel.Name = "costosDeTransporteLabel";
            costosDeTransporteLabel.Size = new System.Drawing.Size(147, 16);
            costosDeTransporteLabel.TabIndex = 13;
            costosDeTransporteLabel.Text = "Costos De Transporte:";
            // 
            // costoTotalCompraDolaresLabel
            // 
            costoTotalCompraDolaresLabel.AutoSize = true;
            costoTotalCompraDolaresLabel.BackColor = System.Drawing.Color.Transparent;
            costoTotalCompraDolaresLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoTotalCompraDolaresLabel.Location = new System.Drawing.Point(31, 214);
            costoTotalCompraDolaresLabel.Name = "costoTotalCompraDolaresLabel";
            costoTotalCompraDolaresLabel.Size = new System.Drawing.Size(193, 16);
            costoTotalCompraDolaresLabel.TabIndex = 15;
            costoTotalCompraDolaresLabel.Text = "Costo Total Compra Dolares:";
            // 
            // costoTotalCompraLempirasLabel
            // 
            costoTotalCompraLempirasLabel.AutoSize = true;
            costoTotalCompraLempirasLabel.BackColor = System.Drawing.Color.Transparent;
            costoTotalCompraLempirasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoTotalCompraLempirasLabel.Location = new System.Drawing.Point(313, 214);
            costoTotalCompraLempirasLabel.Name = "costoTotalCompraLempirasLabel";
            costoTotalCompraLempirasLabel.Size = new System.Drawing.Size(203, 16);
            costoTotalCompraLempirasLabel.TabIndex = 17;
            costoTotalCompraLempirasLabel.Text = "Costo Total Compra Lempiras:";
            // 
            // precioUnitarioCompraDolaresLabel
            // 
            precioUnitarioCompraDolaresLabel.AutoSize = true;
            precioUnitarioCompraDolaresLabel.BackColor = System.Drawing.Color.Transparent;
            precioUnitarioCompraDolaresLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioUnitarioCompraDolaresLabel.Location = new System.Drawing.Point(603, 214);
            precioUnitarioCompraDolaresLabel.Name = "precioUnitarioCompraDolaresLabel";
            precioUnitarioCompraDolaresLabel.Size = new System.Drawing.Size(216, 16);
            precioUnitarioCompraDolaresLabel.TabIndex = 19;
            precioUnitarioCompraDolaresLabel.Text = "Precio Unitario Compra Dolares:";
            // 
            // productoLabel
            // 
            productoLabel.AutoSize = true;
            productoLabel.BackColor = System.Drawing.Color.Transparent;
            productoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productoLabel.Location = new System.Drawing.Point(946, 214);
            productoLabel.Name = "productoLabel";
            productoLabel.Size = new System.Drawing.Size(69, 16);
            productoLabel.TabIndex = 21;
            productoLabel.Text = "Producto:";
            // 
            // proveedorLabel
            // 
            proveedorLabel.AutoSize = true;
            proveedorLabel.BackColor = System.Drawing.Color.Transparent;
            proveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            proveedorLabel.Location = new System.Drawing.Point(31, 123);
            proveedorLabel.Name = "proveedorLabel";
            proveedorLabel.Size = new System.Drawing.Size(77, 16);
            proveedorLabel.TabIndex = 93;
            proveedorLabel.Text = "Proveedor:";
            // 
            // numDeclaracionLabel
            // 
            numDeclaracionLabel.AutoSize = true;
            numDeclaracionLabel.BackColor = System.Drawing.Color.Transparent;
            numDeclaracionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numDeclaracionLabel.Location = new System.Drawing.Point(216, 123);
            numDeclaracionLabel.Name = "numDeclaracionLabel";
            numDeclaracionLabel.Size = new System.Drawing.Size(111, 16);
            numDeclaracionLabel.TabIndex = 94;
            numDeclaracionLabel.Text = "N° Declaracion:";
            // 
            // numFacturaLabel
            // 
            numFacturaLabel.AutoSize = true;
            numFacturaLabel.BackColor = System.Drawing.Color.Transparent;
            numFacturaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numFacturaLabel.Location = new System.Drawing.Point(453, 123);
            numFacturaLabel.Name = "numFacturaLabel";
            numFacturaLabel.Size = new System.Drawing.Size(80, 16);
            numFacturaLabel.TabIndex = 95;
            numFacturaLabel.Text = "N° Factura:";
            // 
            // fechaEnBodegaLabel
            // 
            fechaEnBodegaLabel.AutoSize = true;
            fechaEnBodegaLabel.BackColor = System.Drawing.Color.Transparent;
            fechaEnBodegaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaEnBodegaLabel.Location = new System.Drawing.Point(603, 123);
            fechaEnBodegaLabel.Name = "fechaEnBodegaLabel";
            fechaEnBodegaLabel.Size = new System.Drawing.Size(125, 16);
            fechaEnBodegaLabel.TabIndex = 96;
            fechaEnBodegaLabel.Text = "Fecha En Bodega:";
            // 
            // impuestoPagadoLabel
            // 
            impuestoPagadoLabel.AutoSize = true;
            impuestoPagadoLabel.BackColor = System.Drawing.Color.Transparent;
            impuestoPagadoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            impuestoPagadoLabel.Location = new System.Drawing.Point(758, 123);
            impuestoPagadoLabel.Name = "impuestoPagadoLabel";
            impuestoPagadoLabel.Size = new System.Drawing.Size(126, 16);
            impuestoPagadoLabel.TabIndex = 97;
            impuestoPagadoLabel.Text = "Impuesto Pagado:";
            // 
            // numOrdenLabel
            // 
            numOrdenLabel.AutoSize = true;
            numOrdenLabel.BackColor = System.Drawing.Color.Transparent;
            numOrdenLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numOrdenLabel.Location = new System.Drawing.Point(1066, 39);
            numOrdenLabel.Name = "numOrdenLabel";
            numOrdenLabel.Size = new System.Drawing.Size(72, 16);
            numOrdenLabel.TabIndex = 98;
            numOrdenLabel.Text = "N° Orden:";
            // 
            // ComprasDGV
            // 
            this.ComprasDGV.AutoGenerateColumns = false;
            this.ComprasDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComprasDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ComprasDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComprasDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ComprasDGV.ColumnHeadersHeight = 45;
            this.ComprasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ComprasDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCompraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.precioUnitarioCompraDolaresDataGridViewTextBoxColumn,
            this.costFOBDolaresDataGridViewTextBoxColumn,
            this.costosDeTransporteDataGridViewTextBoxColumn,
            this.costoCIFDolaresDataGridViewTextBoxColumn,
            this.costoCIFLempirasDataGridViewTextBoxColumn,
            this.costosDeImportacionDataGridViewTextBoxColumn,
            this.costoTotalCompraLempirasDataGridViewTextBoxColumn,
            this.costoTotalCompraDolaresDataGridViewTextBoxColumn,
            this.iDProveedorDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.numOrdenDataGridViewTextBoxColumn});
            this.ComprasDGV.DataSource = this.comprasBindingSource;
            this.ComprasDGV.EnableHeadersVisualStyles = false;
            this.ComprasDGV.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComprasDGV.Location = new System.Drawing.Point(26, 267);
            this.ComprasDGV.Name = "ComprasDGV";
            this.ComprasDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ComprasDGV.Size = new System.Drawing.Size(1121, 251);
            this.ComprasDGV.TabIndex = 1;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(26, 189);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 23);
            this.cantidadTextBox.TabIndex = 2;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(143, 189);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(151, 23);
            this.codigoTextBox.TabIndex = 4;
            // 
            // costFOBDolaresTextBox
            // 
            this.costFOBDolaresTextBox.Location = new System.Drawing.Point(308, 189);
            this.costFOBDolaresTextBox.Name = "costFOBDolaresTextBox";
            this.costFOBDolaresTextBox.Size = new System.Drawing.Size(127, 23);
            this.costFOBDolaresTextBox.TabIndex = 6;
            // 
            // costoCIFDolaresTextBox
            // 
            this.costoCIFDolaresTextBox.Location = new System.Drawing.Point(448, 189);
            this.costoCIFDolaresTextBox.Name = "costoCIFDolaresTextBox";
            this.costoCIFDolaresTextBox.Size = new System.Drawing.Size(138, 23);
            this.costoCIFDolaresTextBox.TabIndex = 8;
            // 
            // costoCIFLempirasTextBox
            // 
            this.costoCIFLempirasTextBox.Location = new System.Drawing.Point(598, 189);
            this.costoCIFLempirasTextBox.Name = "costoCIFLempirasTextBox";
            this.costoCIFLempirasTextBox.Size = new System.Drawing.Size(140, 23);
            this.costoCIFLempirasTextBox.TabIndex = 10;
            // 
            // costosDeImportacionTextBox
            // 
            this.costosDeImportacionTextBox.Location = new System.Drawing.Point(753, 189);
            this.costosDeImportacionTextBox.Name = "costosDeImportacionTextBox";
            this.costosDeImportacionTextBox.Size = new System.Drawing.Size(163, 23);
            this.costosDeImportacionTextBox.TabIndex = 12;
            // 
            // costosDeTransporteTextBox
            // 
            this.costosDeTransporteTextBox.Location = new System.Drawing.Point(939, 189);
            this.costosDeTransporteTextBox.Name = "costosDeTransporteTextBox";
            this.costosDeTransporteTextBox.Size = new System.Drawing.Size(208, 23);
            this.costosDeTransporteTextBox.TabIndex = 14;
            // 
            // costoTotalCompraDolaresTextBox
            // 
            this.costoTotalCompraDolaresTextBox.Location = new System.Drawing.Point(26, 232);
            this.costoTotalCompraDolaresTextBox.Name = "costoTotalCompraDolaresTextBox";
            this.costoTotalCompraDolaresTextBox.Size = new System.Drawing.Size(268, 23);
            this.costoTotalCompraDolaresTextBox.TabIndex = 16;
            // 
            // costoTotalCompraLempirasTextBox
            // 
            this.costoTotalCompraLempirasTextBox.Location = new System.Drawing.Point(308, 232);
            this.costoTotalCompraLempirasTextBox.Name = "costoTotalCompraLempirasTextBox";
            this.costoTotalCompraLempirasTextBox.Size = new System.Drawing.Size(278, 23);
            this.costoTotalCompraLempirasTextBox.TabIndex = 18;
            // 
            // precioUnitarioCompraDolaresTextBox
            // 
            this.precioUnitarioCompraDolaresTextBox.Location = new System.Drawing.Point(598, 232);
            this.precioUnitarioCompraDolaresTextBox.Name = "precioUnitarioCompraDolaresTextBox";
            this.precioUnitarioCompraDolaresTextBox.Size = new System.Drawing.Size(314, 23);
            this.precioUnitarioCompraDolaresTextBox.TabIndex = 20;
            // 
            // productoTextBox
            // 
            this.productoTextBox.Location = new System.Drawing.Point(939, 232);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(208, 23);
            this.productoTextBox.TabIndex = 22;
            // 
            // nuevoTextBox
            // 
            this.nuevoTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nuevoTextBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nuevoTextBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nuevoTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nuevoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoTextBox.Image = ((System.Drawing.Image)(resources.GetObject("nuevoTextBox.Image")));
            this.nuevoTextBox.Location = new System.Drawing.Point(1169, 353);
            this.nuevoTextBox.Name = "nuevoTextBox";
            this.nuevoTextBox.Size = new System.Drawing.Size(105, 28);
            this.nuevoTextBox.TabIndex = 79;
            this.nuevoTextBox.Text = "&Nuevo";
            this.nuevoTextBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevoTextBox.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1169, 387);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 28);
            this.button6.TabIndex = 75;
            this.button6.Text = "&Guardar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1154, 228);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 30);
            this.button4.TabIndex = 74;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.Color.Transparent;
            this.printbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.printbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.Image = ((System.Drawing.Image)(resources.GetObject("printbtn.Image")));
            this.printbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printbtn.Location = new System.Drawing.Point(1169, 422);
            this.printbtn.Margin = new System.Windows.Forms.Padding(4);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(105, 28);
            this.printbtn.TabIndex = 80;
            this.printbtn.Text = "Imprimir";
            this.printbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printbtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(229, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 81;
            this.label1.Text = "TOTALES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(366, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 82;
            this.label2.Text = "$ 0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(482, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 83;
            this.label3.Text = "$ 0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(595, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "$ 0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(919, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 87;
            this.label5.Text = "L 0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(798, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 86;
            this.label6.Text = "$ 0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(682, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 85;
            this.label7.Text = "L 0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(1047, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 88;
            this.label9.Text = "$ 0.00";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "25/04/2023";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1144, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 23);
            this.dateTimePicker1.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1087, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 90;
            this.label10.Text = "Fecha:";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(1146, 551);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 91;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(489, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 32);
            this.label11.TabIndex = 93;
            this.label11.Text = "REGISTRO DE COMPRA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(516, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // proveedorTextBox
            // 
            this.proveedorTextBox.Location = new System.Drawing.Point(26, 143);
            this.proveedorTextBox.Name = "proveedorTextBox";
            this.proveedorTextBox.Size = new System.Drawing.Size(182, 23);
            this.proveedorTextBox.TabIndex = 94;
            // 
            // numDeclaracionTextBox
            // 
            this.numDeclaracionTextBox.Location = new System.Drawing.Point(219, 143);
            this.numDeclaracionTextBox.Name = "numDeclaracionTextBox";
            this.numDeclaracionTextBox.Size = new System.Drawing.Size(216, 23);
            this.numDeclaracionTextBox.TabIndex = 95;
            // 
            // numFacturaTextBox
            // 
            this.numFacturaTextBox.Location = new System.Drawing.Point(448, 143);
            this.numFacturaTextBox.Name = "numFacturaTextBox";
            this.numFacturaTextBox.Size = new System.Drawing.Size(138, 23);
            this.numFacturaTextBox.TabIndex = 96;
            // 
            // fechaEnBodegaDateTimePicker
            // 
            this.fechaEnBodegaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaEnBodegaDateTimePicker.Location = new System.Drawing.Point(598, 143);
            this.fechaEnBodegaDateTimePicker.Name = "fechaEnBodegaDateTimePicker";
            this.fechaEnBodegaDateTimePicker.Size = new System.Drawing.Size(140, 23);
            this.fechaEnBodegaDateTimePicker.TabIndex = 97;
            // 
            // impuestoPagadoTextBox
            // 
            this.impuestoPagadoTextBox.Location = new System.Drawing.Point(753, 143);
            this.impuestoPagadoTextBox.Name = "impuestoPagadoTextBox";
            this.impuestoPagadoTextBox.Size = new System.Drawing.Size(163, 23);
            this.impuestoPagadoTextBox.TabIndex = 98;
            // 
            // numOrdenTextBox
            // 
            this.numOrdenTextBox.Location = new System.Drawing.Point(1144, 36);
            this.numOrdenTextBox.Name = "numOrdenTextBox";
            this.numOrdenTextBox.Size = new System.Drawing.Size(91, 23);
            this.numOrdenTextBox.TabIndex = 99;
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AjusteInventarioTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BajosMinimosTableAdapter = null;
            this.tableAdapterManager.BodegaTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ComprobanteEntregaTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DevolucionesTableAdapter = null;
            this.tableAdapterManager.InventarioBodega1TableAdapter = null;
            this.tableAdapterManager.InventarioBodega2TableAdapter = null;
            this.tableAdapterManager.InventarioBodega3TableAdapter = null;
            this.tableAdapterManager.InventarioBodega4TableAdapter = null;
            this.tableAdapterManager.PermisosAdministradorTableAdapter = null;
            this.tableAdapterManager.PermisosComprasTableAdapter = null;
            this.tableAdapterManager.PermisosEncargadoBodegaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RegistrarBaseForaneaTableAdapter = null;
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoMaterialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // numOrdenDataGridViewTextBoxColumn
            // 
            this.numOrdenDataGridViewTextBoxColumn.DataPropertyName = "NumOrden";
            this.numOrdenDataGridViewTextBoxColumn.HeaderText = "NumOrden";
            this.numOrdenDataGridViewTextBoxColumn.Name = "numOrdenDataGridViewTextBoxColumn";
            this.numOrdenDataGridViewTextBoxColumn.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            // 
            // costoTotalCompraDolaresDataGridViewTextBoxColumn
            // 
            this.costoTotalCompraDolaresDataGridViewTextBoxColumn.DataPropertyName = "CostoTotalCompraDolares";
            this.costoTotalCompraDolaresDataGridViewTextBoxColumn.HeaderText = "CostoTotalCompraDolares";
            this.costoTotalCompraDolaresDataGridViewTextBoxColumn.Name = "costoTotalCompraDolaresDataGridViewTextBoxColumn";
            // 
            // costoTotalCompraLempirasDataGridViewTextBoxColumn
            // 
            this.costoTotalCompraLempirasDataGridViewTextBoxColumn.DataPropertyName = "CostoTotalCompraLempiras";
            this.costoTotalCompraLempirasDataGridViewTextBoxColumn.HeaderText = "CostoTotalCompraLempiras";
            this.costoTotalCompraLempirasDataGridViewTextBoxColumn.Name = "costoTotalCompraLempirasDataGridViewTextBoxColumn";
            // 
            // costosDeImportacionDataGridViewTextBoxColumn
            // 
            this.costosDeImportacionDataGridViewTextBoxColumn.DataPropertyName = "CostosDeImportacion";
            this.costosDeImportacionDataGridViewTextBoxColumn.HeaderText = "CostosDeImportacion";
            this.costosDeImportacionDataGridViewTextBoxColumn.Name = "costosDeImportacionDataGridViewTextBoxColumn";
            // 
            // costoCIFLempirasDataGridViewTextBoxColumn
            // 
            this.costoCIFLempirasDataGridViewTextBoxColumn.DataPropertyName = "CostoCIFLempiras";
            this.costoCIFLempirasDataGridViewTextBoxColumn.HeaderText = "CostoCIFLempiras";
            this.costoCIFLempirasDataGridViewTextBoxColumn.Name = "costoCIFLempirasDataGridViewTextBoxColumn";
            // 
            // costoCIFDolaresDataGridViewTextBoxColumn
            // 
            this.costoCIFDolaresDataGridViewTextBoxColumn.DataPropertyName = "CostoCIFDolares";
            this.costoCIFDolaresDataGridViewTextBoxColumn.HeaderText = "CostoCIFDolares";
            this.costoCIFDolaresDataGridViewTextBoxColumn.Name = "costoCIFDolaresDataGridViewTextBoxColumn";
            // 
            // costosDeTransporteDataGridViewTextBoxColumn
            // 
            this.costosDeTransporteDataGridViewTextBoxColumn.DataPropertyName = "CostosDeTransporte";
            this.costosDeTransporteDataGridViewTextBoxColumn.HeaderText = "CostosDeTransporte";
            this.costosDeTransporteDataGridViewTextBoxColumn.Name = "costosDeTransporteDataGridViewTextBoxColumn";
            // 
            // costFOBDolaresDataGridViewTextBoxColumn
            // 
            this.costFOBDolaresDataGridViewTextBoxColumn.DataPropertyName = "CostFOBDolares";
            this.costFOBDolaresDataGridViewTextBoxColumn.HeaderText = "CostFOBDolares";
            this.costFOBDolaresDataGridViewTextBoxColumn.Name = "costFOBDolaresDataGridViewTextBoxColumn";
            // 
            // precioUnitarioCompraDolaresDataGridViewTextBoxColumn
            // 
            this.precioUnitarioCompraDolaresDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitarioCompraDolares";
            this.precioUnitarioCompraDolaresDataGridViewTextBoxColumn.HeaderText = "PrecioUnitarioCompraDolares";
            this.precioUnitarioCompraDolaresDataGridViewTextBoxColumn.Name = "precioUnitarioCompraDolaresDataGridViewTextBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // iDCompraDataGridViewTextBoxColumn
            // 
            this.iDCompraDataGridViewTextBoxColumn.DataPropertyName = "IDCompra";
            this.iDCompraDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDCompraDataGridViewTextBoxColumn.Name = "iDCompraDataGridViewTextBoxColumn";
            this.iDCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCompraDataGridViewTextBoxColumn.Width = 40;
            // 
            // obtenerComprasConProveedoresBindingSource
            // 
            this.obtenerComprasConProveedoresBindingSource.DataSource = this._CATELSA_MULTICABLE;
            this.obtenerComprasConProveedoresBindingSource.Position = 0;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 602);
            this.Controls.Add(numOrdenLabel);
            this.Controls.Add(this.numOrdenTextBox);
            this.Controls.Add(impuestoPagadoLabel);
            this.Controls.Add(this.impuestoPagadoTextBox);
            this.Controls.Add(fechaEnBodegaLabel);
            this.Controls.Add(this.fechaEnBodegaDateTimePicker);
            this.Controls.Add(numFacturaLabel);
            this.Controls.Add(this.numFacturaTextBox);
            this.Controls.Add(numDeclaracionLabel);
            this.Controls.Add(this.numDeclaracionTextBox);
            this.Controls.Add(proveedorLabel);
            this.Controls.Add(this.proveedorTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.nuevoTextBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(costFOBDolaresLabel);
            this.Controls.Add(this.costFOBDolaresTextBox);
            this.Controls.Add(costoCIFDolaresLabel);
            this.Controls.Add(this.costoCIFDolaresTextBox);
            this.Controls.Add(costoCIFLempirasLabel);
            this.Controls.Add(this.costoCIFLempirasTextBox);
            this.Controls.Add(costosDeImportacionLabel);
            this.Controls.Add(this.costosDeImportacionTextBox);
            this.Controls.Add(costosDeTransporteLabel);
            this.Controls.Add(this.costosDeTransporteTextBox);
            this.Controls.Add(costoTotalCompraDolaresLabel);
            this.Controls.Add(this.costoTotalCompraDolaresTextBox);
            this.Controls.Add(costoTotalCompraLempirasLabel);
            this.Controls.Add(this.costoTotalCompraLempirasTextBox);
            this.Controls.Add(precioUnitarioCompraDolaresLabel);
            this.Controls.Add(this.precioUnitarioCompraDolaresTextBox);
            this.Controls.Add(productoLabel);
            this.Controls.Add(this.productoTextBox);
            this.Controls.Add(this.ComprasDGV);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Nueva Compra";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerComprasConProveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ComprasDGV;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox costFOBDolaresTextBox;
        private System.Windows.Forms.TextBox costoCIFDolaresTextBox;
        private System.Windows.Forms.TextBox costoCIFLempirasTextBox;
        private System.Windows.Forms.TextBox costosDeImportacionTextBox;
        private System.Windows.Forms.TextBox costosDeTransporteTextBox;
        private System.Windows.Forms.TextBox costoTotalCompraDolaresTextBox;
        private System.Windows.Forms.TextBox costoTotalCompraLempirasTextBox;
        private System.Windows.Forms.TextBox precioUnitarioCompraDolaresTextBox;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button nuevoTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox proveedorTextBox;
        private System.Windows.Forms.TextBox numDeclaracionTextBox;
        private System.Windows.Forms.TextBox numFacturaTextBox;
        private System.Windows.Forms.DateTimePicker fechaEnBodegaDateTimePicker;
        private System.Windows.Forms.TextBox impuestoPagadoTextBox;
        private System.Windows.Forms.TextBox numOrdenTextBox;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private _CATELSA_MULTICABLETableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioCompraDolaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costFOBDolaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costosDeTransporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCIFDolaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCIFLempirasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costosDeImportacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotalCompraLempirasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotalCompraDolaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOrdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource obtenerComprasConProveedoresBindingSource;
    }
}