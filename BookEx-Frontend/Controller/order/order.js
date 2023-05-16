var app = angular.module('my-app', []);
app.controller('orderAddCtrl', function($scope, $http) 
{
  $scope.createOrder = function() 
  {
    var data = {
        OrderId: $scope.orderId,
        OrderDate: $scope.orderDate,
        TotalPrice: $scope.totalPrice,
        CustomerId: $scope.customerId,

      };
    $http.post("https://localhost:44373/api/order/add", data).then(function(resp) 
    {
      location.reload();

      alert("order has created");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
