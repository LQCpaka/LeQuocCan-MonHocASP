<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKyThanhVien.aspx.cs" Inherits="Lab02.DangKyThanhVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2 class="text-center">HỒ SƠ ĐĂNG KÝ</h2>
            <div class="row border border-primary bg-nen1">
                <div class="col-md-8 p-2 text-center">
                    Thông tin đăng ký
                </div>
                <div class="col-md-4 p-2 text-center border-left border-primary">
                    Hồ sơ đăng nhập
                </div>
            </div>

            <div class="row border border-primary">
                <div class="col-md-8">
                    <div class="row mt-2 mb-2">
                        <div class="col-md-3">
                            Tên Đăng Nhập
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtTenDangNhap" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row mb-2">
                        <div class="col-md-3">
                            Mật Khẩu
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtMatKhau" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row mb-2">
                        <div class="col-md-3">
                            Nhập Lại Mật Khẩu
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtNhapLaiMatKhau" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                
            </div>
        </div>
    </form>
</body>
</html>
