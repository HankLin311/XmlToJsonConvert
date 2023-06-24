using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Net;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ConvertJson.Util
{
    internal class WsdlUtil
    {
        // 設定檔路徑
        readonly static string settingDirectory = Application.StartupPath + "\\Setting";

        // 設定路徑加檔名
        readonly static string settingFileName = "\\0000.txt";

        /// <summary>
        /// 使用 Wsdl Description 取得 Assembly
        /// </summary>
        internal static CompilerResults CompileWsdlToAssembly(ServiceDescription sd)
        {
            ServiceDescriptionImporter importer = new ServiceDescriptionImporter();
            importer.AddServiceDescription(sd, null, null);

            // 設定協議名稱為 "Soap12"
            importer.ProtocolName = "Soap12";

            // 用於客戶端的 Wsdl 格式
            importer.Style = ServiceDescriptionImportStyle.Client;

            // 設定程式碼產生選項為產生屬性
            importer.CodeGenerationOptions = CodeGenerationOptions.GenerateProperties;

            // 動態編譯編譯代碼
            CodeNamespace ns = new CodeNamespace("ClassName");
            CodeCompileUnit ccu = new CodeCompileUnit();
            ccu.Namespaces.Add(ns);
            importer.Import(ns, ccu);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();

            // 使用 CSharpCodeProvider 從 CodeCompileUnit 編譯組件
            CompilerResults results = provider.CompileAssemblyFromDom(parameters, ccu);

            // 判斷是否包含錯誤
            if (results.Errors.Count > 0)
            {
                string errorMsg = "以下為錯誤訊息: ";
                foreach (CompilerError error in results.Errors)
                {
                    errorMsg += error.ErrorText + "\n\n";
                }
                throw new Exception(errorMsg);
            }

            return results;
        }

        /// <summary>
        /// 使用 Wsdl Description 取得 Wsdl ServiceDescription
        /// </summary>
        internal static ServiceDescription ReadServiceDescriptionFromWsdl(string txtWsdlUrl)
        {
            ServiceDescription sd = new ServiceDescription();

            using (WebClient wc = new WebClient()) 
            {
                using (Stream stream = wc.OpenRead(txtWsdlUrl)) 
                {
                    sd = ServiceDescription.Read(stream);
                    stream.Close();
                }
            }

            return sd;
        }

        /// <summary>
        /// 取得上次輸入的 Wsdl Url
        /// </summary>
        internal static string GetLastWsdlUrl()
        {
            string result = string.Empty;

            // 判斷是否有設定檔暫存
            if (!Directory.Exists(settingDirectory))
            {
                Directory.CreateDirectory(settingDirectory);
            }

            // 沒有設定檔
            if (!File.Exists(settingDirectory + settingFileName))
            {
                File.CreateText(settingDirectory + settingFileName);
            }
            // 有設定檔
            else
            {
                result = File.ReadAllText(settingDirectory + settingFileName);
            }

            return result;
        }

        /// <summary>
        /// 設定 Wsdl Url
        /// </summary>
        internal static void SetWsdlUrl(string wsdlUrl)
        {
            File.WriteAllText(settingDirectory + settingFileName, string.Empty);
            File.WriteAllText(settingDirectory + settingFileName, wsdlUrl);
        }
    }
}
