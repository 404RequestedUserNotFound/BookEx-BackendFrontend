var app = angular.module('my-app', []);
app.controller('authorAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/author").then(function(resp){
        $scope.authors = resp.data;
    },function(err){
        console.log(err);
    });
  });
