
//function ChangeProfile() {
//  var x = document.createElement("INPUT");
//  x.setAttribute("type", "text");
//  x.setAttribute("value", "Hello World!");
//  document.body.appendChild(x);
//}
function ChangeProfile(divSelector, value) {
  
    if (divSelector == "phone" && document.querySelector(".change--phone") == null) {
        //var para = document.getElementById(divSelector).innerHTML;
        var x = document.createElement("INPUT");
        x.setAttribute("type", "text");
        //x.setAttribute("value", para);
        x.setAttribute("id", "phone-new");
        x.setAttribute("value", value);
        x.setAttribute("class", "form-item__shopname-output form-item__shopname-output--input-change change--phone");
        x.setAttribute("name", "newphone");
        console.log(x);
        document.getElementById(divSelector).innerHTML = '';
        document.getElementById(divSelector).appendChild(x);
    }
}
function CheckName() {
    var name = document.getElementById('name').value;
    if (name.trim() == '') {
        $('#err-name').show();
        return false;
    }
    $('#err-name').hide();
    return true;
}
function CheckCity() {
    var city = document.getElementById('city').value;
    if (city.trim() == '')
    {
        $('#err-city').show();
        return false;
    }
    $('#err-city').hide();
    return true;
}
function CheckAddress() {
    var address = document.getElementById('address').value;
    if (address.trim() == '') {
        $('#err-address').show();
        return false;
    }
    $('#err-address').hide()
    return true;
}
function CheckPhone() {
    var phone = document.getElementById('phone').value;
    if (phone.trim() == '') {
        $('#err-phone').show();
        return false;
    }
    $('#err-phone').hide();
    return true;
}
function Validation() {
    var check = true;
    if (CheckAddress()==false) {
        check = false;
    }
    if (CheckCity()==false) {
        check = false;
    }
    if (CheckName()==false) {
        check = false;
    }
    if (CheckPhone()==false) {
        check=false
    }
    return check;
}

function submitProfile() {
    if (Validation()==true) {
        document.getElementById('submit-btn').className = document.getElementById('submit-btn').className.replace(" disabled", "");
        document.getElementById('form-profile').submit();
    }
    else {
        document.getElementById('submit-btn').className += ' disabled';
    }
    return;
}

function doDelete(id) {
    let text;
    let path;
    if (confirm("Bạn muốn xóa sản phẩm này?") == true) {
        text = "Sản phẩm đã được xóa";
        path = 'delete?id=' + id;
        window.location.href = path;
    }
}


function ShipFunction() {
    var id = document.getElementById("mySelect").value;
    if (id == 1) {
        document.getElementById("sname").innerHTML = "Tên shipper:Bùi Xuân Huấn";
        document.getElementById("sphone").innerHTML = "Số điện thoại:07888899999";
    }
    else {
        document.getElementById("sname").innerHTML = "Tên Shipper:Dương Minh Tuyền";
        document.getElementById("sphone").innerHTML = "Số điện thoại:0924999888";
    }
}


function CheckRepass() {
    var e = document.getElementById('re_new_pass').value;
    var newpass = document.getElementById('new_pass').value;
    if (e != newpass && e.trim() != '') {
        $('#err-re-newpass').show();
        return false;
    }
    $('#err-re-newpass').hide();
    return true;
}
function CheckNewPass() {
    var e = document.getElementById('new_pass').value;
    var old_pass = document.getElementById('old_pass').value;
    if (e == old_pass && old_pass.trim() != '') {
        $('#err-newpass').show();
        return false;
    } else {
        $('#err-newpass').hide();
        return true;
    }
}
function Validate_passform() {
    var check = true;
    //if (CheckNewPass()==false) {
    //    check = false;
    //}
    if (!CheckRepass()) {
        check = false;
    }
    if (check == false) {
        $('#change-btn').prop('disabled', true);
    } else {
        $('#change-btn').prop('disabled', false);
    }
}