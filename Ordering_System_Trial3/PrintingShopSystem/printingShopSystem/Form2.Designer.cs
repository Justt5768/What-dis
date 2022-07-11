
namespace printingShopSystem
{
    partial class form_productsPage
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_stocks = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_status = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            // 
            // btn_stocks
            // 
            this.btn_stocks.Location = new System.Drawing.Point(639, 32);
            this.btn_stocks.Name = "btn_stocks";
            this.btn_stocks.Size = new System.Drawing.Size(83, 31);
            this.btn_stocks.TabIndex = 15;
            this.btn_stocks.Text = "Stocks";
            this.btn_stocks.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Elegant Prints";
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(318, 32);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(83, 31);
            this.btn_home.TabIndex = 12;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(423, 32);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(83, 31);
            this.btn_products.TabIndex = 13;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            // 
            // btn_status
            // 
            this.btn_status.Location = new System.Drawing.Point(531, 32);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(83, 31);
            this.btn_status.TabIndex = 14;
            this.btn_status.Text = "Status";
            this.btn_status.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 45);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // form_productsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 503);
            this.Controls.Add(this.btn_stocks);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "form_productsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_stocks;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}