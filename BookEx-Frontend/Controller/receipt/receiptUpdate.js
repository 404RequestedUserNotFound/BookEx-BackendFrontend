var app = angular.module('my-app', []);
app.controller('receiptUpdateCtrl', function($scope, $http) 
{
  $scope.updateReceipt = function() 
  {
    var data = {
        ReceiptId: $scope.ReceiptId,
        ReceiptNumber: $scope.ReceiptNumber,
        ReceiptDescription: $scope.ReceiptDescription,
        CustomerId: $scope.CustomerId,
        Amount: $scope.Amount,
      };
    $http.post("https://localhost:44373/api/receipt/update", data).then(function(resp) 
    {
      location.reload();

      alert("Receipt Payment has updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
