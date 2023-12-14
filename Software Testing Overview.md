# Tổng Quan Kiểm Thử Phần Mềm

`Kiểm thử (Testing)` nghĩa là thực thi chương trình với dữ liệu được chuẩn bị trước và tiến hành kiểm tra các kết quả để phát hiện những vấn đề hoặc bất thường trong hệ thống.

Mục đích chính của `Kiểm thử` là để phát hiện những trường hợp hệ thống có lỗi, thiết sót, dư thừa (Defect Testing) hoặc hoạt động không đúng với đặc tả (Validation Testing).

#### Tầm Quan Trọng của Kiểm Thử Phần Mềm

Kiểm thử phần mềm (Software Testing) là công đoạn quan trọng để đảm bảo chất lượng phần mềm trước khi sản phẩm đến tay client. Nó giúp tăng tính tin cậy của client và dev về sản phẩm, cũng như giảm thiểu chi phí, rủi ro giải quyết các vấn đề trong quá trình phát triển.

#### Chất Lượng Phần Mềm

Để quyết định chúng có chất lượng cao hay không có thể đánh giá thông qua các thuộc tính chất lượng.

-   `Tính Chính Xác (Correctness)`: mức độ phần mềm thực hiện được các chức năng như mong muốn của nó.
-   `Tính Tin Cậy (Reliability)`: mức độ phần mềm thực hiện các chức năng yêu cầu điều kiện và khoảng thời gian cho trước.
-   `Tính Khả Dụng (Usability)`: mức độ công sức (Effort) cần để học sử dụng phần mềm.
-   `Tính Toàn Vẹn (Integrity)`: khả năng hệ thống chịu được trước sự tấn công vô ý hoặc có chủ ý.
-   `Tính Khả Chuyển (Portability)`: khả năng chuyển phần mềm từ môi trường này sang môi trường khác.
-   `Tính Bảo Trì (Maintainability)`: công sức (Effort) cần thiết để thực hiện các thay đổi trong phần mềm.
-   `Tính Tương Tác (Interoperability)`: công sức (Effort) cần thiết để liên kế hệ thống này đến một hệ thống khác.

#### Phân Loại Kiểm Thử Phần Mềm

![image](https://assets-global.website-files.com/619e15d781b21202de206fb5/636b964bcbddd712f496e592_comparative-guide-to-automation-and-manual-testing-blog.webp)

-   `Kiểm thử thủ công (Manual Testing)` là thực hiện việc kiểm thử không cần sự hỗ trợ của các công cụ hay viết chương trình thực thi nào, kiểm thử viên thường đóng vai trò người dùng cuối (End-User) để kiểm thử phần mềm nhằm xác định một số hành vi không muốn hoặc các lỗi (Bug) xảy ra trong hệ thống.
-   `Kiểm thử tự động (Automation Testing)` sử dụng một số công cụ có sẳn hoặc kiểm thử viên viết chương trình thực hiện kiểm thử một chương trình khác.

[A Comparative Guide to Automation and Manual Testing](https://www.headspin.io/blog/automation-and-manual-testing)

#### Ai thực hiện việc kiểm thử?

Quản lý dự án, lập trình viên, nhân viên quản trị hạ tầng hệ thống, người dùng cuối, nhân viên thiết kế, v.v
