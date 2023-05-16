var app = angular.module('my-app', []);
app.controller('reservationUpdatePageCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/reservation").then(function(resp){
        $scope.reserves = resp.data;
    },function(err){
        console.log(err);
    });
  });
