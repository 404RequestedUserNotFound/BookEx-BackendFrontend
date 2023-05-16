var app = angular.module('my-app', []);
app.controller('publisherAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/publisher").then(function(resp){
        $scope.publishes = resp.data;
    },function(err){
        console.log(err);
    });
  });
