/**
 * Created by Sandeep Reddy on 7/15/2015.
 */

var signupApp = angular.module('signupApp', []);

signupApp.controller('AppCtrl', ['$scope', function($scope) {
    $scope.password = null;
    $scope.passwordConfirmation = null;
    $scope.user = {};
    $scope.submit = function()
    {
       window.alert("Form submitted");
       location.reload();
       console.log($scope.user);
    }
}]);

signupApp.directive('passwordConfirm', ['$parse', function ($parse) {
    return {
        restrict: 'A',
        scope: {
            matchTarget: '=',
        },
        require: 'ngModel',
        link: function link(scope, elem, attrs, ctrl) {
            var validator = function (value) {
                ctrl.$setValidity('match', value === scope.matchTarget);
                return value;
            }

            ctrl.$parsers.unshift(validator);
            ctrl.$formatters.push(validator);

            // This is to force validator when the original password gets changed
            scope.$watch('matchTarget', function(newval, oldval) {
                validator(ctrl.$viewValue);
            });

        }
    };
}]);

/*CustomersController.$inject = ['$scope'];

angular.module('customersApp')
    .controller('CustomersController', CustomersController);
*/
