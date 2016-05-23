$('#CategoryID').change(function () {
    var selectedItem = $(this).val();
    //GetProductByCategory(selectedItem);
    $.ajax({
        type: 'GET',
        //url: '@Url.Action("GetProductByCategory", "Region")?CategoryId=' + categoryId,
        url: '@Url.Action("GetProductByCategory", "Region")',
        data: { categoryId: selectedItem },
        success: function (data) {
            alert(data);
            product.html('');
            $.each(data, function (id, option) {
                product.append($('<option></option>').val(option.id).html(option.name));
            });
        },
        error: function () {
            alert("erorr");
        }
    });
   
});

//function GetProductByCategory(categoryId) {
//    //alert('Came on function');
//    var product = $('#ProductID');

//    $.ajax({
//        type: 'GET',
//        //url: '@Url.Action("GetProductByCategory", "Region")?CategoryId=' + categoryId,
//        url: '@Url.Action("GetProductByCategory", "Region")',
//        data: { categoryId: selectedItem },
//        success: function (data) {
//            alert(data);
//            product.html('');
//            $.each(data, function (id, option) {
//                product.append($('<option></option>').val(option.ProductID).html(option.ProductName));
//            });
//        },
//        error: function () {
//            alert("erorr");
//        }
//    });
//}