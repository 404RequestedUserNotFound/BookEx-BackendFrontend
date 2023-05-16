var app = angular.module('my-app', []);
app.controller('borrowUpdatePageCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/borrow").then(function(resp){
        $scope.borrows = resp.data;
    },function(err){
        console.log(err);
    });
  });
