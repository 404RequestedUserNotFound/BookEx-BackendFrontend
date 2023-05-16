var app = angular.module('my-app', []);
app.controller('customerUpdatePageCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/customer").then(function(resp){
        $scope.customers = resp.data;
    },function(err){
        console.log(err);
    });
  });
