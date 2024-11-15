# WebAPI Practice Projects
專案基本描述
RESTful API set  
已經有兩個預設 GET API  
GET /todos, 取得所有的 todos  
GET /todos/{id}, 取得特定 id 的 todos  

public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);

1. 擴充一個 POST API /todos 透過 body 可以建立一個 todo
2. 擴充一個 PUT API /todos/{id} 加上 body 可以修改特定一個 todo 的內容
3. 擴充一個 DELETE API /todos/{id} 可以刪除特定一個 todo
4. 擴充一個 POST API /todos?title={title}&dueby={dueby}&iscomplete={iscomplete} 不透過 body, 反而透過 query 來建立一個 todo 內容 
5. 擴充一個 GET API /todos/search?title={title} 可以取得包含查詢條件的的 titles
6. 使用 Controller base 來實作一個 POST API /todos 透過 body 可以建立一個 todo
7. 使用 Controller base 來實作一個 PUT API /todos/{id} 加上 body 可以修改特定一個 todo 的內容
8. 使用 Controller base 來實作一個 DELETE API /todos/{id} 可以刪除特定一個 todo
9. 使用 Controller base 來實作一個 POST API /todos?title={title}&dueby={dueby}&iscomplete={iscomplete} 不透過 body, 反而透過 query 來建立一個 todo 內容
10. 使用 Controller base 來實作一個 GET API /todos/search?title={title} 可以取得包含查詢條件的的 titles
以下五點練習都要確保測試是可以通過的
11. 在 MyLinq 類別中實作 GetEmployeesAgeGreaterThan25(), GetFruitPriceBiggerThan150() 方法, 讓測試通過 (可以使用 where 語法)
12. 在 MyLinq 類別中將方法 GetEmployeesAgeGreaterThan25(), GetFruitPriceBiggerThan150() 方法 轉換成 IEnumerable<Employee>, IEnumerable<Fruit> 的擴充方法
13. 讓這兩個方法把條件抽到參數上用 Predicate 委派, 方法名稱與用法可以改成  GetEmployees(x => x.Age > 25), GetFruits(x => x.Price > 150)
14. 將這兩個方法變成泛型方法  MyWhere(x => x.Age > 25), MyWhere(x => x.Price > 150)
15. 將方法的第一個參數從 IEnumerable<T> 改成 IEnumerator<T>, 並實作迭代器
