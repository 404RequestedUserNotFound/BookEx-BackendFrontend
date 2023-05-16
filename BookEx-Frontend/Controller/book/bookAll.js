var app = angular.module('my-app', []);
app.controller('bookAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/book").then(function(resp){
        $scope.books = resp.data;
    },function(err){
        console.log(err);
    });
  });
