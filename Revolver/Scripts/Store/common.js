var Revolver = {};
$(function () {
    $('#btnNewProduct').on('click', function () {
        Revolver.showAdminContainer('newProduct');
    });

    $('#btnUpdateProduct').on('click', function () {
        Revolver.showAdminContainer('updateProduct');
    });

    $('#updateAdmin a').click(function (e) {
        e.preventDefault();
        //do not allow user to update product unless they select a product
        if ($('#sltUpdateProduct').val() === "")
            return false;

        $(this).tab('show');
        

    })
});

Revolver.showAdminContainer = function (name) {
    $('.admin-content').hide();
    $('#' + name).show()
};