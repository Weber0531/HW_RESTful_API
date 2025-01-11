# NotesAPI

## 簡介
一個簡單的 RESTful API，可用於新增、修改、刪除及查詢記事。

## 技術棧
- .NET 8.0
- SQLite
- Entity Framework Core
- Swagger (API 文件)

## 安裝步驟
1. clone repository。
   ```bash
   git clone https://github.com/Weber0531/HW_RESTful_API.git
   
2. 在專案目錄執行遷移命令。
   ```bash
   dotnet ef database update

3. 執行專案。
   ```bash
   dotnet run

API 說明
GET /api/Notes - 取得所有記事。
GET /api/Notes/{id} - 取得單一記事。
POST /api/Notes - 新增記事。
PUT /api/Notes/{id} - 修改記事。
DELETE /api/Notes/{id} - 刪除記事。
