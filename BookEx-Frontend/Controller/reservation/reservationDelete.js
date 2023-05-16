var app = angular.module('my-app', []);
app.controller('reservationAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/reservation").then(function(resp){
        $scope.reserves = resp.data;
    },function(err){
        console.log(err);
    });
  });


  app.controller('reservationDeleteCtrl', function ($scope, $http) {
    $scope.deleteReservation = function (id) {
         var confirmDelete = confirm("Are you sure you want to delete this reservation?");
         if (confirmDelete) 
         {
            $http.get("https://localhost:44373/api/reservation/delete/" + id).then(function(resp){
                
            alert("Deleted Failed");
            }, function (err) 
            {
                location.reload();
                alert("reservation removed successfully!");                       
                console.log(err);
            });
         }
         else
         {
             alert("No, I don't want to delete");

         }
    };
});

