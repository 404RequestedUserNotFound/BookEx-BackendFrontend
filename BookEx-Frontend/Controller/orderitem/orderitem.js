var app = angular.module('my-app', []);
app.controller('orderitemAddCtrl', function($scope, $http) 
{
  $scope.createOrderItem = function() 
  {
    var data = {
        OrderItemId: $scope.OrderItemId,
        Quantity: $scope.Quantity,
        OrderId: $scope.OrderId,
      };
    $http.post("https://localhost:44373/api/orderitem/add", data).then(function(resp) 
    {
      location.reload();

      alert("OrderItem has created");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
