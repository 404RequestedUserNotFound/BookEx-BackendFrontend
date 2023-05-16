var app = angular.module('my-app', []);
app.controller('categoryAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/category").then(function(resp){
        $scope.categories = resp.data;
    },function(err){
        console.log(err);
    });
  });
