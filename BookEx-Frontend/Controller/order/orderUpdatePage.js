var app = angular.module('my-app', []);
app.controller('orderUpdatePageCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/order").then(function(resp){
        $scope.orders = resp.data;
    },function(err){
        console.log(err);
    });
  });