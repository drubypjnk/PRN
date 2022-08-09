

function Addtocart() {
    document.getElementById('form-product').submit();
}
function Checkquantity(min, max) {
    var x = document.getElementById('text');
    var y = document.getElementById('uncreament')
    var z = document.getElementById('creament')
    console.log()
    if (x.value < min) {
        x.value = min
        z.className += ' disabled'
    }
    if (x.value > max) {
        x.value = max
        y.className += ' disabled'
    }
    if (x.value <= max && x.value >= min) {
        y.className = y.className.replace(" disabled", "");
        z.className=z.className.replace(" disabled", "");
    }
}
function SubmitNote() {
    var note = document.getElementById('note').value;
    var order_id = document.getElementById('order_id').value;
  
    $.ajax({
        type: "POST",
        url: "/Admin/AddNote",
        data: {
            order_id: order_id,
            note: note
        },
        dataType: "text",
        success: function (data) {
            console.log(data);
            $('#content').empty().append(data);
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });
}


function ChangeStatus() {
    status = $("#status option:selected").val();
    if (status == 0) {
        note = "Chuyển sang trạng thái Hủy đơn hàng";
    } else if (status == 1) {
        note = "Chuyển sang trạng thái. Chờ xác nhận!";
    } else if (status == 2) {
        note = "Đã xác nhận đơn hàng. \n Chờ vận chuyển";
    } else if (status == 3) {
        note = "Đơn đang được giao. \n Chờ Hoàn thành ";
    } else {
        note = "Đơn hàng đã hoàn thành";
    }
    if (status > 0) {
        $("button").prop("disabled", false); //unlock
    } else {
        $("button").prop("disabled", false); //lock
    }
    
    var order_id = document.getElementById('order_id').value;
    $.ajax({
        type: "POST",
        url: "/Admin/AddNote",
        data: {
            order_id: order_id,
            note: note
        },
        dataType: "text",
        success: function (data) {
            console.log(data);
            $('#content').empty().append(data);
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });

    //update status
    $.ajax({
        type: "POST",
        url: "/Order/ChangeOrderStatus",
        data: {
            order_id: order_id,
            status: status
        },
        dataType: "text",
        success: function (data) {
            //console.log(data);
            //$('#content').empty().append(data);
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });
}