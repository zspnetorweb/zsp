function Logout() {
    swal({
        title: "确认注销该账号吗？",
        text: "注销后需重新登录",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "是",
        cancelButtonText: "否",
        closeOnConfirm: false
    },function() {
        $.get(
            "/Admin/Logout",
            {},
            function(data) {
                if (data.Code !== 0) {
                    swal({
                        title: data.Title,
                        text: data.Content,
                        type: "success",
                        showConfirmButton:false
                    });
                    setTimeout("location.href = '/Member/Index'",500);
                } else
                    swal(data.Title, data.Content, "error");
            }
            );
    });
}