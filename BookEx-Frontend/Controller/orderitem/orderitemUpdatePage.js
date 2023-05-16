var app = angular.module('my-app', []);
app.controller('orderitemUpdatePageCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/orderitem").then(function(resp){
        $scope.orderitems = resp.data;
    },function(err){
        console.log(err);
    });
  });
