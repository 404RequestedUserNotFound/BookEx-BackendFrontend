var app = angular.module('my-app', []);
app.controller('adminUpdatePageCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/admin").then(function(resp){
        $scope.admins = resp.data;
    },function(err){
        console.log(err);
    });
  });
