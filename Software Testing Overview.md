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

### Các Nguyên Tắc Kiểm Thử Phần Mềm (7 principles)

![image](https://bestarion.com/wp-content/uploads/2022/08/software-testing-principles.png)

[7 Software Testing Principles](https://bestarion.com/7-software-testing-principles/)

## Các Khái Niệm

**Error (Lỗi) (hay mistake)** là lỗi, nhầm lẫn do con người gây ra.
**Fault (Sai Sót) (hay Defect)** là kết quả của một error, fault có thể là do dư hoặc thiếu hoặc không đúng với các yêu cầu phần mềm cần thực hiện.
**Failure (Hỏng)** phần mềm không thể thực hiện các chức năng được mô tả trong yêu cầu.
**Incident (Biến Cố)** là những trường hợp hệ thống có những thực thi đáng nghi ngờ những chưa chắc là lỗi.
**Test Case** là đặc tả dữ liệu đầu vào, dữ liệu ra mong muốn, và bản mô tả những điều kiện, các bước để kiểm thử.
**Test Suite** là nhóm các test case hoặc thủ tục kiểm thử có liên quan đến nhau.
**Stub** là một mẫu chương trình mô phỏng hoạt động của thành phần hệ thống đang thiếu.
Driver là một mẫu chương trình gọi test case được thực thi, nhận kết quả và xuất ra.
![image](https://www.differencebetween.info/sites/default/files/images/6/stub-vs-driver.jpg)
[Difference between Stub and Driver](https://www.differencebetween.info/difference-between-stub-and-driver)
**QA (Âulity Asurance)** là những kế hoạch, hoạt động mang tính hệ thống nhầm đảm bảo quá trình phát triển sẽ tạo ra những sản phẩm có chất lượng đáp ứng yêu cầu client.
**QC (Quanlity Control)** là những hoạt động, kỹ thuật nhầm đảm bảo chất lượng sản phẩm.
**Testing** là các hoạt động thực thi chương trình nhầm xác định các lỗi trong sản phẩm phần mềm, không bao gồm việc sửa (fixed) các lỗi đã xác định.

## Các Cấp Độ Kiểm Thử

![image](https://slideplayer.com/slide/14970416/91/images/8/Quy+tr%C3%ACnh+ki%E1%BB%83m+th%E1%BB%AD+ph%E1%BA%A7n+m%E1%BB%81m.jpg)

> Quy trình Kiểm thử phần mềm.

-   Công việc đầu tiên là thiết kế test case.
-   Test Case là đặc tả dữ liệu đầu vào, dữ liệu đầu ra mong muốn, và bản mô tả các bước để kiểm thử.
-   Test Data là những dữ liệu vào có thể lấy để kiểm thử.
-   Sau đó thực thi các Test Case trên hệ thống thực.
-   Dựa trên kết quả so sánh kết quả thực thi bởi hệ thống và kết quả mong muốn được thiết kế trong các test case để viết báo cáo kết quả kiểm thử.

![image](https://haucanit.com/wp-content/uploads/2020/12/cac-muc-do-kiem-thu-1024x576.png)
[Cấp độ kiểm thử trong kiểm thử phần mềm](https://viblo.asia/p/cap-do-kiem-thu-trong-kiem-thu-phan-mem-eW65Gb3PlDO)
[Các loại kiểm thử và Mức độ kiểm thử](https://techmaster.vn/posts/35987/cac-loai-kiem-thu-va-muc-do-kiem-thu-so-sanh-kiem-thu-tu-dong-voi-kiem-thu-thu-cong)

Tương ứng với các giai đoạn trong quy trình phát triển phần mềm có các cấp độ kiểm thử:

> `Unit Test` > `Integration Test` > `System Test` > `Acceptance Test`

### Unit Test

`Một đơn vị (Unit)` là một thành phần nhỏ nhất có thể kiểm thử được, nó có thể là một hàm, một thủ tục, một phương thức, hoặc một lớp. Các đơn vị thường được phát triển độc lập, việc tích hợp được thực hiện ở các giai đoạn sau đó.

`Kiểm thử đơn vị (Unit Test)` dùng kiểm thử trên từng đơn vị riêng rẽ, thường được thực hiện bởi chính lập trình viên phát triển đơn vị đó. Lập trình viên dựa trên đặc tả yêu cầu xác định các đầu vào và đầu ra mong muốn.

Một tiếp cận cho kiểm thử đơn vị là `Test-Driven Development (TDD)`<br/>
Theo tiếp cận này, các test case sẽ được viết trước, sau đó mới viết mã nguồn của đơn vị đó, rồi chạy kiểm thử, thay đổi nếu cần cho đến khi các test case đều chạy thành công (pass).
![image](https://allma.si/blog/wp-content/uploads/2022/08/vitest-coverage-report.png)

[Unit Testing](https://websitehcm.com/unit-testing-la-gi-unit-test-trong-kiem-thu-phan-mem/)

### Integration Test

### System Test

### Acceptance Test
