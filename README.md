# 動物森友會主題互動與資料管理系統

## 專案簡介
本專案以《集合啦！動物森友會》為設計靈感，使用 C# WinForms 開發桌面應用程式，模擬遊戲中的互動體驗，並結合底層資料庫操作，打造出一套具備完整 CRUD 功能的資料管理系統。

專案核心著重於事件驅動開發 (Event-driven)、ADO.NET 資料庫操作，並導入三層式架構 (3-Tier Architecture) 以確保程式碼的高內聚與低耦合。

## 系統功能與核心邏輯
島主登入系統：基本的帳號密碼驗證機制與主畫面導覽。
角色圖鑑與資訊管理：結合圖片與文字的 UI 面板，可即時查看島民的種族、性格與口頭禪。
互動送禮系統：實作好感度演算邏輯。玩家送禮後，系統會自動計算並更新好感度數值，並透過進度條呈現關係等級。
動態查詢與過濾：支援關鍵字搜尋，動態篩選 DataGridView 中的島民資料。
軟刪除與資料復原：捨棄危險的實體刪除，採用「垃圾桶」機制。刪除的居民可進入回收區，並支援「回復居民」功能，確保資料安全性。

## 使用技術
前端介面：C#, WinForms
資料存取：ADO.NET
資料庫：S SQL Server
設計模式：分層架構 

## 系統架構設計（三層式架構）
本專案將系統拆分為 UI / BLL / DAL，落實關注點分離：
UI（使用者介面層）：負責 WinForms 畫面呈現、接收使用者操作與點擊事件，並將需求傳遞給 BLL。
BLL（業務邏輯層）：系統大腦，負責處理資料驗證（如防呆檢查）、控制商業流程，並作為 UI 與 DAL 的溝通橋樑。
DAL（資料存取層）：專注於 ADO.NET 操作，執行 SQL 指令與資料庫進行連線與 CRUD 存取。

**系統資料流向：**
使用者操作 -> UI -> BLL -> DAL -> 資料庫
資料庫回傳 -> DAL -> BLL -> UI 渲染畫面

## 專案結構
Solution
├── UI (WinForms 介面與事件)
├── BLL (Business Logic 邏輯層)
├── DAL (Data Access 資料存取層)
└── Models (資料模型與物件傳遞)


## 專案畫面 (Screenshots)
1. 系統登入:<img width="454" height="302" alt="系統登入" src="https://github.com/user-attachments/assets/ca7b92cb-cdf6-4966-9b10-8b141ae5041e" />


2. 主頁面導覽:<img width="368" height="284" alt="主頁面導覽" src="https://github.com/user-attachments/assets/26b4870f-44d9-4d2b-9106-4840c153f5dc" />


3. 島民資訊管理:<img width="822" height="538" alt="居民清單" src="https://github.com/user-attachments/assets/74e7efc9-9e57-412c-ba6a-998ea06f6da6" />


4. 軟刪除(垃圾桶)機制:<img width="813" height="531" alt="垃圾桶" src="https://github.com/user-attachments/assets/06c86c9a-6266-46e7-9102-d05bf14fb8fa" />


5. 送禮互動與好感度邏輯實作:<img width="555" height="291" alt="送禮後好感度變化" src="https://github.com/user-attachments/assets/3643b62c-9c8f-4d3c-ac67-5f27d26d15fe" />


6. 新增居民:<img width="397" height="337" alt="新增居民" src="https://github.com/user-attachments/assets/a4fcefd9-2358-49b8-81e0-945f9ba13b7b" />


7. 條件搜尋與資料表動態呈現:<img width="665" height="374" alt="居民搜尋" src="https://github.com/user-attachments/assets/08e4b7cc-a9d2-42ff-b6fe-7fc36ce0acdc" />






