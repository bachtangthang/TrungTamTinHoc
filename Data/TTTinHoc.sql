Create database TTTinHoc
go
use TTTinHoc
go
-----------------------------------------------------------
-----------------------------------------------------------
create table HOCVIEN
(
	ID int,
	HoTen nvarchar(40),
	SDT nvarchar(10),
	GioiTinh nchar(3),
	NgaySinh date,
	primary key(ID)
)

create table LOPCHUYENDE	
(
	ID_LopChuyenDe int,
	TenLop nvarchar(40),
	ID_ChuyenDeMo int,
	ID_GiaoVien int,
	HocKy int,
	NamHoc int,
	primary key(ID_LopChuyenDe)
)


create table CHUYENDE
(
	ID_ChuyenDe int,
	TenChuyenDe nvarchar(40),
	GiaTien float,
	primary key(ID_ChuyenDe)
)

create table LICHTHI
(
	ID_LichThi int,
	PhongThi nvarchar(6),
	ThoiGian nvarchar(4),
	ID_LopHocPhan int,
	Ngay date,
	primary key(ID_LichThi)
)


create table GIAOVIEN
(
	ID_GiaoVien int,
	HoTen nvarchar(40),
	SDT nvarchar(10),
	NgaySinh date,
	GioiTinh nchar(3),
	primary key(ID_GiaoVien)
)

create table CHUONGTRINHDAOTAO
(
	ID_ChungChi int,
	TenChungChi nvarchar(40),
	MoTa nvarchar(60),
	primary key(ID_ChungChi)
)


create table HOCPHAN
(
	ID_HocPhan int,
	TenHocPhan nvarchar(40),
	MoTa nvarchar(60),
	primary key(ID_HocPhan)
)

create table MONHOC
(
	ID_MonHoc int,
	HocPhi float,
	Ten nvarchar(40),
	MoTa nvarchar(40),
	ID_HocPhan int,
	primary key(ID_MonHoc)
)

create table HOADON
(
	ID_HoaDon int,
	NguoiThucHien int,
	ID_HocVien int,
	primary key(ID_HoaDon)
)


create table NHANVIEN
(
	ID_NhanVien int,
	Pass nvarchar(10),
	SDT nvarchar(10),
	HoTen nvarchar(40),
	Email nvarchar(40),
	primary key(ID_NhanVien)
)

create table CHITIETHOADON
(
	ID_MonHoc int,
	ID_HD int,
	primary key(ID_HD, ID_MonHoc)
)

create table LOPHOCPHAN
(
	ID_Lop int,
	SoLuong int,
	SoLuongToiDa int,
	TenLop nvarchar(40),
	ID_MonHoc int,
	ID_GiaoVien int,
	HocKy int,
	NamHoc int,
	primary key(ID_Lop)
)

create table HOCVIEN_DANGKY_LOPHOCPHAN
(
	ID_HocVien int,
	ID_Lop int,
	is_Pass bit,
	Diem int,
	primary key(ID_Lop, ID_HocVien)
)

create table GIAOVIEN_MONHOC
(
	ID_GiaoVien int,
	ID_MonHoc int,
	primary key(ID_GiaoVien, ID_MonHoc)
)

create table HOCPHAN_CHUNGCHI
(
	ID_HocPhan int,
	ID_ChungChi int,
	primary key(ID_HocPhan, ID_ChungChi)
)

create table CHITIETHOADONCHUYENDE
(
	ID_HD int, 
	ID_ChuyenDe int,
	primary key(ID_HD, ID_ChuyenDe)
)

create table HOCVIEN_DANGKY_LOPCHUYENDE
(
	ID_HocVien int,
	ID_LopChuyenDe int,
	is_Pass bit,
	Diem int,
	primary key(ID_LopChuyenDe, ID_HocVien)
)

create table HOCVIEN_LICHTHI
(
	ID_HocVien int,
	ID_LichThi int,
	lanthi int,
	ngayDK date,
	diem int,
	primary key(ID_HocVien, ID_LichThi)
)

