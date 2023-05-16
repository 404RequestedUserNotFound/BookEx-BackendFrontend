var app = angular.module('my-app', []);
app.controller('orderitemAllCtrl',function($scope,$http){
    $http.get("https://localhost:44373/api/orderitem").then(function(resp){
        $scope.orderitems = resp.data;
    },function(err){
        console.log(err);
    });
  });


  app.controller('orderitemDeleteCtrl', function ($scope, $http) {
    $scope.deleteOrderItem = function (id) {
        var confirmDelete = confirm("Are you sure you want to delete this orderitem?");
        if (confirmDelete) {
            $http.get("https://localhost:44373/api/orderitem/delete/" + id).then(function(resp){
                
            alert("Failed to delete orderitem!");
            }, function (err) {
                location.reload();

                alert("orderitem deleted successfully!");
                console.log(err);
            });
        }
    };
});