USE [QLSV]
GO

-- 1. TẠO DỮ LIỆU LỚP HỌC (10 LỚP)
INSERT INTO [dbo].[LOP] ([MALOP], [TENLOP]) VALUES
('L001', 'Cong Nghe Thong Tin 1'),
('L002', 'Cong Nghe Thong Tin 2'),
('L003', 'He Thong Thong Tin'),
('L004', 'Ky Thuat Phan Mem'),
('L005', 'An Toan Thong Tin'),
('L006', 'Quan Tri Kinh Doanh 1'),
('L007', 'Quan Tri Kinh Doanh 2'),
('L008', 'Ke Toan Doanh Nghiep'),
('L009', 'Ngon Ngu Anh 1'),
('L010', 'Ngon Ngu Anh 2');

-- 2. TẠO DỮ LIỆU MÔN HỌC (15 MÔN)
INSERT INTO [dbo].[MONHOC] ([MAMH], [TENMH], [SOTIET_LT], [SOTIET_TH]) VALUES
('MH01', 'Co So Du Lieu', 45, 15),
('MH02', 'Cau Truc Du Lieu', 45, 15),
('MH03', 'Lap Trinh C#', 30, 30),
('MH04', 'Toan Roi Rac', 45, 0),
('MH05', 'Mang May Tinh', 45, 15),
('MH06', 'He Dieu Hanh', 45, 0),
('MH07', 'Tieng Anh Giao Tiep', 45, 0),
('MH08', 'Kinh Te Vi Mo', 45, 0),
('MH09', 'Phap Luat Dai Cuong', 30, 0),
('MH10', 'Lap Trinh Web', 30, 30),
('MH11', 'Tri Tue Nhan Tao', 45, 15),
('MH12', 'Ky Thuat Do Hoa', 30, 30),
('MH13', 'Xac Suat Thong Ke', 45, 0),
('MH14', 'Triet Hoc Mac-Lenin', 45, 0),
('MH15', 'Nhap Mon Quan Tri', 45, 0);

-- 3. TẠO DỮ LIỆU SINH VIÊN (Dùng vòng lặp tạo 100 sinh viên ngẫu nhiên)
DECLARE @i INT = 1;
DECLARE @MaLop CHAR(8);
DECLARE @Ho VARCHAR(40);
DECLARE @Ten VARCHAR(10);
DECLARE @Phai CHAR(3);

WHILE @i <= 100
BEGIN
    SET @MaLop = 'L00' + CAST(((@i % 10) + 1) AS CHAR(1)); -- Phân bổ đều vào 10 lớp
    SET @Phai = CASE WHEN @i % 2 = 0 THEN 'nam' ELSE 'nu' END;
    
    SET @Ho = CASE (@i % 5)
        WHEN 0 THEN 'Nguyen Van'
        WHEN 1 THEN 'Tran Thi'
        WHEN 2 THEN 'Le Hoang'
        WHEN 3 THEN 'Pham Minh'
        ELSE 'Vu Duc' END;
        
    SET @Ten = CASE (@i % 4)
        WHEN 0 THEN 'Anh'
        WHEN 1 THEN 'Binh'
        WHEN 2 THEN 'Cuong'
        ELSE 'Dung' END;

    INSERT INTO [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [PHAI], [NOISINH], [DIACHI], [NGHIHOC], [MALOP])
    VALUES (
        'SV' + RIGHT('000' + CAST(@i AS VARCHAR(3)), 3), 
        @Ho, 
        @Ten + CAST(@i AS VARCHAR(3)), 
        DATEADD(DAY, -(RAND()*365*5 + 18*365), GETDATE()), -- Độ tuổi SV 18-23
        @Phai, 
        'TP. Ho Chi Minh', 
        'Quan ' + CAST((@i % 12 + 1) AS VARCHAR(2)), 
        0, 
        @MaLop
    );
    SET @i = @i + 1;
END

-- 4. TẠO DỮ LIỆU ĐIỂM SỐ (Mỗi SV đăng ký ngẫu nhiên 3 môn học)
DECLARE @sv_id INT = 1;
DECLARE @mh_id INT;

WHILE @sv_id <= 100
BEGIN
    SET @mh_id = 1;
    WHILE @mh_id <= 3 -- Mỗi sinh viên có điểm cho 3 môn đầu tiên để test
    BEGIN
        INSERT INTO [dbo].[ChiTiet_DangKy_Diem] ([MASV], [MAMH], [LAN], [HOCKY], [DIEM])
        VALUES (
            'SV' + RIGHT('000' + CAST(@sv_id AS VARCHAR(3)), 3),
            'MH0' + CAST(@mh_id AS VARCHAR(1)),
            1, -- Lần thi 1
            1, -- Học kỳ 1
            ROUND(RAND() * 10, 1) -- Điểm ngẫu nhiên từ 0-10
        );
        SET @mh_id = @mh_id + 1;
    END
    SET @sv_id = @sv_id + 1;
END
GO