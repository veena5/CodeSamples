

angular.module("bookMyShow").controller("HomeController", ["$scope", "$state", "$timeout", "bookMyShowService", function ($scope, $state, $timeout, bookMyShowService) {
   
    var init = function () {
        
    }

    $scope.getMovies = function () {
        if($scope.showDate!=''){
        bookMyShowService.query({ action: "Movies", date:$scope.bookingInfo.showDate } , function (data) {
            $scope.movies = data;
         }, function () {
        });
        }
        else {
            $scope.movies = null;
        }
    }

    var getTheaters = function () {

        bookMyShowService.query({ action: "Theaters", id: $scope.bookingInfo.movieId }, function (response) {
            $scope.theaters = response;
        });
    }

    $scope.showTheaters = function () {
        if ($scope.bookingInfo.movieId != null) {
            $scope.showTheatersList = true;
            $scope.hideMovies = true;
            getTheaters();
        }
        else {
            alert("Please Select a Movie");
        }
    }

    var createRows = function (noOfRows) {
        var row = 'A';
        var rows = [];
        for (var i = 65; i < (65 + noOfRows) ; i++) {
            rows.push(String.fromCharCode(i));
        }
        $scope.rows = rows;
    }

    $scope.showSeats = function (theaterId, showTime) {

        $scope.showSeatsContainer = true;
        $scope.hideMovies=true;
        $scope.showTheatersList = false;

        $scope.bookingInfo.theaterId = theaterId;
        $scope.bookingInfo.showTime = showTime;
                   
        bookMyShowService.save({ action: "seatsInfo"}, $scope.bookingInfo).$promise.then(function (data) {
            $scope.premiumArray = data.premiumSeats;
            $scope.standardArray = data.standardSeats;
            $scope.noOfPremiumRows = data.noOfPremiumRows;
            createRows(data.noOfPremiumRows+data.noOfStandardRows);
        });
        $("#quantity").prop('selectedIndex', 0);
        $("#seatType").prop('selectedIndex', 0);
        $scope.seatType = "";
        $scope.showDisabler();
    }

    var checkSelectedSeat = function (id) {
        return selectedSeats.indexOf(id);
    }

    var addSeat=function(id) {
        angular.element(document.querySelector("#" + id)).attr("src", "/Content/Images/selectedChair.png");
        selectedSeats.push(id);
        $timeout(function () {
            if (selectedSeats.length < $scope.noOfSeats)
                angular.element(document.querySelector("#" + id)).next().triggerHandler("click");
        }, 0, false);
    }

    var toggleProceedBtn = function () {
        if (selectedSeats.length == $scope.noOfSeats)
            $scope.proceed = true;
        else
            $scope.proceed = false;
    }

    var selectedSeats = [];
    $scope.selectSeat = function (id) {

        var seatIndex = checkSelectedSeat(id);
        if (selectedSeats.length == $scope.noOfSeats) {
            $scope.clearSelection();
        }
        if (seatIndex < 0 && selectedSeats.length < $scope.noOfSeats && ($scope.seatType != "")) {
            addSeat(id);
            toggleProceedBtn();

        }

        else if (seatIndex >= 0) {
            $scope.clearSelection();
            addSeat(id);
            toggleProceedBtn();
        }
    }

    $scope.clearSelection = function () {

        angular.forEach(selectedSeats, function (key) {
            angular.element(document.querySelector(("#" + key))).attr("src", "/Content/Images/chair1.png");
        });
        selectedSeats.length = 0;
        $scope.proceed = false;
    }

    var showTicket = function () {
        $scope.showTicketContainer = true;
        $scope.showSeatsContainer = false;
    }
    
    var getTicket = function () {
        $scope.vm = {};
        bookMyShowService.get({ action: "Ticket", id: $scope.ticketId }, function (data) {
            $scope.vm.ticket = data;
            showTicket();
        });
    }

    $scope.bookSeats = function () {
        
        $scope.bookingInfo.seatsBooked = selectedSeats.toString();
        bookMyShowService.save({ action: "BookSeats" }, $scope.bookingInfo).$promise.then(function (data) {
            $scope.ticketId = data.id;
            getTicket();
        });

    }

    $scope.goBack = function () {
        $scope.showTheatersList = false;
        $scope.hideMovies = false;
        $('#showDate').prop('selectedIndex', 0);
        $scope.movies = null;
    }

    $scope.showDisabler = function () {

        if ($scope.seatType == 'Premium') {
            $scope.standardDisabler = true;
            $scope.premiumDisabler = false;
        }
        else if($scope.seatType=='Standard'){
            $scope.standardDisabler = false;
            $scope.premiumDisabler = true;
        }
        else {
            $scope.standardDisabler = false;
            $scope.premiumDisabler = false;
        }
    }
   
    $scope.goToHome = function () {
        $scope.showTicketContainer = false;
        $scope.hideMovies = false;
        $('#showDate').prop('selectedIndex', 0);
        $scope.movies = null;
    }
     

    init();

}]);