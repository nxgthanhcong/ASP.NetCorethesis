var stt = ($('button[name=update_brand_stt]').attr('data-stt'));
stt = JSON.parse(stt.toLowerCase());

$('button[name=update_brand_stt]').on('click', function () {
    var id = $(this).attr('data-id');
    

    $.ajax({
        method: "POST",
        url: "../api/brand_api/UpdateStatus",
        contentType: 'application/json;charset=UTF-8',
        data: JSON.stringify({ "ma": parseInt(id), "stt": stt }),
        success: function (msg) {
            if (msg == '0') {
                alert("Cập nhập thất bại!!");
            }
            else {
                var r = JSON.parse(msg);
                if (r.stt == "True") {
                    $('button[name=update_brand_stt][data-id=' + r.id + ']').html('Ẩn');
                    $("#" + id).prop("checked", true);
                    stt = !stt;
                }
                else {

                    $('button[name=update_brand_stt][data-id=' + r.id + ']').html('Hiện');
                    $("#" + id).prop("checked", false);
                    stt = !stt;
                }
            }
        },
        error: function (err) {
            console.log(err)
        }

    })
})
//function get1Brand(id) {
//    //alert("dss");
//    $.ajax({
//        method: "GET",
//        url: "../api/brand_api/GetBrand/" + id,

//        success: function (data) {

//            //alert(data["name"] + " "+ data["status"]);
//        }
//    })
//}




function readURL(input, idImg) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $(idImg).attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]); // convert to base64 string
    }
}

$("#ful").change(function () {
    readURL(this, '#imgPre');
    $('#myModal').modal(options);

    // Example:

  
});
