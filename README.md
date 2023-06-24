# XML / JSON 格式轉換器

## 說明
測試遇到 XML 和 JSON 資料需要不停轉換 <br />
所以才使用 WSDL URL 匯入的方式，使用 CHAT GPT 輔助寫出一個小工具 <br />

## 實作
1. ConvertUtil : 使用 Type 將 Json 或 Xml 做轉換
2. WsdlUtil : 處理下載 WSDL、自動編譯成 Assembly、將 Assembly 轉型成 Class 的功能

## 待改進的地方
1. 因為直接使用反射 Class 去做轉型，所以下拉式選單的物件有些不是輸入輸出的物件
