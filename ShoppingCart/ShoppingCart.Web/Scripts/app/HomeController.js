/// <reference path="AngularJs/angular.min.js" />
angular.module("shoppingCart").controller("HomeController", ["$scope", "$state", "shoppingCartService", function ($scope, $state, shoppingCartService) { 

    $scope.cart = [];
    $scope.recentlyViewed = [];
    
    var getProducts = function () {
        shoppingCartService.query(function (data) {
            angular.forEach(data, function (product) {
                product.quantity = 1;
                product.viewCount = 0;
            });
            $scope.productsList = data;

        }, function () {
            alert("Sorry Unable to Retrive Products Info")
        });
    }

    var init = function () {
        getProducts();
    }
    $scope.totalPrice = function () {
        $scope.total = 0;
        angular.forEach($scope.cart, function (product) {
            $scope.total += product.quantity * product.price;
        });
    }
    $scope.showItems = function (category, brand) {
        shoppingCartService.query({ category: category, brand: brand }, function (data) {
            angular.forEach(data, function (product) {
                product.quantity = 1;
                product.viewCount = 0;
            });
            $scope.itemsList = data
        }, function () {
            alert("Sorry Unable Retirve Items");
        });
    }
    var addToRecentlyViewed = function (product) {

      var viewedProduct = $.grep($scope.recentlyViewed, function (products, i) {
            return products.id == product.id;
        })[0];
  
      var index = $scope.recentlyViewed.indexOf(viewedProduct);

      if (index >= 0) {
          $scope.recentlyViewed[index].viewCount += 1;
      }
      else {
          product.viewCount += 1;
          $scope.recentlyViewed.push(product);
      }
    }

    $scope.itemDetails=function(product)
    {
        $state.go("itemsDetails");
        $scope.product = product;
        addToRecentlyViewed(product);
    }
    $scope.addToCart = function (contact) {
        $scope.cart.push(contact);
        $scope.cartSize = $scope.cart.length;
    }
    $scope.viewCart = function () {
        $scope.totalPrice();
    }

    $scope.remove = function (product) {
        var index = $scope.cart.indexOf(product);
        $scope.cart.splice(index, 1);
        $scope.cartSize = $scope.cart.length;
    }
    $scope.pay = function () {
        $scope.cart.length = 0;
        $scope.cartSize = 0;
        alert("Payment Successfull");
    }
    
    init();

}]);