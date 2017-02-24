angular.module("shoppingCart").factory("shoppingCartService", ["$resource", function ($resource) {

    return $resource("/api/Home");
}]);