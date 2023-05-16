var app = angular.module('my-app', []);
app.controller('reservationUpdateCtrl', function($scope, $http) 
{
  $scope.updateReservation = function() 
  {
    var data = {
        Id: $scope.reservationId,
        BookId: $scope.bookId,
        userId: $scope.userId,
        ReservationDate: $scope.reservationDate,
        Status: $scope.status
      };
    $http.post("https://localhost:44373/api/reservation/update", data).then(function(resp) 
    {
      location.reload();

      alert("Reservation Information has been updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
