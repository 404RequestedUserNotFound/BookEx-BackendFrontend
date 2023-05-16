var app = angular.module('my-app', []);
app.controller('reservationAddCtrl', function($scope, $http) 
{
  $scope.createReservation = function() 
  {
    var data = {
        BookId: $scope.bookId,
        userId: $scope.userId,
        ReservationDate: $scope.reservationDate,
        Status: $scope.status
      };
    $http.post("https://localhost:44373/api/reservation/add", data).then(function(resp) 
    {
      location.reload();

      alert("reservation request has created");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
