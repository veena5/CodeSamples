
describe("Sample Test Suite", function() {
 beforeEach(module('app'));

  var $controller;

  beforeEach(inject(function(_$controller_){
    // The injector unwraps the underscores (_) from around the parameter names when matching
    $controller = _$controller_;
  }));



  describe('$scope.grade', function() {
    var $scope, controller;

    beforeEach(function() {
      $scope = {};
      controller = $controller('MainCtrl', { $scope: $scope });
    });

  it("sample thrutiness test", function() {
    expect(true).toBeTruthy();
  });
  
  it("to record the temperature", function(){
   
      
  $scope.temperature=4;
  $scope.temperatureMonitor.recordTemperature();
  
    expect($scope.temp[0]).toEqual(4);//).toBe(true);
  });
  
  
  it("calculate median for total odd", function(){
    $scope.temperature=10;
  $scope.temperatureMonitor.recordTemperature();
  
  $scope.temperature=12;
  $scope.temperatureMonitor.recordTemperature();
  
   $scope.temperature=7;
  $scope.temperatureMonitor.recordTemperature();
 
  $scope.temperature=3;
  $scope.temperatureMonitor.recordTemperature();
  
  $scope.temperature=5;
  $scope.temperatureMonitor.recordTemperature();
  
  $scope.temperatureMonitor.getCurrentMedian();
    expect($scope.median).toEqual(7);
  })
  
  it("calculate median for total even", function(){
    $scope.temperature=10;
  $scope.temperatureMonitor.recordTemperature();
  
  $scope.temperature=12;
  $scope.temperatureMonitor.recordTemperature();
  
   $scope.temperature=7;
  $scope.temperatureMonitor.recordTemperature();
 
  $scope.temperature=3;
  $scope.temperatureMonitor.recordTemperature();
  
  $scope.temperatureMonitor.getCurrentMedian();
    expect($scope.median).toEqual(8.5);
  })
  
  it("calculate median without any values", function(){
      $scope.temperatureMonitor.getCurrentMedian();
    expect($scope.median).toEqual(NaN);
  })
  
  it("calculate median for fractions", function(){
     $scope.temperature=10.5;
  $scope.temperatureMonitor.recordTemperature();
  
  $scope.temperature=12.23;
  $scope.temperatureMonitor.recordTemperature();
  
   $scope.temperature=7.5;
  $scope.temperatureMonitor.recordTemperature();
 
  $scope.temperature=3;
  $scope.temperatureMonitor.recordTemperature();
      $scope.temperatureMonitor.getCurrentMedian();
    expect($scope.median).toEqual(9);
  })
  
  
  
  
});
});