(function() {
    
    var BuddysController = function ($scope) {
        $scope.sortBy = 'name';
        $scope.reverse = false;
        
        $scope.doSort = function(propName) {
           $scope.sortBy = propName;
           $scope.reverse = !$scope.reverse;
        };
        
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
                    }
                ]
            }, 
            {
                id: 2, 
                joined: '1965-01-25',
                name:'Zed', 
                lastname:'Las',
                firstname: 'Zed',
                status:'busy',
                bio: [
                    {
                        id: 2,
                        emails: 'zed@gmail.com',
                        dob:'2000-12-02',
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
                    }
                ]
            }
        ];
    };
    
    BuddysController.$inject = ['$scope'];

    angular.module('customersApp')
      .controller('BuddysController', BuddysController);
    
}());
