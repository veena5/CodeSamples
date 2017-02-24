(function() {
    
    var app = angular.module('customersApp', ['ngRoute','signupApp','pwdMatch']);
    
    app.config(function($routeProvider) {
        $routeProvider
            .when('/buddys', {
                controller: 'BuddysController',
                templateUrl: 'app/views/buddys.html'
            })
            .when('/bio/:customerId', {
                controller: 'BioController',
                templateUrl: 'app/views/bio.html'
            })
            .when('/', {
                controller: 'AppCtrl',
                templateUrl: 'app/views/signup.html'
            })
            .otherwise( { redirectTo: '/' } );
    });
    
}());