alter table LOPCHUYENDE	add SoLuong int;
alter table LOPCHUYENDE add SoLuongToiDa int;
-----------------------------------------------------------
-----------------------------------------------------------
alter table HOADON add constraint FK_HOADON_HOCVIEN foreign key (ID_HocVien) references HOCVIEN(ID)
alter table HOADON add constraint FK_HOADON_NHANVIEN foreign key (NguoiThucHien) references NHANVIEN(ID_NhanVien)

alter table CHITIETHOADON add constraint FK_CHITIETHOADON_MONHOC foreign key (ID_MonHoc) references MONHOC(ID_MonHoc)
alter table CHITIETHOADON add constraint FK_CHITIETHOADON_HOADON foreign key (ID_HD) references HOADON(ID_HoaDon) 

alter table HOCPHAN_CHUNGCHI add constraint FK_HOCPHAN_CHUNGCHI_CHUONGTRINHDAOTAO foreign key (ID_ChungChi) references CHUONGTRINHDAOTAO(ID_ChungChi)
alter table HOCPHAN_CHUNGCHI add constraint FK_HOCPHAN_CHUNGCHI_HOCPHAN foreign key (ID_HocPhan) references HOCPHAN(ID_HocPhan)

alter table MONHOC add constraint FK_MONHOC_HOCPHAN foreign key (ID_HocPhan) references HOCPHAN(ID_HocPhan)

alter table GIAOVIEN_MONHOC add constraint FK_GIANGDAY_1 foreign key (ID_MonHoc) references MONHOC(ID_MonHoc)
alter table GIAOVIEN_MONHOC add constraint FK_GIANGDAY_2 foreign key (ID_GiaoVien) references GIAOVIEN(ID_GiaoVien)

alter table LOPCHUYENDE add constraint FK_LOPCHUYENDE_CHUYENDEMO foreign key (ID_ChuyenDeMo) references CHUYENDE(ID_ChuyenDe)
alter table LOPCHUYENDE add constraint FK_LOPCHUYENDE_GIAOVIEN foreign key (ID_GIAOVIEN) references GIAOVIEN(ID_GiaoVien)

alter table LICHTHI add constraint FK_LICHTHI_LOPHOCPHAN foreign key (ID_LOPHOCPHAN) references LOPHOCPHAN(ID_Lop)

alter table LOPHOCPHAN add constraint FK_LOPHOCPHAN_GIAOVIEN foreign key (ID_GiaoVien) references GIAOVIEN(ID_GiaoVien)
alter table LOPHOCPHAN add constraint FK_LOPHOCPHAN_MONHOCMO foreign key (ID_MonHoc) references MONHOC(ID_MonHoc)

alter table HOCVIEN_DANGKY_LOPHOCPHAN add constraint FK_DANGKYHOCPHAN_1 foreign key (ID_HocVien) references HOCVIEN(ID)
alter table HOCVIEN_DANGKY_LOPHOCPHAN add constraint FK_DANGKYHOCPHAN_2 foreign key (ID_Lop) references LOPHOCPHAN(ID_Lop)

alter table HOCVIEN_DANGKY_LOPCHUYENDE add constraint FK_DANGKYCHUYENDE_1 foreign key (ID_HocVien) references HOCVIEN(ID)
alter table HOCVIEN_DANGKY_LOPCHUYENDE add constraint FK_DANGKYCHUYENDE_2 foreign key (ID_LopChuyenDe) references LOPCHUYENDE(ID_LopChuyenDe)

alter table CHITIETHOADONCHUYENDE add constraint FK_CHITIETHOADONCUCHUYENDE_1 foreign key (ID_ChuyenDe) references CHUYENDE(ID_ChuyenDe)
alter table CHITIETHOADONCHUYENDE add constraint FK_CHITIETHOADONCUCHUYENDE_2 foreign key (ID_HD) references HOADON(ID_HoaDon)

alter table HOCVIEN_LICHTHI add constraint FK_DK_THI_1 foreign key (ID_LichThi) references LICHTHI(ID_LichThi)
alter table HOCVIEN_LICHTHI add constraint FK_DK_THI_2 foreign key (ID_HocVien) references HOCVIEN(ID)




