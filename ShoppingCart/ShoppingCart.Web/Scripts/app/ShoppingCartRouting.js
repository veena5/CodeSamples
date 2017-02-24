angular.module("shoppingCart").config(["$stateProvider", "$urlRouterProvider", function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise("/Home");

    $stateProvider
    .state("home", {
        url: "/Home",
        templateUrl:"Home/Home"
    })
    .state("items", {
        url: "/Home/Items",
        templateUrl:"Home/ItemsList"
    })
    .state("itemsDetails", {
        url: "/Home/Items/ItemsDetails",
        templateUrl:"Home/ItemsDetails"
    })
    .state("cart", {
        url:"/Home/Cart",
        templateUrl:"Home/Cart"
    })

}]);