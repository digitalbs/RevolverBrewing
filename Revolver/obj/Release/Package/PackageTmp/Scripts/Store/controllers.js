'use strict';

/* Controllers */


function AdminCtrl($scope, $http) {
    $scope.product = {};
    //get products
    $http.get(baseUri).success(function (data) {
        $scope.products = data;
    });

    //get product to update
    $scope.getProduct = function () {
        var selectedProduct = $('#sltUpdateProduct').val();
        if (selectedProduct !== "") {
            $('#updateAdmin li:eq(1) a').tab('show');
            $('#updateAdmin li:eq(1)').removeClass('disabled');
            $('.tab-content article:eq(0)').removeClass('in active');
        }
        $http.get(baseUri + '/' + selectedProduct).success(function (data) {
            $scope.product = data;
            $('.updateProduct').show();
        });

    };


    //submit product
    $scope.createProduct = function () {
        $http.post(baseUri, $scope.product).success(function (data) {
            $scope.products.push(data);
            alert(data.Name + ' has been created.');
        });
    }

    //update product
    $scope.updateProduct = function (product) {
        $http.put(baseUri + '/' + product.Id, product).success(function (data) {
            alert(product.Name + ' has been updated!');
        });
    }

    $scope.deleteProduct = function (product) {
        $http.delete(baseUri + '/' + product.Id).success(function (data) {
            $('.updateProduct').hide();
            alert(product.Name + ' is removed');
            $http.get(baseUri).success(function (data) {
                $scope.products = data;
            });
        });
    }
}
AdminCtrl.$inject = ['$scope', '$http'];


function MyCtrl2() {
}
MyCtrl2.$inject = [];
