var app = angular.module('my-app', []);
app.controller('employeeAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/employee").then(function(resp){
        $scope.employees = resp.data;
    },function(err){
        console.log(err);
    });
  });
