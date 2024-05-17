

function Create() {
    var result = Validate();
    if (result == false) {
        return false;
    }

    var formData = new Object();
    formData.id = $('#Id').val();
    formData.price = $('#Price').val();
    formData.unit = $('#Unit').val();
    formData.totalPrice = $('#TotalPrice').val();

    $.ajax({
        url: 'Factor/Create',
        data: formData,
        type: 'Post',
        success: function (response) {
            if (response == null || response == undefined || response.length == 0) {
                alert('Unable to save the data');
            }
            else {
                alert(response);
            }
        },
        error: function () {
            alert('Unable to save the data');
        }

    });
}


function Validate() {
    var isValid = true;

    if ($('#Price').val().trim() == "") {
        $('#Price').css('border-color', 'red');
        isValid = false;
    }
    else {
        $('#Price').css('border-color', 'lightgrey');
    }

    if ($('#Unit').val().trim() == "") {
        $('#Unit').css('border-color', 'red');
        isValid = false;
    }
    else {
        $('#Unit').css('border-color', 'lightgrey');
    }

    if ($('#TotalPrice').val().trim() == "") {
        $('#TotalPrice').css('border-color', 'red');
        isValid = false;
    }
    else {
        $('#TotalPrice').css('border-color', 'lightgrey');
    }
    return isValid;
}

