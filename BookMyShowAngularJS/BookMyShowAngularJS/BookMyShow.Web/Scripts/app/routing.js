angular.module("bookMyShow").config(["$stateProvider", "$urlRouterProvider", function ($stateProvider, $urlRouterProvider) {
    
    $urlRouterProvider.otherwise("/Home");

    $stateProvider
    .state("home", {
        url:"/Home",
        templateUrl:"Home/Home"
    })

}]);