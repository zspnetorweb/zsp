function Register() {
    var UserName = $("input[name=UserName]").val();
    var Password = $("input[name=Password]").val();
    var RePassword = $("input[name=RePassword]").val();
    var Phone = $("input[name=Phone]").val();
    if (UserName === "" || UserName.length < 5 || UserName.length > 8) {
        swal("", "请输入用户名且长度在5到8个字符之间", "warning");
        return;
    }
    if (Password === "" || Password.length < 6 || Password.length > 10) {
        swal("", "请输入密码且长度在6到10个字符之间", "warning");
        return;
    }
    if (RePassword === "") {
        swal("", "请再次输入密码", "warning");
        return;
    }
    if (RePassword !== Password) {
        swal("", "两次密码不一致", "warning");
        return;
    }
    if (Phone === "" || Phone.length !== 11) {
        swal("", "请输入手机号码，长度为11位", "warning");
        return;
    }
    $.post(
        "/Member/Register",
        {
            UserName: UserName,
            Password: Password,
            Phone: Phone
        },
        function (data) {
            if (data.Code !== 0) {
                swal({
                    title: data.Title,
                    text: data.Content,
                    type: "success",
                    showConfirmButton: false
                });
                setTimeout("location.href='/Member/Login'", 500);
            } else {
                swal(data.Title, data.Content, "error");
            }
        }
        );
}