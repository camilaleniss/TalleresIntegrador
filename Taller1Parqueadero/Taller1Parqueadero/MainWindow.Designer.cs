namespace Taller1Parqueadero
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registerButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.codeTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.nameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.codesComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.plateTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.enterVehicleButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.removeVehicleButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.plateComboBox = new System.Windows.Forms.ComboBox();
            this.availableLabel = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(776, 38);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Parqueadero Icesi";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLabel.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerButton);
            this.groupBox1.Controls.Add(this.codeTextField);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.nameTextField);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 388);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.Depth = 0;
            this.registerButton.Icon = null;
            this.registerButton.Location = new System.Drawing.Point(11, 134);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.Primary = true;
            this.registerButton.Size = new System.Drawing.Size(83, 36);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "agregar";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // codeTextField
            // 
            this.codeTextField.Depth = 0;
            this.codeTextField.Hint = "";
            this.codeTextField.Location = new System.Drawing.Point(10, 92);
            this.codeTextField.MaxLength = 32767;
            this.codeTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.codeTextField.Name = "codeTextField";
            this.codeTextField.PasswordChar = '\0';
            this.codeTextField.SelectedText = "";
            this.codeTextField.SelectionLength = 0;
            this.codeTextField.SelectionStart = 0;
            this.codeTextField.Size = new System.Drawing.Size(183, 23);
            this.codeTextField.TabIndex = 3;
            this.codeTextField.TabStop = false;
            this.codeTextField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 69);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Código";
            // 
            // nameTextField
            // 
            this.nameTextField.Depth = 0;
            this.nameTextField.Hint = "";
            this.nameTextField.Location = new System.Drawing.Point(11, 43);
            this.nameTextField.MaxLength = 32767;
            this.nameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.PasswordChar = '\0';
            this.nameTextField.SelectedText = "";
            this.nameTextField.SelectionLength = 0;
            this.nameTextField.SelectionStart = 0;
            this.nameTextField.Size = new System.Drawing.Size(183, 23);
            this.nameTextField.TabIndex = 1;
            this.nameTextField.TabStop = false;
            this.nameTextField.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nombre";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enterVehicleButton);
            this.groupBox2.Controls.Add(this.plateTextField);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.codesComboBox);
            this.groupBox2.Controls.Add(this.studentCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(218, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 201);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresar vehículo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // studentCheckBox
            // 
            this.studentCheckBox.AutoSize = true;
            this.studentCheckBox.Depth = 0;
            this.studentCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.studentCheckBox.Location = new System.Drawing.Point(7, 20);
            this.studentCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.studentCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.studentCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.studentCheckBox.Name = "studentCheckBox";
            this.studentCheckBox.Ripple = true;
            this.studentCheckBox.Size = new System.Drawing.Size(126, 30);
            this.studentCheckBox.TabIndex = 0;
            this.studentCheckBox.Text = "¿Es estudiante?";
            this.studentCheckBox.UseVisualStyleBackColor = true;
            this.studentCheckBox.CheckedChanged += new System.EventHandler(this.studentCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.availableLabel);
            this.groupBox3.Location = new System.Drawing.Point(425, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 387);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vehículos";
            // 
            // codesComboBox
            // 
            this.codesComboBox.Enabled = false;
            this.codesComboBox.FormattingEnabled = true;
            this.codesComboBox.IntegralHeight = false;
            this.codesComboBox.Location = new System.Drawing.Point(7, 54);
            this.codesComboBox.Name = "codesComboBox";
            this.codesComboBox.Size = new System.Drawing.Size(187, 21);
            this.codesComboBox.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 78);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(46, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Placa";
            // 
            // plateTextField
            // 
            this.plateTextField.Depth = 0;
            this.plateTextField.Hint = "";
            this.plateTextField.Location = new System.Drawing.Point(7, 100);
            this.plateTextField.MaxLength = 32767;
            this.plateTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.plateTextField.Name = "plateTextField";
            this.plateTextField.PasswordChar = '\0';
            this.plateTextField.SelectedText = "";
            this.plateTextField.SelectionLength = 0;
            this.plateTextField.SelectionStart = 0;
            this.plateTextField.Size = new System.Drawing.Size(183, 23);
            this.plateTextField.TabIndex = 5;
            this.plateTextField.TabStop = false;
            this.plateTextField.UseSystemPasswordChar = false;
            // 
            // enterVehicleButton
            // 
            this.enterVehicleButton.AutoSize = true;
            this.enterVehicleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enterVehicleButton.Depth = 0;
            this.enterVehicleButton.Icon = null;
            this.enterVehicleButton.Location = new System.Drawing.Point(10, 134);
            this.enterVehicleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.enterVehicleButton.Name = "enterVehicleButton";
            this.enterVehicleButton.Primary = true;
            this.enterVehicleButton.Size = new System.Drawing.Size(155, 36);
            this.enterVehicleButton.TabIndex = 5;
            this.enterVehicleButton.Text = "ingresar vehículo";
            this.enterVehicleButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.removeVehicleButton);
            this.groupBox4.Controls.Add(this.materialLabel4);
            this.groupBox4.Controls.Add(this.plateComboBox);
            this.groupBox4.Location = new System.Drawing.Point(218, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 201);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Retirar vehículo";
            // 
            // removeVehicleButton
            // 
            this.removeVehicleButton.AutoSize = true;
            this.removeVehicleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeVehicleButton.Depth = 0;
            this.removeVehicleButton.Icon = null;
            this.removeVehicleButton.Location = new System.Drawing.Point(10, 75);
            this.removeVehicleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeVehicleButton.Name = "removeVehicleButton";
            this.removeVehicleButton.Primary = true;
            this.removeVehicleButton.Size = new System.Drawing.Size(144, 36);
            this.removeVehicleButton.TabIndex = 5;
            this.removeVehicleButton.Text = "retirar vehículo";
            this.removeVehicleButton.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 17);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(46, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Placa";
            // 
            // plateComboBox
            // 
            this.plateComboBox.Enabled = false;
            this.plateComboBox.FormattingEnabled = true;
            this.plateComboBox.IntegralHeight = false;
            this.plateComboBox.Location = new System.Drawing.Point(6, 39);
            this.plateComboBox.Name = "plateComboBox";
            this.plateComboBox.Size = new System.Drawing.Size(187, 21);
            this.plateComboBox.TabIndex = 1;
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Depth = 0;
            this.availableLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.availableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.availableLabel.Location = new System.Drawing.Point(6, 16);
            this.availableLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(60, 19);
            this.availableLabel.TabIndex = 6;
            this.availableLabel.Text = "Cupos: ";
            this.availableLabel.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Parqueadero Icesi";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel titleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField codeTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton registerButton;
        private MaterialSkin.Controls.MaterialCheckBox studentCheckBox;
        private System.Windows.Forms.ComboBox codesComboBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField plateTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton enterVehicleButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialRaisedButton removeVehicleButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox plateComboBox;
        private MaterialSkin.Controls.MaterialLabel availableLabel;
    }
}

