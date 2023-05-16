var app = angular.module('my-app', []);
app.controller('orderAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/order").then(function(resp){
        $scope.orders = resp.data;
    },function(err){
        console.log(err);
    });
  });



  app.controller('orderDeleteCtrl', function ($scope, $http) {
    $scope.deleteorder = function (id) {
        var confirmDelete = confirm("Do you want to delete this order?");
        if (confirmDelete) {
            $http.get("https://localhost:44373/api/order/delete/" + id).then(function(resp){
                
            alert("Failed to delete order!");
            }, function (err) {
                location.reload();

                alert("order deleted successfully!");
                console.log(err);
            });
        }
    };
});