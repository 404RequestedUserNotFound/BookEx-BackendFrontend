var app = angular.module('my-app', []);
app.controller('orderitemUpdateCtrl', function($scope, $http) 
{
  $scope.updateOrderItem = function() 
  {
    var data = {
        OrderItemId: $scope.OrderItemId,
        Quantity: $scope.Quantity,
        OrderId: $scope.OrderId,
      };
    $http.post("https://localhost:44373/api/orderitem/update", data).then(function(resp) 
    {
      location.reload();

      alert("OrderItem has updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
