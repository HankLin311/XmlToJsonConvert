
namespace ConvertJson
{
    partial class formWsdlConvert
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXmlToJson = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnJsonToXml = new System.Windows.Forms.Button();
            this.txtWsdlUrl = new System.Windows.Forms.TextBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.listClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXmlToJson
            // 
            this.btnXmlToJson.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnXmlToJson.Location = new System.Drawing.Point(468, 309);
            this.btnXmlToJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnXmlToJson.Name = "btnXmlToJson";
            this.btnXmlToJson.Size = new System.Drawing.Size(223, 92);
            this.btnXmlToJson.TabIndex = 0;
            this.btnXmlToJson.Text = "XML 轉 Json";
            this.btnXmlToJson.UseVisualStyleBackColor = true;
            this.btnXmlToJson.Click += new System.EventHandler(this.btnXmlToJson_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(51, 172);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtSource.MaxLength = 0;
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSource.Size = new System.Drawing.Size(408, 500);
            this.txtSource.TabIndex = 1;
            this.txtSource.WordWrap = false;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(699, 172);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.MaxLength = 0;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(408, 500);
            this.txtResult.TabIndex = 2;
            this.txtResult.WordWrap = false;
            // 
            // btnJsonToXml
            // 
            this.btnJsonToXml.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnJsonToXml.Location = new System.Drawing.Point(468, 458);
            this.btnJsonToXml.Margin = new System.Windows.Forms.Padding(4);
            this.btnJsonToXml.Name = "btnJsonToXml";
            this.btnJsonToXml.Size = new System.Drawing.Size(223, 92);
            this.btnJsonToXml.TabIndex = 3;
            this.btnJsonToXml.Text = "Json 轉 XML";
            this.btnJsonToXml.UseVisualStyleBackColor = true;
            this.btnJsonToXml.Click += new System.EventHandler(this.btnJsonToXml_Click);
            // 
            // txtWsdlUrl
            // 
            this.txtWsdlUrl.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWsdlUrl.Location = new System.Drawing.Point(188, 38);
            this.txtWsdlUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtWsdlUrl.Name = "txtWsdlUrl";
            this.txtWsdlUrl.Size = new System.Drawing.Size(725, 42);
            this.txtWsdlUrl.TabIndex = 4;
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetting.Location = new System.Drawing.Point(921, 38);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(93, 42);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "設定";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // listClass
            // 
            this.listClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listClass.FormattingEnabled = true;
            this.listClass.Location = new System.Drawing.Point(188, 96);
            this.listClass.Margin = new System.Windows.Forms.Padding(4);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(919, 41);
            this.listClass.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "WSDL : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(43, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "CLASS : ";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(1022, 38);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // formWsdlConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 689);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listClass);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.txtWsdlUrl);
            this.Controls.Add(this.btnJsonToXml);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnXmlToJson);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formWsdlConvert";
            this.Text = "物件轉換器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXmlToJson;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnJsonToXml;
        private System.Windows.Forms.TextBox txtWsdlUrl;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.ComboBox listClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
    }
}

