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
    });

    Revolver.footerPosition();

    $(window).resize(Revolver.footerPosition);

});

Revolver.showAdminContainer = function (name) {
    $('.admin-content').hide();
    $('#' + name).show()
};

Revolver.calculateBodyHeight = function () {
    return $('body').height();
}

Revolver.footerPosition = function () {
    var windowHeight = $(window).height() - 80;

    console.log(windowHeight + ', ' + Revolver.calculateBodyHeight());

    if (windowHeight > Revolver.calculateBodyHeight()) {
        $('footer').addClass('fixed');
    } else {
        $('footer').removeClass('fixed');
    }
}
