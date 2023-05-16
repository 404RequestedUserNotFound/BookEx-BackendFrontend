var app = angular.module('my-app', []);
app.controller('orderUpdateCtrl', function($scope, $http) 
{
  $scope.updateorder = function() 
  {
    var data = {
        OrderId: $scope.orderId,
        TotalPrice: $scope.totalPrice,
        
       
      };
    $http.post("https://localhost:44373/api/order/update", data).then(function(resp) 
    {
      location.reload();

      alert("Order details has updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
