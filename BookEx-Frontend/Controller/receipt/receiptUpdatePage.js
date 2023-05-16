var app = angular.module('my-app', []);
app.controller('receiptUpdatePageCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/receipt").then(function(resp){
        $scope.receipts = resp.data;
    },function(err){
        console.log(err);
    });
  });
