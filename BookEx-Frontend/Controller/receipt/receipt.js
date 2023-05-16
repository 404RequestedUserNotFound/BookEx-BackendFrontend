var app = angular.module('my-app', []);
app.controller('receiptAddCtrl', function($scope, $http) 
{
  $scope.createReceipt = function() 
  {
    var data = {
        ReceiptId: $scope.ReceiptId,
        ReceiptNumber: $scope.ReceiptNumber,
        ReceiptDescription: $scope.ReceiptDescription,
        CustomerId: $scope.CustomerId,
        Amount: $scope.Amount,
      };
    $http.post("https://localhost:44373/api/receipt/add", data).then(function(resp) 
    {
      location.reload();

      alert("Receipt Payment Done");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
