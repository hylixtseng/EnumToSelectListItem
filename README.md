有時我們會在列舉上定義一些項目，例如在職狀態(在職中、已離職、留職停薪)，那麼可不可以將這些列舉項目清單直接輸出到前端以供使用呢？

本專案示範，如何在列舉(enum)的每個項目(element)上添加文字描述，再透過自訂的擴充方法將這些文字描述提取出來。
從提取出來的文字就可以和對應的列舉項目值一起包裝成 SelectListItem 物件，再利用 Web API 輸出，以供前端網頁的 RadioButton、Checkbox 或 Select 元素使用。

本專案使用 ASP.NET Core 2.0 實作 Web API，並且有安裝 Swagger，因此執行 IISExpress 時會直接跳轉到 Swagger UI 頁面。
