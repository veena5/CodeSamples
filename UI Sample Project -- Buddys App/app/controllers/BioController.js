(function() {
    
    var BioController = function ($scope, $routeParams) {
        var customerId = $routeParams.customerId;
        //$scope.order = null;
        
        function init() {
            //Search the customers for the customerId
            for (var i=0,len=$scope.customers.length;i<len;i++) {
               if ($scope.customers[i].id === parseInt(customerId)) {
                   $scope.order = $scope.customers[i];
                   console.log($scope.order);
                   break;
               }
            }
        }

        $scope.customers= [
            {
                id: 1,
                joined: '2000-12-02',
                name:'John',
                lastname:'Chandler',
                firstname:'John',
                status:'available',
                bio: [
                    {
                        id: 1,
                        emails: 'john@gmail.com',
                        dob:'2000-12-02',
                        last: '-----',
                    }
                ]
            },
            {
                id: 2,
                joined: '1965-01-25',
                name:'Zed',
                lastname:'Las',
                firstname: 'Zed',
                status:'offline',
                bio: [
                    {
                        id: 2,
                        emails: 'john@gmail.com',
                        dob:'2000-12-02',
                        last: '2014-08-06',

                    }
                ]
            },
            {
                id: 3,
                joined: '1944-06-15',
                name:'Tina',
                lastname:'York',
                firstname:'Tina',
                status:'busy',
                bio: [
                    {
                        id: 3,
                        emails: 'tina@gmail.com',
                        dob: '2000-12-02',
                        last: '-----',
                    }
                ]
            },
            {
                id: 4,
                joined: '1995-03-28',
                name:'Dave',
                lastname:'Sele',
                firstname:'Dave',
                status:'busy',
                bio: [
                    {
                        id: 4,
                        emails: 'davn@gmail.com',
                        dob: '2000-12-02',
                        last: '-----',
                    }
                ]
            }
        ];

        init();
    };
    
    BioController.$inject = ['$scope', '$routeParams'];

    angular.module('customersApp')
      .controller('BioController', BioController);
    
}());
