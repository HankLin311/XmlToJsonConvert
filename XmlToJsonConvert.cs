using ConvertJson.Util;
using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.Linq;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace ConvertJson
{
    public partial class formWsdlConvert : Form
    {
        Type[] convertDocument = null;

        public formWsdlConvert()
        {
            InitializeComponent();

            try
            {
                // 鎖住選擇物件按鈕
                listClass.Enabled = false;
                listClass.DropDownStyle = ComboBoxStyle.DropDownList;
                btnXmlToJson.Enabled = false;
                btnJsonToXml.Enabled = false;


                // 帶入舊 Wsdl 網址
                txtWsdlUrl.Text = WsdlUtil.GetLastWsdlUrl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("取得舊網址錯誤!! 錯誤訊息: " + ex.Message);
            }
        }

        private void btnXmlToJson_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = string.Empty;

                ConvertUtil convertUtil = new ConvertUtil(convertDocument);
                txtResult.Text = convertUtil.XmlToJson(listClass.Text, txtSource.Text);
            }
            catch (Exception ex)
            {
                txtResult.Text = string.Empty;

                MessageBox.Show("轉換錯誤!! 錯誤訊息: " + ex.Message);
            }
        }

        private void btnJsonToXml_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = string.Empty;

                ConvertUtil convertUtil = new ConvertUtil(convertDocument);
                txtResult.Text = convertUtil.JsonToXml(listClass.Text, txtSource.Text);
            }
            catch (Exception ex)
            {
                txtResult.Text = string.Empty;

                MessageBox.Show("轉換錯誤!! 錯誤訊息: " + ex.Message);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            try
            {
                // 鎖定畫面
                txtWsdlUrl.Enabled = false;
                btnSetting.Enabled = false;
                listClass.Enabled = false;
                txtSource.Text = string.Empty;
                txtResult.Text = string.Empty;
                btnJsonToXml.Enabled = false;
                btnXmlToJson.Enabled = false;

                // 取得Wsdl網址
                ServiceDescription sd = WsdlUtil.ReadServiceDescriptionFromWsdl(txtWsdlUrl.Text);

                // 動態編譯 Class
                CompilerResults results = WsdlUtil.CompileWsdlToAssembly(sd);

                // 使用轉換後的類別調用 Web 服務中的方法
                convertDocument = results.CompiledAssembly.GetTypes();

                // 設定下拉式選單
                foreach (var type in convertDocument.OrderBy(x => x.FullName))
                {
                    listClass.Items.Add(type.FullName);
                }

                // 下拉式選單 AutoSize
                int maxSize = 0;
                Graphics g = CreateGraphics();
                for (int i = 0; i < listClass.Items.Count; i++)
                {
                    listClass.SelectedIndex = i;
                    SizeF size = g.MeasureString(listClass.Text, listClass.Font);
                    if (maxSize < (int)size.Width)
                    {
                        maxSize = (int)size.Width;
                    }
                }

                listClass.DropDownWidth = listClass.Width;

                if (listClass.DropDownWidth < maxSize)
                {
                    listClass.DropDownWidth = maxSize;
                }

                // 紀錄暫存網址
                WsdlUtil.SetWsdlUrl(txtWsdlUrl.Text);

                // 開啟畫面
                listClass.SelectedIndex = -1;
                listClass.Enabled = true;
                txtSource.Enabled = true;
                txtResult.Enabled = true;
                btnXmlToJson.Enabled = true;
                btnJsonToXml.Enabled = true;
            }
            catch (Exception ex)
            {
                txtResult.Text = string.Empty;

                MessageBox.Show("取得 Wsdl 資料錯誤!! 錯誤訊息: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                // 清除畫面
                txtWsdlUrl.Enabled = true;
                btnSetting.Enabled = true;
                txtSource.Text = string.Empty;
                txtResult.Text = string.Empty;
                btnJsonToXml.Enabled = false;
                btnXmlToJson.Enabled = false;
                listClass.Enabled = false;
                listClass.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("清除資料錯誤!! 錯誤訊息: " + ex.Message);
            }
        }
    }
}
