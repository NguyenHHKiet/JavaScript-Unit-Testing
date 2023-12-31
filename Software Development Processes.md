# Các Quy Trình Phát Triển Phần Mềm

Quy trình phát triển phần mềm là các giai đoạn mà phát triển phần mềm phải trải qua để sản xuẩt phát triển phần mềm, mỗi giai đoạn phải được xác định rõ ràng:

> `1. Mục tiêu` > `2. Kết quả đạt được của giai đoạn trước` > `3. Kết quả chuyển giai cho giai đoạn tiếp theo`

Thực tế có nhiều quy trình phát triển phần mềm khác nhau, nhưng nhìn chung các quy trình phát triển phần mềm đều có các giai đoạn sau:

<ol>
<li>Đặc tả phần mềm (Software Specification): xác định các chức năng và ràng buộc của phần mềm.</li>
<li>Thiết kế và thực hiện phần mềm (Software Design & Implementation): phần mềm được phát triển theo đúng thiết kế được xác định.</li>
<li>Kiểm tra phần mềm (Software Validation): kiểm tra phần mềm đáp ứng những gì khánh hàng muốn.</li>
<li>Tiến hóa phần mềm (Software Evolution): phần mềm phát triển theo sự thay đổi yêu cầu của khánh hàng.</li>
</ol>

Các quy trình phát triển phần mềm thường được chia thành: Quy trình có kế hoạch (Plan-Driven Process) và Quy trình phát triển nhanh (Agile Process)

<ul>
<li>Quy trình có kế hoạch (Plan-Driven): là quy trình mà tất cả các hoạt động đã được lên kế hoạch trước và tiến độ được xác định thông qua kế hoạch này.</li>
<li>Quy trình phát triển nhanh (Agile): là quy trình có các kế hoạch tăng trưởng dần, quy trình này dễ dàng đáp ứng được những thay đổi yêu cầu thường xuyên của khách hàng.</li>
</ul>

[Truy cập Các Mô hình >](https://viblo.asia/p/cac-mo-hinh-phat-trien-phan-mem-GrLZDwbgKk0)

![image](https://cs.ccsu.edu/~stan/classes/CS410/Notes16/images/03-plan_vs_agile.png)

<h3>Quy trình Thác nước (Waterfall Model)</h3>

![image](https://amela.vn/wp-content/uploads/2021/04/waterfall-01-scaled.jpg)

[Truy cập >](https://www.google.com.vn/url?sa=i&url=https%3A%2F%2Famela.vn%2Fban-hieu-gi-ve-mo-hinh-thac-nuoc-waterfall-model-trong-phat-trien-phan-mem%2F&psig=AOvVaw38QDOaQrKTpbbKa_gMrOSf&ust=1702548333834000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCPj2v5aVjIMDFQAAAAAdAAAAABAD)

<h3>Quy trình Lặp (Iterative Process)</h3>

![image](https://images.viblo.asia/630b42b1-ba62-4605-bc18-39498a219f7c.JPG)

<p>Quy trình Lặp (Iterative Process) phát triển phần mềm theo nhiều vòng lặp, mỗi vòng lặp sẽ cho ra các phiên bản khác nhau của phần mềm. Kết thúc mỗi vòng lặp sẽ được đánh giá, cải thiện để xác định yêu cầu cho phiên bản của vòng lặp tiếp theo. Quy trình này lặp lại cho đến khi sản phẩm phần mềm hoàn thành.</p>

<h3>Quy trình tăng trưởng (Incremental)</h3>

![image](https://images.viblo.asia/e3b5ff8b-0a14-4cc0-bbdd-0708de254017.JPG)

<p>Quy trình tăng trưởng (Incremental) chia hệ thống thành các thành phần nhỏ để phát triển, mỗi thành phần áp dụng quy trình thác nước hoặc một quy trình nào đó để tiến hành phát triển.</p>

<h3>Quy trình Scrum</h3>
<p>Quy trình Scrum là một quy trình phát triển phần mềm theo mô hình linh hoạt, scrum chia dự án thành nhiều vòng lặp phát triển gọi là Sprint, mỗi Sprint kéo dài từ 2 đến 4 tuần. Quy trình này phù hợp với những dự án có nhiều thay đổi và yêu cầu tốc độ phát triển cao.</p>

<strong><em>Các Tài Liệu</em></strong>

-   `Product Backlog` là danh sách ưu tiên các chức năng tồn tại trong suốt quy trình phát triển phần mềm chỉ có một tài liệu Product Backlog cho một sản phẩm.
-   `Sprint Backlog` là danh sách các chức năng ưu tiên (lấy từ Product Backlog) cần hoàn tấtt trong 1 Sprint.

<strong><em>Các Vai Trò</em></strong>

-   `Product Owner` người khởi động dự án, tạo ra các chức năng dự án, quyết định các chức năng, đáng giá độ ưu tiên của từng nhiệm trong Product Backlog. Vai trò này thường là client hoặc người đại diện cho client.
-   `Scrum Master` người có nhiệm vụ đảm bảo Sprint hoàn thành đúng mục tiêu, giải quyết các xung đột, trở ngại, cũng như bảo vệ nhóm phát triển.
-   `Nhóm phát triển (Developer Team)` là những thành viên tham gia vào cài đặt các chức năng theo yêu cầu, quản lý Sprint Backlog, giữa các thành viên trong nhóm có vai trò như nhau, tự quản lý, tổ chức công việc sao cho hiệu quả nhất.

<strong><em>Các Buổi Họp</em></strong>

<p>
    Trong Scrum sẽ có nhiều cuộc họp (Meeting) quan trọng để thực hiện quy trình bao gồm Sprint Plainning Meeting, Daily Scrum Meeting, Sprint Review, Sprint Retrosoective.<br/>
    Trước khi bắt đầu một Sprint, nhóm phát triển (Dev) họp với Prodcut Owner đầu mỗi Sprint để lên kế hoạch cho Sprint bao gồm: 
    <ol>
    <li>Chọn.</li>
    <li>Phân tích các yêu cầu cần phát triển.</li>
    <li>Ước lượng thời gian thực hiện.</li>
    </ol>
    Cuộc họp này là Sprint Plainning Meeting.
</p>

![image](https://i0.wp.com/quanlyduan.edu.vn/wp-content/uploads/2015/07/Quy-trinh-scrum-1.png)

[Quy trình Scrum – các hoạt động Scrum](http://quanlyduan.edu.vn/quy-trinh-scrum-cac-hoat-dong-scrum/)

## Author

[Qliphort Shell](https://github.com/nguyenhhkiet)
