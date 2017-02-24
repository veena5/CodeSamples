/// <reference path="../angular.min.js" />

angular.module("bookMyShow").factory("bookMyShowService",["$resource", function ($resource) {

    return $resource("/api/Home/:action/:id/:bookingInfo", { action: '@action', id: '@id',bookingInfo:'@bookingInfo' });

}]);
    