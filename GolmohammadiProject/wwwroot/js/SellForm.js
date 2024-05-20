$(document).ready(function () {
    ShowCustomerData();
    ShowProductData();
})

//Get Data
function ShowCustomerData() {
    $.ajax({
        url: 'Factor/GetCustomer',
        type: 'Get',
        dataType: 'json',
        contentType: 'application/json',
        success: function (result, statu, xhr) {
            var object = "";
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.customer.name + '</td>';
                object += '<td>' + item.customer.address + '</td>';
                object += '<td>' + item.customer.city + '</td>';
                object += '<td>' + item.customer.region + '</td>';
                object += '</tr>';
            });
            $('#table_data_customer').html(object);
        },
        error: function () {
            alert("Data Can Not Get");
        }
    });
};

function ShowProductData() {
    $.ajax({
        url: 'Factor/GetProduct',
        type: 'Get',
        dataType: 'json',
        contentType: 'application/json',
        success: function (result, statu, xhr) {
            var object = "";
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.product.name + '</td>';
                object += '<td>' + item.priceUnit + '</td>';
                object += '<td>' + item.unit + '</td>';
                object += '<td>' + item.totalPrice + '</td>';
                object += '</tr>';
            });
            $('#table_data_product').html(object);
        },
        error: function () {
            alert("Data Can Not Get");
        }
    });
};



function Create() {
    var result = Validate();
    if (!result) {
        return false;
    }

    //var formData = new Object();

    //formData.customerId = $('#CustomerId').val(),
    //formData.productId = $('#ProductId').val(),
    //formData.id = $('#Id').val(),
    //formData.price = $('#PriceUnit').val(),
    //formData.unit = $('#Unit').val(),
    //formData.totalPrice = $('#TotalPrice').val()

    var formData = {
        Id: $('#Id').val(),
        CustomerName: $('#CustomerName').val(),
        ProductName: $('#ProductName').val(),
        PriceUnit: $('PriceUnit').val(),
        Unit: $('Unit').val(),
        TotalPrice: $('TotalPrice').val()
    };

    $.ajax({
        url: 'Factor/Create',
        data: formData,
        type: 'Post',
        success: function (response) {
            //if (!response || response == undefined || response.length == 0) {
            //    alert('Unable to save the data');
            //}
            if (!response) {
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

    if ($('#PriceUnit').val().trim() == "") {
        $('#PriceUnit').css('border-color', 'red');
        isValid = false;
    }
    else {
        $('#PriceUnit').css('border-color', 'lightgrey');
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

