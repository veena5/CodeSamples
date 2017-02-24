var app = angular.module('app', []);
app.controller('MainCtrl', function($scope) {
    $scope.title = 'Temperature Monitor App';
    $scope.temperatureMonitor= {};
    $scope.temperature=undefined;
    $scope.median=undefined;
    $scope.temp=[];
    $scope.temperatureMonitor.recordTemperature = function()
    {
      
      $scope.temp.push($scope.temperature);
      $scope.temperature=undefined;
    }

    $scope.temperatureMonitor.getCurrentMedian = function()
    {
      
       $scope.temp.sort( function(a,b) {return a - b;} );

    var half = Math.floor($scope.temp.length/2);

    if($scope.temp.length % 2)
      $scope.median= $scope.temp[half];
    else
      $scope.median= ($scope.temp[half-1] + $scope.temp[half]) / 2.0;
    }
    
  
  });
