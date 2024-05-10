# Lập trình ứng dụng trên Windows - Đề tài: Tìm việc

## Chú ý

### Nhớ pull về cập nhật code trước khi bắt đầu làm
```
git pull
```
### Tách sang nhánh mới để làm việc trên máy của mình

Sau khi pull code mới nhất về, chạy lệnh các lệnh sau để tách nhánh trước khi làm
1. Tạo nhánh
    ```
    git branch <tên_nhánh>
    * <tên_nhánh>: <tên>_<mô tả>
    * VD: Phuc_SQL, Anh_UI-Company, Loi_UI-User
    ```
2. Chuyển nhánh
    ```
    git checkout <tên nhánh> 
    ```
3. Sau khi làm xong rồi thì commit và push nhánh của mình lên.
    ```
    git add .
    git commit -m "<Mô_tả>"
    git push <tên_nhánh>
    ```
    Ví dụ:
    ```
    # Trước khi làm, pull code hoàn thiện từ master về
    git checkout master
    git pull

    # Tạo nhánh, chuyển nhánh, phát triển chức năng của mình
    git branch Phuc_Daos_Models
    git checkout Phuc_Daos_Models

    # Sau khi xong, sẵn sàng commit và push
    git add .
    git commit -m "feature: Add Daos and Models"
    git push Phuc_Daos_Models
    ```
Sau đó kiểm tra code ok, không conflicts gì hết mới merge vào master để giữ master luôn là code hoàn thiện. Đảm bảo code báo cáo cho cô sẽ luôn nằm ở master. ***Không push hay chỉnh sửa gì trong nhánh master***

***Tốt nhất là nên tách nhánh mỗi khi làm một chức năng mới. Để lỗi chỗ nào thì dễ backup.***